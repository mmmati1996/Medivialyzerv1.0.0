using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Medivialyzerv1._0._0
{
    public partial class ChooseMonsters : Form
    {
        MLProcessChecker klient;
        LootHUD LootHUDwindow;
        SumUpHUD SumUpHUDwindow;
        bool alreadyrunning = false; //open only 1 lootHUD

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public ChooseMonsters()
        {
            InitializeComponent();
        }


        private void ChooseMonsters_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        public void InitializeClient (MLProcessChecker klient)
        {
            this.klient = klient;
        }
        private void LoadListOfMonsters(ComboBox name)
        {
            name.Items.Add("None");
            name.Items.Add("Monster1");
            name.Items.Add("Monster2");
            name.Items.Add("Monster3");

        }
        private void ChooseMonsters_Load(object sender, EventArgs e)
        {
            LoadListOfMonsters(Monster1combobox);
            LoadListOfMonsters(Monster2combobox);
            LoadListOfMonsters(Monster3combobox);
        }
        private void ApplyButtonCM_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ValueHigherTXT.Text, "[^0-9]"))
                MessageBox.Show("Please enter only numbers in value");
            else if (((Monster1combobox.Text == Monster2combobox.Text) && (Monster1combobox.Text != "None" || Monster2combobox.Text != "None")) || ((Monster1combobox.Text == Monster3combobox.Text) && (Monster1combobox.Text != "None" || Monster3combobox.Text != "None")) || ((Monster2combobox.Text == Monster3combobox.Text) && (Monster2combobox.Text != "None" || Monster3combobox.Text != "None")) || (Monster1combobox.Text == "None" && Monster2combobox.Text == "None" && Monster3combobox.Text == "None"))
                MessageBox.Show("You cant choose same monsters or leave all empty. Leave <none> if want to keep it empty");
            else
            {
                if (Monster1combobox.Text != "None")
                {
                    LootHUD.loot1 = MonstersDrop.GetMonsterItemList(Monster1combobox.Text);
                    LootHUD.IsLoot1Used = true;
                }
                else
                    LootHUD.IsLoot1Used = false;
                if (Monster2combobox.Text != "None")
                {
                    LootHUD.loot2 = MonstersDrop.GetMonsterItemList(Monster2combobox.Text);
                    LootHUD.IsLoot2Used = true;
                }
                else
                    LootHUD.IsLoot2Used = false;
                if (Monster3combobox.Text != "None")
                {
                    LootHUD.loot3 = MonstersDrop.GetMonsterItemList(Monster3combobox.Text);
                    LootHUD.IsLoot3Used = true;
                }
                else
                    LootHUD.IsLoot3Used = false;

                LootHUD.MinimumValueOfItem = Convert.ToInt32(ValueHigherTXT.Text);
                if (alreadyrunning == false)
                {
                    LootHUDwindow = new LootHUD();
                    SetParent(LootHUDwindow.Handle, klient.cHWND);
                    LootHUDwindow.Show();
                    if(ExtraSumUpCheck.Checked)
                    {
                        ExtraSumUpCheck.Enabled = false;
                        SumUpHUDwindow = new SumUpHUD();
                        SetParent(SumUpHUDwindow.Handle, klient.cHWND);
                        SumUpHUDwindow.Show();
                    }
                    alreadyrunning = true;
                    Monster1combobox.Enabled = false;
                    Monster2combobox.Enabled = false;
                    Monster3combobox.Enabled = false;
                    ValueHigherTXT.Enabled = false;
                    ApplyButtonCM.Text = "STOP/RESTART";
                    Hide();
                }
                else
                {
                    if(ExtraSumUpCheck.Checked)
                    {
                        SumUpHUDwindow.Close();
                        ExtraSumUpCheck.Enabled = true;
                    }

                    ApplyButtonCM.Text = "START";
                    LootHUDwindow.Close();
                    alreadyrunning = false;
                    Monster1combobox.Enabled = true;
                    Monster2combobox.Enabled = true;
                    Monster3combobox.Enabled = true;
                    ValueHigherTXT.Enabled = true;
                }
            }
        }
        
    }
}
