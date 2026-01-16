// DarkMatter.java

public class DarkMatter extends QuantumObject implements ICritical {
    public DarkMatter(String id, int stability, int dangerLevel) {
        super(id, stability, dangerLevel);
    }

    @Override
    public void analyze() throws QuantumCollapseException {
        int newValue = getStability() - 15;
        if (newValue <= 0) throw new QuantumCollapseException(getObjectID());
        setStability(newValue);
        System.out.println("Dark matter composition analyzed.");
    }

    @Override
    public void emergencyCooling() {
        int newValue = getStability() + 50;
        setStability(newValue >= 100 ? 99 : newValue);
        System.out.println("Cooling successful. Current Stability: " + getStability() + "%");
    }
}