namespace Thermometer
{
    partial class Form1
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fahreheit = new System.Windows.Forms.Label();
            this.flabel = new System.Windows.Forms.Label();
            this.clabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(371, 97);
            this.vScrollBar1.Maximum = 200;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(49, 195);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(180, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(526, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Centigrade";
            // 
            // fahreheit
            // 
            this.fahreheit.AutoSize = true;
            this.fahreheit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fahreheit.Location = new System.Drawing.Point(0, 0);
            this.fahreheit.Name = "fahreheit";
            this.fahreheit.Size = new System.Drawing.Size(0, 13);
            this.fahreheit.TabIndex = 5;
            this.fahreheit.Click += new System.EventHandler(this.label3_Click);
            // 
            // flabel
            // 
            this.flabel.AutoSize = true;
            this.flabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flabel.ForeColor = System.Drawing.Color.Red;
            this.flabel.Location = new System.Drawing.Point(183, 181);
            this.flabel.Name = "flabel";
            this.flabel.Size = new System.Drawing.Size(0, 55);
            this.flabel.TabIndex = 6;
            this.flabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clabel
            // 
            this.clabel.AutoSize = true;
            this.clabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clabel.ForeColor = System.Drawing.Color.Red;
            this.clabel.Location = new System.Drawing.Point(519, 181);
            this.clabel.Name = "clabel";
            this.clabel.Size = new System.Drawing.Size(0, 55);
            this.clabel.TabIndex = 8;
            this.clabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clabel);
            this.Controls.Add(this.flabel);
            this.Controls.Add(this.fahreheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "Thermometer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fahreheit;
        private System.Windows.Forms.Label flabel;
        private System.Windows.Forms.Label clabel;
    }
}

