using Pentagram.Game.Platforms.Windows;

namespace Pentagram.Game;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
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

    private void OnPointerEntered(object? sender, PointerEventArgs e)
    {
        var button = (Button)sender!;
        button.SetCustomCursor(CursorIcon.Hand, Application.Current?.MainPage?.Handler?.MauiContext);
    }

    private void OnPointerExited(object? sender, PointerEventArgs e)
    {
        var button = (Button)sender!;
        button.SetCustomCursor(CursorIcon.Arrow, Application.Current?.MainPage?.Handler?.MauiContext);
    }


}