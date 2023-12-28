using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentagram.Game.Services
{
    public interface IMusicPlayer
    {
        void Play();
        void Stop();
        void ChangeTrack(string track);
        string GetTrack();
        bool ShouldPlay();
    }

    public class MusicPlayer : IMusicPlayer
    {
        public bool IsPlaying { get; set; }
        public string Track { get; set; } = "embed://Tracks/forestwalk.mp3";

        public void Play()
        {
            IsPlaying = true;
        }

        public void Stop()
        {
            IsPlaying = false;
        }

        public void ChangeTrack(string track)
        {
            Track = $"embed://Tracks/{track}.mp3";
        }

        public string GetTrack()
        {
            return Track;
        }

        public bool ShouldPlay()
        {
            return IsPlaying;
        }
    }
}
