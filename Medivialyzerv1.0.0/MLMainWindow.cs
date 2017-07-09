using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Medivialyzerv1._0._0
{
    public partial class MLMainWindow : Form
    {

        /*[DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        */
        MLProcessChecker klient;
        ChooseMonsters ChooseMonsters = new ChooseMonsters();
        AddOrEditItemValue newform = new AddOrEditItemValue();
        //LootHUD LootHUDwindow = new LootHUD();
        //bool alreadyrunning = false; //open only 1 lootHUD
        public MLMainWindow()
        {
            InitializeComponent();
        }
        public void InitializeClient(MLProcessChecker proces)
        {
            this.klient = proces;
        }
        private void MLMainWindow_Load(object sender, EventArgs e)
        {

        }
        private void LootHUDbutton_Click(object sender, EventArgs e)
        {
            /*if (alreadyrunning == false)
            {
                SetParent(LootHUDwindow.Handle, klient.cHWND);
                LootHUDwindow.Show();
                alreadyrunning = true;
            }
            else
                MessageBox.Show("Sorry, but one LootHUD is already running.");
*/
        }
        private void MonstersChooseButton_Click(object sender, EventArgs e)
        {
            ChooseMonsters.InitializeClient(klient);
            ChooseMonsters.Show();
        }

        private void AddEditValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disable at the moment, please write any mistakes on forum. I will fix them in next version.");
            //newform.Show();
        }
    }
}
