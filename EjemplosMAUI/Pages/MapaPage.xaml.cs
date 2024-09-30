using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Diagnostics;

namespace EjemplosMAUI.Pages;

public partial class MapaPage : ContentPage
{
	public MapaPage()
	{
		InitializeComponent();
		/*
		Location location = new Location(-16.54323364031667, -68.07971861983887);
		MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
		mimapa.MoveToRegion(mapSpan);
		*/

		// Cambio a satelital
		//mimapa.MapType = MapType.Satellite;

		// Pin para el Cine Monje Campero
		mimapa.Pins.Add(new Pin { 
			Label = "Cine Teatro Monje Campero",
			Location = new Location(-16.50112174320868, -68.13281759265845)
		});
	}
	async void OnMapaClic(object sender, MapClickedEventArgs e) {
		Debug.WriteLine($"Mapa clickeado: {e.Location.Latitude}, {e.Location.Longitude}");
        mimapa.Pins.Add(new Pin
        {
            Label = "Pin dinámico",
            Location = new Location(e.Location.Latitude, e.Location.Longitude)
        });
		Polygon recuadro = new Polygon { 
			StrokeWidth = 9,
			StrokeColor = Color.FromArgb("#0000FF"),
			FillColor = Color.FromArgb("#884444FF"),
			Geopath = { 
				new Location(-16.500634162580837, -68.13249471147009),
                new Location(-16.500791666984583, -68.13237031310194),
                new Location(-16.501152550377498, -68.13280889709215),
                new Location(-16.50097363793212, -68.13294286456552)
            }
		};
		mimapa.MapElements.Add(recuadro);

		// Uso de polyline
		Polyline polyline = new Polyline { 
			StrokeColor = Colors.LightSalmon,
			StrokeWidth = 15,
            Geopath = {
                new Location(-16.50527434814343, -68.13181326918296),
                new Location(-16.50570250489451, -68.13127101980193),
                new Location(-16.506063379123233, -68.13121998457197),
                new Location(-16.50647318463406, -68.13092653199973),
                new Location(-16.50706648361066, -68.13077980571362),
                new Location(-16.50752521870096, -68.13082446154122),
                new Location(-16.50810016512342, -68.1302439358005)
            }
        };
        mimapa.MapElements.Add(polyline);
    }
}