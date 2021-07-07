using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAV_SORULARI
{
    class Program
    {
        static bool asalmi(int sayi)
        { // 13. soru 
            bool geri;
            int sayaç = 0;
            for (int i = 1; i <= sayi; i++)
{
                if (sayi % i == 0)
                {
                    sayaç += 1;
                }
            }
            if (sayaç == 2) geri = true;
            else geri = false;
            return geri;
        }




        static bool KelimeVarmi(string cumle, string kelime)
        {
            
            // 14.soru
             
            bool sonuc =false;
         
            string[] kelimeler = kelime.Split(' ');
            foreach (string a in kelimeler)
            {
                if (a == kelime)
                {
                    sonuc = true;
                } 
              

            }
            return sonuc;
        }

            



        static void Main(string[] args)
        { 
            /*
            // 14.soru 
            bool sonuc = KelimeVarmi("osman bizi ışınla", "bizi");
            if (sonuc) Console.WriteLine("Var");
            else Console.WriteLine("YOK");
            */








            /
            Console.Write("Asallığını kontrol etmek istediğiniz sayıyı giriniz : ");
            //13.soru
            bool sonuc = asalmi(Math.Abs( Convert.ToInt32( Console.ReadLine())));

            if (sonuc)
            {
                Console.WriteLine("Asal ");
            }

            else
            {
                Console.WriteLine("Asal değil");
            }

            

            /*

            double ahmetMaas = 0, hasanMaas = 0, ekUcret = 0;
            int kacAy = 0;

            Console.Write("Ahmet'in Başlangıç Maaşı :");

            ahmetMaas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hasan'ın Başlangıç Maaşı : ");

            hasanMaas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kaç Ay Sürecek:");

            kacAy = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= kacAy; i++)
            {
                if (i % 2 == 0)
                {
                    //ahmetin para artacak
                    ekUcret = ahmetMaas * 0.5;
                    ahmetMaas = ekUcret +ahmetMaas;
                }
                else
                {
                    //ahmetin para azalacak
                    ekUcret = ahmetMaas * 0.25;
                    ahmetMaas -= ekUcret;
                }
                //hasanınki her türlü artacak
                ekUcret = hasanMaas * 0.25;

                hasanMaas = ekUcret + hasanMaas;

                Console.WriteLine(i + " Ayına kadar");

                Console.WriteLine("Ahmetin toplam maaşı" + ahmetMaas);

                Console.WriteLine("Hasanın toplam maaşı" + hasanMaas);

                //  Console.WriteLine("{ 0}. Ayın Sonunda Ahmetin Maaşı : { 1}, Hasanın Maaşı{ 2}",i+1 ,ahmetMaas,hasanMaas);

            }
            if (ahmetMaas > hasanMaas)

            { Console.WriteLine("Sonuç Olarak { 0} AySonunda Ahmet, Hasandan Daha Fazla Maaş Almaktadır.", kacAy); }


            else if (ahmetMaas == hasanMaas)
            {
                Console.WriteLine("Sonuç Olarak { 0} AySonunda Ahmet ve Hasandan Eşit Fazla Maaş Almaktadır.", kacAy);

            }

            else if(ahmetMaas<hasanMaas)
            {
                Console.WriteLine(" aydan sonra {0} Hasan, Ahmetten DahaFazla Maaş Aldığı ay sayısı.", kacAy);
            }

            
            */



            /*
              

            Random rnd = new Random();
            int ilkSayi = 0, ikinciSayi = 0, toplamPuan = 0, sayilarinToplami = 0,
            girilenCevap = 0, dogruCevapSayisi = 0, yanlisCevapSayisi = 0;
            char devam;
            
            
                ilkSayi = rnd.Next(1, 100);

                ikinciSayi = rnd.Next(1, 100);

                sayilarinToplami = ilkSayi + ikinciSayi;

                Console.Write(ilkSayi +" + ");
                 Console.WriteLine(ikinciSayi);

                Console.Write("Cevabınız : ");

                girilenCevap = Convert.ToInt16(Console.ReadLine());

                if (girilenCevap == sayilarinToplami)

                {
                    Console.WriteLine("Tebrikler Bildiniz");
                    toplamPuan = 5 +toplamPuan;
                    dogruCevapSayisi += 1 ;
                }
                else
                {
                    Console.WriteLine("Üzgünüm Bilemediniz");

                    toplamPuan -= 2;

                    yanlisCevapSayisi += 1;
                }
                Console.Write("Tekrar Oynamak istiyormusunuz(e/E)?");

                devam = Convert.ToChar(Console.ReadLine());

             while (devam == 'E' || devam == 'e');

            Console.WriteLine("Toplam Doğru Cevap Sayınız {0}, Yanlış Cevap Sayınız { 1}, Toplamda Almış Olduğunuz Puan{ 2}",dogruCevapSayisi,yanlisCevapSayisi,toplamPuan);
            

            */





            /*
           double odenecekTutar = 0;

           int kalinanSure = 0, aracTipi = 0;

           Console.WriteLine("Araç Tipleri Taksi : 1, Minübüs : 2, Ticari : 3");

           Console.Write("Lütfen Araç Tipini Giriniz : ");

           aracTipi = Convert.ToInt16(Console.ReadLine());


           Console.Write("Kalınan Süreyi Giriniz : ");

            = Convert.ToInt32(Console.ReadLine());



               for (int i = 1; i <= kalinanSure; i++)
               {


                   if (i == 1)
                   {

                       if (aracTipi == 1)
                       {
                           odenecekTutar = i * 5;


                       }
                       else if (aracTipi == 2)
                       {
                           odenecekTutar = i * 6;
                       }
                       else if (aracTipi == 3)
                       {
                           odenecekTutar = i * 6.5;

                       }

                   }


                   else
                   {
                       kalinanSure = kalinanSure - 1;
                       if (aracTipi == 1)
                       {
                           odenecekTutar = odenecekTutar+ (kalinanSure * 5 * 1.20);
                       }
                       else if (aracTipi == 2)
                       {
                           odenecekTutar += kalinanSure * 6 * 1.215;
                       }
                       else if (aracTipi == 3)
                       {
                           odenecekTutar += kalinanSure * 6.5 * 1.25;
                       }




                       else
                       {
                           if (aracTipi == 1)
                           {
                               odenecekTutar = kalinanSure * 5;
                           }

                           else if (aracTipi == 2)

                           {
                               odenecekTutar = kalinanSure * 6;
                           }

                           else if (aracTipi == 3)

                           {
                               odenecekTutar = kalinanSure * 6.5;
                           }
                       }
                   }
                   Console.WriteLine("Ödenecek Tutar : {0} TL", odenecekTutar);

















                  }


           */


            /*

            string hangiAy;
            int gunSayisi = 30, enDusukGun = 0;
            double gunlukSicaklik = 0, ayToplami = 0, ayOrtalamasi = 0, enDusuk =
            100000;
            Console.Write("Hangi Ay Bilgisi Girilecek : ");
            hangiAy = Console.ReadLine();
            if (hangiAy == "şubat" ) {
              
                gunSayisi = 28; 

            }


            for (int i = 1; i <gunSayisi; i++)
{
                Console.Write("{0}. Güne Ait Sıcaklık Değeri : ", i );
                gunlukSicaklik = Convert.ToDouble(Console.ReadLine());
                if (gunlukSicaklik > enDusuk) {
                    enDusuk = gunlukSicaklik; enDusukGun =i + 1;
                }
                ayToplami = ayOrtalamasi+ gunlukSicaklik;
            }
            ayOrtalamasi = ayToplami / gunSayisi;
            Console.WriteLine("{0} Ayına Ait Sıcaklık Ortalaması {1} Derecedir. En  Düşük Sıcaklık { 2}. Gün = { 3} Derecedir.",hangiAy,ayOrtalamasi,enDusukGun,enDusuk);

            
            */


            /*
            string cumle; char harf;
            Console.Write("Cümleyi Giriniz : ");
            cumle = Console.ReadLine();
            Console.WriteLine("Girilen Cümele : "+ cumle);
            Console.Write("Şifreli Hali : ");
            int sifreli = 0;
            for (int i = cumle.Length - 1; i>=0; i--)
            {
                harf = cumle[i]; // buse
                if (harf == 'a') { harf = '?'; sifreli++; }
                if (harf == 'e') { harf = '*'; sifreli++; }
                if (harf == 'ı' || harf == 'i') { harf = '='; sifreli++; }
                if (harf == 'ö' || harf == 'o') { harf = '&'; sifreli++; }
                if (harf == 'u' || harf == 'ü') { harf = '+'; sifreli++; }
                if (i == 0) Console.WriteLine("{0}", harf);
                else Console.Write("{0}", harf);
            }
            Console.WriteLine("Toplam {0} tane harf şifrelendi {1} tanesi şifrelenmedi", sifreli, cumle.Length - sifreli);
        

            */

            // cumle="buse bugün saçlarını yıkadı";
            // cumle.Split('a');



            /*
            string cumle;
            Console.Write("Cumleyi Girin : ");
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine(kelimeler.Length);
            */




            /*

            string cumle;
            Console.WriteLine("Ters çevrilmesini istediğiniz cümleyi giriniz");
            cumle = Console.ReadLine().ToUpper();

            for (int i = cumle.Length-1;  i>=0 ; i--)
            {
                Console.WriteLine(cumle[i]);

            }

            
            */



            /*
            int[,] dizi = new int[3, 2];
            int toplamKisi = 0, evdekiKisi = 0;

            for (int i = 0; i & lt; dizi.GetLength(0); i++ )
                    
                 {
                for (int y = 0; y & lt; dizi.GetLength(1); y++)
                {
                    Console.Write("{0}. Kat {1}. Dairedeki Kişi sayısını Giriniz : ",i+1,y+1);
                    evdekiKisi = Convert.ToInt32(Console.ReadLine());
                    toplamKisi += evdekiKisi;
                }
            }
            Console.WriteLine("Toplam Kişi Sayısı : {0}", toplamKisi);

            */


            /*

            double malFiyati = 0, komisyonMiktari = 0, toplamKomisyon = 0;
            for (int i = 1; i<6 ; i++)
{
                Console.Write("{0}. Malın Fiyatını Giriniz : ", i );
                malFiyati = Convert.ToDouble(Console.ReadLine());
                if (malFiyati > 50)
                    komisyonMiktari = malFiyati * 0.02;

               else komisyonMiktari = malFiyati * 0.03;

                Console.WriteLine("komisyon miktarı :  " +komisyonMiktari);

                toplamKomisyon = toplamKomisyon+ komisyonMiktari;
            }
            Console.WriteLine("Toplam Komisyon Miktarı : {0}", toplamKomisyon);

            */





            /*
            double sayilar = 0, sayiToplami = 0;

           

            
                Console.Write("Sayıyı Giriniz :  ");
                sayilar = Convert.ToDouble(Console.ReadLine());
                sayiToplami =sayiToplami+ sayilar;
            
            while (sayiToplami >= 21);
            Console.WriteLine("Toplamda Sayılar {0} Rakamına Ulaştı. Yeter Bu Kadar.",sayiToplami);

           */

            /*
            
            
            // 11.soru

            int[] dizi = new int[20];

            Random rnd = new Random();

            int diziToplami = 0, Buyuk = 0, Kucuk = 0;

            double diziOrtalamasi = 0;

            for (int i = 0; i < dizi.Length; i++)

            {
                dizi[i] = rnd.Next(100);
                diziToplami =diziToplami+ dizi[i];
            }
            diziOrtalamasi = diziToplami / 20;
            foreach (int sıra in dizi)
            {
                if (sıra > diziOrtalamasi) 
                    Buyuk = Buyuk+ 1;
            else Kucuk = Kucuk+ 1;
            }
            Console.WriteLine("Ortalama : {0}. Ortalamadan Büyük Eleman Sayısı : {1}, Ortalamadan Küçük Eleman Sayısı:{ 2}",diziOrtalamasi,Buyuk,Kucuk);

            */


            /*
            
            // 12. soru
            
            int asalart;
            int girilenSayi ;
            Console.Write(" ilk sayıdan kontrol edilmesini istenilen sayı : ");

            girilenSayi = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <=girilenSayi; i++)
            {
                asalart = 0; 
                for (int j = 1; j <= girilenSayi; j++)
                {
                    if (i % j == 0)
                    {
                        asalart = asalart+ 1; // ilk değeri vermediğim için hata verdi bu yüzden 0 atamam lazım
                    }
                }
               if (asalart == 2)
                {
                    Console.WriteLine(i + " asaldır");
                }
            }

            
            */




            































            Console.Read();



        }
    }
}





