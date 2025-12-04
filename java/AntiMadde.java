
public class AntiMadde  extends  KuantumNesnesi implements  IKritik{
    
    public AntiMadde(String id, int stabilite, int tseviyesi)
    {
        super(id, stabilite, tseviyesi);
    }
    
    @Override
    public void analizEt() throws KuantumCokusException
    {
        int yeniDeger = getStabilite() - 25;


        if (yeniDeger <= 0)
        {
            throw new KuantumCokusException(getNesneID());
        }
        setStabilite(yeniDeger);
        System.out.println("Evernin dokusu titriyor...");
    }

    @Override
    public void AcilDurumSogutmasi()
    {
        int yeniDeger = getStabilite() + 50;
        if (!(yeniDeger > 0 && yeniDeger < 100))
        {
            System.out.println("Sinir deger asiliyor, nesne sogutulamaz...");
            return;
        }
        setStabilite(yeniDeger);
        System.out.println("Bu nesne soğutuldu: " + getStabilite());
    }
}