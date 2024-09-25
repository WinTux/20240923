using System.Timers;

namespace EjemplosMAUI.Pages;

public partial class RelojPage : ContentPage
{
	public RelojPage()
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