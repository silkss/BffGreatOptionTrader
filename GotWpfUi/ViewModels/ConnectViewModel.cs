using GotWpfUi.Infrastructure.Commands.Base;
using System.Diagnostics;

namespace GotWpfUi.ViewModels;

internal class ConnectViewModel : Base.BaseViewModel
{
    private string _host = "192.168.0.1";
    public string Host
    {
        get => _host;
        set => Set(ref _host, value);
    }

    private int _clientID = 3;
    public int ClientID
    {
        get => _clientID;
        set => Set(ref _clientID, value);
    }

    private int _port = 7497;
    public int Port
    {
        get => _port;
        set => Set(ref _port, value);
    }

    public ConnectViewModel()
    {
        Connect = new LambdaCommand(onConnect, canConnect);
    }

    public LambdaCommand Connect { get; }
    private void onConnect(object? obj)
    {
#if DEBUG
        Debug.WriteLine("Connect pressed. Host: {0}, Port: {1}, ClientID: {2}", Host, Port, ClientID);
#endif
    }
    private bool canConnect(object? obj) => true;
}
