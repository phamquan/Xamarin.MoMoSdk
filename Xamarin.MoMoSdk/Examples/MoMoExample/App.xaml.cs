using Xamarin.Forms;

namespace MoMoExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MoMoExamplePage();
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
