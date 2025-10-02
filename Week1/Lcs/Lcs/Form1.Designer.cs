namespace Lcs
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lcs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lcs
            // 
            this.Lcs.BackColor = System.Drawing.Color.DeepPink;
            this.Lcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lcs.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lcs.Location = new System.Drawing.Point(137, 286);
            this.Lcs.Name = "Lcs";
            this.Lcs.Size = new System.Drawing.Size(253, 99);
            this.Lcs.TabIndex = 0;
            this.Lcs.Text = "KAPAT";
            this.Lcs.UseVisualStyleBackColor = false;
            this.Lcs.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(136, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 98);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mesaj Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lcs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LcsWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lcs;
        private System.Windows.Forms.Button button1;
    }
}

