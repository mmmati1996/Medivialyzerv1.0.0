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
    public partial class WastedSupplies : Form
    {
        List<string> LocalListOfItems = new List<string>();
        public static int TotalValueOfWastedItems = 0;
        public WastedSupplies()
        {
            InitializeComponent();
        }
        private int GetItemPrice(string ItemName)
        {
            return Convert.ToInt32(Properties.Settings.Default[ItemName]);
        }
        private void WastedSupplies_Load(object sender, EventArgs e)
        {
            RefreshComboBox(comboBox1);
            RefreshComboBox(comboBox2);
            RefreshComboBox(comboBox3);
            RefreshComboBox(comboBox4);
            RefreshComboBox(comboBox5);
            RefreshComboBox(comboBox6);
            RefreshComboBox(comboBox7);

        }
        private void RefreshComboBox(ComboBox name)
        {
            name.Items.Clear();
            LocalListOfItems.Clear();
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                if (currentProperty.PropertyType == typeof(int) || currentProperty.PropertyType == typeof(long))
                {
                    LocalListOfItems.Add(currentProperty.Name);
                    name.Items.Add(currentProperty.Name);
                }
            }
        }
        private void ApplyChangesInFunction(ComboBox box,NumericUpDown num)
        {
            if (LocalListOfItems.Contains(box.Text))
            {
                int Value;
               Type now = Properties.Settings.Default[box.Text].GetType();
                if (now == typeof(int))
                {
                    Value = (int)num.Value / 20;
                    Properties.Settings.Default[box.Text] = Value;
                }
                else
                {
                    Value = (int)num.Value;
                    Properties.Settings.Default[box.Text] = (long)Value;
                }
                Properties.Settings.Default.Save();
            }
        }
        private void SumUpAllCells()
        {
            TotalValueOfWastedItems = 0;
            TotalValueOfWastedItems += (int)numericUpDown1.Value * (int)numericUpDown5.Value;
            TotalValueOfWastedItems += (int)numericUpDown2.Value * (int)numericUpDown6.Value;
            TotalValueOfWastedItems += (int)numericUpDown3.Value * (int)numericUpDown7.Value;
            TotalValueOfWastedItems += (int)numericUpDown4.Value * (int)numericUpDown8.Value;
            TotalValueOfWastedItems += (int)numericUpDown9.Value * (int)numericUpDown12.Value;
            TotalValueOfWastedItems += (int)numericUpDown10.Value * (int)numericUpDown13.Value;
            TotalValueOfWastedItems += (int)numericUpDown11.Value * (int)numericUpDown14.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                ApplyChangesInFunction(comboBox1, numericUpDown1);
                ApplyChangesInFunction(comboBox2, numericUpDown2);
                ApplyChangesInFunction(comboBox3, numericUpDown3);
                ApplyChangesInFunction(comboBox4, numericUpDown4);
                ApplyChangesInFunction(comboBox4, numericUpDown9);
                ApplyChangesInFunction(comboBox4, numericUpDown10);
                ApplyChangesInFunction(comboBox4, numericUpDown11);
                SumUpAllCells();
                MessageBox.Show("Total waste was: " + TotalValueOfWastedItems + " gp");
        }
        private void RefreshValuesInTextBoxesFunction(ComboBox box, NumericUpDown num)
        {
            if (LocalListOfItems.Contains(box.Text))
            {
                Type now = Properties.Settings.Default[box.Text].GetType();
                if (now == typeof(int))
                    num.Value = GetItemPrice(box.Text) * 20;
                else
                    num.Value = GetItemPrice(box.Text);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValuesInTextBoxesFunction(comboBox1, numericUpDown1);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValuesInTextBoxesFunction(comboBox2, numericUpDown2);
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValuesInTextBoxesFunction(comboBox3, numericUpDown3);
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValuesInTextBoxesFunction(comboBox4, numericUpDown4);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValuesInTextBoxesFunction(comboBox5, numericUpDown9);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValuesInTextBoxesFunction(comboBox6, numericUpDown10);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValuesInTextBoxesFunction(comboBox7, numericUpDown11);
        }
    }
}
