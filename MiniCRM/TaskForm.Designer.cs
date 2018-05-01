namespace MiniCRM
{
    partial class TaskForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.deleteTaskButton);
            this.panel2.Controls.Add(this.addTaskButton);
            this.panel2.Controls.Add(this.editTaskButton);
            this.panel2.Location = new System.Drawing.Point(12, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 413);
            this.panel2.TabIndex = 9;
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Location = new System.Drawing.Point(243, 14);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTaskButton.TabIndex = 2;
            this.deleteTaskButton.Text = "Удалить";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(8, 15);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "добавить ";
            this.addTaskButton.UseVisualStyleBackColor = true;
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(123, 15);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(75, 23);
            this.editTaskButton.TabIndex = 1;
            this.editTaskButton.Text = "Редактировать";
            this.editTaskButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "TaskForm";
            this.Text = "Задачи:";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}