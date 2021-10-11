using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class THISINHDTO
    {
        private string _mats;
        private string _tents;
        private string _ngaysinh;
        private int _gioitinh;
        private string _diachi;

        public string mats
        {
            get { return _mats; }
            set { _mats = value; }
        }
        public string tents
        {
            get { return _tents; }
            set { _tents = value; }
        }
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }

        public int gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public THISINHDTO()
        {
            _mats = "";
            _tents = "";
            _ngaysinh = "";
            _gioitinh = 0;
            _diachi = "";
        }
        public THISINHDTO(string MaTS, string TenTS, String Ngaysinh, int Gioitinh, string Diachi)
        {
            _mats = MaTS;
            _tents = TenTS;
            _ngaysinh = Ngaysinh;
            _gioitinh = Gioitinh;
            _diachi = Diachi;
        }
    }
}
