using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.UIApplication.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Регистрация";

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _confirmPassword;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private bool _hasError;

        [RelayCommand]
        private async Task Register()
        {
            // Ваша логика регистрации здесь.
            // Проверка email, password, confirmPassword, обращение к сервису регистрации.

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword))
            {
                HasError = true;
                ErrorMessage = "Требуется заполнить все поля!";
                return;
            }

            if (Password != ConfirmPassword)
            {
                HasError = true;
                ErrorMessage = "Введенные пароли не совпадают";
                return;
            }

            // Пример успешной регистрации
            HasError = false;
            ErrorMessage = "";
            await Shell.Current.GoToAsync("///LoginPage"); // Переход на страницу авторизации
        }

        [RelayCommand]
        private async Task GoToLogin()
        {
            await Shell.Current.GoToAsync("///LoginPage");
        }
    }
}