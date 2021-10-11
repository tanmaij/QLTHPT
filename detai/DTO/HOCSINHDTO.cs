using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class HOCSINHDTO
    {
        private string _mahs;
        private string _tenhs;
        private string _ngaysinh;
        private string _diachi;
        private int _gioitinh;


        public string mahs
        {
            get { return _mahs; }
            set { _mahs = value; }
        }
        public string tenhs
        {
            get { return _tenhs; }
            set { _tenhs = value; }
        }
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public int gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public HOCSINHDTO()
        {
            _mahs = "";
            _tenhs = "";
            _ngaysinh = "";
            _diachi = "";


        }
        public HOCSINHDTO(string MaHS, string TenHS,string NgaySinh,string DiaChi,int GioiTinh)
        {
            _mahs = MaHS;
            _tenhs = TenHS;
            _ngaysinh = NgaySinh;
            _diachi = DiaChi;
            _gioitinh = GioiTinh;
        }
    }
}
