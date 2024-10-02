using EjemplosMAUI.Pages;
using System.Diagnostics;
using System.Timers;

namespace EjemplosMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnRelojPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnRelojPageClic clickeado");
            await Shell.Current.GoToAsync(nameof(RelojPage));
        }
        async void OnScannerQRPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnScannerQRPageClic clickeado");
            await Shell.Current.GoToAsync(nameof(ScannerQRPage));
        }
        async void OnCommunityToolkitPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnCommunityToolkitPageClic clickeado");
            await Shell.Current.GoToAsync(nameof(CommunityToolkitPage));
        }
        async void OnMapaPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnMapaClic clickeado");
            await Shell.Current.GoToAsync(nameof(MapaPage));
        }
        async void OnMediaPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnMediaClic clickeado");
            await Shell.Current.GoToAsync(nameof(MediaPage));
        }
        async void OnGridLayoutPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnGridLayoutClic clickeado");
            await Shell.Current.GoToAsync(nameof(GridLayoutPage));
        }
        async void OnArchivosPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnArchivosClic clickeado");
            await Shell.Current.GoToAsync(nameof(ArchivosPage));
        }
    }

}
