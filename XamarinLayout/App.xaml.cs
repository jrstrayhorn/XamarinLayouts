using Xamarin.Forms;

using Xamarin.Forms.Xaml;
using XamarinLayout.Views;
using XamarinLayout.Views.PickerNavigation;
using XamarinLayout.Views.TabbedPageSample;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
             
namespace XamarinLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new XamarinLayoutPage();
            //MainPage = new NavigationPage(new SampleEventsPage());
            //MainPage = new SampleTabbedPage();
            MainPage = new NavigationPage(new PickNavMainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
