using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DTO
{
    class DIEMTHISINHDTO
    {
        private string _mats;
        
        private float _DIEMTOAN ;
        private float _DIEMNV;
        private float _DIEMAV;
        private float _DIEMTONG;

        public string mats
        {
            get { return _mats; }
            set { _mats = value; }
        }
        public float DIEMTOAN
        {
            get { return _DIEMTOAN; }
            set { _DIEMTOAN = value; }
        }
        public float DIEMNV
        {
            get { return _DIEMNV; }
            set { _DIEMNV = value; }
        }

        public float DIEMAV
        {
            get { return _DIEMAV; }
            set { _DIEMAV = value; }
        }
        public float DIEMTONG
        {
            get { return _DIEMTONG; }
            set { _DIEMTONG = value; }
        }
        public DIEMTHISINHDTO()
        {
            _mats = "";
            _DIEMTOAN = 0;
            _DIEMNV = 0;
            _DIEMAV = 0;
            _DIEMTONG = 0;
        }
        public DIEMTHISINHDTO(string MaTS,float DT,float DNV, float DAV,float DTOG)
        {
            _mats = MaTS;
            _DIEMTOAN = DT;
            _DIEMNV = DNV;
            _DIEMAV = DAV;
            _DIEMTONG = DTOG;
        }
    }
}
