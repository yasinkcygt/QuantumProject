const readline = require('node:readline/promises');
const { stdin: input, stdout: output } = require('node:process');

// Dosyaları çağırıyoruz (Require = Using)
const VeriPaketi = require('./VeriPaketi');
const KaranlikMadde = require('./KaranlikMadde');
const AntiMadde = require('./AntiMadde');
const KuantumCokusuException = require('./KuantumCokusuException');

async function Main() {
    const rl = readline.createInterface({ input, output });
    const kNList = []; 

    while (true) {
        console.log("\n--- KUANTUM AMBARI (MODÜLER SİSTEM) ---");
        console.log("1. Yeni Nesne Ekle");
        console.log("2. Tüm Envanteri Listele");
        console.log("3. Nesneyi Analiz Et");
        console.log("4. Acil Durum Soğutması Yap");
        console.log("5. Çıkış\n");

        let secimStr = await rl.question("Seçiminiz: ");
        let secim = parseInt(secimStr);

        if (secim === 5) {
            console.log("Çıkış yapılıyor...");
            rl.close();
            process.exit(0);
        }
        
        else if (secim === 1) {
            let sonuc = Math.floor(Math.random() * 3);
            let id = await rl.question("Nesne IDsini girin: ");
            
            let sStr = await rl.question("Nesne stabilitesini girin: ");
            let stabilite = parseInt(sStr);
            
            let tStr = await rl.question("Nesne tehlike seviyesini girin: ");
            let tSeviye = parseInt(tStr);

            let kN = null;

            try {
                switch (sonuc) {
                    case 0: kN = new VeriPaketi(id, stabilite, tSeviye); break;
                    case 1: kN = new KaranlikMadde(id, stabilite, tSeviye); break;
                    case 2: kN = new AntiMadde(id, stabilite, tSeviye); break;
                }
                
                if (kN) {
                    kNList.push(kN); 
                    console.log(`Başarıyla eklendi. Tür: ${kN.constructor.name}`);
                }
            } catch (err) {
                console.log("Hata: " + err.message);
            }
        }

        else if (secim === 2) {
            if (kNList.length === 0) { 
                console.log("\nDepo şu an boş...");
            } else {
                for (let s of kNList) {
                    console.log(s.DurumBilgisi());
                }
            }
        }

        else if (secim === 3) {
            try {
                let girilenID = await rl.question("Lütfen bir NesneID giriniz: ");
                let secilenID = kNList.find(x => x.NesneID == girilenID);

                if (secilenID) {
                    console.log(`Analiz öncesi: ${secilenID.Stabilite}`);
                    secilenID.AnalizEt();
                    console.log(`Analiz sonrası: ${secilenID.Stabilite}`);
                } else {
                    console.log("Bu ID ile bir nesne bulunamadı.");
                }

            } catch (ex) {
                if (ex instanceof KuantumCokusuException) {
                    console.log("\n!!! SİSTEM ÇÖKTÜ (ÖZEL HATA) !!!");
                    console.log(ex.message);
                    process.exit(0);
                } else {
                    console.log("Bilinmeyen hata: " + ex.message);
                }
            }
        }

        else if (secim === 4) {
            let girilenID = await rl.question("Nesne id'si girin: ");
            let secilenID = kNList.find(x => x.NesneID == girilenID);

            if (secilenID) {
                if (typeof secilenID.AcilDurumSogutmasi === 'function') {
                    secilenID.AcilDurumSogutmasi();
                } else {
                    console.log("Bu nesne soğutulamaz (IKritik değil)...");
                }
            } else {
                console.log("Nesne bulunamadı.");
            }
        }
    }
}

Main();