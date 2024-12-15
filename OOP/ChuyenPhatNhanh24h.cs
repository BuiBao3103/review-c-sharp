using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ChuyenPhatNhanh24h : HoaDon, IDamBaoHangHoa
    {
        private int kichThuoc;

        public int KichThuoc { get => kichThuoc; set => kichThuoc = value; }

        public ChuyenPhatNhanh24h() : base()
        {
        }

        public ChuyenPhatNhanh24h(string maVanDon, string tenNguoiGui, string diaChiNG, string tenNguoiNhan, string diaChiNN, DateTime ngayGui, string tuyen, double soKG, int kichThuoc) : base(maVanDon, tenNguoiGui, diaChiNG, tenNguoiNhan, diaChiNN, ngayGui, tuyen, soKG)
        {
            KichThuoc = kichThuoc;
        }


        public override double TinhTienCuoc()
        {
            double phiVuotKho = 0;

            if (kichThuoc >= 50)
            {
                phiVuotKho = (kichThuoc - 50) * 1000;
            }
            double tienCuoc = 20000 + soKG * 2000 + phiVuotKho;

            return tienCuoc + PhiDamBao(tienCuoc);
        }

        public double PhiDamBao(double tienCuoc)
        {
            return tienCuoc * 0.1;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Kich thuoc: " + kichThuoc);
        }
    }
}