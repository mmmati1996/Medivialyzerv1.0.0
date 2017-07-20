using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TestLootHUDa___wyglad
{
    public partial class ListOfItems : Form
    {
        public ListOfItems()
        {
            InitializeComponent();
        }

        private void ListOfItems_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Price";
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                    dataGridView1.Rows.Add(currentProperty.Name, Properties.Settings.Default[currentProperty.Name]);
            }
        }
    }
}
