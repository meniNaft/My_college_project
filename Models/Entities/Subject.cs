using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_college_project.Models.Entities
{
    internal class Subject
    {
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Subject(DataRow row)
        {
            Id = (int)row["id"];
            Name = (string)row["name"];
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
