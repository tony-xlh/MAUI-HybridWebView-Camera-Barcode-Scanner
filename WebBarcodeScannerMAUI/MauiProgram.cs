using Microsoft.Extensions.Logging;

namespace WebBarcodeScannerMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers(handlers =>
                {
#if ANDROID
                    handlers.AddHandler<HybridWebView, WebBarcodeScannerMAUI.Platforms.Android.MyHybridWebViewHandler>();
#endif
#if IOS
                    handlers.AddHandler<HybridWebView, WebBarcodeScannerMAUI.Platforms.iOS.MyHybridWebViewHandler>();
#endif
#if MACCATALYST
                    handlers.AddHandler<HybridWebView, WebBarcodeScannerMAUI.Platforms.MacCatalyst.MyHybridWebViewHandler>();
#endif
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#if DEBUG
            builder.Services.AddHybridWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
