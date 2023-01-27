using CommunityToolkit.Mvvm.ComponentModel;

namespace Artista.Maui.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private Guid _id;

        [ObservableProperty]
        private string _loginName;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private bool _isActive;

        [ObservableProperty]
        private string _firstName;

        [ObservableProperty]
        private string _lastName;

        [ObservableProperty]
        private string _email;

        public DateTime DateOfBirth { get; set; }

        [ObservableProperty]
        private string _phone;        
    }
}
