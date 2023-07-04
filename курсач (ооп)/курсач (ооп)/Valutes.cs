using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3_наследованиеООП_
{
    class Valute : Deposit
    {
        string name_valutes;

        public Valute()
        {
        }

        public Valute(string name, int price_in, int price_out, string vid_deposit, int srok_depozit, string name_valutes, string vid_valutes, int shtuki) : base(name, price_in, price_out, vid_deposit, srok_depozit, shtuki )
        {
            this.name_valutes = name_valutes;
        }
        public string Name_valutes { get => name_valutes; set => name_valutes = value; }



    }
}