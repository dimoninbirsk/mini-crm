using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.UIApplication.ViewModel
{
    public partial class AppShellViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isLoggedIn = false;

        public bool IsNotLoggedIn => !IsLoggedIn;

        [RelayCommand]
        private async Task Login()
        {
            IsLoggedIn = true;
            await Shell.Current.GoToAsync("///MainPage");
        }

        [RelayCommand]
        private async Task Logout()
        {
            IsLoggedIn = false;
            await Shell.Current.GoToAsync("///LoginPage");
        }
    }
}