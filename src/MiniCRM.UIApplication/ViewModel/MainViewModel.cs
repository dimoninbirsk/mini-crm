using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.UIApplication.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Главная";
    }
}
