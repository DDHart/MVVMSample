using MVVMSample.ViewModels;

namespace MVVMSample.Views;

public partial class LoginUser : ContentPage
{
	public LoginUser()
	{
		InitializeComponent();
        BindingContext = new LoginUserPageViewModel();
    }
}