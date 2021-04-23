using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class UcanNesneler
    {
        List<IUcan> _Ucanlar;
        public void TumunuUcur()
        {
            foreach (var item in _Ucanlar)
            {
                item.Uc();
            }
        }
        public UcanNesneler()
        {
            _Ucanlar = new List<IUcan>();
        }
    }
}
