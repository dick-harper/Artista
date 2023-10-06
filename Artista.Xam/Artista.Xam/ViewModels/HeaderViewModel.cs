using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Artista.Xam.ViewModels
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
