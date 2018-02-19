using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace lion

{
    public partial class App : Application
    {
        private const string PostKey = "Post";
        private const string ReplyKey = "Reply";

        public App()
        {
            InitializeComponent();

            var navigationPage = new Xamarin.Forms.NavigationPage(new Views.HomeView());
            navigationPage.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetPrefersLargeTitles(true);

            MainPage = navigationPage;
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

        public string Post
        {
            get
            {
                if (Properties.ContainsKey(PostKey))
                    return Properties[PostKey].ToString();

                return "";
            }

            set
            {
                Properties[PostKey] = value;
            }
        }

        public string Reply
        {
            get
            {
                if (Properties.ContainsKey(ReplyKey))
                    return Properties[ReplyKey].ToString();

                return "";
            }

            set
            {
                Properties[ReplyKey] = value;
            }
        }
    }
}
