using My_college_project.Forms.Components;
using My_college_project.Models;
using My_college_project.Models.Entities;
using My_college_project.Models.Enums;
using My_college_project.Services;
using ReaLTaiizor.Forms;

namespace My_college_project.Forms
{
    public partial class UserDetailsForm : MaterialForm
    {
        Form prompt;
        Label textLabel_dialog;
        TextBox textBox_dialog;
        Button confirmation;
        public UserDetailsForm()
        {
            InitializeComponent();
            LoadUserData();
            GenerateDialogForm();
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
                    labelBtn_payment.Visible = false;
                    materialLabel_payment.Visible = false;
                    materialTextBox_payment.Visible = false;
                }
                else
                {
                    LoadCourseListItem();
                    materialLabel_hourly_wage.Visible = false;
                    materialTextBox_hourly_wage.Visible = false;
                    materialLabel_myCourses.Visible = true;
                    panel_courseList.Visible = true;
                    labelBtn_payment.Visible = true;
                    materialLabel_payment.Visible = true;
                    materialTextBox_payment.Visible = true;
                    materialTextBox_payment.Text = ManagerService.User.AmountToPay.ToString();
                }
            }
        }

        private void LoadCourseListItem()
        {
            ManagerService.LoadStudentCourses();
            if (ManagerService.UserCourses != null)
            {
                int PanelHeight = 10; 
                foreach (Course course in ManagerService.UserCourses)
                {
                    var panel_courseItem = GetCorsePanel.LoadCourseListItem(course, new Point(10, PanelHeight), PayPerCourse);
                    panel_courseList.Controls.Add(panel_courseItem);
                    PanelHeight += 200;
                }
            }
        }

        private void labelBtn_update_Click(object sender, EventArgs e)
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

        private void PayPerCourse(object sender, EventArgs e)
        {
            prompt.Text = "תשלום יתרה";
            Course currentCourse = (Course)((Label)sender).Tag;
            textLabel_dialog.Text = $"הזן סכום לתשלום עד {currentCourse.NeedToPay}";
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string input = textLabel_dialog.Text;
                if (double.TryParse(input, out double amount) && amount > 0 && amount < currentCourse.NeedToPay)
                {
                    bool res = ManagerService.payForCourse(currentCourse, amount);
                }
                else
                {
                    MessageBox.Show("הסכום לא תקין");
                }
            }
        }
        private void GenerateDialogForm()
        {
            prompt = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel_dialog = new Label() { Left = 50, Top = 20, Text = "" };
            TextBox textBox_dialog = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 200, Height = 30, Width = 100, Top = 100, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox_dialog);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel_dialog);
            prompt.AcceptButton = confirmation;
        }
    }
}
