using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot1.startWindow
{
    internal class AudioPlayer
    {
        public static void PlayAudio()
        {
            // Specify the path to my audio file
            string audioFilePath = @"C:\projects\Prog6221_WPT\CyberBot1\CyberBot1\startWindow\greetings.wav.wav";
            SoundPlayer player = new SoundPlayer(audioFilePath);   // Create a new SoundPlayer instance
            player.Play();            // Play the audio file synchronously, so once its domne playing, the program will continue
        }
    }
}
