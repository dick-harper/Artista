using Artista.Maui.ViewModels;

namespace Artista.Maui.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}