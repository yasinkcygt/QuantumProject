const KuantumNesnesi = require('./KuantumNesnesi');
const KuantumCokusuException = require('./KuantumCokusuException');

class KaranlikMadde extends KuantumNesnesi {
    constructor(id, stabilite, tseviyesi) {
        super(id, stabilite, tseviyesi);
    }
    
    AnalizEt() {
        let yeniDeger = this.Stabilite - 15;
        if (yeniDeger <= 0) {
            throw new KuantumCokusuException(this.NesneID);
        }
        this.Stabilite = yeniDeger;
        console.log("Karanlık madde titriyor...");
    }

    AcilDurumSogutmasi() {
        let yeniDeger = this.Stabilite + 50;
        
        if (!(yeniDeger > 0 && yeniDeger < 100)) {
            this.Stabilite = 100;
            console.log("Sınır değer aşılıyor... " + this.Stabilite);
        } else {
            this.Stabilite = yeniDeger;
            console.log("Bu nesne soğutuldu: " + this.Stabilite);
        }
    }
}

module.exports = KaranlikMadde;