/* 
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAV_SORULARI_2
{
    class Program
    {

        static bool Asalmi(int sayi)
        {
            bool sonuc;
            int sayac = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac += 1;
                }
            }
            if (sayac == 2)
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }

            return sonuc;
        }









        static bool KelimeVarmi(string cumle, string kelime)
        {
            bool sonuc = false;



            string[] kelimeler = kelime.Split(' ');

            foreach (string a in kelimeler)

            {
                if (a == kelime) sonuc = true;
                break;
            }
            return sonuc;
        }








        static int Karistir(params int[] dizimiz)
        {
            

           

            int[] yeniDizi = new int[dizimiz.Length];

            Random rnd = new Random();
            for (int i = 0; i < dizimiz.Length; i++)

{
                if (i == 0) { yeniDizi[i] = dizimiz[rnd.Next(0, dizimiz.Length)]; }

                else
                {
                    int sonuc = 0;
                    do
                    {
                        int rastgeleGelen = 0, sayac = 0;

                        rastgeleGelen = dizimiz[rnd.Next(0, dizimiz.Length)];

                        foreach (int diziEleman in yeniDizi)
                        {
                            if (diziEleman == rastgeleGelen)
                            {
                                sayac += 1;
                                break;
                            }
                        }
                        if (sayac == 0)
                        {
                            yeniDizi[i] = rastgeleGelen;
                            sonuc = 1;
                        }
                    } while (sonuc != 1);
                }
                Console.WriteLine(yeniDizi[i]);
            }
            return dizimiz.Length;
        }







        static int KarelerinToplami(int sayi)
        {
            int toplam = 0;
            if (sayi < 1) {
                Console.WriteLine("hesaplama işlemi yapılamaz");
                toplam= -1;
            }
            else
            {
                for (int i = 1; i <= sayi; i++)
                {
                    toplam += i * i;
                }
            }
            Console.WriteLine(toplam);
          

            return toplam;
        }











        static void Main(string[] args)
        {





            KarelerinToplami(11);









            /*
            Console.WriteLine("Assalığını kontrol etmek istediğiniz sayıyı giriniz :  ");


            bool bus = Asalmi(Math.Abs( Convert.ToInt16(Console.ReadLine())));
            if (bus)
            {
                Console.WriteLine("Asal Sayı");
            }
            else
            {
                Console.WriteLine("asal sayı değil");
            }
            */



