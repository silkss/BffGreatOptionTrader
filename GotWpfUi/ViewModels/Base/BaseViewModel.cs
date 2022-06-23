using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GotWpfUi.ViewModels.Base;

internal class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
    {
        if (Equals(field, value))
        {
            return false;
        }

        field = value;
        NotifyPropertyChanged(PropertyName);
        
        return true;
    }
}
