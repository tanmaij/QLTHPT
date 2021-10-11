using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class CHUCVUDTO
    {
        private string _macv;


        private string _tencv;

        public string macv
        {
            get { return _macv; }
            set { _macv = value; }
        }
        public string tencv
        {
            get { return _tencv; }
            set { _tencv = value; }
        }
        public CHUCVUDTO()
        {
            _macv = "";
            _tencv = "";


        }
        public CHUCVUDTO(string MaCV,string TenCV)
        {
            _macv = MaCV;
            _tencv = TenCV;
        }
    }
}
