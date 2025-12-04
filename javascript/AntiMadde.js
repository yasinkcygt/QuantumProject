const KuantumNesnesi = require('./KuantumNesnesi');
const KuantumCokusuException = require('./KuantumCokusuException');

class AntiMadde extends KuantumNesnesi {
    constructor(id, stabilite, tSeviye) {
        super(id, stabilite, tSeviye);
    }

    AnalizEt() {
        let yeniDeger = this.Stabilite - 15;
        if (yeniDeger <= 0) {
            throw new KuantumCokusuException(this.NesneID);
        }
        this.Stabilite = yeniDeger;
        console.log("Evrenin dokusu titriyor...");
    }

    AcilDurumSogutmasi() {
        let yeniDeger = this.Stabilite + 50;
        
        if (!(yeniDeger > 0 && yeniDeger < 100)) {
            this.Stabilite = 100;
            console.log("Sınır değer aşılıyor, nesne 100'e sabitlendi... " + this.Stabilite);
        } else {
            this.Stabilite = yeniDeger;
            console.log("Bu nesne soğutuldu: " + this.Stabilite);
        }
    }
}

module.exports = AntiMadde;