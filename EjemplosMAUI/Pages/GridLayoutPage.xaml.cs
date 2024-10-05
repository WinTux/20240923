
namespace EjemplosMAUI.Pages;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}
    public void OnBotonPlayPauseClic(object sender, EventArgs e)
    {
        if (video.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            video.Pause();
        else
            video.Play();
    }
    public void OnBotonPlayPause2Clic(object sender, EventArgs e)
    {
        if (videolocal.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            videolocal.Pause();
        else
            videolocal.Play();
    }
    public void OnBotonAudioClic(object sender, EventArgs e)
    {
        if (audio.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            audio.Pause();
        else
            audio.Play();
    }
}