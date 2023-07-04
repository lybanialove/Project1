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

    public partial class Form6 : Form
    {
        Form2 form2;
        public Form6(Portfel portfel,Form2 form2)
        {
            this.portfel = portfel;
            this.form2 = form2;

            InitializeComponent();
        }
        Portfel portfel;
        private void Form6_Load(object sender, EventArgs e)
        {
            k();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentDoubleClick;

        }
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            vvv();
            vvv1();
            dataGridView1.CellContentDoubleClick -= DataGridView1_CellContentDoubleClick;
            portfel.list_add_Deposit(index);
        }
        private void vvv1()
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1[2, i].EditedFormattedValue.ToString() == "")
            {
                MessageBox.Show("Вы не выбрали время депозита!", "Ошибка!");
            }
            else 
            {
                portfel.Deposits[i].Shtuki = int.Parse(dataGridView1[2, i].Value.ToString());
            }

        }
        private void vvv()
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1[1, i].EditedFormattedValue.ToString() == "")
            {
                MessageBox.Show("Вы не выбрали вид депозита!", "Ошибка!");
            }
            else if (dataGridView1[1, i].Value.ToString() == "Срочный")
            {
                portfel.Deposits[i].Vid = "Срочный";
            }

            else if (dataGridView1[1, i].EditedFormattedValue.ToString() == "Сберегательный")
            {
                portfel.Deposits[i].Vid = "Сберегательный";
            }
        }

        public void k()
        {
            dataGridView1.DataSource = null;
            portfel.Create_Deposit();
                for (int i = 0; i < 13; i++)
                {
                    dataGridView1.Rows.Add(portfel.Deposits[i].Organization, "", "", portfel.Deposits[i].Risk, portfel.Deposits[i].Price_in);
                    portfel.Deposits[i].Name = "Депозит";
                    portfel.Deposits[i].Time = int.Parse(dataGridView1[2,i].Value.ToString());
                }
            
        }
        public void k1()
        {
            portfel.Deposits.Clear();
            dataGridView1.DataSource = null;
            portfel.Create_Deposit();
            for (int i = 0; i < 13; i++)
            {
                dataGridView1.Rows.Add(portfel.Deposits[i].Organization, "", "", portfel.Deposits[i].Risk, portfel.Deposits[i].Price_in);
                portfel.Deposits[i].Name = "Депозит";
                portfel.Deposits[i].Time = int.Parse(dataGridView1[2, i].Value.ToString());
            }

        }

    }
}
