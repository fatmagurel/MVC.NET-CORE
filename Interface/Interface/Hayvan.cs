using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class Hayvan
    {
        public string Cinsi { get; set; }
        public bool Cinsiyet { get; set; }
        public int Kilo { get; set; }
        public int AyakSayisi { get; set; }
        public abstract void Yuru();

        public void SesCikar() 
        {
        }
    }
}
