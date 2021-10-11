using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class GIAOVIENDTO
    {
            private string _magv;
            private string _tengv;
        private string _ngaysinh;
        private int _gioitinh;
        private string _diachi;
        private string _ngayvaotruong;
        private string _ngaydaday;
        public string magv
            {
                get { return _magv; }
                set { _magv = value; }
            }
            public string tengv
            {
                get { return _tengv; }
                set { _tengv = value; }
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
        public string ngayvaotruong
        {
            get { return _ngayvaotruong; }
            set { _ngayvaotruong = value; }
        }
        public string ngaydaday
        {
            get { return _ngaydaday; }
            set { _ngaydaday = value; }
        }
        public GIAOVIENDTO()
            {
                _magv = "";
                _tengv = "";
            _ngaysinh = "";
            _gioitinh = 0;
            _diachi = "";

            
        }
            public GIAOVIENDTO(string MaGV, string TenGV, string Ngaysinh, int Gioitinh, string Diachi, string Ngayvaotruong,string Ngaydaday)
            {
                _magv = MaGV;
                _tengv = TenGV;
            _ngaysinh = Ngaysinh;
            _gioitinh = Gioitinh;
            _diachi = Diachi;
            _ngayvaotruong = Ngayvaotruong;
            _ngaydaday = Ngaydaday;

        }

    }
}
