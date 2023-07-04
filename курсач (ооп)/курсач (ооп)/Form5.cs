using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лаба_3_наследованиеООП_;

namespace курсач__ооп_
{
    public partial class Form5 : Form
    {
        Form2 form2;
        public Form5(Portfel portfel,Form2 form2)
        {
            this.portfel = portfel;
            this.form2 = form2;
            
            InitializeComponent();
        }
        Portfel portfel;
        private void Form5_Load(object sender, EventArgs e)
        {
            k2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentDoubleClick;
            vvv();
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            portfel.Valutes[index].Shtuki = int.Parse(dataGridView1[4, index].Value.ToString());
            dataGridView1.CellContentDoubleClick -= DataGridView1_CellContentDoubleClick;
            portfel.list_add_Valut(index);
        }
        private void vvv()
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1[1, i].EditedFormattedValue.ToString() == "")
            {
                MessageBox.Show("Вы не выбрали валюту", "Ошибка!");
            }
            else if (dataGridView1[1, i].Value.ToString() == "Доллар")
            {
                dataGridView1[2, i].Value = int.Parse(portfel.Valutes[i].Price_in.ToString()) * 2;
                dataGridView1[3, i].Value = int.Parse(portfel.Valutes[i].Price_out.ToString()) * 2;
                portfel.Valutes[i].Name_valutes = "Доллар";
            }

            else if (dataGridView1[1, i].EditedFormattedValue.ToString() == "Евро")
            {
                dataGridView1[2, i].Value = int.Parse(portfel.Valutes[i].Price_in.ToString()) * 3;
                dataGridView1[3, i].Value = int.Parse(portfel.Valutes[i].Price_out.ToString()) * 3;
                portfel.Valutes[i].Name_valutes = "Евро";
            }
            else if (dataGridView1[1, i].EditedFormattedValue.ToString() == "Рубли")
            {
                dataGridView1[2, i].Value = int.Parse(portfel.Valutes[i].Price_in.ToString());
                dataGridView1[3, i].Value = int.Parse(portfel.Valutes[i].Price_out.ToString());
                portfel.Valutes[i].Name_valutes = "Рубли";
            }
        }
        public void k2()
        {
            dataGridView1.DataSource = null;
            portfel.Create_Valuta();
            for (int i = 0; i < 13; i++)
            {
                dataGridView1.Rows.Add(portfel.Valutes[i].Organization, "", portfel.Valutes[i].Price_in, portfel.Valutes[i].Price_out);
                portfel.Valutes[i].Time = 0;
                portfel.Valutes[i].Name = "Валюта";
            }

        }
        public void k3()
        {
            portfel.Valutes.Clear();
            dataGridView1.DataSource = null;
            portfel.Create_Valuta();
            for (int i = 0; i < 13; i++)
            {
                dataGridView1.Rows.Add(portfel.Valutes[i].Organization, "", portfel.Valutes[i].Price_in, portfel.Valutes[i].Price_out);
                portfel.Valutes[i].Name = "Валюта";
                portfel.Valutes[i].Time = 0;
            }
        }
    }
}
