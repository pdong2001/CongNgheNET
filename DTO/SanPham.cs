using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class SanPham
    {
        private string maSP, tenSP, xuatSu;
        private int soLuong, giaBan;
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string XuatSu { get => xuatSu; set => xuatSu = value; }

        public int SoLuong { get => soLuong; set => soLuong = value >= 0 ? value : 0; }
        public int GiaBan { get => giaBan; set => giaBan = value >= 0 ? value : 0; }

        public SanPham(DataRow Row)
        {
            MaSP = Row["MaSP"].ToString();
            TenSP = Row["TenSP"].ToString();
            SoLuong = (int)Row["SoLuong"];
            GiaBan = (int)Row["GiaBan"];
            XuatSu = Row["XuatSu"].ToString();
        }
    }
}
