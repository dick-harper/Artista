﻿using Artista.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Artista.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FooterView : ContentView
	{
		public FooterView ()
		{
			InitializeComponent ();

            BindingContext = ((App)Application.Current).ServiceProvider.GetService<FooterViewModel>();
        }
	}
}