using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Maui.Views;

namespace EjemplosMAUI.Pages;

public partial class FotosVideosMeidaPickerPage : ContentPage
{
    IFileSaver fileSaver;
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

    public FotosVideosMeidaPickerPage(IFileSaver fileSaver)
	{
		InitializeComponent();
        this.fileSaver = fileSaver;
	}
	async void OnTomarFotoClic(object sender, EventArgs e) {
		var resultado = await MediaPicker.CapturePhotoAsync();
		if (resultado != null) { 
			var flujoFoto = await resultado.OpenReadAsync();
			imagen.Source = ImageSource.FromStream(()=>flujoFoto);
		}
	}
    async void OnGrabarVideoClic(object sender, EventArgs e)
    {
        var resultado = await MediaPicker.CaptureVideoAsync();
		if (resultado != null) { 
			var flujoVideo = await resultado.OpenReadAsync();
			//Guardar el archivo
			var ruta = await fileSaver.SaveAsync("videoprueba.mp4",flujoVideo,
				cancellationTokenSource.Token);
			mensaje.Text = ruta.IsSuccessful? ruta.FilePath : "CANCELADO POR EL USUARIO";
			//Cargar video
			video.Source = MediaSource.FromFile(ruta.FilePath);
			//Falta solicitar permiso de manera programática :D
        }
    }
}