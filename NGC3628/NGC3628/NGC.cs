using System;
using System.Collections.Generic;
using System.Text;

namespace NGC3628
{
    class NGC
    {
        public int kedv;
        public string nezet;

        public NGC(int kedv, string nezet)
        {
            this.kedv = kedv;
            this.nezet = nezet;
        }
        
        public void setKedv(int kedv)
        {
            this.kedv = kedv;
        }

    }
}
