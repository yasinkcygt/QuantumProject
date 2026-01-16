// AntiMatter.java
public class AntiMatter extends QuantumObject implements ICritical {
    public AntiMatter(String id, int stability, int dangerLevel) {
        super(id, stability, dangerLevel);
    }

    @Override
    public void analyze() throws QuantumCollapseException {
        int newValue = getStability() - 25;
        if (newValue <= 0) throw new QuantumCollapseException(getObjectID());
        setStability(newValue);
        System.out.println("The fabric of the universe trembles during analysis...");
    }

    @Override
    public void emergencyCooling() {
        int newValue = getStability() + 50;
        if (newValue >= 100) {
            System.out.println("Warning: Cooling limit reached. Further cooling impossible.");
        } else {
            setStability(newValue);
            System.out.println("Thermal extraction complete. Stability: " + getStability() + "%");
        }
    }
}