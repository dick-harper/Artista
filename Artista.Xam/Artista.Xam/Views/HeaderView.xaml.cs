using Artista.Xam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Artista.Xam.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HeaderView : ContentView
	{
		public HeaderView ()
		{
			InitializeComponent ();

            BindingContext = ((App)Application.Current).ServiceProvider.GetService<HeaderViewModel>();
        }
	}
}