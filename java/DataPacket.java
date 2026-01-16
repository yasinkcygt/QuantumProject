// DataPacket.java

public class DataPacket extends QuantumObject {
    public DataPacket(String id, int stability, int dangerLevel) {
        super(id, stability, dangerLevel);
    }

    @Override
    public void analyze() throws QuantumCollapseException {
        int newValue = getStability() - 5;
        if (newValue <= 0) throw new QuantumCollapseException(getObjectID());
        setStability(newValue);
        System.out.println("Data decryption successful. Content read.");
    }
}



