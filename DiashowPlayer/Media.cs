using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiashowPlayer
{
    public class Media
    {
        private string filename;
        private RepeationSetting repeationSetting;
        private MediaType type;

        public Media(string filename, RepeationSetting repeationSetting, MediaType type)
        {
            this.filename = filename;
            this.repeationSetting = repeationSetting;
            this.type = type;
        }

        public string Filename { get => filename; set => filename = value; }
        public RepeationSetting RepeationSetting { get => repeationSetting; }
        public MediaType Type { get => type; set => type = value; }
    }
}
