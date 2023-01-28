using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Artista.Maui.ViewModels
{
    public partial class UserRegistrationViewModel : ObservableObject
    {
        [ObservableProperty]
        private Guid _id;

        [ObservableProperty]
        private string _loginName;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _confirmPassword;
        
        [ObservableProperty]
        private string _firstName;

        [ObservableProperty]
        private string _lastName;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private DateTime _dateOfBirth;

        [ObservableProperty]
        private string _phone;

        [RelayCommand]
        public void Add()
        {
            // TODO
        }
    }
}
