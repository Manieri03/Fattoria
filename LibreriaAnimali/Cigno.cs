using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaAnimali
{
    public class Cigno : Volatile
    {
        public Cigno() { }
        public override string Vola()
        {
            return "Il cigno vola";
        }

        public string Nuota()
        {
            return "Il cigno nuota";
        }
    }
}
