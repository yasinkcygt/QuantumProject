public abstract class QuantumObject {
    /* * The 'final' keyword is used here because the ObjectID is assigned 
     * once in the constructor and should never change throughout the 
     * lifetime of the object (Immutability).
     */
    private final String objectID; 
    private int stability;
    private int dangerLevel;

    public QuantumObject(String id, int stability, int dangerLevel) {
        this.objectID = id;
        setStability(stability);
        setDangerLevel(dangerLevel);
    }

    public String getObjectID() { return objectID; }

    public int getStability() { return stability; }

    public final void setStability(int stability) {
        // Encapsulation logic: ensuring values stay within bounds
        if (stability >= 0 && stability <= 100) {
            this.stability = stability;
        } else {
            System.out.println("System Alert: Stability must be between 0 and 100.");
        }
    }

    public int getDangerLevel() { return dangerLevel; }

    public final void setDangerLevel(int dangerLevel) {
        if (dangerLevel >= 1 && dangerLevel <= 10) {
            this.dangerLevel = dangerLevel;
        } else {
            System.out.println("System Alert: Danger level must be between 1 and 10.");
        }
    }

    public abstract void analyze() throws QuantumCollapseException;

    public String getStatusInfo() {
        return String.format("[ID: %s] | Stability: %d%% | Danger Level: %d/10", 
                             objectID, stability, dangerLevel);
    }
}