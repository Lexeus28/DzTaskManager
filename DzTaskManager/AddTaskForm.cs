namespace DzTaskManager
{
    public partial class AddTaskForm : Form
    {
        ITaskService _taskService;
        public AddTaskForm(ITaskService taskService)
        {
            InitializeComponent();
            _taskService = taskService;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await _taskService.CreateTaskAsync(txtboxAddTask.Text.Trim(), false);
            MessageBox.Show("Задача успешно добавлена",
             "Успех",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
            this.Close();
        }
    }
}
