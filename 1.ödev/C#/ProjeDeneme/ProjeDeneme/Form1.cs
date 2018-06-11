using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme
{
       
    public partial class Form1 : Form
    {
        String ResminYolu = null;//Seçilecek olan resmin yoludur.//BLUE,GREEN,RED
        Image<Bgr, byte> _girisResmi;//ilk olarak bgr resim(yüklenen resimdir)
        Image<Gray, byte> gri;//Gri resim
        //Bitmap GirisResmi, CikisResmi;
        public Form1()
        {
            InitializeComponent();
        }
        public void DosyaYukle()//Resim yükleme metodu
        {
            
                try
                {
                openFileDialog1.DefaultExt = ".jpg"; //OpenFileDialog ile resim uzantısı kontrol ediliyor.jpg,bmp,gif dosya açılıyor.
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                ResminYolu = openFileDialog1.FileName;//Resmin yolun seçilendosya ve adı veriliyor.
                _girisResmi = new Image<Bgr, byte>(ResminYolu);//giris resmi olarak seçilen resim oluyor.
                ımageBoxRgbResim.Image = _girisResmi;//RgbResim ımagebox ile giris resmi gösteriliyor.
                pictureBoxGrayResim.Image = null;//Her dosya butonuna basıldığında gray resmi ve binary resim olan picture box ımage null değerini alıyor.
                pictureBoxBinaryResim.Image = null;
                }
                catch
                {
                MessageBox.Show("Hata ");//Eğer resim yükleme çalışırken openFileDalog açıldıktan resim seçilmeyip "iptal" tuşuna basılırsa, resimyolu
                //değişkeni "null" olacağı için program hata verir.Bunu engellemek için Try-Catch kodları içine yazılması gerekir. 
                }
                
                
            
          
        }
        //public Bitmap ResmiGriTonaDonustur()
        //{ Bu kod bloğuda uyarlandığı çalışıyor.
        //    try
        //    {
        //        GirisResmi = new Bitmap(ımageBox1.Image.Bitmap);
        //        Color OkunanRenk, DonusenRenk;
        //        int R = 0, G = 0, B = 0;
        //        int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. Fonksiyonla gelmedi.
        //        int ResimYuksekligi = GirisResmi.Height;
        //        CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi

        //        int i = 0, j = 0; //Çıkış resminin x ve y si olacak
        //        for (int x = 0; x < ResimGenisligi; x++)
        //        {
        //            j = 0;
        //            for (int y = 0; y < ResimYuksekligi; y++)
        //            {
        //                OkunanRenk = GirisResmi.GetPixel(x, y);

        //                int GriDegeri = Convert.ToInt32(OkunanRenk.R * 0.299 + OkunanRenk.G * 0.587 + OkunanRenk.B * 0.114);
        //                //Gri-ton formülü
        //                R = GriDegeri;
        //                G = GriDegeri;
        //                B = GriDegeri;
        //                DonusenRenk = Color.FromArgb(R, G, B);
        //                CikisResmi.SetPixel(i, j, DonusenRenk);
        //                j++;
        //            }
        //            i++;
        //        }


        //    }
        //    catch
        //    {
        //        MessageBox.Show("Lütfen ilk önce resim yükleyiniz...");
        //    }
        //    return CikisResmi;
        //}//Bu kod
        public static Image<Gray, byte> GriGetir(Image<Bgr, byte> img)//GriGetir adında rgb resmi gray(8 bit cinsinden) gray resime dönüştürüyor.
        {
            Image<Gray, byte> gri = img.Convert<Gray, byte>();
            return gri; //oluşturulan bu kodu geri döndürüyor.
        }
        public static Mat HistogramGetir(Image<Gray, byte> griFoto)//Mat sınıfından oluşan bir gray kodunu 1 ile 256 arası değere alcak şekilde grafik şekline dönüştürüyor.

        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            hist.Calculate(new Image<Gray, Byte>[] { griFoto }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            return m;
        }
        public void BinaryDonus()
        {
           
            try
            {
                if (pictureBoxGrayResim.Image == null)// Bu metod da ilk önce grayresmin null olup olmadığı kontol ediliyor.
                {
                    MessageBox.Show("Lütfen ilk önce(8bitlik)gray koduna çeviriniz");
                   //Eğer null ise Kullanıcıya Mesaj veriyor.
                }
                else//Değilse
                {
                    _girisResmi = new Image<Bgr, byte>(ResminYolu);
                    labelBinaryResim.Visible = true;//Başlangıcta visible(görünmezlik false olan yani görünmez olan pictureBoxBinaryResim oluyor).Görsel acısından iyi olması için böyle tanımladım. 
                    labelrgbresim.Visible = false;//labellarda hangi resim tipi gelirse onun adını yazıyor.
                    pictureBoxBinaryResim.Visible = true;
                   
                    gri = GriGetir(_girisResmi);
                    int threshold = 70;

                    Image<Gray, byte> binary = gri.ThresholdBinary(new Gray(threshold), new Gray(255));//Gray resim binary resime dönüştürülüyor.
                    pictureBoxBinaryResim.Image = binary.Bitmap;//pictureBoxBinaryResim.Image atanıyor.
                }
               
            }
            catch//Rgb resim yüklenmeden seçilirse böyle bir hata verecektir.
            {
                MessageBox.Show("Gray Resmi bulunamadı ");
            }
        }

        private void buttonDosyaYukle_Click(object sender, EventArgs e)//DosyaYükle butonu dosyanın seçilip uygulamaya yüklenmesini sağlar.
        {
            pictureBoxBinaryResim.Visible = false; //ilk olarak binaryresim picturebox görünmezdir.
            labelBinaryResim.Visible = false;//labelda resim tiplerinin bilgileri değişiyor.
            labelrgbresim.Visible = true;

            DosyaYukle();//Butona basıldığında dosya yükle metodu çağırılıyor.
        }
        private void buttonGrayDonus_Click(object sender, EventArgs e)//Rgb olan resmi gray resme dönüştürme.
        {
            try
            {
                if (pictureBoxBinaryResim.Visible == true)//binary resim görünür halde bütün dönüşüm işlemleri yapılmıştır.O yüzden rgb resim diye yüklensin diye kullanıcıya bilgi verir.
                   {
                     MessageBox.Show("Dönüştürme işlemi bitmiştir Lütfen Rgb resmi yükleyiniz ");
                   }
                _girisResmi = new Image<Bgr, byte>(ResminYolu);

                Image<Gray, byte> griFoto = GriGetir(_girisResmi);//Yukarıdaki griGetir metodu ile rgb resim gray resime dönüşür.
                pictureBoxGrayResim.Image = griFoto.Bitmap; //gray resim picturebox atanır.
            }
            catch
            {
                MessageBox.Show("Rgb resmi yüklemelisiniz ");//gray dönüşüm butonuna basıldığında rgb resim yüklenmediği için kullanıcıya uyarı verir.
            }
            
        }
        private void buttonHistogramDonus_Click(object sender, EventArgs e)//Histogram butonu
        {
            try
            {
                if(pictureBoxGrayResim.Image==null)//gray resim picturebox boş ise gray resim seçilmesi gerek.
                {
                    MessageBox.Show("Lütfen gray(8 bitlik) resime dönüştürünüz");

                }
                else
                {
                    _girisResmi = new Image<Bgr, byte>(ResminYolu);
                    Mat m = HistogramGetir(GriGetir(_girisResmi)); //Mat sınıfı ile histogramgetir metodu ile gray kodu eklenir.
                    histogramBox1.ClearHistogram();//Histogram temizleniyor.

                    histogramBox1.AddHistogram("Gri Histogram", Color.Blue, m, 256, new float[] { 0.0f, 256.0f });//Histogram ekleniyor.Grafiğin çizgi renkleri belirleniyor.
                    histogramBox1.Refresh(); //histogram yenileniyor.
                }
               
            }
            catch
            {
                MessageBox.Show("Lütfen Rgb resmini giriniz: ");//Kullanıcıya uyarı veriliyor.
            }
           

        }
        private void buttonBinaryDonus_Click(object sender, EventArgs e)//Binary resime dönüş butonu
        {
           
            BinaryDonus();//BinaryDonus metodu çağırılıyor.
        }

    }
}
