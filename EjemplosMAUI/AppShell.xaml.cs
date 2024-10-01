using EjemplosMAUI.Pages;

namespace EjemplosMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RelojPage), typeof(RelojPage));
            Routing.RegisterRoute(nameof(ScannerQRPage), typeof(ScannerQRPage));
            Routing.RegisterRoute(nameof(CommunityToolkitPage), typeof(CommunityToolkitPage));
            Routing.RegisterRoute(nameof(MapaPage), typeof(MapaPage));
            Routing.RegisterRoute(nameof(MediaPage), typeof(MediaPage));
            Routing.RegisterRoute(nameof(GridLayoutPage), typeof(GridLayoutPage));
        }
    }
}
