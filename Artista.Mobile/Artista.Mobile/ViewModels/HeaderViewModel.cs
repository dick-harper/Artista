using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Artista.Mobile.ViewModels
{
    public partial class HeaderViewModel : ObservableObject
    {
        public HeaderViewModel()
        {
            AppName = "Artista";
            Version = "0.0.1";
        }

        [ObservableProperty]       
        private string _version;

        [ObservableProperty]       
        private string _AppName;

       
            
    }
}
