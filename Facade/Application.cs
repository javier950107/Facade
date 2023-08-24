using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            VideoConverter video = new VideoConverter();
            video.converter("halo.mp4", "mp3");
            video.converter("test.mp4", "mp4");
        }
    }
}
