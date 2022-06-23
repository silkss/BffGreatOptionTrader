using GotWpfUi.ViewModels.Base;

namespace GotWpfUi.ViewModels;

internal class MainViewModel : BaseViewModel
{
    private string _title = "Hello from something";

    public string Title
    {
        get => _title;
        set => Set(ref _title, value);
    }
}
