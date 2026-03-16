namespace EnergeticProjectX
{
    partial class AuthorizationForm
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
            labelOfAuthorization = new Label();
            labelOfLogin = new Label();
            textBoxForLogin = new TextBox();
            labelOfPassword = new Label();
            textBoxOfPassword = new TextBox();
            buttonOfInvolve = new Button();
            SuspendLayout();
            // 
            // labelOfAuthorization
            // 
            labelOfAuthorization.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelOfAuthorization.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfAuthorization.Location = new Point(229, 9);
            labelOfAuthorization.Name = "labelOfAuthorization";
            labelOfAuthorization.Size = new Size(346, 63);
            labelOfAuthorization.TabIndex = 0;
            labelOfAuthorization.Text = "Авторизация";
            labelOfAuthorization.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOfLogin
            // 
            labelOfLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfLogin.Location = new Point(12, 118);
            labelOfLogin.Name = "labelOfLogin";
            labelOfLogin.Size = new Size(121, 54);
            labelOfLogin.TabIndex = 1;
            labelOfLogin.Text = "Логин";
            labelOfLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxForLogin
            // 
            textBoxForLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxForLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxForLogin.Location = new Point(170, 118);
            textBoxForLogin.Name = "textBoxForLogin";
            textBoxForLogin.Size = new Size(594, 50);
            textBoxForLogin.TabIndex = 2;
            // 
            // labelOfPassword
            // 
            labelOfPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOfPassword.Location = new Point(12, 206);
            labelOfPassword.Name = "labelOfPassword";
            labelOfPassword.Size = new Size(145, 51);
            labelOfPassword.TabIndex = 3;
            labelOfPassword.Text = "Пароль";
            labelOfPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxOfPassword
            // 
            textBoxOfPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxOfPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOfPassword.Location = new Point(170, 208);
            textBoxOfPassword.Name = "textBoxOfPassword";
            textBoxOfPassword.Size = new Size(594, 50);
            textBoxOfPassword.TabIndex = 4;
            textBoxOfPassword.UseSystemPasswordChar = true;
            // 
            // buttonOfInvolve
            // 
            buttonOfInvolve.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOfInvolve.Location = new Point(229, 317);
            buttonOfInvolve.Name = "buttonOfInvolve";
            buttonOfInvolve.Size = new Size(346, 84);
            buttonOfInvolve.TabIndex = 5;
            buttonOfInvolve.Text = "ВОЙТИ";
            buttonOfInvolve.UseVisualStyleBackColor = true;
            buttonOfInvolve.Click += buttonOfInvolve_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOfInvolve);
            Controls.Add(textBoxOfPassword);
            Controls.Add(labelOfPassword);
            Controls.Add(textBoxForLogin);
            Controls.Add(labelOfLogin);
            Controls.Add(labelOfAuthorization);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AuthorizationForm";
            Text = "Учёт данных";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOfAuthorization;
        private Label labelOfLogin;
        private TextBox textBoxForLogin;
        private Label labelOfPassword;
        private TextBox textBoxOfPassword;
        private Button buttonOfInvolve;
    }
}
