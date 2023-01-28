using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Artista.Maui.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _loginId;

        [ObservableProperty]
        private string _password;
        
        [RelayCommand]
        void Login()
        {

        }

        [RelayCommand]
        void ForgotLoginIdOrPassword()
        {

        }

        [RelayCommand]
        void RegisterNewUser()
        {

        }
    }
}
