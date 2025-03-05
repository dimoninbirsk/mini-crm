namespace MiniCRM.UIApplication.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new ViewModels.LoginViewModel();
    }
}