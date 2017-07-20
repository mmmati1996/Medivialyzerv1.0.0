using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Configuration;
using System.Text.RegularExpressions;

namespace TestLootHUDa___wyglad
{
    public partial class AddOrEditItemValue : Form
    {
        List<string> ListOfItemsLocalList = new List<string>();
        public AddOrEditItemValue()
        {
            InitializeComponent();
        }
        private void AddOrEditItemValue_Load(object sender, EventArgs e)
        {
            RefreshComboBox();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if(ListOfItemsLocalList.Contains(comboBox1.Text) && Regex.IsMatch(textBox1.Text, "[0-9][0-9]*"))
            {
            Properties.Settings.Default[comboBox1.Text] = textBox1.Text;
            Properties.Settings.Default.Save();
            textBox1.Clear();
            label3.Text = Properties.Settings.Default[comboBox1.Text].ToString();
            }
        }

        private void CurrentPriceButton_Click(object sender, EventArgs e)
        {
            var ListOfItems = new ListOfItems();
            ListOfItems.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = Properties.Settings.Default[comboBox1.SelectedItem.ToString()].ToString();
        }

        private void RefreshComboBox()
        {
            comboBox1.Items.Clear();
            ListOfItemsLocalList.Clear();
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                if (currentProperty.PropertyType == typeof(string))
                {
                    ListOfItemsLocalList.Add(currentProperty.Name);
                    comboBox1.Items.Add(currentProperty.Name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not working right now sorry :(");
            /*string name = textBox2.Text;
            int value = Convert.ToInt32(textBox3.Text);
            IResourceWriter writer = new ResourceWriter("myResources.resources");
            writer.AddResource(name, value);
            writer.Close();
            RefreshComboBox();*/
        }
    }
}
