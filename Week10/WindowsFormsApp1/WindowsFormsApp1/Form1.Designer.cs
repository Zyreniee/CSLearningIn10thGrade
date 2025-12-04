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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elemanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinKutusununToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.temizleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kapatToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(105, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 225);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 202);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 225);
            this.textBox1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.renkDeğiştirToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem,
            this.formAçToolStripMenuItem,
            this.toolStripSeparator1,
            this.elemanEkleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBoxunToolStripMenuItem,
            this.metinKutusununToolStripMenuItem,
            this.formunToolStripMenuItem});
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.renkDeğiştirToolStripMenuItem.Text = "Re&nk Değiştir";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "H&akkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // formAçToolStripMenuItem
            // 
            this.formAçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem});
            this.formAçToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_us_32;
            this.formAçToolStripMenuItem.Name = "formAçToolStripMenuItem";
            this.formAçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formAçToolStripMenuItem.Text = "Form Aç";
            // 
            // elemanEkleToolStripMenuItem
            // 
            this.elemanEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBoxToolStripMenuItem,
            this.textBoxToolStripMenuItem});
            this.elemanEkleToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_free_64;
            this.elemanEkleToolStripMenuItem.Name = "elemanEkleToolStripMenuItem";
            this.elemanEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elemanEkleToolStripMenuItem.Text = "Eleman Ekle";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.indir;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBoxToolStripMenuItem1,
            this.textBoxToolStripMenuItem1});
            this.temizleToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_marine_corps_50;
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // textBoxToolStripMenuItem
            // 
            this.textBoxToolStripMenuItem.Name = "textBoxToolStripMenuItem";
            this.textBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.textBoxToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.textBoxToolStripMenuItem.Text = "TextBox";
            this.textBoxToolStripMenuItem.Click += new System.EventHandler(this.textBoxToolStripMenuItem_Click);
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form2ToolStripMenuItem.Text = "Form2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // form3ToolStripMenuItem
            // 
            this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            this.form3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.form3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form3ToolStripMenuItem.Text = "Form3";
            this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem1
            // 
            this.listBoxToolStripMenuItem1.Name = "listBoxToolStripMenuItem1";
            this.listBoxToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.listBoxToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem1.Text = "ListBox";
            this.listBoxToolStripMenuItem1.Click += new System.EventHandler(this.listBoxToolStripMenuItem1_Click);
            // 
            // textBoxToolStripMenuItem1
            // 
            this.textBoxToolStripMenuItem1.Name = "textBoxToolStripMenuItem1";
            this.textBoxToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.textBoxToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.textBoxToolStripMenuItem1.Text = "TextBox";
            this.textBoxToolStripMenuItem1.Click += new System.EventHandler(this.textBoxToolStripMenuItem1_Click);
            // 
            // listBoxunToolStripMenuItem
            // 
            this.listBoxunToolStripMenuItem.Name = "listBoxunToolStripMenuItem";
            this.listBoxunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxunToolStripMenuItem.Text = "ListBoxun";
            this.listBoxunToolStripMenuItem.Click += new System.EventHandler(this.listBoxunToolStripMenuItem_Click);
            // 
            // metinKutusununToolStripMenuItem
            // 
            this.metinKutusununToolStripMenuItem.Name = "metinKutusununToolStripMenuItem";
            this.metinKutusununToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.metinKutusununToolStripMenuItem.Text = "Metin Kutusunun";
            this.metinKutusununToolStripMenuItem.Click += new System.EventHandler(this.metinKutusununToolStripMenuItem_Click);
            // 
            // formunToolStripMenuItem
            // 
            this.formunToolStripMenuItem.Name = "formunToolStripMenuItem";
            this.formunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formunToolStripMenuItem.Text = "Formun";
            this.formunToolStripMenuItem.Click += new System.EventHandler(this.formunToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem1,
            this.ekleToolStripMenuItem,
            this.renkDeğiştirToolStripMenuItem1,
            this.kapatToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 92);
            // 
            // temizleToolStripMenuItem1
            // 
            this.temizleToolStripMenuItem1.Name = "temizleToolStripMenuItem1";
            this.temizleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.temizleToolStripMenuItem1.Text = "Temizle";
            this.temizleToolStripMenuItem1.Click += new System.EventHandler(this.temizleToolStripMenuItem1_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // renkDeğiştirToolStripMenuItem1
            // 
            this.renkDeğiştirToolStripMenuItem1.Name = "renkDeğiştirToolStripMenuItem1";
            this.renkDeğiştirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.renkDeğiştirToolStripMenuItem1.Text = "Renk Değiştir";
            this.renkDeğiştirToolStripMenuItem1.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem1_Click);
            // 
            // kapatToolStripMenuItem1
            // 
            this.kapatToolStripMenuItem1.Name = "kapatToolStripMenuItem1";
            this.kapatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem1.Text = "Kapat";
            this.kapatToolStripMenuItem1.Click += new System.EventHandler(this.kapatToolStripMenuItem1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem2,
            this.renkDeğiştirToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(144, 48);
            // 
            // kapatToolStripMenuItem2
            // 
            this.kapatToolStripMenuItem2.Name = "kapatToolStripMenuItem2";
            this.kapatToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem2.Text = "Kapat";
            this.kapatToolStripMenuItem2.Click += new System.EventHandler(this.kapatToolStripMenuItem2_Click);
            // 
            // renkDeğiştirToolStripMenuItem2
            // 
            this.renkDeğiştirToolStripMenuItem2.Name = "renkDeğiştirToolStripMenuItem2";
            this.renkDeğiştirToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.renkDeğiştirToolStripMenuItem2.Text = "Renk Değiştir";
            this.renkDeğiştirToolStripMenuItem2.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elemanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listBoxunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metinKutusununToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formunToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

