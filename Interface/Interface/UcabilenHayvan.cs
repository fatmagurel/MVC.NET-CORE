using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class UcabilenHayvan : Hayvan
    {
        public void Uc()
        {

        }

        public override void Yuru()
        {
            Uc();
        }
    }
}
