using GalaSoft.MvvmLight.Views;
using School.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ViewModels
{
    public class HomePageModel: BasePageModel
    {
        public HomePageModel(INavigationService navigationService) : base(navigationService)
        {
            
        }
    }
}
