using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            List<KuantumNesnesi> kNList = new List<KuantumNesnesi>();
            

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("KUANTUM AMBARI KONTROL PANELİ");
                Console.WriteLine("1.Yeni Nesne Ekle (Rastgele Veri/Karanlık Madde/Anti Madde üretir)");
                Console.WriteLine("2.Tüm Envanteri Listele (Durum Raporu)");
                Console.WriteLine("3.Nesneyi Analiz Et (ID isteyerek)");
                Console.WriteLine("4.Acil Durum Soğutması Yap (Sadece IKritik olanlar için!)");
                Console.WriteLine("5.Çıkış");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Seçiminiz:");
                secim = Convert.ToInt32(Console.ReadLine());


                if (secim == 5)
                {
                    break;
                }
                else if (secim == 1)
                {
                    Random rn = new Random();
                    int sonuc = rn.Next(0,3);

                    Console.Write("nesne idsini girin...\t");
                    string id = Console.ReadLine();
                    Console.Write("nesne stabilitesini girin...\t");
                    int stabilite = int.Parse(Console.ReadLine());
                    Console.WriteLine("nesne tehlike seviyesini girin...\t");
                    int tSeviye = int.Parse(Console.ReadLine());

                    KuantumNesnesi kN = null;

                    switch (sonuc)
                    {
                        //Veri Paketi
                        case 0:
                            kN = new VeriPaketi(id, stabilite, tSeviye);
                            break;
                        
                        //Karanlık Madde
                        case 1:
                            kN = new KaranlikMadde(id, stabilite, tSeviye);
                            break;

                        //Anti Madde
                        case 2:
                            kN = new AntiMadde(id, stabilite, tSeviye);
                            break;
                    }
                    if((kN.Stabilite > 0 && kN.Stabilite < 100) && (kN.TehlikeSeviyesi >= 1 && kN.TehlikeSeviyesi <= 10))
                    {
                        kNList.Add(kN);
                        Console.WriteLine("Basariyla eklendi...");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş! Değerleri kontrol ediniz.");
                    }
                    
                }
                else if (secim == 2)
                {
                    if (kNList.Count == 0)
                    {
                        Console.WriteLine("\nDepo şu an boş, nesne yok.Lütfen nesne ekleyin...");
                    }
                    else
                    {
                        // Senin yazdığın doğru kod burada çalışsın
                        foreach (var s in kNList)
                        {
                            Console.WriteLine(s.DurumBilgisi());
                        }
                    }
                }
                else if (secim == 4)
                {
                    Console.Write("Nesne id'si girin: ");
                    string kullaniciID = Console.ReadLine();
                    var secilenID = kNList.FirstOrDefault(x => x.NesneID == kullaniciID);

                    if (secilenID is IKritik)
                    {
                        //secilenID aslında KuantumNesnesi sınıfı ve burada IKritik interface i yok o yüzden AcilDurumSogutmasi() yok!!!!!!!
                        ((IKritik)secilenID).AcilDurumSogutmasi();
                    }
                    else
                    {
                        Console.WriteLine("Bu nesne soğutulamaz...");
                    }
                }
                else if (secim == 3)
                {
                    try
                    {
                        Console.Write("Lütfen bir NesneID giriniz...\t");
                        string kullanilanID = Console.ReadLine();
                        var secilenID = kNList.FirstOrDefault(x => x.NesneID == kullanilanID);

                        Console.WriteLine($"Analiz edilmeden önce: {secilenID.Stabilite}");
                        secilenID.AnalizEt();
                        Console.WriteLine($"Analiz edildikten sonra: {secilenID.Stabilite}");

                    }
                    catch (KuantumCokusuException ex)
                    {
                        Console.WriteLine("\nSİSTEM ÇÖKTÜ! TAHLİYE BAŞLATILIYOR...");
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else { continue; }
            }
        }
    }
}
