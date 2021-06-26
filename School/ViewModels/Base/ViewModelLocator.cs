using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using School.Views;
namespace School.ViewModels.Base
{

    public class ViewModelLocator
    {

        private static ViewModelLocator locator;
        public static ViewModelLocator Locator => locator ?? (locator = new ViewModelLocator());

        public ViewModelLocator()
        {


            var nav = new NavigationService();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
            {
                SimpleIoc.Default.Register<INavigationService, NavigationService>();
                SimpleIoc.Default.Register<HomePageModel>();
                nav.Configure("HomePage", typeof(HomePage));
            }
        }
        public HomePageModel HomePage => ServiceLocator.Current.GetInstance<HomePageModel>();
    }
}

