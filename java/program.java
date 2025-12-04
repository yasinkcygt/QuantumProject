
import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class program {
    public static void main(String[] args) {        
        int secim;
        List<KuantumNesnesi> kNList = new ArrayList<>();
        Scanner sc = new Scanner(System.in);

        while (true)
        {
            System.out.println();
            System.out.println("KUANTUM AMBARI KONTROL PANELİ");
            System.out.println("1.Yeni Nesne Ekle (Rastgele Veri/Karanlık Madde/Anti Madde üretir)");
            System.out.println("2.Tüm Envanteri Listele (Durum Raporu)");
            System.out.println("3.Nesneyi Analiz Et (ID isteyerek)");
            System.out.println("4.Acil Durum Soğutması Yap (Sadece IKritik olanlar için!)");
            System.out.println("5.Çıkış");
            System.out.println();
            System.out.println();
            System.out.println("Seçiminiz:");
            secim = sc.nextInt();
            sc.nextLine();  //boşta enter ı temizler


            if (secim == 1)
            {
                Random rn = new Random();
                int sonuc = rn.nextInt(3);

                System.out.println("nesne idsini girin...\t");
                String id = sc.nextLine();
                System.out.println("nesne stabilitesini girin...\t");
                int stabilite = sc.nextInt();
                System.out.println("nesne tehlike seviyesini girin...\t");
                int tSeviye = sc.nextInt();

                KuantumNesnesi kN = null;

                switch(sonuc)
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
                if((kN.getStabilite() > 0 && kN.getStabilite() < 100) && (kN.getTehlikeSeviyesi() >= 1 && kN.getTehlikeSeviyesi() <= 10))
                {
                    kNList.add(kN);
                    System.out.println("Basariyla eklendi...");
                }
                else
                {
                    System.out.println("Hatalı giriş! Değerleri kontrol ediniz.");
                }
                
            }

            else if (secim == 2)
            {
                if (kNList.size() == 0)
                {
                    System.out.println("\nDepo şu an boş, nesne yok.Lütfen nesne ekleyin...");
                }
                else
                {
                    // Senin yazdığın doğru kod burada çalışsın
                    for (var s : kNList)
                    {
                        System.out.println(s.DurumBilgisi());
                    }
                }
            }
            
            else if (secim == 3)
            {
                try
                {
                    System.out.println("Lütfen bir NesneID giriniz...\t");
                    String kullanilanID = sc.nextLine();

                    for (KuantumNesnesi kN : kNList) {
                        if(kN.getNesneID().equals(kullanilanID)){
                            System.out.printf("Analiz edilmeden önce: %d\n", kN.getStabilite());
                            kN.analizEt();
                            System.out.printf("Analiz edilmeden önce: %d\n", kN.getStabilite());
                        }
                    }
                }
                catch (KuantumCokusException ex)
                {
                    System.out.println("\nSİSTEM ÇÖKTÜ! TAHLİYE BAŞLATILIYOR...");
                    System.out.println(ex.getMessage());
                    return;
                }
                catch (Exception ex)
                {
                    System.out.println(ex.getMessage());
                }
            }
            
            else if (secim == 4)
            {
                System.out.println("Nesne id'si girin: ");
                String kullanilanID = sc.nextLine();
                KuantumNesnesi secilenNesne = null;
                for (KuantumNesnesi kN : kNList) {
                    if (kN.getNesneID().equals(kullanilanID)) {
                        secilenNesne = kN;
                        break;
                    }
                }

                if (secilenNesne instanceof IKritik)
                {
                    //secilenID aslında KuantumNesnesi sınıfı ve burada IKritik interface i yok o yüzden AcilDurumSogutmasi() yok!!!!!!!
                    ((IKritik)secilenNesne).AcilDurumSogutmasi();
                }
                else
                {
                    System.out.println("Bu nesne soğutulamaz...");
                }
            }

            else if (secim == 5)
            {
                break;
            }
            else { 
                sc.close();
                continue; }
        }
    }
}