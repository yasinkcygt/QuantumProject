using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Odev4
{
    public abstract class KuantumNesnesi
    {
        public string NesneID {  get; set; }
        private int stabilite;
        private int tehlikeSeviyesi;

        public int Stabilite
        {
            get { return stabilite; }
            set
            {
                if (value > 0 && value < 100)
                {
                    stabilite = value;
                }
                else
                {
                    Console.WriteLine("0 ile 100 arasinda olmalidir...");
                }
            }
            
        }

        public int TehlikeSeviyesi
        {
            get { return tehlikeSeviyesi; }
            set
            {
                if (value >= 1 && value <= 10)
                    tehlikeSeviyesi = value;
                else
                    Console.WriteLine("0 ile 10 arasinda olmalidir.");
            }
        }

        //ctor
        public KuantumNesnesi(string nesneid, int stabilite, int tSeviye)
        {
            NesneID = nesneid;
            Stabilite = stabilite;
            TehlikeSeviyesi= tSeviye;
        }

        public abstract void AnalizEt();
        public string DurumBilgisi()
        {
            return $"Nesne ID'si: {NesneID}, mevcut stabilite: {Stabilite}, tehlike seviyesi: {TehlikeSeviyesi}";
        }
    }
}
