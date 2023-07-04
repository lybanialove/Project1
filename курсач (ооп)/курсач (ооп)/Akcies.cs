using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3_наследованиеООП_
{
    class Akcie : Bumaga
    {
        
        double divident;// может быть (%)
        int srok_viplat;
        string vid_akcies;

        public Akcie()
        {
        }

        public Akcie(string name, int price_in, int price_out, string organization, double divident, int srok_viplat, string vid_akcies) : base(name, price_in, price_out, organization)
        {
            this.divident = divident;
            this.srok_viplat = srok_viplat;
            this.vid_akcies = vid_akcies;
        }

        public double Divident { get => divident; set => divident = value; }
        public int Srok_viplat { get => srok_viplat; set => srok_viplat = value; }
        public string Vid_akcies { get => vid_akcies; set => vid_akcies = value; }
    }
}
