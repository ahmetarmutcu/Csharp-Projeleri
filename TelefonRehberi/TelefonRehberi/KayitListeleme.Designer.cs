namespace TelefonRehberi
{
    partial class KayitListeleme
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
            this.rchtelefontext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchtelefontext
            // 
            this.rchtelefontext.Location = new System.Drawing.Point(13, 10);
            this.rchtelefontext.Name = "rchtelefontext";
            this.rchtelefontext.Size = new System.Drawing.Size(495, 240);
            this.rchtelefontext.TabIndex = 14;
            this.rchtelefontext.Text = "";
            // 
            // KayitListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 261);
            this.Controls.Add(this.rchtelefontext);
            this.Name = "KayitListeleme";
            this.Text = "KayitListeleme";
            this.Load += new System.EventHandler(this.KayitListeleme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtelefontext;
    }
}