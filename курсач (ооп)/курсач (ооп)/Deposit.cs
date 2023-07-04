using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3_наследованиеООП_
{
    class Deposit : Invistition
    {
        string vid_deposit;
        int srok_depozit;
        string organization;
        private string name;
        private int price_in;
        private int price_out;

        public Deposit()
        {
        }

        public Deposit(string name, int price_in, int price_out, string vid_deposit, int srok_depozit,int shtuki): base(name, price_in,price_out,shtuki)
        {
            this.vid_deposit = vid_deposit;
            this.srok_depozit = srok_depozit;
        }

        public new int Time { get => srok_depozit; set => srok_depozit = value; }
        public string Vid { get => vid_deposit; set => vid_deposit = value; }
        public string Organization { get => organization; set => organization = value; }
    }
}
