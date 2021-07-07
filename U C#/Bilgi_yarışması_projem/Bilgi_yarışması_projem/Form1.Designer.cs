
namespace Bilgi_yarışması_projem
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.lbldoğru = new System.Windows.Forms.Label();
            this.lblyanlış = new System.Windows.Forms.Label();
            this.btna = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(556, 199);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru no :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yanlış :";
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Location = new System.Drawing.Point(696, 15);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(21, 24);
            this.lblsoruno.TabIndex = 4;
            this.lblsoruno.Text = "0";
            // 
            // lbldoğru
            // 
            this.lbldoğru.AutoSize = true;
            this.lbldoğru.Location = new System.Drawing.Point(696, 57);
            this.lbldoğru.Name = "lbldoğru";
            this.lbldoğru.Size = new System.Drawing.Size(21, 24);
            this.lbldoğru.TabIndex = 5;
            this.lbldoğru.Text = "0";
            // 
            // lblyanlış
            // 
            this.lblyanlış.AutoSize = true;
            this.lblyanlış.Location = new System.Drawing.Point(696, 96);
            this.lblyanlış.Name = "lblyanlış";
            this.lblyanlış.Size = new System.Drawing.Size(21, 24);
            this.lblyanlış.TabIndex = 6;
            this.lblyanlış.Text = "0";
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(21, 217);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(157, 39);
            this.btna.TabIndex = 7;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(246, 262);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(157, 39);
            this.btnd.TabIndex = 8;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(246, 217);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(157, 39);
            this.btnb.TabIndex = 9;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(21, 262);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(157, 39);
            this.btnc.TabIndex = 10;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnsonraki
            // 
            this.btnsonraki.Location = new System.Drawing.Point(606, 166);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(204, 64);
            this.btnsonraki.TabIndex = 11;
            this.btnsonraki.Text = "Sonraki";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(722, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(856, 426);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.lblyanlış);
            this.Controls.Add(this.lbldoğru);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label lbldoğru;
        private System.Windows.Forms.Label lblyanlış;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

