using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MiniCRM.UIApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.UIApplication.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Авторизация";

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private bool _hasError;

        [RelayCommand]
        private async Task Login()
        {
            // Ваша логика авторизации здесь.
            // Проверка email и password, обращение к сервису аутентификации.

            if (Email == "test@example.com" && Password == "password") // Пример
            {
                HasError = false;
                ErrorMessage = "";
                // Аутентификация прошла успешно
                await Shell.Current.GoToAsync("///MainPage");
            }
            else
            {
                HasError = true;
                ErrorMessage = "Неверная почта или пароль.";
            }
        }

        [RelayCommand]
        private async Task GoToRegister()
        {
            await Shell.Current.GoToAsync("///RegisterPage");
        }
    }
}