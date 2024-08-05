using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Gorbachev_Vinyl.ClassFolder
{
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanger([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
