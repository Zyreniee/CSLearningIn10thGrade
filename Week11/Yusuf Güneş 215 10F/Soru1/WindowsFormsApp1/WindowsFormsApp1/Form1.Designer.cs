namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yemekİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekÇeşitleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çorbalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilavlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatlılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etliYemeklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 345);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GÖKTOR YEMEKÇİLİK";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.yemekİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriEkleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem,
            this.toolStripSeparator1,
            this.müşteriBilgileriToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "&Müşteri İşlemleri";
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni Müşteri Ekle";
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            // 
            // müşteriBilgileriToolStripMenuItem
            // 
            this.müşteriBilgileriToolStripMenuItem.Checked = true;
            this.müşteriBilgileriToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.müşteriBilgileriToolStripMenuItem.Name = "müşteriBilgileriToolStripMenuItem";
            this.müşteriBilgileriToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.müşteriBilgileriToolStripMenuItem.Text = "Müşteri Bilgileri";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // yemekİşlemleriToolStripMenuItem
            // 
            this.yemekİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişAlToolStripMenuItem,
            this.siparişİptalToolStripMenuItem,
            this.yemekÇeşitleriToolStripMenuItem});
            this.yemekİşlemleriToolStripMenuItem.Name = "yemekİşlemleriToolStripMenuItem";
            this.yemekİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.yemekİşlemleriToolStripMenuItem.Text = "&Yemek İşlemleri";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // siparişAlToolStripMenuItem
            // 
            this.siparişAlToolStripMenuItem.Name = "siparişAlToolStripMenuItem";
            this.siparişAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.siparişAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişAlToolStripMenuItem.Text = "Sipariş Al";
            this.siparişAlToolStripMenuItem.Click += new System.EventHandler(this.siparişAlToolStripMenuItem_Click);
            // 
            // siparişİptalToolStripMenuItem
            // 
            this.siparişİptalToolStripMenuItem.Name = "siparişİptalToolStripMenuItem";
            this.siparişİptalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişİptalToolStripMenuItem.Text = "Sipariş İptal";
            // 
            // yemekÇeşitleriToolStripMenuItem
            // 
            this.yemekÇeşitleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çorbalarToolStripMenuItem,
            this.pilavlarToolStripMenuItem,
            this.tatlılarToolStripMenuItem,
            this.etliYemeklerToolStripMenuItem});
            this.yemekÇeşitleriToolStripMenuItem.Name = "yemekÇeşitleriToolStripMenuItem";
            this.yemekÇeşitleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yemekÇeşitleriToolStripMenuItem.Text = "Yemek Çeşitleri";
            // 
            // çorbalarToolStripMenuItem
            // 
            this.çorbalarToolStripMenuItem.Name = "çorbalarToolStripMenuItem";
            this.çorbalarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çorbalarToolStripMenuItem.Text = "Çorbalar";
            // 
            // pilavlarToolStripMenuItem
            // 
            this.pilavlarToolStripMenuItem.Name = "pilavlarToolStripMenuItem";
            this.pilavlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilavlarToolStripMenuItem.Text = "Pilavlar";
            // 
            // tatlılarToolStripMenuItem
            // 
            this.tatlılarToolStripMenuItem.Name = "tatlılarToolStripMenuItem";
            this.tatlılarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tatlılarToolStripMenuItem.Text = "Tatlılar";
            // 
            // etliYemeklerToolStripMenuItem
            // 
            this.etliYemeklerToolStripMenuItem.Name = "etliYemeklerToolStripMenuItem";
            this.etliYemeklerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.etliYemeklerToolStripMenuItem.Text = "Etli Yemekler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişİptalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekÇeşitleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çorbalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilavlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatlılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etliYemeklerToolStripMenuItem;
    }
}

