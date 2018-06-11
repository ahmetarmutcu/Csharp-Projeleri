namespace TelefonRehberi
{
    partial class AnaMenu
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
            this.buttonKayitEkleme = new System.Windows.Forms.Button();
            this.buttonKayıtListeleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKayitEkleme
            // 
            this.buttonKayitEkleme.Location = new System.Drawing.Point(29, 58);
            this.buttonKayitEkleme.Name = "buttonKayitEkleme";
            this.buttonKayitEkleme.Size = new System.Drawing.Size(75, 107);
            this.buttonKayitEkleme.TabIndex = 0;
            this.buttonKayitEkleme.Text = "Kayıt Ekleme";
            this.buttonKayitEkleme.UseVisualStyleBackColor = true;
            this.buttonKayitEkleme.Click += new System.EventHandler(this.buttonKayitEkleme_Click);
            // 
            // buttonKayıtListeleme
            // 
            this.buttonKayıtListeleme.Location = new System.Drawing.Point(144, 58);
            this.buttonKayıtListeleme.Name = "buttonKayıtListeleme";
            this.buttonKayıtListeleme.Size = new System.Drawing.Size(75, 107);
            this.buttonKayıtListeleme.TabIndex = 1;
            this.buttonKayıtListeleme.Text = "Kayıt Listeleme";
            this.buttonKayıtListeleme.UseVisualStyleBackColor = true;
            this.buttonKayıtListeleme.Click += new System.EventHandler(this.buttonKayıtListeleme_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonKayıtListeleme);
            this.Controls.Add(this.buttonKayitEkleme);
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKayitEkleme;
        private System.Windows.Forms.Button buttonKayıtListeleme;
    }
}