// 14.soru

/*
    bool sonuc = KelimeVarmi("osman bizi ışınla", "bizi");
    if (sonuc) Console.WriteLine("Var");
    else Console.WriteLine("YOK");
*/
















/*
Console.WriteLine("Mükemelliğini kontrol etmek istediğiniz sayıyı giriniz");


MukemmelSayi(Convert.ToInt16(Console.ReadLine()));
*/
















/*

// 17.soru 


int[] dizi = { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
// Random rnd = new Random();
int enKucukEleman = 0, enBuyukEleman = 0;
//  for (int i = 0; i & lt; dizi.Length; i++)
{
//    dizi[i] = rnd.Next(1, 1000);
//}
foreach (int eleman in dizi)
{
    if (eleman > enBuyukEleman) enBuyukEleman = eleman;
    if (eleman < enKucukEleman) enKucukEleman = eleman;
}
Console.WriteLine("En Büyük Eleman : {0}", enBuyukEleman);
Console.WriteLine("En Küçük Eleman : {0}", enKucukEleman);



*/



/*
// 18.soru


int elemanSayisi = 0, sonuc = 0, rastgeleSayi ;
Console.Write("Dizinin Eleman Sayısını Girin : ");
elemanSayisi = Convert.ToInt32(Console.ReadLine());
int[] dizi = new int[elemanSayisi];
Random rnd = new Random();
for (int i = 0; i < dizi.Length; i++)
 {

    do
    {
        rastgeleSayi = rnd.Next( 1000);
        if (rastgeleSayi % 2 != 0 && rastgeleSayi % 5 == 0)
{
            dizi[i] = rastgeleSayi;
            sonuc = 1;
        }




    } while (sonuc != 1);
    Console.WriteLine(dizi[i]);


    Console.WriteLine("------------------------------------------------------------");
}



*/
















