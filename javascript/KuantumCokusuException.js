class KuantumCokusuException extends Error {
    constructor(id) {
        super(`Kuantum Çöküşü! Nesne ID: ${id}`);
        this.name = "KuantumCokusuException";
    }
}

// Dışarıya açıyoruz (Public yapıyoruz)
module.exports = KuantumCokusuException;