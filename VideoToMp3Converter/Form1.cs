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
        string VideoPath = string.Empty;
        string MusicPath = string.Empty;
        string MusicName = string.Empty;

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog() { Multiselect = false };
            if (of.ShowDialog() == DialogResult.OK)
            {
                VideoPath = txtInput.Text = of.FileName;
                VideoName = of.SafeFileName;
                MusicName = VideoName.Substring(0, VideoName.Length - 4);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MusicPath = Application.StartupPath + "/" + MusicName + ".mp3";
            txtOutput.Text = MusicPath;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var Convert = new NReco.VideoConverter.FFMpegConverter();
            Convert.ConvertMedia(VideoPath, MusicPath, "mp3");

        }
    }
}
