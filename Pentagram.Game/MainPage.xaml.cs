using CommunityToolkit.Maui.Views;

namespace Pentagram.Game;

public partial class MainPage : ContentPage
{
    private readonly MediaElement _mediaElement;
    
    public MainPage()
    {
        InitializeComponent();
        _mediaElement = new MediaElement
        {
            ShouldAutoPlay = true,
            ShouldShowPlaybackControls = true,
            Source = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",
            HeightRequest = 300,
            WidthRequest = 400
        };
        //Content = _mediaElement;
    }
    
    void ContentPage_Unloaded(object? sender, EventArgs e)
    {
        _mediaElement.Handler?.DisconnectHandler();
    }
    
    private void OnRotateButtonClicked(object sender, EventArgs e)
    {
        // Rotate the button around its X-axis
        var rotateAnimation = new Animation(v => RotateButton.RotationX = v, 0, 360);
        rotateAnimation.Commit(this, "RotationXAnimation", 16, 2000, Easing.Linear, (v, c) => RotateButton.RotationX = 0, () => true);
    }
}