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

        private void OnHybridWebViewRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
        {
            Debug.WriteLine(e.Message);
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                hybridWebView.SendRawMessage("stop");
                await DisplayAlert("Barcode Results Received", e.Message, "OK");
            });
        }

        private void OnStartScanButtonClicked(object sender, EventArgs args)
        {
            hybridWebView.SendRawMessage("start");
            Debug.WriteLine("clicked");
        }

        private void OnStopScanButtonClicked(object sender, EventArgs args)
        {
            hybridWebView.SendRawMessage("stop");
        }
    }
}
