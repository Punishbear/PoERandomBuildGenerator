using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PoERandomBuildGenerator
{
    public abstract class PropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected void SetProperty<T>(ref T store, T value, Action afterSet = null, [CallerMemberName] string propertyName = null)
        {
            if (!value.Equals(store))
            {
                store = value;
                RaisePropertyChanged(propertyName);
            }

            if (afterSet != null)
            {
                afterSet.Invoke();
            }
        }
    }
}
