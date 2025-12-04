class KuantumNesnesi {
    #nesneID;
    #stabilite;
    #tehlikeSeviyesi;

    constructor(nesneid, stabilite, tSeviye) {
        // Abstract Class Koruması
        if (this.constructor === KuantumNesnesi) {
            throw new Error("KuantumNesnesi abstract bir sınıftır, new ile türetilemez!");
        }

        this.NesneID = nesneid;
        this.Stabilite = stabilite;
        this.TehlikeSeviyesi = tSeviye;
    }

    get NesneID() { return this.#nesneID; }
    set NesneID(v) { this.#nesneID = v; }

    get Stabilite() { return this.#stabilite; }
    set Stabilite(v) { 
        if (v > 0 && v < 100) this.#stabilite = v; 
        else this.#stabilite = v; 
    }

    get TehlikeSeviyesi() { return this.#tehlikeSeviyesi; }
    set TehlikeSeviyesi(v) { 
        if (v >= 1 && v <= 10) this.#tehlikeSeviyesi = v;
    }

    AnalizEt() { throw new Error("AnalizEt metodu override edilmelidir!"); }
    
    DurumBilgisi() {
        return `Nesne ID: ${this.NesneID}, Stabilite: ${this.Stabilite}, Tehlike: ${this.TehlikeSeviyesi}`;
    }
}

module.exports = KuantumNesnesi;