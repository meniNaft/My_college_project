using My_college_project.Models;
using My_college_project.Models.Enums;
using My_college_project.Services;
using ReaLTaiizor.Forms;

namespace My_college_project.Forms
{
    public partial class UserDetailsForm : MaterialForm
    {
        public UserDetailsForm()
        {
            InitializeComponent();
            LoadUserData();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!NavigationService.isNavigate)
            {
                Application.Exit();
            }
        }

        private void LoadUserData()
        {
            if (ManagerService.User != null)
            {
                materialTextBox_name.Text = ManagerService.User.Name;
                materialTextBox_address.Text = ManagerService.User.Address;
                materialTextBox_username.Text = ManagerService.User.Username;
                materialTextBox_password.Text = ManagerService.User.Password;
                materialTextBox_phone.Text = ManagerService.User.Phone;

                if (ManagerService.User.Role == RoleEnum.LECTURE) 
                {
                    double? hourlyWage = ManagerService.GetHourlyWage();
                    if(hourlyWage != null)
                    {
                        materialTextBox_hourly_wage.Text = hourlyWage.ToString();
                    }
                    materialLabel_hourly_wage.Visible = true;    
                    materialTextBox_hourly_wage.Visible = true;    
                    materialLabel_myCourses.Visible = false;
                    panel_courseList.Visible = false;
                }
                else
                {
                    materialLabel_hourly_wage.Visible = false;
                    materialTextBox_hourly_wage.Visible = false;
                    materialLabel_myCourses.Visible = true;
                    panel_courseList.Visible = true;
                }
            }
        }

        private void LoadCourseListItem()
        {

            Panel panel_courseItem = new Panel();
            panel_courseItem.AutoScroll = true;
            panel_courseItem.BorderStyle = BorderStyle.Fixed3D;
            //panel_courseItem.Location = new Point(677, 174);
            panel_courseItem.Name = "item";
            panel_courseItem.Size = new Size(250, 200);
            panel_courseItem.TabIndex = 17;
            panel_courseItem.Visible = true;
            panel_courseItem.RightToLeft = RightToLeft.Yes;

            Label l = new Label();
            l.Location = new Point(10, 10);
            l.Font = new Font("Arial", 12, FontStyle.Bold);
            l.Text = "שם הקורס";
            Label l1 = new Label();
            l1.Text = "נושא: הקדמה";
            l1.Location = new Point(10, 30);
            Label l2 = new Label();
            l2.Location = new Point(10, 50);
            l2.Text = "נושא: הקדמה2";
            Label l3 = new Label();
            l3.Location = new Point(10, 70);
            l3.Text = "נושא: הקדמה3";
            panel_courseItem.Controls.AddRange([l, l1, l2, l3]);
        }

        private void labelBtn_login_Click(object sender, EventArgs e)
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
                int res = ManagerService.upadte(name, address, username, password, phone);
                string msg;
                switch (res)
                {
                    case 1:
                        msg = "העדכון בוצע בהצלחה";
                        break;
                    case 0:
                        msg = "המשתמש לא נמצא";
                        break;
                    default:
                        msg = "משהו השתבש";
                        break;
                }
                MessageBox.Show(msg);
            }
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            ManagerService.User = null;
            NavigationService.ShowForm(FormsEnum.LOGIN_FORM);
        }
    }
}
