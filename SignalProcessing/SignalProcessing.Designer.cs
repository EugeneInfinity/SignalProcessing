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
            // SignalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
    }
}

