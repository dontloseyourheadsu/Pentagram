using Pentagram.Game.Services;

namespace Pentagram.Game;

public partial class MainPage
{
    private readonly IMusicPlayer _musicPlayer;
    public MainPage()
    {
        InitializeComponent();
        //_musicPlayer = musicPlayer;
        
        /*if (musicPlayer.ShouldPlay())
        {
            mediaElement.ShouldLoopPlayback = true;
            mediaElement.Source = _musicPlayer.GetTrack();
            mediaElement.ShouldMute = musicPlayer.ShouldPlay();
            mediaElement.Play();
        }
        else
        {
            mediaElement.Pause();
        }*/
    }

    private void PlayButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PlayMenuPage());
    }
    
    private void SettingsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SettingsPage());
    }
    
    private void ExitButton_Clicked(object sender, EventArgs e)
    {
        Application.Current?.Quit();
    }
}