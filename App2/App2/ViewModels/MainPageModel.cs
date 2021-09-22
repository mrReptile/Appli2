using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2.ViewModels
{
    class MainPageModel : ViewModelBase
    {
        private string _nombre;

        public MainPageModel() {
            _nombre = "hola";
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
            if (string.Equals(_nombre, value)) return;
                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
            }
        }

        public string SinUpdate
        {
            get => _nombre;
        }
    }
}
