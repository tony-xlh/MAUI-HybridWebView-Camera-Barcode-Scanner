using Microsoft.Maui.Handlers;

namespace WebBarcodeScannerMAUI.Platforms.iOS
{
    public class MyHybridWebViewHandler : HybridWebViewHandler
    {
        protected override WebKit.WKWebView CreatePlatformView()
        {
            var view = base.CreatePlatformView();
            view.Configuration.AllowsInlineMediaPlayback = true;
            view.Configuration.MediaTypesRequiringUserActionForPlayback = WebKit.WKAudiovisualMediaTypes.None;
            return view;
        }
    }
}
