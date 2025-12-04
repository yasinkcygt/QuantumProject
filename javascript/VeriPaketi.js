const KuantumNesnesi = require('./KuantumNesnesi');
const KuantumCokusuException = require('./KuantumCokusuException');

class VeriPaketi extends KuantumNesnesi {
    constructor(id, stabilite, tseviyesi) {
        super(id, stabilite, tseviyesi);
    }

    AnalizEt() {
        let yeniDeger = this.Stabilite - 5;
        if (yeniDeger <= 0) {
            throw new KuantumCokusuException(this.NesneID);
        }
        this.Stabilite = yeniDeger;
        console.log("Veri icerigi okundu...");
    }
}

module.exports = VeriPaketi;