using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Odev4
{
    internal class VeriPaketi : KuantumNesnesi
    {
        public VeriPaketi(string id, int stabilite, int tseviyesi):base(id, stabilite, tseviyesi)
        {
            NesneID = id;
            Stabilite = stabilite;
            TehlikeSeviyesi = tseviyesi;
        }

        public override void AnalizEt()
        {
            int yeniDeger = Stabilite - 5;
            

            if (yeniDeger <= 0)
            {
                throw new KuantumCokusuException(NesneID);
            }
            Stabilite = yeniDeger;
            Console.WriteLine("Veri icerigi okundu...");

        }
    }
}
