namespace ProjeDeneme
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
            this.components = new System.ComponentModel.Container();
            this.buttonDosyaYukle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ımageBoxRgbResim = new Emgu.CV.UI.ImageBox();
            this.pictureBoxGrayResim = new System.Windows.Forms.PictureBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.pictureBoxBinaryResim = new System.Windows.Forms.PictureBox();
            this.buttonGrayDonus = new System.Windows.Forms.Button();
            this.buttonBinaryDonus = new System.Windows.Forms.Button();
            this.buttonHistogramDonus = new System.Windows.Forms.Button();
            this.labelrgbresim = new System.Windows.Forms.Label();
            this.labelBinaryResim = new System.Windows.Forms.Label();
            this.labelgrayresim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBoxRgbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinaryResim)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDosyaYukle
            // 
            this.buttonDosyaYukle.Location = new System.Drawing.Point(12, 27);
            this.buttonDosyaYukle.Name = "buttonDosyaYukle";
            this.buttonDosyaYukle.Size = new System.Drawing.Size(138, 23);
            this.buttonDosyaYukle.TabIndex = 1;
            this.buttonDosyaYukle.Text = "Dosya Yükle";
            this.buttonDosyaYukle.UseVisualStyleBackColor = true;
            this.buttonDosyaYukle.Click += new System.EventHandler(this.buttonDosyaYukle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ımageBoxRgbResim
            // 
            this.ımageBoxRgbResim.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ımageBoxRgbResim.Location = new System.Drawing.Point(12, 61);
            this.ımageBoxRgbResim.Name = "ımageBoxRgbResim";
            this.ımageBoxRgbResim.Size = new System.Drawing.Size(220, 263);
            this.ımageBoxRgbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ımageBoxRgbResim.TabIndex = 2;
            this.ımageBoxRgbResim.TabStop = false;
            // 
            // pictureBoxGrayResim
            // 
            this.pictureBoxGrayResim.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxGrayResim.Location = new System.Drawing.Point(440, 71);
            this.pictureBoxGrayResim.Name = "pictureBoxGrayResim";
            this.pictureBoxGrayResim.Size = new System.Drawing.Size(205, 253);
            this.pictureBoxGrayResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGrayResim.TabIndex = 4;
            this.pictureBoxGrayResim.TabStop = false;
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(660, 71);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(228, 253);
            this.histogramBox1.TabIndex = 6;
            // 
            // pictureBoxBinaryResim
            // 
            this.pictureBoxBinaryResim.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxBinaryResim.Location = new System.Drawing.Point(12, 61);
            this.pictureBoxBinaryResim.Name = "pictureBoxBinaryResim";
            this.pictureBoxBinaryResim.Size = new System.Drawing.Size(220, 263);
            this.pictureBoxBinaryResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBinaryResim.TabIndex = 8;
            this.pictureBoxBinaryResim.TabStop = false;
            this.pictureBoxBinaryResim.Visible = false;
            // 
            // buttonGrayDonus
            // 
            this.buttonGrayDonus.Location = new System.Drawing.Point(258, 113);
            this.buttonGrayDonus.Name = "buttonGrayDonus";
            this.buttonGrayDonus.Size = new System.Drawing.Size(121, 23);
            this.buttonGrayDonus.TabIndex = 9;
            this.buttonGrayDonus.Text = "Gray Resme Çevir=>";
            this.buttonGrayDonus.UseVisualStyleBackColor = true;
            this.buttonGrayDonus.Click += new System.EventHandler(this.buttonGrayDonus_Click);
            // 
            // buttonBinaryDonus
            // 
            this.buttonBinaryDonus.Location = new System.Drawing.Point(258, 190);
            this.buttonBinaryDonus.Name = "buttonBinaryDonus";
            this.buttonBinaryDonus.Size = new System.Drawing.Size(121, 23);
            this.buttonBinaryDonus.TabIndex = 10;
            this.buttonBinaryDonus.Text = "<= Binary Çevir";
            this.buttonBinaryDonus.UseMnemonic = false;
            this.buttonBinaryDonus.UseVisualStyleBackColor = true;
            this.buttonBinaryDonus.Click += new System.EventHandler(this.buttonBinaryDonus_Click);
            // 
            // buttonHistogramDonus
            // 
            this.buttonHistogramDonus.Location = new System.Drawing.Point(698, 42);
            this.buttonHistogramDonus.Name = "buttonHistogramDonus";
            this.buttonHistogramDonus.Size = new System.Drawing.Size(98, 23);
            this.buttonHistogramDonus.TabIndex = 11;
            this.buttonHistogramDonus.Text = "Histogram";
            this.buttonHistogramDonus.UseVisualStyleBackColor = true;
            this.buttonHistogramDonus.Click += new System.EventHandler(this.buttonHistogramDonus_Click);
            // 
            // labelrgbresim
            // 
            this.labelrgbresim.AutoSize = true;
            this.labelrgbresim.Location = new System.Drawing.Point(77, 340);
            this.labelrgbresim.Name = "labelrgbresim";
            this.labelrgbresim.Size = new System.Drawing.Size(62, 13);
            this.labelrgbresim.TabIndex = 12;
            this.labelrgbresim.Text = "RGB Resmi";
            // 
            // labelBinaryResim
            // 
            this.labelBinaryResim.AutoSize = true;
            this.labelBinaryResim.Location = new System.Drawing.Point(77, 340);
            this.labelBinaryResim.Name = "labelBinaryResim";
            this.labelBinaryResim.Size = new System.Drawing.Size(65, 13);
            this.labelBinaryResim.TabIndex = 13;
            this.labelBinaryResim.Text = "BinaryResim";
            this.labelBinaryResim.Visible = false;
            // 
            // labelgrayresim
            // 
            this.labelgrayresim.AutoSize = true;
            this.labelgrayresim.Location = new System.Drawing.Point(523, 340);
            this.labelgrayresim.Name = "labelgrayresim";
            this.labelgrayresim.Size = new System.Drawing.Size(61, 13);
            this.labelgrayresim.TabIndex = 14;
            this.labelgrayresim.Text = "Gray Resmi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 533);
            this.Controls.Add(this.labelgrayresim);
            this.Controls.Add(this.labelBinaryResim);
            this.Controls.Add(this.labelrgbresim);
            this.Controls.Add(this.buttonHistogramDonus);
            this.Controls.Add(this.buttonBinaryDonus);
            this.Controls.Add(this.buttonGrayDonus);
            this.Controls.Add(this.pictureBoxBinaryResim);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.pictureBoxGrayResim);
            this.Controls.Add(this.ımageBoxRgbResim);
            this.Controls.Add(this.buttonDosyaYukle);
            this.Name = "Form1";
            this.Text = "Resim Dönüştürme";
            ((System.ComponentModel.ISupportInitialize)(this.ımageBoxRgbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinaryResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDosyaYukle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Emgu.CV.UI.ImageBox ımageBoxRgbResim;
        private System.Windows.Forms.Button buttonGrayResmi;
        private System.Windows.Forms.PictureBox pictureBoxGrayResim;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.PictureBox pictureBoxBinaryResim;
        private System.Windows.Forms.Button buttonGrayDonus;
        private System.Windows.Forms.Button buttonBinaryDonus;
        private System.Windows.Forms.Button buttonHistogramDonus;
        private System.Windows.Forms.Label labelrgbresim;
        private System.Windows.Forms.Label labelBinaryResim;
        private System.Windows.Forms.Label labelgrayresim;
    }
}

