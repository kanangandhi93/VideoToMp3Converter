using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
        string FolderPath = string.Empty;
        string MusicName = string.Empty;

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog() { Multiselect = false, Filter = "Video files(*.mp4, *.avi, *.mkv, *.3gp, *.flv, *.mov) | *.mp4; *.avi; *.mkv; *.3gp; *.flv; *.mov" };
            if (of.ShowDialog() == DialogResult.OK)
            {
                VideoPath = txtInput.Text = of.FileName;
                VideoName = of.SafeFileName;
                MusicName = VideoName.Substring(0, VideoName.Length - 4);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FolderPath = fd.SelectedPath;
            }
            MusicPath = FolderPath + "/" + MusicName + ".mp3";
            txtOutput.Text = MusicPath;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                if (!string.IsNullOrEmpty(txtOutput.Text))
                {
                    lblStatus.Text = "Converting...";
                    btnConvert.Enabled = false;
                    bkw.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Please Select Export file Path.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Select Video file Path.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bkw_DoWork(object sender, DoWorkEventArgs e)
        {
            var Convert = new NReco.VideoConverter.FFMpegConverter();
            Convert.ConvertMedia(VideoPath, MusicPath, "mp3");
        }

        private void bkw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Completed.";
            btnConvert.Enabled = true;
            MessageBox.Show(VideoName + " mp3 Conversion Completed.", "Conversion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(FolderPath);
        }

        private void bkw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Converting...";
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
