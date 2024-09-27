using CommunityToolkit.Maui;
using EjemplosMAUI.Pages;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace EjemplosMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).UseMauiCommunityToolkit();
            builder.UseBarcodeReader();
            builder.UseMauiMaps();
            /*
            builder.ConfigureMauiHandlers(h => {
                h.AddHandler(typeof(CameraBarcodeReaderView), typeof(CameraBarcodeReaderViewHandler));
                h.AddHandler(typeof(CameraView), typeof(CameraViewHandler));
                h.AddHandler(typeof(BarcodeGeneratorView), typeof(BarcodeGeneratorViewHandler));
            });
            */
            builder.Services.AddTransient<RelojPage>();
            builder.Services.AddTransient<ScannerQRPage>();
            builder.Services.AddTransient<CommunityToolkitPage>();
            builder.Services.AddTransient<MapaPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
