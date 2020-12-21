using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaAnimali
{
    public class Fattoria
    {
        public List<Animale> Animali { get; private set; }

        public Fattoria() { }
        public void Adotta(Animale animale)
        {
            Animali.Add(animale);
        }
    }
}
