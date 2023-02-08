using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.MediaPlayerSample
{
    public interface IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName);

        public void PlayMp4(string fileName);
    }

    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
            => Console.WriteLine($"Playing vlc file. Name: {fileName}");

        public void PlayVlc(string fileName)
        {

        }
    }

    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            
        }

        public void PlayVlc(string fileName)
            => Console.WriteLine($"Playing mp4 file. Name: {fileName}");
    }
}