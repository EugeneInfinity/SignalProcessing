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
            this.frequency_1 = new System.Windows.Forms.TextBox();
            this.frequency_2 = new System.Windows.Forms.TextBox();
            this.zeroes = new System.Windows.Forms.TextBox();
            this.timeFFT = new System.Windows.Forms.TextBox();
            this.timeFilter = new System.Windows.Forms.TextBox();
            this.windowLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 345);
            this.hScrollBar.Maximum = 40000;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBar.Size = new System.Drawing.Size(600, 21);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // frequency_1
            // 
            this.frequency_1.Location = new System.Drawing.Point(0, 1);
            this.frequency_1.Name = "frequency_1";
            this.frequency_1.Size = new System.Drawing.Size(47, 20);
            this.frequency_1.TabIndex = 1;
            this.frequency_1.Text = "1000";
            this.frequency_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFreq1);
            // 
            // frequency_2
            // 
            this.frequency_2.Location = new System.Drawing.Point(53, 1);
            this.frequency_2.Name = "frequency_2";
            this.frequency_2.Size = new System.Drawing.Size(45, 20);
            this.frequency_2.TabIndex = 2;
            this.frequency_2.Text = "5000";
            this.frequency_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFreq2);
            // 
            // zeroes
            // 
            this.zeroes.Location = new System.Drawing.Point(155, 1);
            this.zeroes.Name = "zeroes";
            this.zeroes.Size = new System.Drawing.Size(29, 20);
            this.zeroes.TabIndex = 3;
            this.zeroes.Text = "2";
            this.zeroes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnZeroes);
            // 
            // timeFFT
            // 
            this.timeFFT.Location = new System.Drawing.Point(190, 1);
            this.timeFFT.Name = "timeFFT";
            this.timeFFT.Size = new System.Drawing.Size(65, 20);
            this.timeFFT.TabIndex = 4;
            // 
            // timeFilter
            // 
            this.timeFilter.Location = new System.Drawing.Point(261, 1);
            this.timeFilter.Name = "timeFilter";
            this.timeFilter.Size = new System.Drawing.Size(65, 20);
            this.timeFilter.TabIndex = 4;
            // 
            // windowLength
            // 
            this.windowLength.Location = new System.Drawing.Point(104, 1);
            this.windowLength.Name = "windowLength";
            this.windowLength.Size = new System.Drawing.Size(45, 20);
            this.windowLength.TabIndex = 5;
            this.windowLength.Text = "512";
            this.windowLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnWindowLength);
            // 
            // SignalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.windowLength);
            this.Controls.Add(this.timeFilter);
            this.Controls.Add(this.timeFFT);
            this.Controls.Add(this.zeroes);
            this.Controls.Add(this.frequency_2);
            this.Controls.Add(this.frequency_1);
            this.Controls.Add(this.hScrollBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignalProcessing";
            this.Text = "SignalProcessing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.TextBox frequency_1;
        private System.Windows.Forms.TextBox frequency_2;
        private System.Windows.Forms.TextBox zeroes;
        private System.Windows.Forms.TextBox timeFFT;
        private System.Windows.Forms.TextBox timeFilter;
        private System.Windows.Forms.TextBox windowLength;
    }
}

