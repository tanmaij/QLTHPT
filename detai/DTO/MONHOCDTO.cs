using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class MONHOCDTO
    {
        private string _mamh;
        public string mamh
        {
            get { return _mamh; }
            set { _mamh = value; }
        }
        public MONHOCDTO()
        {
            _mamh = "";
        }
        public MONHOCDTO(string Mamh)
        {
            _mamh = Mamh;
        }
    }
}
