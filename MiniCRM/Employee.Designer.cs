namespace MiniCRM
{
    partial class Employee
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
            this.TaskButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskButton
            // 
            this.TaskButton.Location = new System.Drawing.Point(311, 14);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(75, 23);
            this.TaskButton.TabIndex = 3;
            this.TaskButton.Text = "Задачи";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(197, 14);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить ";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(405, 14);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(75, 23);
            this.OrderButton.TabIndex = 4;
            this.OrderButton.Text = "Отчет";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(98, 14);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Поиск сотрудника";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(17, 14);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить ";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.dataGridView1);
            this.employeePanel.Controls.Add(this.AddButton);
            this.employeePanel.Controls.Add(this.textBox1);
            this.employeePanel.Controls.Add(this.EditButton);
            this.employeePanel.Controls.Add(this.OrderButton);
            this.employeePanel.Controls.Add(this.DeleteButton);
            this.employeePanel.Controls.Add(this.TaskButton);
            this.employeePanel.Location = new System.Drawing.Point(12, 12);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(717, 426);
            this.employeePanel.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Login,
            this.Password,
            this.Position});
            this.dataGridView1.Location = new System.Drawing.Point(17, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Login
            // 
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.Visible = false;
            // 
            // Password
            // 
            this.Password.HeaderText = "Пароль";
            this.Password.Name = "Password";
            this.Password.Visible = false;
            // 
            // Position
            // 
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            this.Position.Visible = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.employeePanel);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
    }
}