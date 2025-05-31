using System.Resources;

namespace DzTaskManager
{
    public partial class MainForm : Form
    {
        private readonly ITaskService _taskService;

        public MainForm(ITaskService taskService)
        {
            InitializeComponent();
            _taskService = taskService;
            UpdateTaskListAsync();

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm(_taskService);
            addTaskForm.ShowDialog();
            UpdateTaskListAsync();
        }
        private async Task UpdateTaskListAsync()
        {
            listBoxTasks.DataSource = null;
            var tasks = await _taskService.GetAllTasksAsync();

            listBoxTasks.DisplayMember = "Description"; 
            listBoxTasks.ValueMember = "Task_id";        
            listBoxTasks.DataSource = tasks;
        }

        private async void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("������. ���������� ������� ������ ��� ��������.", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �������� Id ��������� ������
            var selectedTaskId = (Guid)listBoxTasks.SelectedValue;

            DialogResult result = MessageBox.Show(
                "�� ������������� ������ ������� ��������� ������?",
                "������������� ��������",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _taskService.DeleteTaskAsync(selectedTaskId);
                await UpdateTaskListAsync();
            }
        }
    }
}
