using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Storage;
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
                .UseMauiCommunityToolkitMediaElement()
                .UseMauiCommunityToolkitCamera()
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
            builder.Services.AddSingleton<IFileSaver>(FileSaver.Default);

            builder.Services.AddTransient<RelojPage>();
            builder.Services.AddTransient<ScannerQRPage>();
            builder.Services.AddTransient<CommunityToolkitPage>();
            builder.Services.AddTransient<MapaPage>();
            builder.Services.AddTransient<MediaPage>();
            builder.Services.AddTransient<GridLayoutPage>();
            builder.Services.AddTransient<ArchivosPage>();
            builder.Services.AddTransient<FotosVideosMeidaPickerPage>();
            builder.Services.AddTransient<CameraPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
