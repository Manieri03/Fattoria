using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaAnimali
{
    public class PesceVolante : Pesce
    {
        public PesceVolante() { }
        public override string Nuota()
        {
            return "Il pesce volante nuota";
        }

        public string Vola()
        {
            return "Il pesce volante vola";
        }
    }
}
