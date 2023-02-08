using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.MediaPlayerSample
{
    public static class MediaPlayerSample
    {
        public static void TestCase()
        {
            var audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
        }
    }
}