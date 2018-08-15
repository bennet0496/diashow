using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiashowPlayer
{
    public class Diashow
    {
        public int GlobalInterval { get; set; }
        public List<Media> Medias { get; } = new List<Media>();

        public List<Media> PriorityMedia
        {
            get
            {
                return (from media in Medias where media.RepeationSetting.GaranteedEvery != 0 select media).ToList();
            }
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public int IntervalTicks
        {
            get
            {
                return (from media in Medias select media.RepeationSetting.Interval).Aggregate(GCD);
            }
        }

        public int WeightedCount
        {
            get
            {
                return (from media in Medias select media.RepeationSetting.Weight).Sum();
            }
        }

        public Media WeightedElementAt(int index)
        {
            int realindex = 0;
            while(index > 0)
            {
                index -= Medias.ElementAt(realindex++).RepeationSetting.Weight;
            }

            return Medias.ElementAt(Math.Max(0,--realindex));
        }
    }
}
