using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;
using System.Diagnostics;

namespace EjemplosMAUI.Pages;

public partial class CameraPage : ContentPage
{
    private ICameraProvider cameraProvider;

    public CameraPage(ICameraProvider cameraProvider)
	{
		InitializeComponent();
        this.cameraProvider = cameraProvider;
	}
    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await cameraProvider.RefreshAvailableCameras(CancellationToken.None);
        Debug.WriteLine($"Cantidad de camaras: {cameraProvider.AvailableCameras.Count}");
        foreach (var cam in cameraProvider.AvailableCameras) {
            Debug.WriteLine($"Camara: {cam.Name}, Fash: {cam.IsFlashSupported}, Min Zoom: {cam.MinimumZoomFactor}, Max Zoom: {cam.MaximumZoomFactor}, Posicion: {cam.Position}");
            foreach (var res in cam.SupportedResolutions)
                Debug.WriteLine($"Resolucion: {res.ToString()}");
            
        }
        camara.SelectedCamera = cameraProvider.AvailableCameras.Where(cam=>cam.IsFlashSupported).FirstOrDefault();
        camara.SelectedCamera = cameraProvider.AvailableCameras.Where(cam => cam.Position == CameraPosition.Front).FirstOrDefault();
    }
    async void OnTomarFotoClic(object sender, EventArgs e) {
		await camara.CaptureImage(CancellationToken.None);
	}
    async void OnCapturaTomada(object sender, MediaCapturedEventArgs e)
    {
		if (Dispatcher.IsDispatchRequired) {
            Dispatcher.Dispatch(() => {
				imagen.Source = ImageSource.FromStream(()=> e.Media);
            });
        }
		
    }

    async void OnFlashClic(object sender, EventArgs e)
    {
        camara.CameraFlashMode = 
            camara.CameraFlashMode == CameraFlashMode.On ?
            CameraFlashMode.Off : CameraFlashMode.On;
    }
    async void OnZoomInClic(object sender, EventArgs e)
    {
        camara.ZoomFactor += 0.1f;
    }
    async void OnZoomOutClic(object sender, EventArgs e)
    {
        camara.ZoomFactor -= 0.1f;
    }
}