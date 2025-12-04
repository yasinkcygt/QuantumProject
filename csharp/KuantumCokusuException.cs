using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Odev4
{
    public class KuantumCokusuException : Exception
    {
        public KuantumCokusuException(string ID) : base($"ID'si {ID} olan nesne patladi...") { }
    }
}
