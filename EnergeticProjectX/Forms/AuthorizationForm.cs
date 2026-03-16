using AdministratorPanelForm;

namespace EnergeticProjectX
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void buttonOfInvolve_Click(object sender, EventArgs e)
        {
            DbOfUser.ApplicationContextOfUser db = new();
            var login = textBoxForLogin.Text.Trim();

            var password = textBoxOfPassword.Text.Trim();

            var user = db.Users.FirstOrDefault(u =>
            u.Login == login &&
            u.Password == password);
            if (user != null)
            {
                Console.WriteLine("W: " +
                    "Access to the app is open as an administrator!");
                var choice = MessageBox.Show("Успешно!", "Вы вошли в аккаунт",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (choice == DialogResult.OK)
                {
                    this.Hide();
                    AdministratorPanel administratorPanel = new AdministratorPanel(textBoxForLogin.Text);
                    administratorPanel.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            textBoxForLogin.Clear();
            textBoxOfPassword.Clear();
            Console.WriteLine("E:" +
                    "Access error. Please try again.");
            }
        }
}
