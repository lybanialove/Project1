using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3_наследованиеООП_
{
    internal class Bumaga: Invistition
    {
        string active;// ресурсы организации
        string organization;

        public Bumaga()
        {
            
        }
        public Bumaga(string name, int price_in, int price_out, string organization) : base(name, price_in, price_out)
        {
            this.organization = organization;
        }
        public Bumaga(string name, int price_in, int risk, int price_out, string organization) : base(name, price_in, risk, price_out)
        {

            this.organization = organization;
        }
        
        public string Organization { get => organization; set => organization = value; }

    }
}
