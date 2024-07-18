using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_college_project.DAL
{
    internal interface IRepository<T>
    {
        public List<T> FindAll(); 
        public T? FindById(int id);
        public bool Insert(T item);
        public bool Update(T item);
        public bool DeleteById(T item);
    }
}
