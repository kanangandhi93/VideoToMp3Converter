using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoToMp3Converter
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
            lblTitle.Text = Text;
        }

        private void btnCLose_MouseEnter(object sender, EventArgs e)
        {
            btnCLose.BackColor = Color.Red;
            btnCLose.ForeColor = Color.White;
        }

        private void btnCLose_MouseLeave(object sender, EventArgs e)
        {
            btnCLose.BackColor = Color.White;
            btnCLose.ForeColor = Color.Black;
        }

        private void btnCLose_MouseHover(object sender, EventArgs e)
        {
            btnCLose.BackColor = Color.Red;
            btnCLose.ForeColor = Color.White;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string VideoName = string.Empty;

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog() { Multiselect = false };
            if (of.ShowDialog()==DialogResult.OK)
            {
                txtInput.Text = of.FileName;
                VideoName = of.SafeFileName;
            }
        }
    }
}
