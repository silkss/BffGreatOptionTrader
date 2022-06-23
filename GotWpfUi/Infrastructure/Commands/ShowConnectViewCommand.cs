using GotWpfUi.Infrastructure.Commands.Base;
using GotWpfUi.Views;
using System.Windows;

namespace GotWpfUi.Infrastructure.Commands;

internal class ShowConnectViewCommand : Command
{
    public override bool CanExecute(object? parameter) => parameter is Window;

    public override void Execute(object? parameter)
    {
        if (parameter == null) return;
        new ConnectView(){ Owner = (Window)parameter,}
            .Show();
    }
}
