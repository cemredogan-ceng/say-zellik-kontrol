
namespace nesneye_yönelik_programlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnhesapla = new System.Windows.Forms.Button();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtbitisDeger = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbaslangıcDeger = new System.Windows.Forms.MaskedTextBox();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangıc = new System.Windows.Forms.Label();
            this.tabCntrl = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.listTek = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listCift = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listAsal = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listMükemmel = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ntficon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpBox1.SuspendLayout();
            this.tabCntrl.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnhesapla
            // 
            this.bttnhesapla.BackColor = System.Drawing.SystemColors.Control;
            this.bttnhesapla.Location = new System.Drawing.Point(567, 35);
            this.bttnhesapla.Name = "bttnhesapla";
            this.bttnhesapla.Size = new System.Drawing.Size(119, 32);
            this.bttnhesapla.TabIndex = 0;
            this.bttnhesapla.Text = "Çalıştır";
            this.bttnhesapla.UseVisualStyleBackColor = false;
            this.bttnhesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.mtxtbitisDeger);
            this.grpBox1.Controls.Add(this.mtxtbaslangıcDeger);
            this.grpBox1.Controls.Add(this.lblBitis);
            this.grpBox1.Controls.Add(this.lblBaslangıc);
            this.grpBox1.Controls.Add(this.bttnhesapla);
            this.grpBox1.Location = new System.Drawing.Point(12, 41);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(776, 100);
            this.grpBox1.TabIndex = 1;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Giriş Bilgileri";
            // 
            // mtxtbitisDeger
            // 
            this.mtxtbitisDeger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mtxtbitisDeger.Location = new System.Drawing.Point(394, 35);
            this.mtxtbitisDeger.Name = "mtxtbitisDeger";
            this.mtxtbitisDeger.Size = new System.Drawing.Size(100, 26);
            this.mtxtbitisDeger.TabIndex = 4;
            // 
            // mtxtbaslangıcDeger
            // 
            this.mtxtbaslangıcDeger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mtxtbaslangıcDeger.Location = new System.Drawing.Point(129, 35);
            this.mtxtbaslangıcDeger.Name = "mtxtbaslangıcDeger";
            this.mtxtbaslangıcDeger.Size = new System.Drawing.Size(100, 26);
            this.mtxtbaslangıcDeger.TabIndex = 3;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(344, 35);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(43, 20);
            this.lblBitis.TabIndex = 2;
            this.lblBitis.Text = "Bitis:";
            // 
            // lblBaslangıc
            // 
            this.lblBaslangıc.AutoSize = true;
            this.lblBaslangıc.Location = new System.Drawing.Point(40, 35);
            this.lblBaslangıc.Name = "lblBaslangıc";
            this.lblBaslangıc.Size = new System.Drawing.Size(82, 20);
            this.lblBaslangıc.TabIndex = 1;
            this.lblBaslangıc.Text = "Başlangıc:";
            // 
            // tabCntrl
            // 
            this.tabCntrl.Controls.Add(this.tabpage1);
            this.tabCntrl.Controls.Add(this.tabPage2);
            this.tabCntrl.Controls.Add(this.tabPage3);
            this.tabCntrl.Controls.Add(this.tabPage4);
            this.tabCntrl.Location = new System.Drawing.Point(13, 147);
            this.tabCntrl.Name = "tabCntrl";
            this.tabCntrl.SelectedIndex = 0;
            this.tabCntrl.Size = new System.Drawing.Size(760, 291);
            this.tabCntrl.TabIndex = 2;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.listTek);
            this.tabpage1.Location = new System.Drawing.Point(4, 29);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(752, 258);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Tek Sayılar";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // listTek
            // 
            this.listTek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listTek.HideSelection = false;
            this.listTek.Location = new System.Drawing.Point(34, 21);
            this.listTek.Name = "listTek";
            this.listTek.Size = new System.Drawing.Size(597, 199);
            this.listTek.TabIndex = 0;
            this.listTek.UseCompatibleStateImageBehavior = false;
            this.listTek.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tek Sayılar";
            this.columnHeader1.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listCift);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çift Sayılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listCift
            // 
            this.listCift.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listCift.HideSelection = false;
            this.listCift.Location = new System.Drawing.Point(25, 26);
            this.listCift.Name = "listCift";
            this.listCift.Size = new System.Drawing.Size(677, 201);
            this.listCift.TabIndex = 0;
            this.listCift.UseCompatibleStateImageBehavior = false;
            this.listCift.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Çift Sayılar";
            this.columnHeader2.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listAsal);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(752, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listAsal
            // 
            this.listAsal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listAsal.HideSelection = false;
            this.listAsal.Location = new System.Drawing.Point(40, 19);
            this.listAsal.Name = "listAsal";
            this.listAsal.Size = new System.Drawing.Size(624, 210);
            this.listAsal.TabIndex = 0;
            this.listAsal.UseCompatibleStateImageBehavior = false;
            this.listAsal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asal Sayılar";
            this.columnHeader3.Width = 150;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listMükemmel);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(752, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükemmel Sayılar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listMükemmel
            // 
            this.listMükemmel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listMükemmel.HideSelection = false;
            this.listMükemmel.Location = new System.Drawing.Point(19, 16);
            this.listMükemmel.Name = "listMükemmel";
            this.listMükemmel.Size = new System.Drawing.Size(689, 206);
            this.listMükemmel.TabIndex = 0;
            this.listMükemmel.UseCompatibleStateImageBehavior = false;
            this.listMükemmel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mükemmel Sayılar";
            this.columnHeader4.Width = 300;
            // 
            // ntficon
            // 
            this.ntficon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntficon.Icon")));
            this.ntficon.Text = "Programa Hoşgeldiniizz!!!!!!!";
            this.ntficon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCntrl);
            this.Controls.Add(this.grpBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.tabCntrl.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnhesapla;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.MaskedTextBox mtxtbitisDeger;
        private System.Windows.Forms.MaskedTextBox mtxtbaslangıcDeger;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangıc;
        private System.Windows.Forms.TabControl tabCntrl;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NotifyIcon ntficon;
        private System.Windows.Forms.ListView listTek;
        private System.Windows.Forms.ListView listCift;
        private System.Windows.Forms.ListView listAsal;
        private System.Windows.Forms.ListView listMükemmel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

