const QuantumObject = require('./QuantumObject');
const QuantumCollapseException = require('./QuantumCollapseException');

class DataPacket extends QuantumObject {
    analyze() {
        let newValue = this.Stability - 5;
        if (newValue <= 0) throw new QuantumCollapseException(this.ObjectID);
        this.Stability = newValue;
        console.log("Data decryption successful. Content read.");
    }
}
module.exports = DataPacket;