using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class NHANVIENDTO
    {
        private string _manv;
        private string _tennv;
        private string _ngaysinh;
        private string _gioitinh;
        private string _diachi;
        private string _ngayvaolam;
        public string manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        public string tennv
        {
            get { return _tennv; }
            set { _tennv = value; }
        }
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string ngayvaolam
        {
            get { return _ngayvaolam; }
            set { _ngayvaolam = value; }
        }
        public NHANVIENDTO()
        {
            _manv = "";
            _tennv = "";
            _ngaysinh = "";
            _gioitinh = "";
            _diachi = "";
            _ngayvaolam = "";
        }
        public NHANVIENDTO(string manv, string tennv, string ngaysinh, string gioitinh, string diachi, string ngayvaolam )
        {
            _manv = manv;
            _tennv = tennv;
            _ngaysinh = ngaysinh;
            _gioitinh = gioitinh;
            _diachi = diachi;
            _ngayvaolam = ngayvaolam;
        }
    }

}
