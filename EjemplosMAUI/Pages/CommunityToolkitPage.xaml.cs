using CommunityToolkit.Maui.Core;

namespace EjemplosMAUI.Pages;

public partial class CommunityToolkitPage : ContentPage
{
	public CommunityToolkitPage()
	{
		InitializeComponent();
	}
	async void OnLineaDibujada(object sender, DrawingLineCompletedEventArgs e) {
		var flujo = await lienzo.GetImageStream(200, 200);
		Dispatcher.Dispatch(() => {
			imagen.Source = ImageSource.FromStream(()=> flujo);
		});
	}
}