public class VeriPaketi extends KuantumNesnesi {
    public VeriPaketi(String id, int stabilite, int tSeviyesi){
        super(id, stabilite, tSeviyesi);
    }

    @Override
    public void analizEt() throws KuantumCokusException{
        int yeniDeger = getStabilite() - 5; 
        if (yeniDeger <= 0) {
            throw new KuantumCokusException(getNesneID());
        }
        setStabilite(yeniDeger);
        System.out.println("Veri icerigi okundu.");
    }
}
