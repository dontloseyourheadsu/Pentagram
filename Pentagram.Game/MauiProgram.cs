﻿using CommunityToolkit.Maui;
using Pentagram.Game.Services;
using Microsoft.Extensions.Logging;

namespace Pentagram.Game;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("BebasNeue-Regular.ttf", "BebasNeueRegular");
                fonts.AddFont("OdibeeSans-Regular.ttf", "OdibeeSansRegular");
            });
        //builder.Services.AddSingleton<IMusicPlayer, MusicPlayer>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}