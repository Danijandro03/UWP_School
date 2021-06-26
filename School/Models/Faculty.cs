using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Faculty
    {
        public int Id
        {
            get;
            set;
        }
        public string Teacher
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        //public Teacher Teacher
        //{
        //    get;
        //    set;
        //}
        public Faculty()
        {
            
        }

        public List<Faculty> faculties = new List<Faculty>();

        public Faculty(int id, string NameT, string cl)
        {
            this.Id = id;
            this.Teacher = NameT;
            this.Name = cl;
        }

    }

}
