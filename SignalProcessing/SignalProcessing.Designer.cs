namespace SignalProcessing
{
    partial class SignalProcessing
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
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.frequency_1 = new System.Windows.Forms.ToolStripTextBox();
            this.frequency_2 = new System.Windows.Forms.ToolStripTextBox();
            this.windowLength = new System.Windows.Forms.ToolStripTextBox();
            this.zeroes = new System.Windows.Forms.ToolStripTextBox();
            this.timeFFT = new System.Windows.Forms.ToolStripLabel();
            this.timeFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 345);
            this.hScrollBar.Maximum = 40000;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBar.Size = new System.Drawing.Size(729, 21);
            this.hScrollBar.TabIndex = 6;
            this.hScrollBar.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frequency_1,
            this.frequency_2,
            this.windowLength,
            this.zeroes,
            this.timeFFT,
            this.timeFilter});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(729, 25);
            this.toolStrip.TabIndex = 7;
            // 
            // frequency_1
            // 
            this.frequency_1.Name = "frequency_1";
            this.frequency_1.Size = new System.Drawing.Size(50, 25);
            this.frequency_1.Text = "1000";
            this.frequency_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFreq1);
            // 
            // frequency_2
            // 
            this.frequency_2.Name = "frequency_2";
            this.frequency_2.Size = new System.Drawing.Size(50, 25);
            this.frequency_2.Text = "5000";
            this.frequency_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFreq2);
            // 
            // windowLength
            // 
            this.windowLength.Name = "windowLength";
            this.windowLength.Size = new System.Drawing.Size(50, 25);
            this.windowLength.Text = "512";
            this.windowLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnWindowLength);
            // 
            // zeroes
            // 
            this.zeroes.Name = "zeroes";
            this.zeroes.Size = new System.Drawing.Size(25, 25);
            this.zeroes.Text = "2";
            this.zeroes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnZeroes);
            // 
            // timeFFT
            // 
            this.timeFFT.Name = "timeFFT";
            this.timeFFT.Size = new System.Drawing.Size(13, 22);
            this.timeFFT.Text = "0";
            // 
            // timeFilter
            // 
            this.timeFilter.Name = "timeFilter";
            this.timeFilter.Size = new System.Drawing.Size(13, 22);
            this.timeFilter.Text = "0";
            // 
            // SignalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 366);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.hScrollBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignalProcessing";
            this.Text = "SignalProcessing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripTextBox frequency_1;
        private System.Windows.Forms.ToolStripTextBox frequency_2;
        private System.Windows.Forms.ToolStripTextBox windowLength;
        private System.Windows.Forms.ToolStripTextBox zeroes;
        private System.Windows.Forms.ToolStripLabel timeFFT;
        private System.Windows.Forms.ToolStripLabel timeFilter;
    }
}

