
// Custom exception thrown when stability hits zero or below
public class QuantumCollapseException extends Exception {
    public QuantumCollapseException(String id) {
        super("CRITICAL FAILURE: Object with ID '" + id + "' has collapsed and exploded!");
    }
}