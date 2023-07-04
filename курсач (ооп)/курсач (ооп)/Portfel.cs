using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3_наследованиеООП_
{
    public class Portfel 

    {
        Invistition inv = new Invistition();

        private List<Invistition> invest = new List<Invistition>();

        private List<Akcie> akcies = new List<Akcie>();
        private List<Deposit> deposits = new List<Deposit>();
        private List<Valute> valutes = new List<Valute>();
        private List<obligation> obligations = new List<obligation>();


        int balance = 50000000;
        int count;
        string name;

        public Portfel()
        {

        }

        public Portfel(int balance, int count, string name)
        {
            Balance = balance;
            Count = count;
            Name = name;
        }
        public int Balance { get => balance; set => balance = value; }
        public int Count { get => count; set => count = value; }
        public string Name { get => name; set => name = value; }

        internal List<Akcie> Akcies { get => akcies; set => akcies = value; }
        internal List<Deposit> Deposits { get => deposits; set => deposits = value; }
        internal List<Valute> Valutes { get => valutes; set => valutes = value; }
        internal List<obligation> Obligations { get => obligations; set => obligations = value; }
        internal List<Invistition> Invest { get => invest; set => invest = value; }

        public void list_add_Deposit(int k)
        {
            invest.Add(Deposits[k]);
        }
        public void list_add_Akcie(int k)
        {
            invest.Add(Akcies[k]);
        }
        public void list_add_Obligat(int k)
        {
            invest.Add(Obligations[k]);
        }
        public void list_add_Valut(int k)
        {
            invest.Add(Valutes[k]);
        }

        public void Create_Deposit()
        {
            Deposit dep = new Deposit();
            Random random = new Random();
            for (int i = 0; i <dep.Organizates.Count(); i++)
            {
                Deposit deposit = new Deposit();
                deposit.Vid = "";
                deposit.Organization = inv.Organizates[i].ToString();
                deposit.Time = random.Next(12, 60);
                deposit.Risk = random.Next(1, 25);
                deposit.Price_in = random.Next(1000000, 15000000);
                deposit.Price_out = deposit.Price_in * Convert.ToInt32(Math.Pow(1 + (deposit.Risk / 100), deposit.Time));
                Deposits.Add(deposit);
            }
        }

        public void Create_Akcie()
        {
            Akcie ak1 = new Akcie();
            Random random = new Random();
            for (int i = 0; i < ak1.Organizates.Count(); i++)
            {
                Akcie ak = new Akcie();
                ak.Organization = inv.Organizates[i].ToString();
                ak.Price_in = random.Next(10, 15000);
                ak.Price_out = random.Next(10, 15000);
                ak.Divident = random.Next(0, 25);
                ak.Srok_viplat = random.Next(1, 13);
                akcies.Add(ak);
            }

        }
        public void Create_Valuta()
        {
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                Valute valuta = new Valute();
                valuta.Name_valutes = "";
                valuta.Organization = inv.Organizates[i].ToString();
                valuta.Price_in = random.Next(25, 500);
                int j = random.Next(1, 20);
                valuta.Price_out = valuta.Price_in - j;
                Valutes.Add(valuta);
            }
        }
        public void Create_Obligation()
        {
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                obligation obl = new obligation();
                obl.Organization = inv.Organizates[i].ToString();
                obl.Period = random.Next(12, 500);
                obl.Price_in = random.Next(1000000, 15000000);
                obl.Risk = random.Next(1, 50);
                obl.Kupon = random.Next(5, 50);
                Obligations.Add(obl);
            }
        }


    }
}
