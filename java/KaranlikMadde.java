public class KaranlikMadde extends KuantumNesnesi implements  IKritik
{
    public KaranlikMadde(String id, int stabilite, int tseviyesi)
    {
        super(id, stabilite, tseviyesi);
    }

    @Override
    public void analizEt() throws KuantumCokusException
    {
        int yeniDeger = getStabilite() - 15;
        if (yeniDeger <= 0)
        {
            throw new KuantumCokusException(getNesneID());
        }
        setStabilite(yeniDeger);
    }
    
    @Override
    public void AcilDurumSogutmasi()
    {   
        int yeniDeger = getStabilite() + 50;
        if (!(yeniDeger > 0 && yeniDeger< 100))
        {
            System.out.println("Sınır değer aşılıyor...");
            return;
        }
        setStabilite(yeniDeger);
        System.out.println("Bu nesne soğutuldu: " +  getStabilite());
    }
}