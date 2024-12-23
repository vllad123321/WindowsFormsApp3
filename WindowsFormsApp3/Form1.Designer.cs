namespace WindowsFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblTasks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();

            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTask.Location = new System.Drawing.Point(450, 100);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(120, 35);
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            // 
            // btnEditTask
            // 
            this.btnEditTask.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTask.Location = new System.Drawing.Point(450, 150);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(120, 35);
            this.btnEditTask.Text = "Редактировать";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);

            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTask.Location = new System.Drawing.Point(450, 200);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(120, 35);
            this.btnDeleteTask.Text = "Удалить";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);

            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTask.Location = new System.Drawing.Point(50, 50);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(350, 25);

            // 
            // lstTasks
            // 
            this.lstTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTasks.Location = new System.Drawing.Point(50, 150);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(350, 250);
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.lstTasks_SelectedIndexChanged);

            // 
            // lblTask
            // 
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTask.Location = new System.Drawing.Point(50, 25);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(200, 20);
            this.lblTask.Text = "Введите задачу:";

            // 
            // lblTasks
            // 
            this.lblTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTasks.Location = new System.Drawing.Point(50, 125);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(200, 20);
            this.lblTasks.Text = "Список задач:";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Name = "Form1";
            this.Text = "Менеджер задач";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
