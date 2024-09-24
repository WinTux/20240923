using System.Timers;

namespace EjemplosMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var temporizador = new System.Timers.Timer(1000);
            temporizador.Elapsed += new System.Timers.ElapsedEventHandler(RedibujarReloj);
            temporizador.Start();
        }

        private void RedibujarReloj(object? sender, ElapsedEventArgs e)
        {
            var graphicView = this.relojGraphicView;
            graphicView.Invalidate();
        }
    }

}
