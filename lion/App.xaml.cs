using Xamarin.Forms;

namespace lion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.HomeView());



        }

        NavigationPage navPage = new NavigationPage
        {
            BarBackgroundColor = Color.FromHex("#1FBED6"),
            BarTextColor = Color.FromHex("#000000")
        };

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
