using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class VideoConverter
    {
        public void converter(string filename, string format) {
            if (format == "mp4")
            {
                VideoFile video = new VideoFile(filename, format);
                Console.WriteLine("Video converter => "+ video.getName());
            }
            else
            {
                AudioMixer audio = new AudioMixer(filename);
                Console.WriteLine("Audio converter => "+ audio.getType());
            }
        }


    }
}
