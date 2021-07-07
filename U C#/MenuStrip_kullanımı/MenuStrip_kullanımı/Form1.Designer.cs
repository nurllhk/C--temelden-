
namespace MenuStrip_kullanımı
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevimizTehlikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intersepterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psILoveYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubpeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.hızlıErişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.bilimKurguToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.korkuToolStripMenuItem});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görevimizTehlikeToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // görevimizTehlikeToolStripMenuItem
            // 
            this.görevimizTehlikeToolStripMenuItem.Name = "görevimizTehlikeToolStripMenuItem";
            this.görevimizTehlikeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.görevimizTehlikeToolStripMenuItem.Text = "Görevimiz tehlike";
            this.görevimizTehlikeToolStripMenuItem.Click += new System.EventHandler(this.görevimizTehlikeToolStripMenuItem_Click);
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intersepterToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bilimKurguToolStripMenuItem.Text = "Bilim kurgu";
            // 
            // intersepterToolStripMenuItem
            // 
            this.intersepterToolStripMenuItem.Name = "intersepterToolStripMenuItem";
            this.intersepterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.intersepterToolStripMenuItem.Text = "Yıldızlararsı";
            this.intersepterToolStripMenuItem.Click += new System.EventHandler(this.intersepterToolStripMenuItem_Click);
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.psILoveYouToolStripMenuItem});
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.romantikToolStripMenuItem.Text = "Romantik";
            // 
            // psILoveYouToolStripMenuItem
            // 
            this.psILoveYouToolStripMenuItem.Name = "psILoveYouToolStripMenuItem";
            this.psILoveYouToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.psILoveYouToolStripMenuItem.Text = "Ps ı love you";
            this.psILoveYouToolStripMenuItem.Click += new System.EventHandler(this.psILoveYouToolStripMenuItem_Click);
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cubpeToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.korkuToolStripMenuItem.Text = "Korku";
            // 
            // cubpeToolStripMenuItem
            // 
            this.cubpeToolStripMenuItem.Name = "cubpeToolStripMenuItem";
            this.cubpeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cubpeToolStripMenuItem.Text = "cubpe";
            this.cubpeToolStripMenuItem.Click += new System.EventHandler(this.cubpeToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.griToolStripMenuItem,
            this.yeşilToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.renklerToolStripMenuItem.Text = "Renkler";
            this.renklerToolStripMenuItem.Click += new System.EventHandler(this.renklerToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı erişim";
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            this.hakkımdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(92, 157);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(808, 250);
            this.webBrowser1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "MNT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevimizTehlikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intersepterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem psILoveYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubpeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
    }
}

