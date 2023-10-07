using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace nesneye_yönelik_programlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TekFonksiyon()
        {
            ulong baslangıcDeger = Convert.ToUInt64(mtxtbaslangıcDeger.Text);
            ulong bitisDeger = Convert.ToUInt64(mtxtbitisDeger.Text);

            ulong teksayiToplam = 0;
            ulong teksayiCarpim = 1;

            ulong tekSayi = baslangıcDeger;

            for (tekSayi = baslangıcDeger; tekSayi <= bitisDeger; tekSayi++)
            {
                if (tekSayi % 2 == 1)
                {
                    listTek.Items.Add("" + tekSayi);
                    teksayiToplam += tekSayi;
                    teksayiCarpim *= tekSayi;
                }
            }
            listTek.Items.Add("Tek Sayıların Toplamı:" + teksayiToplam);
            listTek.Items.Add("Tek Sayıların Çarpımı:" + teksayiCarpim);
        }

        private void CiftFonksiyon()
        {
            ulong baslangıcDeger = Convert.ToUInt64(mtxtbaslangıcDeger.Text);
            ulong bitisDeger = Convert.ToUInt64(mtxtbitisDeger.Text);

            ulong ciftsayiToplam = 0;
            ulong ciftsayiCarpim = 1;
            ulong ciftSayi = baslangıcDeger;

            for (ciftSayi = baslangıcDeger; ciftSayi <= bitisDeger; ciftSayi++)
            {
                if (ciftSayi % 2 == 0)
                {
                    listCift.Items.Add("" + ciftSayi);
                    ciftsayiToplam += ciftSayi;
                    ciftsayiCarpim *= ciftSayi;
                }
            }
            listCift.Items.Add("Çift Sayıların Toplamı:" + ciftsayiToplam);
            listCift.Items.Add("Çift Sayıların Çarpımı:" + ciftsayiCarpim);
        }

        private void AsalFonksiyon()
        {
            ulong baslangıcDeger = Convert.ToUInt64(mtxtbaslangıcDeger.Text);
            ulong bitisDeger = Convert.ToUInt64(mtxtbitisDeger.Text);

            ulong asalsayiToplam = 0;
            ulong asalsayiCarpim = 1;

            ulong asalSayi = baslangıcDeger;


            for (asalSayi = baslangıcDeger; asalSayi <= bitisDeger; asalSayi++)
            {
                AsalKontrol(asalSayi);

                if (AsalKontrol(asalSayi) == true)
                {
                    listAsal.Items.Add("" + asalSayi);
                    asalsayiToplam += asalSayi;
                    asalsayiCarpim *= asalSayi;
                }
            }
            listAsal.Items.Add("Asal Sayıların Toplamı:" + asalsayiToplam);
            listAsal.Items.Add("Asal Sayıların Çarpımı:" + asalsayiCarpim);
        }

        private void MukemmelFonksiyon()
        {
            int baslangıcDeger = Convert.ToInt32(mtxtbaslangıcDeger.Text);
            int bitisDeger = Convert.ToInt32(mtxtbitisDeger.Text);

            int mukemmelsayiToplam = 0;
            int mukemmelsayiCarpim = 1;

            int mukemmelSayi = baslangıcDeger;
            int a = 1;

            for (mukemmelSayi = baslangıcDeger; mukemmelSayi <= bitisDeger; mukemmelSayi++)
            {

                MukemmelKontrol(mukemmelSayi);

                int bolenToplam = 0;
                for (a = 1; a <= mukemmelSayi / 2; a++)
                {
                    if (mukemmelSayi % a == 0)
                    {
                        bolenToplam += a;
                    }
                }
                if (bolenToplam == mukemmelSayi)
                {
                    listMükemmel.Items.Add("" + mukemmelSayi);
                    mukemmelsayiToplam += mukemmelSayi;
                    mukemmelsayiCarpim *= mukemmelSayi;
                }
            }
            listMükemmel.Items.Add("Mükemmel Sayıların Toplamı:" + mukemmelsayiToplam);
            listMükemmel.Items.Add("Mükemmel Sayıların Çarpımı:" + mukemmelsayiCarpim);
        }
        private bool AsalKontrol(ulong c)
        {
            if (c == 1)
                return false;

            for (ulong i = 2; i < c; i++)
            {
                if (c % i == 0)
                    return false;
            }
            return true;
        }
        private bool MukemmelKontrol(int d)
        {
            int toplam = 0;
            for (int b = 1; b <= d / 2; b++)
            {
                toplam = toplam + b;

                if (d % b != 0)
                {
                    return false;
                }

                if (toplam != d)
                {
                    return false;
                }

            }
            return true;

        }
        private void GirilenSayiKontrol(int a, int b)
        {
            if (a > b)
            {
                MessageBox.Show("Başlangıç değer bitiş değerden büyük olamaz !");
            }
            if (a < 1 || b > 1000)
            {
                MessageBox.Show("Başlangıç bitiş değerleri 1-1000 arasında olmalıdır.");
            }
        }
        private void GirilenSayiKontrolString(string a, string b)
        {
            if (a == "")
            {
                MessageBox.Show("Başlangıç girmediniz !");
            }
            if (b == "")
            {
                MessageBox.Show("Bitiş girmediniz !");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GirilenSayiKontrolString(mtxtbaslangıcDeger.Text, mtxtbitisDeger.Text);
            GirilenSayiKontrol(Convert.ToInt32(mtxtbaslangıcDeger.Text), Convert.ToInt32(mtxtbitisDeger.Text));

            listTek.Items.Clear();
            listCift.Items.Clear();
            CiftFonksiyon();
            TekFonksiyon();
            listAsal.Items.Clear();
            AsalFonksiyon();
            listMükemmel.Items.Clear();
            MukemmelFonksiyon();
        }
    }
}
