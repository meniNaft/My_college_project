using My_college_project.Models;
using My_college_project.Services;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_college_project
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!NavigationService.isNavigate)
            {
                Application.Exit();
            }
        }

        private void labelBtn_registration_Click(object sender, EventArgs e)
        {
            string name = materialTextBox_name.Text;
            string address = materialTextBox_address.Text;
            string username = materialTextBox_username.Text;
            string password = materialTextBox_password.Text;
            string phone = materialTextBox_phone.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("בבקשה למלא את כל השדות");
            }
            else
            {
                int res = ManagerService.create(name, address, username, password, phone);
                if (res == 0) 
                {
                    MessageBox.Show("משהו השתבש");
                }
                else
                {
                    NavigationService.ShowForm(FormsEnum.USER_DETAILS_FORM);
                }
            }
        }
    }
}
