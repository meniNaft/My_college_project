using My_college_project.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_college_project.Models.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public RoleEnum Role { get; set; }
        public double? AmountToPay{ get; set; }
        public User(int id, string name, string address, string username, string password, string phone, RoleEnum role, double amountToPay)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Username = username;
            Password = password;
            Role = role;
            AmountToPay = amountToPay;
        }

        public User(DataRow row) {
           Id =  (int)row["id"];
           Name =  (string)row["name"];
           Address =  (string)row["address"];
           Phone =  (string)row["username"];
           Username =  (string)row["password"];
           Password =  (string)row["phone"];
           Role = mapToRole((string)row["role_name"]);
           AmountToPay = (double)row["amount_to_pay"];
        }
        private RoleEnum mapToRole(string roleName)
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
