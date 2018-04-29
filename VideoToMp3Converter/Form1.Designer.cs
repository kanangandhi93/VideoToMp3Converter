namespace VideoToMp3Converter
{
    partial class frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTopFrame = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlTopFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pnlTopFrame);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(569, 38);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlTopFrame
            // 
            this.pnlTopFrame.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlTopFrame.ColumnCount = 4;
            this.pnlTopFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlTopFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnlTopFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlTopFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlTopFrame.Controls.Add(this.pictureBox1, 0, 0);
            this.pnlTopFrame.Controls.Add(this.btnMinimize, 2, 0);
            this.pnlTopFrame.Controls.Add(this.btnCLose, 3, 0);
            this.pnlTopFrame.Controls.Add(this.lblTitle, 1, 0);
            this.pnlTopFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFrame.Name = "pnlTopFrame";
            this.pnlTopFrame.RowCount = 1;
            this.pnlTopFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTopFrame.Size = new System.Drawing.Size(567, 36);
            this.pnlTopFrame.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(511, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 28);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnCLose
            // 
            this.btnCLose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Location = new System.Drawing.Point(540, 4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(23, 28);
            this.btnCLose.TabIndex = 2;
            this.btnCLose.TabStop = false;
            this.btnCLose.Text = "X";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            this.btnCLose.MouseEnter += new System.EventHandler(this.btnCLose_MouseEnter);
            this.btnCLose.MouseLeave += new System.EventHandler(this.btnCLose_MouseLeave);
            this.btnCLose.MouseHover += new System.EventHandler(this.btnCLose_MouseHover);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Location = new System.Drawing.Point(33, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(471, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDashboard.Controls.Add(this.btnConvert);
            this.pnlDashboard.Controls.Add(this.button1);
            this.pnlDashboard.Controls.Add(this.btnImport);
            this.pnlDashboard.Controls.Add(this.txtOutput);
            this.pnlDashboard.Controls.Add(this.txtInput);
            this.pnlDashboard.Controls.Add(this.label2);
            this.pnlDashboard.Controls.Add(this.label1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 38);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(569, 235);
            this.pnlDashboard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import a Video:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 47);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(436, 26);
            this.txtInput.TabIndex = 1;
            this.txtInput.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(457, 45);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 31);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Export Audio:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 126);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(436, 26);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(457, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(15, 181);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(532, 31);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 273);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video To Mp3 Converter";
            this.pnlTop.ResumeLayout(false);
            this.pnlTopFrame.ResumeLayout(false);
            this.pnlTopFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel pnlTopFrame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert;
    }
}

