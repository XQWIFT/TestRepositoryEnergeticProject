using AdministratorPanelForm;

namespace UserChangePasswordForm
{
    public partial class UserChangePassword : Form
    {
        string userLogin;
        public UserChangePassword(string UserLogin)
        {

            userLogin = UserLogin;
            InitializeComponent();
        }

        private void buttonOfSaveInfo_Click(object sender, EventArgs e)
        {
            DbOfUser.ApplicationContextOfUser db = new();
            var oldPassword = textBoxForOldPassword.Text.Trim();
            var newPassword = textBoxForNewPassword.Text.Trim();
            var confirmationPassword = textBoxOfConfirmation.Text.Trim();

            var user = db.Users.FirstOrDefault(u => u.Login == userLogin);
            if (user != null)
            {
                if (user.Password == oldPassword)
                {
                    if (newPassword == confirmationPassword)
                    {
                        user.Password = newPassword;
                        db.SaveChanges();
                        MessageBox.Show("Вы изменили пароль!", "Успешно",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AdministratorPanel administratorPanel = new AdministratorPanel(userLogin);
                        administratorPanel.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Новые пароли не совпадают!\n Попробуйте снова!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxForNewPassword.Clear();
                        textBoxOfConfirmation.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Вы неверно ввели старый пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxForOldPassword.Clear();
                    textBoxForNewPassword.Clear();
                    textBoxOfConfirmation.Clear();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден!\n Try again!", "Ошибка",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.Dispose();
        }

        private void buttonOfCancel_Click(object sender, EventArgs e)
        {
            AdministratorPanel administratorPanel = new(userLogin);
            this.Hide();
            administratorPanel.ShowDialog();
            this.Close();
        }
    }
}
