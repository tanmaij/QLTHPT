using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class LOPDTO
    {
        
            private string _malop;
            
           


            public string malop
            {
                get { return _malop; }
                set { _malop = value; }
            }
            
            public LOPDTO()
            {
                _malop = "";
               


            }
            public LOPDTO(string MaLop)
            {
                _malop = MaLop;
                
            }
        }
}
