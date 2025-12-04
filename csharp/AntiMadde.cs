using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Odev4
{
    internal class AntiMadde : KuantumNesnesi, IKritik
    {
        public AntiMadde(string id, int stabilite, int tseviyesi) : base(id, stabilite, tseviyesi)
        {
            NesneID = id;
            Stabilite = stabilite;
            TehlikeSeviyesi = tseviyesi;
        }

        public override void AnalizEt()
        {
            int yeniDeger = Stabilite - 25;


            if (yeniDeger <= 0)
            {
                throw new KuantumCokusuException(NesneID);
            }
            Stabilite = yeniDeger;
            Console.WriteLine("Evrenin dokusu titriyor...");
        }

        public void AcilDurumSogutmasi()
        {
            int yeniDeger = Stabilite + 50;
            if (!(yeniDeger > 0 && yeniDeger < 100))
            {
                Console.WriteLine("Sınır değer aşılıyor, nesne soğutulamaz...");
                return;
            }
            Stabilite = yeniDeger;
            Console.WriteLine($"Bu nesne soğutuldu: {Stabilite}");
        }
    }
}
