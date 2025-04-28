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
    }

}
