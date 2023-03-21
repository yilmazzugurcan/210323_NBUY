using System;

namespace _210323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Calisan Mesai hesaplama abstract örnek
            /* Mudur mudur = new Mudur();
             mudur.ad = "Ali";
             mudur.maas = 15000;

             Console.WriteLine("adı : " + mudur.ad + " olan kişinin maaşı : " + mudur.Mesai_Hesapla(2));
             Console.WriteLine("görevi "); mudur.Gorev();

             Console.Read();
         }

         abstract class Calisan
         {
             public string ad { get; set; }
             public int maas { get; set; }

             abstract public void Gorev();
             abstract public double Mesai_Hesapla(byte saat);
         }

         class Mudur : Calisan
         {

             public override void Gorev()
             {
                 Console.WriteLine("Onaylamak");
             }

             public override double Mesai_Hesapla(byte saat1)
             {
                 return this.maas + (2 * saat1);
             }
         }

         class Memur : Calisan
         {

             public override void Gorev()
             {
                 Console.WriteLine("Evrak Hazırlama");
             }

             public override double Mesai_Hesapla(byte saat1)
             {
                 return this.maas + (1.5 * saat1);
             }
         }

         class Sekreter : Calisan
         {


             public override void Gorev()
             {
                 Console.WriteLine("Telefonlara bakmak");
             }

             public override double Mesai_Hesapla(byte saat1)
             {
                 return this.maas + (1 * saat1);
             }
         }

         class Guvenlikci : Calisan
         {

             public override void Gorev()
             {
                 Console.WriteLine("Giriş/Çıkış Kontrol");
             }

             public override double Mesai_Hesapla(byte saat1)
             {
                 return this.maas + (1 * saat1);
             }
         }*/
            #endregion

            #region Tür seçimi abstract örnek
            /* Console.WriteLine("Tür Seçimi Yapınız" + "\n1-Hayvan" + "\n2-Bitki");
             string secim = Console.ReadLine();
             if (secim == "1")
             {
                 hayvan e1 = new hayvan();
                 e1.tür = "Hayvan";
                 e1.yaptiklari = "Avlanmak,Aile Kurmak";
                 e1.yaz();
             }
             else if (secim == "2")
             {
                 bitki o1 = new bitki();
                 o1.tür = "Bitki";
                 o1.yaptiklari = "Oksijen Üretmek, Yemek Olmak";
                 o1.yaz();
             }
         }
     }
     abstract class canlı
     {
         abstract public string tür { get; set; }
         abstract public string yaptiklari { get; set; }

         abstract public void yaz();

     }
     class hayvan : canlı
     {
         public override string tür { get; set; }
         public override string yaptiklari { get; set; }

         public override void yaz()
         {
             Console.WriteLine("Türü: " + tür + "\n" + "Yaptıkları: " + yaptiklari);
         }
     }
     class bitki : canlı
     {
         public override string tür { get; set; }
         public override string yaptiklari { get; set; }

         public override void yaz()
         {
             Console.WriteLine("Türü: " + tür + "\n" + "Yaptıkları: " + yaptiklari);
         }
     } */
            #endregion

            #region Ders,Ogretmen,Ogrenci Struct yapılar
            /* Ders d1 = new Ders();
              d1.ad = "mat";
              d1.saat = 7;

              Ogrenci o1 = new Ogrenci();
              o1.dersi = d1;
              Ogrenci o2 = new Ogrenci();

              Console.WriteLine(o1.dersi.ad + " " + o1.dersi.saat);

          }
      }
      class Ders
      {
          // static: sınıfran instance almadan sınıfın sonuna nokta koyarak static elemana ulasmamızı saglar
          public string ad { get; set; }
          public string kitap { get; set; }
          public int saat { get; set; }
      }
      struct Ogrenci
      {

         public void Ogrencis()
          {
              OgrenciSayisi++;


          public static int OgrenciSayisi;
          public Ders dersi;

          public string ad { get; set; }
          public string kitap { get; set; }
          public int okulNo { get; set; }
          public int sure { get; set; }
      }
      struct Ogretmen
      {
          public string ad { get; set; }
          public string kitap { get; set; }
          public int id { get; set; }
      }
      struct dersi
      {
          public string ad { get; set; }
          public string kitap { get; set; }
          public int id { get; set; }
      }*/
            #endregion

            // static: sınıfran instance almadan sınıfın sonuna nokta koyarak static elemana ulasmamızı saglar

            #region Static sınıf kullanımı
            /* Ders drs1 = new Ders();
            drs1.Adi = "Matematik";
            drs1.Saat = 7;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Dersi = drs1;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Dersi = drs1;

            Ogrenci ogr3 = new Ogrenci();

            int a = Ogrenci.OgrenciSayisi;

            Console.WriteLine(ogr1.Dersi.Adi);
            Console.WriteLine(ogr1.Dersi.Saat);
            Console.WriteLine(Ogrenci.OgrenciSayisi);
            Ogrenci.Ekle();

        }
    }

    class Ogrenci
    {
        public Ogrenci()
        {
            OgrenciSayisi++;

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int OkulNo { get; set; }
        public int Sinif { get; set; }

        public Ders Dersi { get; set; }

        public Ogretmen MyProperty { get; set; }

        public static int OgrenciSayisi { get; set; }
        //Static : sınıftan instance almadan sınıfın sonuna nokta koyarak static elemana ulaşmamızı sağlıyor.

        public static void Ekle()
        {
            //static metotlar içerisinde static olan propertylere erişilebilir.
            Console.WriteLine("Ekleme Yapılmıstır.");
        }


    }
    struct Ders
    {
        public string Adi { get; set; }
        public int Kredi { get; set; }

        public string Kitabi { get; set; }

        public int Saat { get; set; }
    }

    static class Mudur
    {
        // Static sınıflarda instance alınmaz.
        // Static olmayan property bulunmaz.
        // bir sınıf içerisinde bulunnan elemanlaru yumu static olacaksa sınıf static olarak tanımlanır
    } */
            #endregion

            // Interface kendisinden miras alacak sınıflarda imzansını barındıran bir yapıdır.

            #region Interface kullanımı
            /*  interface IArayuz
              {
                  //Erişim Belirleyicilerin olmasına gerek yoktur. Standart publictir. 
                  //Bir şablon olarak kullanırız.
                  //Nesne olusturualamaz. ama referans noktası olusturulabılır.
                  // Bir sınıfa yetenek ve ozellık kazandırmak ıcın kullanılır.
                  // Metodların govdesı yok.
                  int sayfa { get; set; }
                  void SayfaOlustur();
                  string SayfaSayisi();
                  int kenarBoslugu { get; set; }
              }
              class gazete : haberler, ISpor, IArayuz
              {
                  public int sayfa { get; set; }
                  public int kenarBoslugu { get; set; }
                  public string takımAdı { get; set; }
                  public string baslik { get; set; }

                  public void SayfaOlustur()
                  {
                      Console.WriteLine("Sayfa Olusturdu");
                  }
                  public string SayfaSayisi()
                  {
                      return "15";
                  }
              }
              class haberler
              {
                  public string konumAdres { get; set; }
                  public string haberTuru { get; set; }
              }
              interface ISpor
              {
                  string takımAdı { get; set; }
                  string baslik { get; set; }
              } */
            #endregion

            //işlemler klass,sekreter,müdür, yemek yeme her calısan yemek yıyecek, her calısanın maas bılgısı alınacak

            #region Interface mudur ve sekreter yemek yeme ozellıklerı ve maaslarını yazdırma
            /*   IIslem mudur = new Mudur();
               IIslem sekreter = new Sekreter();
               mudur.YemekYe("Müdür");
               mudur.Maas();
               sekreter.YemekYe("Sekreter");
               sekreter.Maas();
           }
       }
       public interface IIslem
       {
           void YemekYe(string kim);
           void Maas();
       }
       public class Mudur : IIslem
       {
           public void YemekYe(string kim)
           {
               Console.WriteLine(kim + " yemek yiyor.");
           }
           public void Maas()
           {
               Console.WriteLine("Müdürün maaşı 10.000 TL.");
           }
       }
       public class Sekreter : IIslem
       {
           public void YemekYe(string kim)
           {
               Console.WriteLine(kim + " yemek yiyor.");
           }
           public void Maas()
           {
               Console.WriteLine("Sekreterin maaşı 3.500 TL.");
           }
       } */
            #endregion
        }

    }