/*
// 20.soru

int satirToplami = 0;
int[,] dizi = new int[20, 100];
Random rnd = new Random();
for (int i = 0; i < 20; i++)
{

    for (int j = 0; j < 100; j++)
    {
        dizi[i, j] = rnd.Next(0, 100);
        satirToplami += dizi[i, j];
    }
    Console.WriteLine(satirToplami);
}
foreach (var a in dizi)
{
    Console.WriteLine();
    Console.WriteLine(a);


}


*/


/*

int satirSayisi , sutunSayisi , sutunToplami=0;

Console.Write("Satir sayisini Giriniz : ");

satirSayisi = Convert.ToInt32(Console.ReadLine());

Console.Write("sütün sayısını giriniz : ");

sutunSayisi = Convert.ToInt32(Console.ReadLine());

int[,] dizi = new int[satirSayisi, sutunSayisi];

Random rnd = new Random();

                for (int i = 0; i < sutunSayisi; i++)


                              {

                                for (int j = 0; j < satirSayisi; j++)
                                {
                                    dizi[j, i] = rnd.Next(0, 100);
                                    sutunToplami += dizi[j, i];
                                }

                            }
                             for (int i = 0; i <(satirSayisi*sutunSayisi); i++)
                            {


                    foreach (var sonucum in dizi)
                    {

                        if (sonucum >= 70)
                        {
                            Console.WriteLine(i+ " GEÇTİ :)");

                        }
                        else
                        {
                            Console.WriteLine(i+" KALDI :(");
                        }


    }

}
Console.WriteLine("toplam = "+ sutunToplami);



*/












































































