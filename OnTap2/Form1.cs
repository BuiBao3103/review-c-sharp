using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap2
{

    public partial class Form1 : Form
    {
        private readonly qlthietbiEntities _db = new qlthietbiEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDonViTB.DataSource = _db.Donvis.ToList();
            cbDonViTB.DisplayMember = "Tendv";
            cbDonViTB.ValueMember = "Madv";

            cbLoaiThietBiTB.DataSource = _db.Loaithietbis.ToList();
            cbLoaiThietBiTB.DisplayMember = "Tenloai";
            cbLoaiThietBiTB.ValueMember = "Maloai";

            var queryLoaiThietBi = from ltb in _db.Loaithietbis
                                   select new
                                   {
                                       ltb.Maloai,
                                       ltb.Tenloai,
                                       ltb.Ghichu
                                   };
            dgvLoaiThietBi.DataSource = queryLoaiThietBi.ToList();

            var queryThietBi = from tb in _db.Thietbis
                               join ltb in _db.Loaithietbis on tb.Maloai equals ltb.Maloai
                               join dv in _db.Donvis on tb.Madv equals dv.Madv
                               select new
                               {
                                   tb.Matb,
                                   tb.Tentb,
                                   tb.Nuocsx,
                                   tb.Namsx,
                                   tb.Ngaysd,
                                   tb.Ghichu,
                                   ltb.Tenloai,
                                   dv.Tendv
                               };
            dgvThietBi.DataSource = queryThietBi.ToList();

            cbDonViTBTimKiem.DataSource = _db.Donvis.ToList();
            cbDonViTBTimKiem.DisplayMember = "Tendv";
            cbDonViTBTimKiem.ValueMember = "Madv";
        }

        private void btnThemLTB_Click(object sender, EventArgs e)
        {

            try
            {
                Loaithietbi loaiThietBi = new Loaithietbi
                {
                    Tenloai = tbTenLoaiLTB.Text,
                    Ghichu = tbGhiChuLTB.Text
                };

                _db.Loaithietbis.Add(loaiThietBi);
                _db.SaveChanges();

                MessageBox.Show("Thêm thành công!", "Thông báo");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi");
            }
        }

        private void btnSuaLTB_Click(object sender, EventArgs e)
        {
            try
            {
                int maloai = Convert.ToInt32(dgvLoaiThietBi.SelectedRows[0].Cells["Maloai"].Value);
                Loaithietbi loaiThietBi = _db.Loaithietbis.Find(maloai);
                loaiThietBi.Tenloai = tbTenLoaiLTB.Text;
                loaiThietBi.Ghichu = tbGhiChuLTB.Text;

                _db.SaveChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi");
            }

        }

        private void btnXoaLTB_Click(object sender, EventArgs e)
        {
            try
            {
                int maloai = Convert.ToInt32(dgvLoaiThietBi.SelectedRows[0].Cells["Maloai"].Value);
                Loaithietbi loaiThietBi = _db.Loaithietbis.Find(maloai);
                _db.Loaithietbis.Remove(loaiThietBi);
                _db.SaveChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi");
            }
        }

        private void btnClearLTB_Click(object sender, EventArgs e)
        {
            tbGhiChuLTB.Clear();
            tbTenLoaiLTB.Clear();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            try
            {
                Thietbi thietBi = new Thietbi
                {
                    Tentb = tbTenTB.Text,
                    Nuocsx = tbNuocSXTB.Text,
                    Namsx = int.Parse(tbNamSXTB.Text),
                    Ngaysd = tbNgaySDTB.Text,
                    Ghichu = tbGhiChuTB.Text,
                    Maloai = Convert.ToInt32(cbLoaiThietBiTB.SelectedValue),
                    Madv = Convert.ToInt32(cbDonViTB.SelectedValue)
                };

                _db.Thietbis.Add(thietBi);
                _db.SaveChanges();

                MessageBox.Show("Thêm thành công!", "Thông báo");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi");
            }
        }

        private void btnTimKiemTheoDonVi_Click(object sender, EventArgs e)
        {
            int maDv = Convert.ToInt32(cbDonViTBTimKiem.SelectedValue);
            var query = from dv in _db.Donvis
                        join tb in _db.Thietbis on dv.Madv equals tb.Madv
                        join ltb in _db.Loaithietbis on tb.Maloai equals ltb.Maloai
                        where dv.Madv == maDv
                        select new
                        {
                            dv.Tendv,
                            ltb.Tenloai,
                            tb.Tentb,
                            tb.Nuocsx,
                            tb.Namsx,
                            tb.Ngaysd,
                        };

            dgvThietBi.DataSource = query.ToList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenDv = tbThietBiTimKiem.Text;
            var query = from tb in _db.Thietbis
                        where tb.Tentb.Contains(tenDv)
                        select new
                        {
                            tb.Matb,
                            tb.Tentb,
                            tb.Nuocsx,
                            tb.Namsx,
                            tb.Ngaysd,
                        };
            dgvThietBi.DataSource = query.ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
