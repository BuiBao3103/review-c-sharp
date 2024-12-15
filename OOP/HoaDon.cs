namespace OOP
{
    public abstract class HoaDon
    {
        //Cau 1
        protected string maVanDon;
        protected string tenNguoiGui;
        protected string diaChiNG;
        protected string tenNguoiNhan;
        protected string diaChiNN;
        protected DateTime ngayGui;
        protected string tuyen;
        protected double soKG;

        //Cau 2
        public string MaVanDon
        {
            get { return maVanDon; }
            set
            {
                if (value.Length != 7
                    || !value.StartsWith("KG")
                    || !int.TryParse(value.Substring(value.Length - 5), out _)
                    )
                    maVanDon = "KG00000";
                else
                    maVanDon = value;
            }
        }

        //Cau 3
        public double SoKG
        {
            get { return soKG; }
            set
            {
                if (value < 0)
                    soKG = 0;
                else
                    soKG = value;
            }
        }

        //Cau 4
        public HoaDon()
        {
            MaVanDon = "KG04001";
            TenNguoiGui = "Nguyen Van A";
            DiaChiNG = "123 Nguyen Trai, Q1, TP.HCM";
            TenNguoiNhan = "Nguyen Van B";
            DiaChiNN = "456 Le Loi, Q2, TP.HCM";
            NgayGui = new DateTime();
            Tuyen = "Noi tinh";
            SoKG = 0.35;
        }

        //Cau 5
        public HoaDon(string maVanDon, string tenNguoiGui, string diaChiNG, string tenNguoiNhan, string diaChiNN, DateTime ngayGui, string tuyen, double soKG)
        {
            MaVanDon = maVanDon;
            TenNguoiGui = tenNguoiGui;
            DiaChiNG = diaChiNG;
            TenNguoiNhan = tenNguoiNhan;
            DiaChiNN = diaChiNN;
            NgayGui = ngayGui;
            Tuyen = tuyen;
            SoKG = soKG;
        }
        public string TenNguoiGui { get => tenNguoiGui; set => tenNguoiGui = value; }
        public string DiaChiNG { get => diaChiNG; set => diaChiNG = value; }
        public string TenNguoiNhan { get => tenNguoiNhan; set => tenNguoiNhan = value; }
        public string DiaChiNN { get => diaChiNN; set => diaChiNN = value; }
        public DateTime NgayGui { get => ngayGui; set => ngayGui = value; }
        public string Tuyen { get => tuyen; set => tuyen = value; }

        //Cau 6
        public double TinhChiPhiTT()
        {
            return TinhTienCuoc() + TinhPhiPhuThu();
        }

        public double TinhPhiPhuThu()
        {
            if (Tuyen == "Noi tinh")
                return 22000;
            else if (Tuyen == "Lien tinh")
                return 30000;
            else
                return 0;
        }

        public abstract double TinhTienCuoc();

        public virtual void Xuat()
        {
            Console.WriteLine($"Ma van don: {MaVanDon}");
            Console.WriteLine($"Ten nguoi gui: {TenNguoiGui}");
            Console.WriteLine($"Dia chi nguoi gui: {DiaChiNG}");
            Console.WriteLine($"Ten nguoi nhan: {TenNguoiNhan}");
            Console.WriteLine($"Dia chi nguoi nhan: {DiaChiNN}");
            Console.WriteLine($"Ngay gui: {NgayGui}");
            Console.WriteLine($"Tuyen: {Tuyen}");
            Console.WriteLine($"So KG: {SoKG}");
        }

    }
}
