using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Kartal : Hayvan, IUcan
    {
        private int _adet;
        public int KanatAdedi { get { return _adet; } set { _adet = value; } }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public override void Yuru()
        {
            //base.Yuru();
        }
    }
}
