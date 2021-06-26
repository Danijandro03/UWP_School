using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace School.ViewModels.Base
{
    public class BasePageModel : ViewModelBase
    {
        public INavigationService _navigationService;

        private bool isBusy;
        public bool IsBusy { get { return isBusy; } set { isBusy = value; RaisePropertyChanged(); } }

        public BasePageModel(INavigationService navigationservice)
        {
            _navigationService = navigationservice;
        }
    }
}
