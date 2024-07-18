using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_college_project.Models.Entities
{
    internal class Course
    {
        public Course(int id, string name, DateTime startDate, int startHour, int endHour, double price, bool isActive)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            StartHour = startHour;
            EndHour = endHour;
            Price = price;
            IsActive = isActive;
        }

        public Course(DataRow row)
        {
            Id = (int)row["id"];
            Name = (string)row["name"];
            StartDate = (DateTime)row["start_date"];
            StartHour = (int)row["start_huor"];
            EndHour = (int)row["end_huor"];
            Price = (double)row["price"];
            IsActive = (bool)row["is_active"];
            Subjects = new List<Subject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
