using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class HINHANHDTO
    {
        private string _ma;
        private String _hinh;

        public string ma
        {
            get { return _ma; }
            set { _ma = value; }
        }
        public String hinh
        {
            get { return _hinh; }
            set { _hinh = value; }
        }
        public HINHANHDTO()
        {
            _ma = "";
            _hinh = "";
        }
        public HINHANHDTO(String Ma,string hinh)
        {
            _ma = Ma;
            _hinh = hinh;
        }
    }
}
