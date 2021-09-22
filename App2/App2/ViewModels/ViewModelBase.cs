using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App2.ViewModels
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string nombrePropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
    }
}
