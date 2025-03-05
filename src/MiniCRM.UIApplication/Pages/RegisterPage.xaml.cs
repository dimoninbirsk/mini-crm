namespace MiniCRM.UIApplication.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = new ViewModels.RegisterViewModel();
    }
}