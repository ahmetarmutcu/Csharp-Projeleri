using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class KayitEkleme : Form
    {
        public KayitEkleme()
        {
            InitializeComponent();
        }

        private static void dosyaYaz(string bilgi)
        {
            string dosya_yolu = @"veriler.txt";//Txt kayıt edileceği dosya yolunu belirtiyoruz.
            StreamWriter sw = new StreamWriter(dosya_yolu, true);//Txt. yazılacak yolu belirtiyoruz
            sw.WriteLine(bilgi);//Txt yazılacak bilgiyi satır satır yazmasını sağlıyoruz
            sw.Flush();
            sw.Close(); //Yazdıktan sonra kapatıyoruz.

        }
        public char RenkAdi(char renkadi)//Adı icin texbox için kullanıcıdan renk secimi yapması isteniyor 
        {
            if (radioKirmizi.Checked == true) //Radio butonların hepsi ayrı bir group box içindedir.Buradan sadece bir seçenek seçilmesine izin veriliyor.
            {
                renkadi = 'K';// K seçelirse char karakterinde K döndürüyor.
            }
            else if (radioMavi.Checked == true)
            {
                renkadi = 'M';// M seçelirse char karakterinde M döndürüyor.
            }
            else if (radioYesil.Checked == true)
            {
                renkadi = 'Y';// Y seçelirse char karakterinde Y döndürüyor.
            }

            return renkadi;

        }
        public char RenkSoyadi(char renksoyadi)//SoyAdı  texbox için kullanıcıdan renk secimi yapması isteniyor 
        {
            if (radiokirmizi_s.Checked == true)
            {
                renksoyadi = 'K';// K seçelirse char karakterinde K döndürüyor.
            }
            else if (radiomavi_s.Checked == true)
            {
                renksoyadi = 'M';// M seçelirse char karakterinde M döndürüyor
            }
            else if (radioyesil_s.Checked == true)
            {
                renksoyadi = 'Y';// Y seçelirse char karakterinde Y döndürüyor.
            }

            return renksoyadi;

        }
        public char RenkTelefon(char renktelefon)//Telefon textbox için kullanıcıdan renk isteniyor.
        {
            if (radiokirmizi_T.Checked == true) // K seçelirse char karakterinde K döndürüyor.
            {
                renktelefon = 'K';
            }
            else if (radiomavi_T.Checked == true)// M seçelirse char karakterinde M döndürüyor
            {
                renktelefon = 'M';
            }
            else if (radioYesil_T.Checked == true)// Y seçelirse char karakterinde Y döndürüyor.
            {
                renktelefon = 'Y';
            }

            return renktelefon;

        }

        private void buttonKayitEkleme_Click(object sender, EventArgs e)//Kayit Ekleme butonuna basılınca
        {

            try
            {
                char renk = ' '; //char renk ilk değer atanıyor.
                string adi, soyadi;
                adi = textBoxadi.Text;// adi değişkenine Textboxadi atanıyor.
                soyadi = textBoxsoyadi.Text;// soyadi değişkenine Textboxadi atanıyor.
                long telefon = long.Parse(textBoxtelefon.Text);
                if (adi == "" || soyadi == ""||telefon==0)//Eğer texbox alanlarını tümü boş ise kayıt işlemi yapmıyor kullanıcıya uyarı mesajı veriliyor.
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz. ");
                }
                else if((telefon.ToString().Length<10))//Telefon Numarasının en az 11 karakter olması lazımdır.
                {
                    MessageBox.Show("Telefon Numarası için 0 hariç 10 rakam giriniz");
                }
                else if (radioKirmizi.Checked == false && radioYesil.Checked == false && radioMavi.Checked == false)
                {
                    labeladihata.Text = "Adı için renk seçin";//adi bilgisi dolduruktuktan sonra renk seçimi yapılmazsa kullanıcıya labelda uyarı mesajı veriliyor.
                }
                else if (radiokirmizi_s.Checked == false && radioyesil_s.Checked == false && radiomavi_s.Checked == false)
                {
                    labelsoyadihata.Text = "Soyadı için renk seçin";//soyadi bilgisi dolduruktuktan sonra renk seçimi yapılmazsa kullanıcıya labelda uyarı mesajı veriliyor.
                }
                else if (radiokirmizi_T.Checked == false && radioYesil_T.Checked == false && radiomavi_T.Checked == false)
                {
                    labeltelefonhata.Text = "Telefon için renk seçin";//telefon bilgisi dolduruktuktan sonra renk seçimi yapılmazsa kullanıcıya labelda uyarı mesajı veriliyor.
                }
                else//Eğer yukarıdaki işlemlerin hiçbiri karşılaşılmıyorsa Kayıt işlemi yapılıyor.Ve Dosya yaz metodu ile bilgiler veriler.txt dosyasına kayıt ediliyor.
                {
                    string bilgi = RenkAdi(renk).ToString() + "" + RenkSoyadi(renk).ToString() + "" + RenkTelefon(renk).ToString() + " " + adi + " " + soyadi + " " +"0"+telefon;
                    dosyaYaz(bilgi);
                    MessageBox.Show("Bilgiler Kayıt edildi");
                }

            }
            catch (Exception hata)//Eğer farklı bir hata çıkarsa hatayı gösterip kullanıcıya uyarı mesajı veriliyor.
            {
                MessageBox.Show(hata.Message);
            }

        }

       
    }
}
