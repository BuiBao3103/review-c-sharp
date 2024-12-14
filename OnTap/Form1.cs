using Microsoft.Data.SqlClient;
using System.Data;

namespace OnTap
{

    public partial class Form1 : Form
    {
        private readonly string _connectionString = "server=localhost;database=QLThietbi;uid=sa;pwd=123456;connect timeout=150;TrustServerCertificate=True;";

        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());

            }
            return dataTable;
        }

        public int ExecuteNonQuery(string sSql)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand mySqlCommand = new SqlCommand(sSql, connection);
                try
                {
                    return mySqlCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());

                }
            }
            return 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ bảng Donvi để đưa vào combobox
            string queryDonVi = "SELECT * FROM Donvi";
            DataTable dataTableDonVi = GetData(queryDonVi);
            cbDonVi.DataSource = dataTableDonVi;
            cbDonVi.DisplayMember = "Tendv";
            cbDonVi.ValueMember = "Madv";

            // Lấy dữ liệu từ bảng LoaiThietBi để đưa vào combobox
            string queryCbLoaiThietBi = "SELECT * FROM LoaiThietBi";
            DataTable dataCbLoaiThietBi = GetData(queryCbLoaiThietBi);
            cbLoaiThietBi.DataSource = dataCbLoaiThietBi;
            cbLoaiThietBi.DisplayMember = "Tenloai";
            cbLoaiThietBi.ValueMember = "Maloai";

            // Lấy dữ liệu từ bảng LoaiThietBi
            string queryLoaiThietBi = "SELECT * FROM LoaiThietBi";
            DataTable dataTableLoaiThietBi = GetData(queryLoaiThietBi);
            tblLoatThietBi.DataSource = dataTableLoaiThietBi;

            // Lấy dữ liệu từ nhiều bảng ThietBi
            string queryThietBi =
                "SELECT tb.*, dv.Tendv, ltb.Tenloai FROM ThietBi tb " +
                " JOIN Donvi dv ON tb.Madv = dv.Madv " +
                " JOIN LoaiThietBi ltb ON tb.Maloai = ltb.Maloai";
            DataTable dataTableThietBi = GetData(queryThietBi);
            tblThietBi.DataSource = dataTableThietBi;
        }

        private void btnThemLTB_Click(object sender, EventArgs e)
        {
            string tenLoai = tbTenLoai.Text;
            string ghiChu = tbGhiChu.Text;

            string queryInsert = $"INSERT INTO LoaiThietBi" +
                $" VALUES (N'{tenLoai}', N'{ghiChu}')";
            if (ExecuteNonQuery(queryInsert) > 0)
            {
                MessageBox.Show("Thêm loại thiết bị thành công!");
                Form1_Load(sender, e); // Reload data
            }
        }

        private void btnSuaLTB_Click(object sender, EventArgs e)
        {
            int maLoai = Convert.ToInt32(tblLoatThietBi.SelectedRows[0].Cells["Maloai"].Value);
            string tenLoai = tbTenLoai.Text;
            string ghiChu = tbGhiChu.Text;

            string queryUpdate = $"UPDATE LoaiThietBi SET Tenloai = N'{tenLoai}', Ghichu = N'{ghiChu}' WHERE Maloai = {maLoai}";

            if (ExecuteNonQuery(queryUpdate) > 0)
            {
                MessageBox.Show("Cập nhật loại thiết bị thành công!");
                Form1_Load(sender, e); // Reload data
            }
        }

        private void btnXoaLTB_Click(object sender, EventArgs e)
        {
            int maLoai = Convert.ToInt32(tblLoatThietBi.SelectedRows[0].Cells["Maloai"].Value);

            string queryDelete = $"DELETE FROM LoaiThietBi WHERE Maloai = {maLoai}";

            if (ExecuteNonQuery(queryDelete) > 0)
            {
                MessageBox.Show("Xóa loại thiết bị thành công!");
                Form1_Load(sender, e); // Reload data
            }
        }

        private void btnClearLTB_Click(object sender, EventArgs e)
        {
            tbTenLoai.Clear();
            tbGhiChu.Clear();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            int maDonVi = Convert.ToInt32(cbDonVi.SelectedValue);
            int maLoai = Convert.ToInt32(cbLoaiThietBi.SelectedValue);
            string tenThietBi = tbTenThietBi.Text;
            string nuocSanXuat = tbNuocSX.Text;
            string namSanXuat = tbNamSX.Text;
            string ngaySuDung = tbNgaySD.Text;
            string ghiChu = tbGhiChuTB.Text;

            string queryInsert = $"INSERT INTO ThietBi" +
                $" VALUES ({maDonVi}, {maLoai}, N'{tenThietBi}', N'{nuocSanXuat}', N'{namSanXuat}', N'{ngaySuDung}', N'{ghiChu}')";
            if (ExecuteNonQuery(queryInsert) > 0)
            {
                MessageBox.Show("Thêm thiết bị thành công!");
                Form1_Load(sender, e); // Reload data
            }
        }
    }
}