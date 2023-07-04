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
    
    public partial class Form3 : Form
    {
        Form2 form2;
        public Form3(Portfel portfel, Form2 form2,Invistition inv)
        {
            this.inv = inv;
            this.portfel = portfel;
            this.form2 = form2;
            InitializeComponent();   
        }
        Portfel portfel;
        Invistition inv;
        private void Form3_Load(object sender, EventArgs e)
        {
            k6();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentDoubleClick;
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            portfel.Akcies[index].Shtuki = int.Parse(dataGridView1[5,index].Value.ToString());
            dataGridView1.CellContentDoubleClick -= DataGridView1_CellContentDoubleClick;
            portfel.list_add_Akcie(index);
        }
        public void k6()
        {
            dataGridView1.DataSource = null;
            portfel.Create_Akcie();
            for (int i = 0; i < inv.Organizates.Count(); i++)
            {
                portfel.Akcies[i].Name = "Акции";
                portfel.Akcies[i].Time = 0;
                dataGridView1.Rows.Add(portfel.Akcies[i].Organization, portfel.Akcies[i].Srok_viplat, portfel.Akcies[i].Divident, portfel.Akcies[i].Price_in, portfel.Akcies[i].Price_out);
            }

        }
        public void k7()
        {
            portfel.Akcies.Clear();
            dataGridView1.DataSource = null;
            portfel.Create_Akcie();
            for (int i = 0; i < portfel.Akcies.Count(); i++)
            {
                portfel.Akcies[i].Name = "Акции";
                portfel.Akcies[i].Time = 0;
                dataGridView1.Rows.Add(portfel.Akcies[i].Organization, portfel.Akcies[i].Srok_viplat, portfel.Akcies[i].Divident, portfel.Akcies[i].Price_in, portfel.Akcies[i].Price_out);
            }
        }
    }
}
