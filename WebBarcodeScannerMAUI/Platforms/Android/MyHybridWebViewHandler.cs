using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBarcodeScannerMAUI.Platforms.Android
{
    public class MyHybridWebViewHandler : HybridWebViewHandler
    {

        protected override global::Android.Webkit.WebView CreatePlatformView()
        {
            var view = base.CreatePlatformView();
            view.SetWebChromeClient(new MyWebChromeClient(this.Context));
            return view;
        }
    }
}
