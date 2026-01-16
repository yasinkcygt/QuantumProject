const QuantumObject = require('./QuantumObject');
const QuantumCollapseException = require('./QuantumCollapseException');

class DarkMatter extends QuantumObject {
    analyze() {
        let newValue = this.Stability - 15;
        if (newValue <= 0) throw new QuantumCollapseException(this.ObjectID);
        this.Stability = newValue;
        console.log("Dark matter composition analyzed.");
    }

    // ICritical Interface Implementation
    emergencyCooling() {
        let newValue = this.Stability + 50;
        this.Stability = (newValue > 100) ? 99 : newValue;
        console.log(`Cooling successful. Current Stability: ${this.Stability}%`);
    }
}
module.exports = DarkMatter;