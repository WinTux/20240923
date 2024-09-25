using System.Diagnostics;
using ZXing.Net.Maui;

namespace EjemplosMAUI.Pages;

public partial class ScannerQRPage : ContentPage
{
	public ScannerQRPage()
	{
		InitializeComponent();
		lectorCodigo.Options = new BarcodeReaderOptions() { 
			AutoRotate = true,
			Formats = BarcodeFormat.QrCode, // BarcodeFormats.All
			TryHarder = true,
			Multiple = false
		};

    }
	async void OnCodigoBarrasDetectado(Object sender, BarcodeDetectionEventArgs e) {
		Debug.WriteLine("[EVENTO] Se detectó un código de barras");
		Dispatcher.Dispatch(() => {
            resultadoCodigo.Text = $"{e.Results[0].Value} ({e.Results[0].Format})";
        });
    }
}