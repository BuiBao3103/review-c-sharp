using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ChuyenPhatNhanh2h : HoaDon, IDamBaoHangHoa
    {
        private int khoangCach;

        public int KhoangCach { get => khoangCach; set => khoangCach = value; }

        public ChuyenPhatNhanh2h() : base()
        {
        }

        public ChuyenPhatNhanh2h(string maVanDon, string tenNguoiGui, string diaChiNG, string tenNguoiNhan, string diaChiNN, DateTime ngayGui, string tuyen, double soKG, int khoangCach) : base(maVanDon, tenNguoiGui, diaChiNG, tenNguoiNhan, diaChiNN, ngayGui, tuyen, soKG)
        {
            KhoangCach = khoangCach;
        }
        public override double TinhTienCuoc()
        {
            double tienCuoc = 23000;
            if(khoangCach > 4)
            {
                tienCuoc = 23000 + (khoangCach - 4) * 4000;
            }
            return tienCuoc + TinhPhiDamBao(tienCuoc);
        }

        public double TinhPhiDamBao(double tienCuoc)
        {
            return tienCuoc * 0.15;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Khoang cach: " + khoangCach);
        }
    }
}
