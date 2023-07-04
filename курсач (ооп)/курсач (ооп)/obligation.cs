using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3_наследованиеООП_
{
    class obligation: Bumaga
    {
        float kupon;// выплата в поцентах
        int srok_obligation;// срок погашения

        public obligation()
        {
        }

        public obligation(string name, int price_in, int risk, string organization, int kupon, int period) : base(name, price_in, risk, organization)
        { 
            this.kupon = kupon;
            this.srok_obligation = period;
        }

        public float Kupon { get => kupon; set => kupon =  value; }
        public int Period { get => srok_obligation; set => srok_obligation = value; }

    }
}
