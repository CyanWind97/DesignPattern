using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.MediaPlayerSample
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaApater _mediaAdpater;

        public void Play(string audioType, string fileName)
        {
            if(audioType == "mp3")
            {
                Console.WriteLine($"Playing mp3 file. Name: {fileName}");
            }
            else if(audioType == "vlc" || audioType == "mp4")
            {
                _mediaAdpater = new MediaApater(audioType);
                _mediaAdpater.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Invalid media. ");
                Console.WriteLine($"{audioType} format not supported");
            }
        }
    }
}