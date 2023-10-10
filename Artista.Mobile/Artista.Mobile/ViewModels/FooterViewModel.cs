using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Artista.Mobile.ViewModels
{
    public partial class FooterViewModel : ObservableObject
    {
        public FooterViewModel()
        {
            MuseumName = "The Metropolitan Museum of Art";
            CurrentDate = DateTime.Now.ToShortDateString();
        }

        [ObservableProperty]       
        private string _museumName;

        [ObservableProperty]
        private string _currentDate;
    }
}
