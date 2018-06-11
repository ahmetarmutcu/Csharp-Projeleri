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
    public partial class KayitListeleme : Form
    {
        public KayitListeleme()
        {
            InitializeComponent();
        }

        private void KayitListeleme_Load(object sender, EventArgs e)
        {
            rchtelefontext.Clear();//Program çalıştığında richtexbox temizleniyor.
            StreamReader oku = new StreamReader("veriler.txt");//Telefon verilerini kayıt ettiğimiz txt dosyasını StreamReader ile okuyoruz.
            string satir = "";
            string[] kisi_bilgi = new string[2];//kisi bilgileri adında bir dizi tanımlıyor ve boyutu 2dir.
            //0 adi,1 soyadi,2 telefondur.


            int satir_sayisi = 1;
            while ((satir = oku.ReadLine()) != null)//Txt dosyasını satır satır okuyoruz ve null olana kadar
            {
                if (satir_sayisi % 2 == 1)//Satır sayısı modu tek ise
                {
                    rchtelefontext.SelectionFont = new Font(rchtelefontext.Font, FontStyle.Bold);//O satırda buluna kisi bilgerli Bold(Kalın) oluyor.
                }
                kisi_bilgi = satir.Substring(4).Split(' ');//Renk seçimi 3 karakter olduğu için KKM,MMV,YYK 
                //4 harften başlıyoruz ve boşluk ayırarak

                if (satir.Substring(0, 1) == "K")//veriler.txt ilk karakter K
                    rchtelefontext.SelectionColor = Color.Red; //Renkten sonraki ilk kelimeyi yani adı kırmızı yapıyor
                if (satir.Substring(0, 1) == "Y")//veriler.txt ilk karakter Y
                    rchtelefontext.SelectionColor = Color.Green;//Renkten sonraki ilk kelimeyi yani adı yyapıyor
                if (satir.Substring(0, 1) == "M")//veriler.txt ilk karakter M
                    rchtelefontext.SelectionColor = Color.Blue;//Renkten sonraki ilk kelimeyi yani adı mavi yapıyor
                rchtelefontext.SelectedText = kisi_bilgi[0] + " ";//adini 0 indeksli kisi bilgi dizisine atıyor
                if (satir.Substring(1, 1) == "K")//veriler.txt ikinci karakter K
                    rchtelefontext.SelectionColor = Color.Red;//Renkten sonraki ikinci kelimeyi yani adı kırmızı yapıyor
                if (satir.Substring(1, 1) == "Y")//veriler.txt ikinci karakter Y
                    rchtelefontext.SelectionColor = Color.Green;//Renkten sonraki ikinci kelimeyi yani adı Yeşil yapıyor
                if (satir.Substring(1, 1) == "M")//veriler.txt ikinci karakter M
                    rchtelefontext.SelectionColor = Color.Blue;//Renkten sonraki ikinci kelimeyi yani adı mavi yapıyor
                rchtelefontext.SelectedText = kisi_bilgi[1] + " ";//soyadini 1 indeksli kisi bilgi dizisine atanıyor
                if (satir.Substring(2, 1) == "K")//veriler.txt ucuncu karakter K ise
                    rchtelefontext.SelectionColor = Color.Red;//Renkten sonraki üçüncü kelimeyi yani adı kırmızı yapıyor
                if (satir.Substring(2, 1) == "Y")//veriler.txt ucuncu karakter Y ise
                    rchtelefontext.SelectionColor = Color.Green;//Renkten sonraki üçüncü kelimeyi yani adı yeşil yapıyor
                if (satir.Substring(2, 1) == "M")//veriler.txt ucuncu karakter M ise
                    rchtelefontext.SelectionColor = Color.Blue;//Renkten sonraki üçüncü kelimeyi yani adı mavi yapıyor
                rchtelefontext.SelectedText = kisi_bilgi[2] + "\n";//telefon numarasını 2 indeksli kisi bilgi dizisine atıyor


                satir_sayisi++;
                //Satır sayısı sayılıyor
            }
            rchtelefontext.Enabled = false;
            oku.Close();//kapat
        }
    }
}
