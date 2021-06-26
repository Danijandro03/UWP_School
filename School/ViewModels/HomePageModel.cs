using GalaSoft.MvvmLight.Views;
using School.Models;
using School.ViewModels.Base;
using System.Collections.Generic;

namespace School.ViewModels
{
    public class HomePageModel : BasePageModel
    {
        private Faculty father;
        public Faculty Father
        {
            get { return father; }
            set { father = value; RaisePropertyChanged(); }
        }
        public HomePageModel(INavigationService navigationService) : base(navigationService)
        {

            Faculty father = new Faculty();
            List<Faculty> fac = new List<Faculty>();
            fac.Add(new Faculty(1, "Julio", "Ingenieria"));
            fac.Add(new Faculty(4, "John", "Artes"));
            fac.Add(new Faculty(2, "Juan", "Derecho"));
            fac.Add(new Faculty(3, "Ana", "Lenguas"));
            father.faculties = fac;
            //int t = 201;
            //for (int x = 0; x < 10; x++)
            //{

            //    fact.FacultyChild.Add(new Faculty
            //    {
            //        Id = "Facultad numero: " + x.ToString(),
            //        Class = "Clase Codigo: 00" + x.ToString(),
            //        Teacher = "Codigo Profe: " + t.ToString()

            //    });
            //    t++;
            //}
            //Faculty Father = new Faculty();
            //Father.Id = "University";
            //Father.Class = "Engineer";
            //Father.FacultyChild = new List<Faculty>();
            //public List<Teacher> _datateacher = new List<Teacher>();
            //_datateacher.TeacherChild.Add(new Teacher 
            //{
            //    Id = 1,
            //    Name = "",
            //    _class = ""
                
            //});
            //for (int x = 0; x < 10; x++)
            //{
                
            //    Father.FacultyChild.Add(new Faculty {
            //        Id = "Facultad numero: " + x.ToString(),
            //        Class = "Clase Codigo: 00" + x.ToString(),
                 

            //    });
            //    t++;
        }
    }
}
