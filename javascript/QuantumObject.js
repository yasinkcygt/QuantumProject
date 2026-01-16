class QuantumObject {
    #objectID;
    #stability;
    #dangerLevel;

    constructor(id, stability, dangerLevel) {
        // C# Abstract Class Koruması
        if (this.constructor === QuantumObject) {
            throw new Error("QuantumObject is an abstract class and cannot be instantiated directly!");
        }

        this.ObjectID = id;
        this.Stability = stability;
        this.DangerLevel = dangerLevel;
    }

    get ObjectID() { return this.#objectID; }
    set ObjectID(v) { this.#objectID = v; }

    get Stability() { return this.#stability; }
    set Stability(v) { 
        // C# encapsulation logic
        if (v >= 0 && v <= 100) this.#stability = v; 
        else console.log("System Alert: Stability must be between 0 and 100.");
    }

    get DangerLevel() { return this.#dangerLevel; }
    set DangerLevel(v) { 
        // C# encapsulation logic
        if (v >= 1 && v <= 10) this.#dangerLevel = v;
        else console.log("System Alert: Danger level must be between 1 and 10.");
    }

    // C# abstract method
    analyze() { throw new Error("Method 'analyze()' must be implemented!"); }
    
    getStatusInfo() {
        return `[ID: ${this.ObjectID}] | Stability: ${this.Stability}% | Danger: ${this.DangerLevel}/10`;
    }
}
module.exports = QuantumObject;