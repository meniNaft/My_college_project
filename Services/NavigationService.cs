using My_college_project.Forms;
using My_college_project.Models;

namespace My_college_project.Services
{
    static public class NavigationService
    {
        static public bool isNavigate = false;
        static private void CloseAllforms()
        {
            isNavigate = true;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToArray())
            {
                form.Close();
            }
            isNavigate = false;
        }
       static public void ShowForm(FormsEnum formToShow)
        {
            CloseAllforms();
            Form result = formToShow switch
            {
                FormsEnum.LOGIN_FORM => new LoginForm(),
                FormsEnum.REGISTRATION_FORM => new RegistrationForm(),
                FormsEnum.USER_DETAILS_FORM => new UserDetailsForm(),
                FormsEnum.MANAGEMENT_FORM => new ManagementForm(),
                _ => throw new ArgumentException("Invalid form type specified.")
            };
            result.Show();
        }
    }
}
