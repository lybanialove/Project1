using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3_наследованиеООП_

{
    public class Invistition
    {
        int price_out;
        int price_in;
        int risk;
        string name;
        int time;
        int shtuki;
        int id;
        private List<string> organizates = new List<string> { "Тинькофф банк", "Газпром банк", "Тесла", "Nvidia", "Intel", "Ryzen", "Сбербанк", "Лукойл", "Роснефть", "Норникель", "Северсталь", "Втб", "Альфа Банк" };


        public Invistition(string name, int price_in, int risk, int price_out)
        {
            this.price_in = price_in;
            this.price_out = price_out;
            this.risk = risk;
            this.name = name;
        }

        public Invistition(string name, int price_in, int price_out)
        {
            this.price_in = price_in;
            this.price_out = price_out;
            this.name = name;
        }

        public Invistition()
        {
        }

        public int Risk { get => risk; set => risk = value; }
        public string Name { get => name; set => name = value; }
        public int Price_out { get => price_out; set => price_out = value; }
        public int Price_in { get => price_in; set => price_in = value; }
        internal List<string> Organizates { get => organizates; set => organizates = value; }
        public int Time { get => time; set => time = value; }
        public int Shtuki { get => shtuki; set => shtuki = value; }
        public int Id { get => id; set => id = value; }
    }
}