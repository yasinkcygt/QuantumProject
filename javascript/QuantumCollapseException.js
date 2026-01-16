class QuantumCollapseException extends Error {
    constructor(id) {
        // C# : base($"CRITICAL FAILURE...")
        super(`CRITICAL FAILURE: Object with ID '${id}' has collapsed and exploded!`);
        this.name = "QuantumCollapseException";
    }
}
module.exports = QuantumCollapseException;