// KacTaneTek(12);


















































//  EnUzunCumle("osman bizi ışınla", "makina soğuk", "peki zeki mürende bizi  görecek mi");


Console.Read();

        }

        

        static int EnUzunCumle(params string[] cumlem) // değişken sayıda parametre için params kullanılır
{
    int cumleSayisi = cumlem.Length, enCokKelimeSayisi = 0, sırası = 0,
    kelimeSayisi = 0;
    for (int i = 0; i < cumlem.Length; i++)
    {
        string[] kelimeler = cumlem[i].Split(' ');
        kelimeSayisi = kelimeler.Length;

        if (kelimeSayisi > enCokKelimeSayisi)
        {
            enCokKelimeSayisi = kelimeSayisi;
            sırası = i;
        }
    }
    Console.WriteLine("En Çok Kelime {0} Cümlesinde Yer Alıp Toplam Kelime Sayısı {1}.", cumlem[sırası], enCokKelimeSayisi);
    return kelimeSayisi;
}























        /*
    static void KacTaneTek(int sayi)
    {
        int tekSayisayısı = 0;
        for (int i = 1; i <= sayi; i += 2)
     {
             tekSayisayısı += 1;
        }
        Console.WriteLine(tekSayisayısı);
    }

        */











        /*
         static void MukemmelSayi(int sayi)
         {
             int bolenToplami = 0;
             for (int i = 1; i < sayi; i++)
             {
                 if (sayi % i == 0)
                 {
                     bolenToplami += i;
                 }
                 if (sayi == bolenToplami) Console.WriteLine("mükemmel sayı");
                 else Console.WriteLine("mükemmel say değil");
             }*/
    }



    }









 */













                    
             

