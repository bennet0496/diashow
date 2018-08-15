using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiashowPlayer
{
    public class RepeationSetting
    {
        private int garanteedevery;
        private int weight;
        private int interval;
        
        public int GaranteedEvery
        {
            get
            {
                return garanteedevery;
            }

            set
            {
                if(value >= 0)
                {
                    garanteedevery = value;
                }
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                if(value > 0)
                {
                    weight = value;
                }
            }
        }

        public int Interval
        {
            get => interval;
            set
            {
                if (value >= 0)
                {
                    interval = value;
                }
            }
        }

        public string Setting
        {
            get
            {
                string val = "";
                if(garanteedevery != 0)
                {
                    val += "garanteedevery " + garanteedevery + " ";
                }

                if(interval != 0)
                {
                    val += "interval " + interval + " ";
                }

                if(weight > 1)
                {
                    val += "weight " + weight;
                }

                return val;
            }
        }

        public String ToString() {
            return Setting;
        }
    }
}
