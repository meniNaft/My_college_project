using My_college_project.Models;
using My_college_project.Models.Enums;
using My_college_project.Services;
using ReaLTaiizor.Forms;

namespace My_college_project
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelBtn_login_Click(object sender, EventArgs e)
        {
            string username = materialTextBox_username.Text;
            string password = materialTextBox_password.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("אנא הזן שם משתמש וסיסמא");
            }
            else
            {
                bool success = ManagerService.Login(username, password);
                if (!success) 
                {
                    MessageBox.Show("המשתמש אינו קיים");
                }
                else
                {
                    if(ManagerService.User.Role == RoleEnum.ADMIN)
                    {
                        NavigationService.ShowForm(FormsEnum.MANAGEMENT_FORM);
                        return;
                    }
                    NavigationService.ShowForm(FormsEnum.USER_DETAILS_FORM);
                }
            }
            
        }

        private void labelBtn_registration_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm(FormsEnum.REGISTRATION_FORM);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!NavigationService.isNavigate)
            {
                Application.Exit();
            }
        }
    }
}
