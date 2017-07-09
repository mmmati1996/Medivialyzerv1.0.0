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
    public partial class MLChooseClient : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        MLProcessChecker proces;
            public MLChooseClient()
        {
            InitializeComponent();
        }

        private void LockProcessButton_Click(object sender, EventArgs e)
        {
            if (OpenGLcheck.Checked == true && (ProcessListBox.SelectedIndex < 0 || ProcessListBox.SelectedIndex >= Process.GetProcessesByName("Medivia_OGL").Length))
            {
                MessageBox.Show("Please choose client !");
                return;
            }
            else if (DirectXcheck.Checked == true && (ProcessListBox.SelectedIndex < 0 || ProcessListBox.SelectedIndex >= Process.GetProcessesByName("Medivia_D3D").Length))
            {
                MessageBox.Show("Please choose client !");
                return;
            }
            else
            {
                if (OpenGLcheck.Checked == true)
                    proces = new MLProcessChecker(Process.GetProcessesByName("Medivia_OGL")[ProcessListBox.SelectedIndex]);
                else if (DirectXcheck.Checked == true)
                    proces = new MLProcessChecker(Process.GetProcessesByName("Medivia_D3D")[ProcessListBox.SelectedIndex]);
                SetWindowText(proces.cHWND, "Medivia " + proces.pid);
                this.Hide();
                var MainWindow = new MLMainWindow();
                MainWindow.InitializeClient(proces);
                MainWindow.Closed += (s, args) => this.Close();
                MainWindow.Show();
            }
        }

        private void MLChooseClient_Load(object sender, EventArgs e)
        {
            if (OpenGLcheck.Checked == true)
             {
                ProcessListBox.Items.Clear();
                foreach (Process p in Process.GetProcessesByName("Medivia_OGL"))
                {
                    ProcessListBox.Items.Add(p.Id);
                }
            }


        }
        private void RefreshList()
        {
            if (OpenGLcheck.Checked == true && DirectXcheck.Checked == false)
            {
                ProcessListBox.Items.Clear();
                foreach (Process p in Process.GetProcessesByName("Medivia_OGL"))
                {
                    ProcessListBox.Items.Add(p.Id);
                }
            }
            else if (OpenGLcheck.Checked == false && DirectXcheck.Checked == false)
            {
                ProcessListBox.Items.Clear();
            }
            else
            {
                ProcessListBox.Items.Clear();
                foreach (Process p in Process.GetProcessesByName("Medivia_D3D"))
                {
                    ProcessListBox.Items.Add(p.Id);
                }
            }
        }
        private void DirectXcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DirectXcheck.Checked == true && OpenGLcheck.Checked == true)
            {
                OpenGLcheck.Checked = false;
            }
            RefreshList();
        }

        private void OpenGLcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DirectXcheck.Checked == true && OpenGLcheck.Checked == true)
            {    
                DirectXcheck.Checked = false;
            }
            RefreshList();
        }
    }
}
