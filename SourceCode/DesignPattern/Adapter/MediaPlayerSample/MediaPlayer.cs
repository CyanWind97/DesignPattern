using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.MediaPlayerSample
{
    public interface IMediaPlayer
    {
        public void  Play(string audioType, string fileName);
    }


    public class MediaApater : IMediaPlayer
    {
        private IAdvancedMediaPlayer _advancedMussicPlayer;


        public MediaApater(string audioType)
        {
            if(audioType == "vlc")
                _advancedMussicPlayer = new VlcPlayer();
            else if(audioType == "mp4")
                _advancedMussicPlayer = new Mp4Player();
        }

        public void Play(string audioType, string fileName)
        {
            if(audioType == "vlc")
                _advancedMussicPlayer.PlayVlc(fileName);
            else if(audioType == "mp4")
                _advancedMussicPlayer.PlayMp4(fileName);
        }
    }
}