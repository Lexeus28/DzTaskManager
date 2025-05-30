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
            lblInstructionAdd = new Label();
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
            // lblInstructionAdd
            // 
            lblInstructionAdd.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblInstructionAdd.Location = new Point(12, 159);
            lblInstructionAdd.Name = "lblInstructionAdd";
            lblInstructionAdd.Size = new Size(464, 61);
            lblInstructionAdd.TabIndex = 7;
            lblInstructionAdd.Text = "Добавляйте задачи, записывая их в текстовое поле сверху";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(488, 229);
            Controls.Add(lblInstructionAdd);
            Controls.Add(txtboxAddTask);
            Controls.Add(lblTaskAdder);
            Name = "AddTaskForm";
            Text = "Добавлятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskAdder;
        private TextBox txtboxAddTask;
        private Label lblInstructionAdd;
    }
}