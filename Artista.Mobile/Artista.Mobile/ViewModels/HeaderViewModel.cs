using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Artista.Mobile.ViewModels
{
    public partial class HeaderViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title;

        public HeaderViewModel()
        {
            Title = "Artista";
        }
    }
}
