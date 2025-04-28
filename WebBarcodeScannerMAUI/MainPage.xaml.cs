using System.Diagnostics;

namespace WebBarcodeScannerMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RequestPermission();
        }

        private async void RequestPermission() {
            PermissionStatus status = await Permissions.RequestAsync<Permissions.Camera>();
        }

        private async void OnHybridWebViewRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
        {
            //await DisplayAlert("Raw Message Received", e.Message, "OK");
            Debug.WriteLine(e.Message);
            hybridWebView.SendRawMessage("stop");
        }
    }

}
