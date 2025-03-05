using Microsoft.Extensions.Logging;
using MiniCRM.UIApplication.Pages;
using MiniCRM.UIApplication.ViewModel;
using MiniCRM.UIApplication.ViewModels;

namespace MiniCRM.UIApplication;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //builder.Services.AddSingleton<AppShellViewModel>();

        builder.Services.AddTransient<LoginViewModel>(); // Регистрируем ViewModel
        builder.Services.AddTransient<RegisterViewModel>();
        builder.Services.AddTransient<MainViewModel>();

        builder.Services.AddTransient<LoginPage>();  // Регистрируем страницы
        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}