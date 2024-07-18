using My_college_project.DAL;
using My_college_project.Models.Entities;
using My_college_project.Models.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace My_college_project.Services
{
    static internal class ManagerService
    {
        public static User? User = null;
        static public bool Login(string username, string password)
        {
            SqlParameter[] sqlParams =
            [
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            ];
            string selectQuery = "select u.id, u.name, u.address,u.phone, u.username , u.password, r.role_name from users u inner join roles r on r.id = u.role_id where u.username = @username and u.password = @password";
            DataTable res = DbContext.AdapterQuery(selectQuery, sqlParams);
            if (res.Rows.Count> 0)
            {
                User = new User(res.Rows[0]);
                return true;
            }
           else
            {
                return false;
            }
        }

        internal static int upadte(string name, string address, string username, string password, string phone)
        {
            SqlParameter[] sqlParams =
           [

               new SqlParameter("@id", User.Id),
               new SqlParameter("@name", name),
               new SqlParameter("@address", address),
               new SqlParameter("@phone", phone),
               new SqlParameter("@username", username),
               new SqlParameter("@password", password),
           ];
            string query = "update users set name = @name, address = @address, username = @username ,password = @password, phone = @phone where id = @id";
            return DbContext.NoneQuery(query, sqlParams);
        }

        public static double? GetHourlyWage()
        {
            if (User != null)
            {
                
                string query = $"select l.hourly_wage from lectures l where l.user_id = {User.Id}";
                return (double)DbContext.ScalarQuery(query, null);
            }
            return null;
        }


        static private RoleEnum mapToRole(string roleName)
        {
            switch (roleName)
            {
                case "מנהל":
                    return RoleEnum.ADMIN;
                case "מרצה":
                    return RoleEnum.LECTURE;
                case "תלמיד":
                    return RoleEnum.STUDENT;
                default:
                    throw new Exception("no role to user");
            }
        }
    }
}
