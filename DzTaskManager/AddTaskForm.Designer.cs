namespace DzTaskManager
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTaskAdder = new Label();
            txtboxAddTask = new TextBox();
            btnAddTask = new Button();
            SuspendLayout();
            // 
            // lblTaskAdder
            // 
            lblTaskAdder.AutoSize = true;
            lblTaskAdder.Font = new Font("Comic Sans MS", 14F);
            lblTaskAdder.Location = new Point(154, 9);
            lblTaskAdder.Name = "lblTaskAdder";
            lblTaskAdder.Size = new Size(178, 26);
            lblTaskAdder.TabIndex = 3;
            lblTaskAdder.Text = "Добавление задач";
            // 
            // txtboxAddTask
            // 
            txtboxAddTask.Location = new Point(12, 48);
            txtboxAddTask.Multiline = true;
            txtboxAddTask.Name = "txtboxAddTask";
            txtboxAddTask.Size = new Size(464, 108);
            txtboxAddTask.TabIndex = 5;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(128, 255, 255);
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTask.Location = new Point(108, 177);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(256, 28);
            btnAddTask.TabIndex = 8;
            btnAddTask.Text = "добавить задачу";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAdd_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(488, 229);
            Controls.Add(btnAddTask);
            Controls.Add(txtboxAddTask);
            Controls.Add(lblTaskAdder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddTaskForm";
            Text = "Добавлятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskAdder;
        private TextBox txtboxAddTask;
        private Button btnAddTask;
    }
}