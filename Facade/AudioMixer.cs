using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class AudioMixer
    {
        private string _type;

        public AudioMixer(string type)
        {
            this._type = type;
        }

        public string getType()
        {
            return this._type;
        }
    }
}
