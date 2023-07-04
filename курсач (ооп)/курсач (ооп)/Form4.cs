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
    public partial class Form4 : Form
    {
        Form2 form2;
        public Form4(Portfel portfel, Form2 form2)
        {
            this.form2 = form2;
            this.portfel = portfel;
            
            InitializeComponent();
        }
        Portfel portfel;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentDoubleClick;
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.CellContentDoubleClick -= DataGridView1_CellContentDoubleClick;
            portfel.list_add_Obligat (index);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            k4();
        }
        public void k4()
        {
            dataGridView1.DataSource = null;
            portfel.Create_Obligation();
            for (int i = 0; i < 13; i++)
            {
                portfel.Obligations[i].Name = "Облигации";
                portfel.Obligations[i].Time = 0;
                dataGridView1.Rows.Add(portfel.Obligations[i].Organization, portfel.Obligations[i].Period, portfel.Obligations[i].Price_in, portfel.Obligations[i].Risk, portfel.Obligations[i].Kupon);
            }

        }
        public void k5()
        {
            portfel.Obligations.Clear();
            dataGridView1.DataSource = null;
            portfel.Create_Obligation();
            for (int i = 0; i < 13; i++)
            {
                portfel.Obligations[i].Name = "Облигации";
                portfel.Obligations[i].Time = 0;
                dataGridView1.Rows.Add(portfel.Obligations[i].Organization, portfel.Obligations[i].Period, portfel.Obligations[i].Price_in, portfel.Obligations[i].Risk, portfel.Obligations[i].Kupon);
            }
        }
    }
}

