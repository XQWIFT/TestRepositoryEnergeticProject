namespace UserChangePasswordForm
{
    partial class UserChangePassword
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
            labelOfChangePassword = new Label();
            labelOfSeparator = new Label();
            labelOfOldPassword = new Label();
            labelOfNewPassword = new Label();
            labelOfСonfirmation = new Label();
            label1 = new Label();
            buttonOfSaveInfo = new Button();
            buttonOfCancel = new Button();
            textBoxForOldPassword = new TextBox();
            textBoxForNewPassword = new TextBox();
            textBoxOfConfirmation = new TextBox();
            SuspendLayout();
            // 
            // labelOfChangePassword
            // 
            labelOfChangePassword.AutoSize = true;
            labelOfChangePassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfChangePassword.Location = new Point(283, 9);
            labelOfChangePassword.Name = "labelOfChangePassword";
            labelOfChangePassword.Size = new Size(227, 45);
            labelOfChangePassword.TabIndex = 0;
            labelOfChangePassword.Text = "Смена пароля";
            // 
            // labelOfSeparator
            // 
            labelOfSeparator.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfSeparator.Location = new Point(12, 54);
            labelOfSeparator.Name = "labelOfSeparator";
            labelOfSeparator.Size = new Size(776, 30);
            labelOfSeparator.TabIndex = 1;
            labelOfSeparator.Text = "____________________________________________________________________________________________________________";
            // 
            // labelOfOldPassword
            // 
            labelOfOldPassword.AutoSize = true;
            labelOfOldPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfOldPassword.Location = new Point(31, 110);
            labelOfOldPassword.Name = "labelOfOldPassword";
            labelOfOldPassword.Size = new Size(251, 45);
            labelOfOldPassword.TabIndex = 2;
            labelOfOldPassword.Text = "Старый пароль:";
            // 
            // labelOfNewPassword
            // 
            labelOfNewPassword.AutoSize = true;
            labelOfNewPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfNewPassword.Location = new Point(31, 269);
            labelOfNewPassword.Name = "labelOfNewPassword";
            labelOfNewPassword.Size = new Size(242, 45);
            labelOfNewPassword.TabIndex = 3;
            labelOfNewPassword.Text = "Новый пароль:";
            // 
            // labelOfСonfirmation
            // 
            labelOfСonfirmation.AutoSize = true;
            labelOfСonfirmation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfСonfirmation.Location = new Point(31, 433);
            labelOfСonfirmation.Name = "labelOfСonfirmation";
            labelOfСonfirmation.Size = new Size(266, 45);
            labelOfСonfirmation.TabIndex = 4;
            labelOfСonfirmation.Text = "Подтверждение:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 557);
            label1.Name = "label1";
            label1.Size = new Size(776, 30);
            label1.TabIndex = 5;
            label1.Text = "____________________________________________________________________________________________________________";
            // 
            // buttonOfSaveInfo
            // 
            buttonOfSaveInfo.BackColor = Color.LimeGreen;
            buttonOfSaveInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfSaveInfo.Location = new Point(77, 603);
            buttonOfSaveInfo.Name = "buttonOfSaveInfo";
            buttonOfSaveInfo.Size = new Size(263, 74);
            buttonOfSaveInfo.TabIndex = 6;
            buttonOfSaveInfo.Text = "Сохранить";
            buttonOfSaveInfo.UseVisualStyleBackColor = false;
            buttonOfSaveInfo.Click += buttonOfSaveInfo_Click;
            // 
            // buttonOfCancel
            // 
            buttonOfCancel.BackColor = Color.Tomato;
            buttonOfCancel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfCancel.Location = new Point(459, 603);
            buttonOfCancel.Name = "buttonOfCancel";
            buttonOfCancel.Size = new Size(263, 74);
            buttonOfCancel.TabIndex = 7;
            buttonOfCancel.Text = "Отменить";
            buttonOfCancel.UseVisualStyleBackColor = false;
            buttonOfCancel.Click += buttonOfCancel_Click;
            // 
            // textBoxForOldPassword
            // 
            textBoxForOldPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxForOldPassword.Location = new Point(31, 175);
            textBoxForOldPassword.Name = "textBoxForOldPassword";
            textBoxForOldPassword.Size = new Size(726, 45);
            textBoxForOldPassword.TabIndex = 8;
            textBoxForOldPassword.UseSystemPasswordChar = true;
            // 
            // textBoxForNewPassword
            // 
            textBoxForNewPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxForNewPassword.Location = new Point(31, 342);
            textBoxForNewPassword.Name = "textBoxForNewPassword";
            textBoxForNewPassword.Size = new Size(726, 45);
            textBoxForNewPassword.TabIndex = 9;
            textBoxForNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxOfConfirmation
            // 
            textBoxOfConfirmation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOfConfirmation.Location = new Point(31, 509);
            textBoxOfConfirmation.Name = "textBoxOfConfirmation";
            textBoxOfConfirmation.Size = new Size(726, 45);
            textBoxOfConfirmation.TabIndex = 10;
            textBoxOfConfirmation.UseSystemPasswordChar = true;
            // 
            // UserChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 698);
            Controls.Add(textBoxOfConfirmation);
            Controls.Add(textBoxForNewPassword);
            Controls.Add(textBoxForOldPassword);
            Controls.Add(buttonOfCancel);
            Controls.Add(buttonOfSaveInfo);
            Controls.Add(label1);
            Controls.Add(labelOfСonfirmation);
            Controls.Add(labelOfNewPassword);
            Controls.Add(labelOfOldPassword);
            Controls.Add(labelOfSeparator);
            Controls.Add(labelOfChangePassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserChangePassword";
            Text = "Смена пароля (администратор)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOfChangePassword;
        private Label labelOfSeparator;
        private Label labelOfOldPassword;
        private Label labelOfNewPassword;
        private Label labelOfСonfirmation;
        private Label label1;
        private Button buttonOfSaveInfo;
        private Button buttonOfCancel;
        private TextBox textBoxForOldPassword;
        private TextBox textBoxForNewPassword;
        private TextBox textBoxOfConfirmation;
    }
}