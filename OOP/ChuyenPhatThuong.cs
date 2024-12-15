using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ChuyenPhatThuong : HoaDon
    {
        private int soLanGui;

        public int SoLanGui { get => soLanGui; set => soLanGui = value; }

        public ChuyenPhatThuong() : base()
        {
        }

        public ChuyenPhatThuong(string maVanDon, string tenNguoiGui, string diaChiNG, string tenNguoiNhan, string diaChiNN, DateTime ngayGui, string tuyen, double soKG, int soLanGui) : base(maVanDon, tenNguoiGui, diaChiNG, tenNguoiNhan, diaChiNN, ngayGui, tuyen, soKG)
        {
            SoLanGui = soLanGui;
        }
        public override double TinhTienCuoc()
        {
            double tienCuoc;
            if (soKG <= 5)
                tienCuoc = soKG * 8000;
            else
                tienCuoc = 40000 + (soKG - 5) * 10000;

            if (tienCuoc > 50000 && soLanGui > 20)
                tienCuoc = 50000;
            return tienCuoc;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So lan gui: " + soLanGui);
        }
    }
}