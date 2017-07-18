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
using System.Resources;

namespace Medivialyzerv1._0._0
{
    public partial class LootHUD : Form
    {
         public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static int MinimumValueOfItem;
        public static List<string> loot1;
        public static List<string> loot2;
        public static List<string> loot3;
        public static bool IsLoot1Used = false;
        public static bool IsLoot2Used = false;
        public static bool IsLoot3Used = false;
        public static int SumOfAllItems = 0;

        //____________start DLLS___________________________
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        //____________end DLLS___________________________

        public LootHUD()
        {
            InitializeComponent();
        }

        private int GetItemPrice(string ItemName)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;

            return Convert.ToInt32(rm.GetObject(ItemName));
        }
        private void LootHUD_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Price";
            dataGridView1.Columns[1].ValueType = typeof(int);
            dataGridView1.Columns[2].Name = "Sum";
            dataGridView1.Columns[2].ValueType = typeof(int);
            dataGridView1.Columns[3].Name = "Count";
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[3].ValueType = typeof(int);
            DataGridViewButtonColumn buttonplus = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(buttonplus);
            buttonplus.HeaderText = "";
            dataGridView1.Columns[4].Width = 30;
            buttonplus.Text = "+";
            buttonplus.Name = "btnp";
            buttonplus.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn buttonminus = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(buttonminus);
            buttonminus.HeaderText = "";
            dataGridView1.Columns[5].Width = 30;
            buttonminus.Text = "-";
            buttonminus.Name = "btnm";
            buttonminus.UseColumnTextForButtonValue = true;
            if (IsLoot1Used == true)
             {
                 if (loot1.Count > 0)
                     for (int i = 0; i < loot1.Count; i++)
                         AddRow(loot1[i], GetItemPrice(loot1[i]), 0, 0);
             }
             if (IsLoot2Used == true)
             {
                 if (loot2.Count > 0)
                     for (int i = 0; i < loot2.Count; i++)
                         AddRow(loot2[i], GetItemPrice(loot2[i]), 0, 0);
             }
             if (IsLoot3Used == true)
             {
                 if (loot3.Count > 0)
                     for (int i = 0; i < loot3.Count; i++)
                         AddRow(loot3[i], GetItemPrice(loot3[i]), 0, 0);
             }
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            SetLayeredWindowAttributes(this.Handle, 0, 170, 0x2);
        }
        private void AddRow(string value1, int value2, int value3, int value4)
        {
            dataGridView1.Rows.Add(value1, value2, value3, value4);
            ResizeForm();
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ResizeForm()
        {
            int sumheight = 0;
            int sumwidth = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                sumheight += row.Height;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                sumwidth += column.Width;
            this.Height = sumheight;
            this.Width = sumwidth;

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int currvalue = (int)dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value;
                int itemvalue = (int)dataGridView1[e.ColumnIndex - 3, e.RowIndex].Value;
                dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value = currvalue + 1;
                dataGridView1[e.ColumnIndex - 2, e.RowIndex].Value = itemvalue * (currvalue + 1);
                SumOfAllItems += itemvalue;
            }
            else if (e.ColumnIndex == 5)
            {
                int currvalue = (int)dataGridView1[e.ColumnIndex - 2, e.RowIndex].Value;
                if (currvalue != 0)
                {
                    dataGridView1[e.ColumnIndex - 2, e.RowIndex].Value = currvalue - 1;
                    dataGridView1[e.ColumnIndex - 3, e.RowIndex].Value = (int)dataGridView1[e.ColumnIndex - 4, e.RowIndex].Value * (int)dataGridView1[e.ColumnIndex - 2, e.RowIndex].Value;
                    SumOfAllItems -= (int)dataGridView1[e.ColumnIndex - 4, e.RowIndex].Value;
                }

            }
        }

    }
}
