using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лаба_3_наследованиеООП_;

namespace курсач__ооп_
{

    public partial class Form2 : Form
    {
        Form3 f3;
        Form4 f4;
        Form5 f5;
        Form6 f6;
        int m = 0;
        public Invistition invist = new Invistition();
        public Portfel portfel = new Portfel();
        List<string> vs = new List<string> {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        Thread th;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = portfel.Balance.ToString() + " $";
            label4.Text = vs[m];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void opennewform2()
        {
            f3 = new Form3(this.portfel, this,this.invist);
            f3.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform3()
        {
            f4 = new Form4(this.portfel, this);
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform4()
        {
            f5 = new Form5(this.portfel, this);
            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform5()
        {
            f6 = new Form6(this.portfel,this);
            f6.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (portfel.Invest.Count == 0)
            {
                MessageBox.Show("Вы не выбрали инвестиции!", "Ошибка!");
            }
            else
            {
                for (int i = 0; i < portfel.Invest.Count; i++)
                {
                    if (portfel.Invest[i].Time == 0)
                    {
                        dataGridView2.Rows.Add(portfel.Invest[i].Organizates[i], portfel.Invest[i].Price_out, portfel.Invest[i].Price_in,"",  portfel.Invest[i].Shtuki,portfel.Invest[i].Name);
                    }
                    
                    else
                    {
                        dataGridView1.Rows.Add(portfel.Invest[i].Organizates[i], portfel.Invest[i].Price_out, portfel.Invest[i].Price_in, portfel.Invest[i].Time, portfel.Invest[i].Shtuki, portfel.Invest[i].Name  );
                    }
                }
            }
            portfel.Invest.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f3.k7();
            f4.k5();
            f5.k3();
            f6.k1();
            m++;
            if (m == vs.Count)
            {
                m = 0;
            }
            label4.Text = vs[m];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
