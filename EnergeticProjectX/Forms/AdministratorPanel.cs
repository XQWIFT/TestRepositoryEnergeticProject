using UserChangePasswordForm;
using ListOfUsersForm;

namespace AdministratorPanelForm
{
    public partial class AdministratorPanel : Form
    {
        string userLogin;
        public AdministratorPanel(string UserLogin)
        {
            InitializeComponent();
            userLogin = UserLogin;
        }

        private void buttonOfChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserChangePassword changePassword = new UserChangePassword(userLogin);
            changePassword.ShowDialog();
            this.Close();
        }

        private void buttonListOfUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListOfUsers listOfUsers = new ListOfUsers();
            listOfUsers.ShowDialog();
            this.Close();
        }
    }
}