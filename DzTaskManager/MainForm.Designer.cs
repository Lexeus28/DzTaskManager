namespace DzTaskManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTasks = new ListBox();
            btnAddTask = new Button();
            lblTaskManager = new Label();
            btnDeleteTask = new Button();
            txtboxEditTask = new TextBox();
            lblEdit = new Label();
            panelCompleted = new Panel();
            rbtnInProcessing = new RadioButton();
            rbtnCompleted = new RadioButton();
            btnConfirmEditing = new Button();
            panelCompleted.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor = SystemColors.Menu;
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(247, 12);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(270, 259);
            listBoxTasks.TabIndex = 0;
            listBoxTasks.SelectedIndexChanged += HandleTaskSelection;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(128, 255, 255);
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTask.Location = new Point(247, 292);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(119, 28);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "добавить задачу";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // lblTaskManager
            // 
            lblTaskManager.AutoSize = true;
            lblTaskManager.Font = new Font("Comic Sans MS", 14F);
            lblTaskManager.Location = new Point(12, 12);
            lblTaskManager.Name = "lblTaskManager";
            lblTaskManager.Size = new Size(212, 26);
            lblTaskManager.TabIndex = 2;
            lblTaskManager.Text = "Управление задачами";
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteTask.Location = new Point(398, 292);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(119, 28);
            btnDeleteTask.TabIndex = 3;
            btnDeleteTask.Text = "удалить задачу";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // txtboxEditTask
            // 
            txtboxEditTask.Location = new Point(523, 65);
            txtboxEditTask.Multiline = true;
            txtboxEditTask.Name = "txtboxEditTask";
            txtboxEditTask.Size = new Size(265, 108);
            txtboxEditTask.TabIndex = 4;
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Font = new Font("Comic Sans MS", 14F);
            lblEdit.Location = new Point(572, 12);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(157, 26);
            lblEdit.TabIndex = 5;
            lblEdit.Text = "Редактирование";
            // 
            // panelCompleted
            // 
            panelCompleted.Controls.Add(rbtnInProcessing);
            panelCompleted.Controls.Add(rbtnCompleted);
            panelCompleted.Location = new Point(523, 179);
            panelCompleted.Name = "panelCompleted";
            panelCompleted.Size = new Size(265, 26);
            panelCompleted.TabIndex = 7;
            // 
            // rbtnInProcessing
            // 
            rbtnInProcessing.AutoSize = true;
            rbtnInProcessing.Location = new Point(104, 3);
            rbtnInProcessing.Name = "rbtnInProcessing";
            rbtnInProcessing.Size = new Size(158, 19);
            rbtnInProcessing.TabIndex = 1;
            rbtnInProcessing.TabStop = true;
            rbtnInProcessing.Text = "в процессе выполнения";
            rbtnInProcessing.UseVisualStyleBackColor = true;
            // 
            // rbtnCompleted
            // 
            rbtnCompleted.AutoSize = true;
            rbtnCompleted.Location = new Point(3, 3);
            rbtnCompleted.Name = "rbtnCompleted";
            rbtnCompleted.Size = new Size(88, 19);
            rbtnCompleted.TabIndex = 0;
            rbtnCompleted.TabStop = true;
            rbtnCompleted.Text = "выполнено";
            rbtnCompleted.UseVisualStyleBackColor = true;
            // 
            // btnConfirmEditing
            // 
            btnConfirmEditing.BackColor = Color.FromArgb(255, 255, 192);
            btnConfirmEditing.FlatStyle = FlatStyle.Flat;
            btnConfirmEditing.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmEditing.Location = new Point(526, 225);
            btnConfirmEditing.Name = "btnConfirmEditing";
            btnConfirmEditing.Size = new Size(259, 28);
            btnConfirmEditing.TabIndex = 8;
            btnConfirmEditing.Text = "Подтвердить изменения";
            btnConfirmEditing.UseVisualStyleBackColor = false;
            btnConfirmEditing.Click += btnConfirmEditing_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmEditing);
            Controls.Add(panelCompleted);
            Controls.Add(lblEdit);
            Controls.Add(txtboxEditTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(lblTaskManager);
            Controls.Add(btnAddTask);
            Controls.Add(listBoxTasks);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Управлятор";
            panelCompleted.ResumeLayout(false);
            panelCompleted.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTasks;
        private Button btnAddTask;
        private Label lblTaskManager;
        private Button btnDeleteTask;
        private TextBox txtboxEditTask;
        private Label lblEdit;
        private Panel panelCompleted;
        private RadioButton rbtnInProcessing;
        private RadioButton rbtnCompleted;
        private Button btnConfirmEditing;
    }
}
