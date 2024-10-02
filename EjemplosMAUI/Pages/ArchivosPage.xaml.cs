namespace EjemplosMAUI.Pages;

public partial class ArchivosPage : ContentPage
{
	public ArchivosPage()
	{
		InitializeComponent();
	}
	async void OnElegirImagenClic(object sender, EventArgs e) {
		var resultado = await FilePicker.PickAsync(new PickOptions { 
			FileTypes = FilePickerFileType.Images,
			PickerTitle = "Elija una imagen"
		});
		if (resultado != null)
		{
			var flujo = await resultado.OpenReadAsync();
			imagen.Source = ImageSource.FromStream(() => flujo);
		}
		else
			return;
	}
    async void OnElegirImagenesClic(object sender, EventArgs e)
    {
		var TipoPersonalizado = new FilePickerFileType(
			new Dictionary<DevicePlatform, IEnumerable<string>> {
				{ DevicePlatform.WinUI, new[]{ ".pdf"}},
                { DevicePlatform.Android, new[]{ "application/pdf"}},
                { DevicePlatform.iOS, new[]{ "com.adobe.pdf"}},
            }
			);

        var resultados = await FilePicker.PickMultipleAsync(new PickOptions
        {
            FileTypes = FilePickerFileType.Images,//TipoPersonalizado
            PickerTitle = "Elija unas 3 imagenes"
        });
		int contador = 1;
		foreach (var item in resultados) {
			await DisplayAlert("Imgane seleccionada", item.FileName, "Aceptar");
            var flujo = await item.OpenReadAsync();
            switch (contador++) {
				case 1:
                    imagen1.Source = ImageSource.FromStream(() => flujo);
                    break;
                case 2:
                    imagen2.Source = ImageSource.FromStream(() => flujo);
                    break;
                case 3:
                    imagen3.Source = ImageSource.FromStream(() => flujo);
                    break;
            }
		}
    }
}