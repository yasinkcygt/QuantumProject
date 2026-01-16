const QuantumObject = require('./QuantumObject');
const QuantumCollapseException = require('./QuantumCollapseException');

class AntiMatter extends QuantumObject {
    analyze() {
        let newValue = this.Stability - 25;
        if (newValue <= 0) throw new QuantumCollapseException(this.ObjectID);
        this.Stability = newValue;
        console.log("The fabric of the universe trembles during analysis...");
    }

    // ICritical Interface Implementation
    emergencyCooling() {
        let newValue = this.Stability + 50;
        if (newValue >= 100) {
            console.log("Warning: Cooling limit reached. Further cooling impossible.");
            return;
        }
        this.Stability = newValue;
        console.log(`Thermal extraction complete. Stability: ${this.Stability}%`);
    }
}
module.exports = AntiMatter;