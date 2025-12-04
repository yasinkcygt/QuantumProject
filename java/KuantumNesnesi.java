public abstract class KuantumNesnesi
{
    public String NesneID;
    private int Stabilite;
    private int TehlikeSeviyesi;

    //ctor
    public KuantumNesnesi(String nesneid, int stabilite, int tSeviye)
    {
        NesneID = nesneid;
        Stabilite = stabilite;
        TehlikeSeviyesi= tSeviye;
    }

    public String getNesneID(){
        return NesneID;         //private NesneID
    }

    public void setNesneID(String nesneID){
        this.NesneID = nesneID;
    }

    public int getStabilite(){
        return Stabilite;
    }

    public void setStabilite(int stabilite){
        if(stabilite > 0 && stabilite < 100){
            this.Stabilite = stabilite;
        }else{
            System.out.println("Stabilite 0 ile 100 arasinda olmalidir.");
        }
    }

    public int getTehlikeSeviyesi(){
        return TehlikeSeviyesi;
    }

    public void setTehlikeSeviyesi(int tehlikeSeviyesi){
        if(tehlikeSeviyesi >= 1 && tehlikeSeviyesi <=10){
            this.TehlikeSeviyesi = tehlikeSeviyesi;
        }else{
            System.out.println("Tehlike seviyesi 1 ile 10 arasinde olmalidir.");
        }
    }

    public abstract void analizEt() throws KuantumCokusException;
    public String DurumBilgisi()
    {
        return "Nesne ID'si: " + NesneID + ", mevcut stabilite: " + Stabilite + ", tehlike seviyesi: " +TehlikeSeviyesi;
    }
}