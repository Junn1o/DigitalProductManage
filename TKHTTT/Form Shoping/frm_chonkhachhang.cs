using QuanLySach.Class;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TKHTTT
{
    public partial class frm_chonkhachhang : Form
    {
        public SendMessage send;
        private DataTable dboKH;
        public frm_chonkhachhang()
        {
            InitializeComponent();
            Ham.Connect();
        }
        public delegate void SendMessage(String value);
        private void dt_kh_Click(object sender, EventArgs e)
        {
            cb_Gioitinh.ResetText();
            txt_mkh.Text = dt_kh.CurrentRow.Cells["MaKH"].Value.ToString();
            txt_tkh.Text = dt_kh.CurrentRow.Cells["TenKH"].Value.ToString();
            cb_Gioitinh.SelectedText = dt_kh.CurrentRow.Cells["GioiTinhKH"].Value.ToString();
            txt_dc.Text = dt_kh.CurrentRow.Cells["DChi"].Value.ToString();
            txt_sdt.Text = dt_kh.CurrentRow.Cells["SDTKH"].Value.ToString();
            if (dt_kh.CurrentRow.Cells["AnhKH"].Value.ToString() != null && dt_kh.CurrentRow.Cells["AnhKH"].Value != DBNull.Value)
            {
                byte[] imgData = (byte[])(dt_kh.CurrentRow.Cells["AnhKH"].Value);
                var stream = new MemoryStream(imgData);
                pictureBox1.Image = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
            mkt_ngaysinh.Text = dt_kh.CurrentRow.Cells["NgaySinhKH"].Value.ToString();
        }
        private void LoadDataGridView()
        {
            OnReadOnly();
            string sql;
            sql = "SELECT * FROM dbo.KhachHang";
            dboKH = Ham.GetDataToTable(sql);
            dt_kh.DataSource = dboKH;
            dt_kh.AllowUserToAddRows = false;
            dt_kh.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_kh.AllowUserToResizeColumns = false;
            dt_kh.AllowUserToDeleteRows = false;
            dt_kh.AutoGenerateColumns = false;
            dt_kh.AllowUserToAddRows = false;
            if (dt_kh.Rows.Count != 0)
            {
                dt_kh.CurrentCell.Selected = true;
            }
            cb_Gioitinh.DataSource = Ham.GetDataToTable("Select DISTINCT GioiTinhKH from KhachHang");
            cb_Gioitinh.ValueMember = "GioiTinhKH";
        }
        private void LoadDataTimKiem(string sql)
        {
            OnReadOnly();
            dboKH = Ham.GetDataToTable(sql);
            dt_kh.DataSource = dboKH;
            dt_kh.AllowUserToAddRows = false;
            dt_kh.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_kh.AllowUserToResizeColumns = false;
            dt_kh.AllowUserToDeleteRows = false;
            dt_kh.AutoGenerateColumns = false;
            dt_kh.AllowUserToAddRows = false;
            if (dt_kh.Rows.Count != 0)
            {
                dt_kh.CurrentCell.Selected = true;
            }
        }

        private void frm_chonkhachhang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void OnReadOnly()
        {
            txt_dc.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            cb_Gioitinh.Enabled = false;
            txt_tkh.ReadOnly = true;
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (cb_timkiem.SelectedItem.ToString() =="Mã Khách Hàng")
            {
                sql = "SELECT * FROM KhachHang Where MaKH Like '%"+txt_timkiem.Text.ToString()+"%'";
                LoadDataTimKiem(sql);
                return;
            }
            if (cb_timkiem.SelectedItem.ToString() == "Tên Khách Hàng")
            {
                sql = "SELECT * FROM KhachHang Where TenKH Like N'%" + txt_timkiem.Text.ToString() + "%'";
                LoadDataTimKiem(sql);
                return;
            }
            if (cb_timkiem.SelectedItem.ToString() == "Số Điện Thoại")
            {
                sql = "SELECT * FROM KhachHang Where SDTKH Like '%" + txt_timkiem.Text.ToString() + "%'";
                LoadDataTimKiem(sql);
                return;
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Loại Tìm Kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            this.send(this.txt_mkh.Text);
            this.Close();
        }
        public frm_chonkhachhang(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }
    }
}
