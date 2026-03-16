namespace ListOfUsersForm
{
    partial class ListOfUsers
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
            dataGridOfUsers = new DataGridView();
            columnOfEmployeeData = new DataGridViewTextBoxColumn();
            ColumnOfUserLogin = new DataGridViewTextBoxColumn();
            ColumnOfRole = new DataGridViewTextBoxColumn();
            buttonOfAddUser = new Button();
            buttonOfDeleteUser = new Button();
            buttonOfResetPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridOfUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridOfUsers
            // 
            dataGridOfUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOfUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOfUsers.Columns.AddRange(new DataGridViewColumn[] { columnOfEmployeeData, ColumnOfUserLogin, ColumnOfRole });
            dataGridOfUsers.Location = new Point(39, 59);
            dataGridOfUsers.Name = "dataGridOfUsers";
            dataGridOfUsers.RowHeadersWidth = 62;
            dataGridOfUsers.Size = new Size(864, 572);
            dataGridOfUsers.TabIndex = 0;
            // 
            // columnOfEmployeeData
            // 
            columnOfEmployeeData.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnOfEmployeeData.FillWeight = 5F;
            columnOfEmployeeData.HeaderText = "ФИО Сотрудника";
            columnOfEmployeeData.MinimumWidth = 100;
            columnOfEmployeeData.Name = "columnOfEmployeeData";
            columnOfEmployeeData.Width = 300;
            // 
            // ColumnOfUserLogin
            // 
            ColumnOfUserLogin.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnOfUserLogin.FillWeight = 3F;
            ColumnOfUserLogin.HeaderText = "Логин";
            ColumnOfUserLogin.MinimumWidth = 100;
            ColumnOfUserLogin.Name = "ColumnOfUserLogin";
            ColumnOfUserLogin.Width = 250;
            // 
            // ColumnOfRole
            // 
            ColumnOfRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnOfRole.FillWeight = 2F;
            ColumnOfRole.HeaderText = "Роль";
            ColumnOfRole.MinimumWidth = 80;
            ColumnOfRole.Name = "ColumnOfRole";
            ColumnOfRole.Width = 250;
            // 
            // buttonOfAddUser
            // 
            buttonOfAddUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfAddUser.Location = new Point(39, 637);
            buttonOfAddUser.Name = "buttonOfAddUser";
            buttonOfAddUser.Size = new Size(420, 53);
            buttonOfAddUser.TabIndex = 1;
            buttonOfAddUser.Text = "Добавить пользователя";
            buttonOfAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonOfDeleteUser
            // 
            buttonOfDeleteUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfDeleteUser.Location = new Point(483, 637);
            buttonOfDeleteUser.Name = "buttonOfDeleteUser";
            buttonOfDeleteUser.Size = new Size(420, 53);
            buttonOfDeleteUser.TabIndex = 2;
            buttonOfDeleteUser.Text = "Удалить пользователя";
            buttonOfDeleteUser.UseVisualStyleBackColor = true;
            // 
            // buttonOfResetPassword
            // 
            buttonOfResetPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfResetPassword.Location = new Point(259, 697);
            buttonOfResetPassword.Name = "buttonOfResetPassword";
            buttonOfResetPassword.Size = new Size(420, 53);
            buttonOfResetPassword.TabIndex = 3;
            buttonOfResetPassword.Text = "Сбросить пароль";
            buttonOfResetPassword.UseVisualStyleBackColor = true;
            // 
            // ListOfUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 762);
            Controls.Add(buttonOfResetPassword);
            Controls.Add(buttonOfDeleteUser);
            Controls.Add(buttonOfAddUser);
            Controls.Add(dataGridOfUsers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListOfUsers";
            Text = "Список пользователей";
            ((System.ComponentModel.ISupportInitialize)dataGridOfUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridOfUsers;
        private DataGridViewTextBoxColumn columnOfEmployeeData;
        private DataGridViewTextBoxColumn ColumnOfUserLogin;
        private DataGridViewTextBoxColumn ColumnOfRole;
        private Button buttonOfAddUser;
        private Button buttonOfDeleteUser;
        private Button buttonOfResetPassword;
    }
}