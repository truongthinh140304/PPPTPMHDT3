using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace THLAP8 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ✅ Chuỗi kết nối SQL Server LocalDB (theo file .mdf trên máy bạn)
        string strCon = @"Data Source=ASSUS\TRUONGTHINH;
                  Initial Catalog=QuanLySinhVien;
                  Integrated Security=True";

        SqlConnection sqlCon;

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Mở kết nối
                MoKetNoi();

                // 2️⃣ Truy vấn dữ liệu
                string query = "SELECT * FROM SinhVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SinhVien");

                // 3️⃣ Gắn report
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "THLAP8.rptSinhVien.rdlc";

                // ⚠️ KHỚP TÊN DataSet TRONG REPORT (xem trong Report Data)
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["SinhVien"]);

                // 4️⃣ Làm mới nguồn dữ liệu & hiển thị
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi tải dữ liệu:\n" + ex.Message, "Thông báo");
            }
        }
    }
}
