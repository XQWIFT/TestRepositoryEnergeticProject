namespace AdministratorPanelForm
{
    partial class AdministratorPanel
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
            labelOfCompanyName = new Label();
            labelOfLoginAs = new Label();
            labelOfRole = new Label();
            labelOfUserControls = new Label();
            buttonListOfUsers = new Button();
            buttonOfChangePassword = new Button();
            labelOfProducts = new Label();
            buttonOfProductCatalog = new Button();
            buttonOfShipmentLog = new Button();
            label1 = new Label();
            buttonOfClients = new Button();
            labelOfLine = new Label();
            buttonOfLogOut = new Button();
            SuspendLayout();
            // 
            // labelOfCompanyName
            // 
            labelOfCompanyName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfCompanyName.Location = new Point(72, 9);
            labelOfCompanyName.Name = "labelOfCompanyName";
            labelOfCompanyName.Size = new Size(689, 56);
            labelOfCompanyName.TabIndex = 0;
            labelOfCompanyName.Text = " «ООО Птички-тупички | Складская система»";
            // 
            // labelOfLoginAs
            // 
            labelOfLoginAs.AutoSize = true;
            labelOfLoginAs.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfLoginAs.Location = new Point(46, 65);
            labelOfLoginAs.Name = "labelOfLoginAs";
            labelOfLoginAs.Size = new Size(201, 38);
            labelOfLoginAs.TabIndex = 1;
            labelOfLoginAs.Text = "Вы вошли как:";
            // 
            // labelOfRole
            // 
            labelOfRole.AutoSize = true;
            labelOfRole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfRole.Location = new Point(253, 65);
            labelOfRole.Name = "labelOfRole";
            labelOfRole.Size = new Size(215, 38);
            labelOfRole.TabIndex = 2;
            labelOfRole.Text = "Администратор";
            // 
            // labelOfUserControls
            // 
            labelOfUserControls.AutoSize = true;
            labelOfUserControls.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfUserControls.Location = new Point(192, 151);
            labelOfUserControls.Name = "labelOfUserControls";
            labelOfUserControls.Size = new Size(498, 48);
            labelOfUserControls.TabIndex = 3;
            labelOfUserControls.Text = "Управление пользователями";
            // 
            // buttonListOfUsers
            // 
            buttonListOfUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonListOfUsers.Location = new Point(253, 202);
            buttonListOfUsers.Name = "buttonListOfUsers";
            buttonListOfUsers.Size = new Size(379, 44);
            buttonListOfUsers.TabIndex = 4;
            buttonListOfUsers.Text = "Список пользователей";
            buttonListOfUsers.UseVisualStyleBackColor = true;
            buttonListOfUsers.Click += buttonListOfUsers_Click;
            // 
            // buttonOfChangePassword
            // 
            buttonOfChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfChangePassword.Location = new Point(253, 252);
            buttonOfChangePassword.Name = "buttonOfChangePassword";
            buttonOfChangePassword.Size = new Size(379, 46);
            buttonOfChangePassword.TabIndex = 5;
            buttonOfChangePassword.Text = "Изменить мой пароль";
            buttonOfChangePassword.UseVisualStyleBackColor = true;
            buttonOfChangePassword.Click += buttonOfChangePassword_Click;
            // 
            // labelOfProducts
            // 
            labelOfProducts.AutoSize = true;
            labelOfProducts.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfProducts.Location = new Point(316, 329);
            labelOfProducts.Name = "labelOfProducts";
            labelOfProducts.Size = new Size(250, 45);
            labelOfProducts.TabIndex = 6;
            labelOfProducts.Text = "Товары и склад";
            // 
            // buttonOfProductCatalog
            // 
            buttonOfProductCatalog.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfProductCatalog.Location = new Point(253, 377);
            buttonOfProductCatalog.Name = "buttonOfProductCatalog";
            buttonOfProductCatalog.Size = new Size(379, 44);
            buttonOfProductCatalog.TabIndex = 7;
            buttonOfProductCatalog.Text = "Каталог товаров";
            buttonOfProductCatalog.UseVisualStyleBackColor = true;
            // 
            // buttonOfShipmentLog
            // 
            buttonOfShipmentLog.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfShipmentLog.Location = new Point(253, 507);
            buttonOfShipmentLog.Name = "buttonOfShipmentLog";
            buttonOfShipmentLog.Size = new Size(379, 44);
            buttonOfShipmentLog.TabIndex = 8;
            buttonOfShipmentLog.Text = "Журнал отгрузок";
            buttonOfShipmentLog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(292, 459);
            label1.Name = "label1";
            label1.Size = new Size(312, 45);
            label1.TabIndex = 9;
            label1.Text = "Отгрузки и клиенты";
            // 
            // buttonOfClients
            // 
            buttonOfClients.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfClients.Location = new Point(253, 557);
            buttonOfClients.Name = "buttonOfClients";
            buttonOfClients.Size = new Size(379, 44);
            buttonOfClients.TabIndex = 10;
            buttonOfClients.Text = "Клиенты";
            buttonOfClients.UseVisualStyleBackColor = true;
            // 
            // labelOfLine
            // 
            labelOfLine.AutoSize = true;
            labelOfLine.Location = new Point(253, 614);
            labelOfLine.Name = "labelOfLine";
            labelOfLine.Size = new Size(383, 25);
            labelOfLine.TabIndex = 11;
            labelOfLine.Text = "_____________________________________________________";
            // 
            // buttonOfLogOut
            // 
            buttonOfLogOut.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfLogOut.Location = new Point(253, 651);
            buttonOfLogOut.Name = "buttonOfLogOut";
            buttonOfLogOut.Size = new Size(379, 44);
            buttonOfLogOut.TabIndex = 12;
            buttonOfLogOut.Text = "Выйти из аккаунта";
            buttonOfLogOut.UseVisualStyleBackColor = true;
            // 
            // AdministratorPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 731);
            Controls.Add(buttonOfLogOut);
            Controls.Add(labelOfLine);
            Controls.Add(buttonOfClients);
            Controls.Add(label1);
            Controls.Add(buttonOfShipmentLog);
            Controls.Add(buttonOfProductCatalog);
            Controls.Add(labelOfProducts);
            Controls.Add(buttonOfChangePassword);
            Controls.Add(buttonListOfUsers);
            Controls.Add(labelOfUserControls);
            Controls.Add(labelOfRole);
            Controls.Add(labelOfLoginAs);
            Controls.Add(labelOfCompanyName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdministratorPanel";
            Text = "Панель управления (администратор)";
            ResumeLayout(false);
            PerformLayout();

        }

        private Label labelOfCompanyName;
        private Label labelOfLoginAs;
        private Label labelOfUserControls;
        private Button buttonListOfUsers;
        private Button buttonOfChangePassword;
        private Label labelOfProducts;
        private Button buttonOfProductCatalog;
        private Button buttonOfShipmentLog;
        private Label label1;
        private Button buttonOfClients;
        private Label labelOfLine;
        private Button buttonOfLogOut;
        private Label labelOfRole;
    }

        #endregion
 }