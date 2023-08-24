using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class VideoFile
    {
        private string _name;
        private string _codecType;

        public VideoFile(string name, string codecType)
        {
            this._name = name;
            this._codecType = codecType;
        }

        public string getCodeType()
        {
            return this._codecType;
        }

        public string getName()
        {
            return this._name;
        }

    }
}
