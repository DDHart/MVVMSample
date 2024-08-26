using MVVMSample.Views;

namespace MVVMSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AddToyPage();
            MainPage = new LoginUser();
        }
    }
}
