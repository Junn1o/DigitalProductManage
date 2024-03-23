using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySach.Class;

namespace TKHTTT
{
    public partial class form_CTHD : Form
    {
        DataTable dboCTHDB;
        public static string MaHD;
        public form_CTHD()
        {
            InitializeComponent();
            Ham.Connect();
        }
        private void dt_DB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // buộc người dùng phải nhập hóa đơn trước
            if (txt_mhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa load hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mhd.Focus();
            }
            else if (txt_tenkh.Text == "")
            {
                MessageBox.Show("Bạn chưa load hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mhd.Focus();
            }
            else if (txt_tennv.Text == "")
            {
                MessageBox.Show("Bạn chưa load hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mhd.Focus();
            }
            else
            {
                txt_masach.Text = dt_DGV.CurrentRow.Cells["MaSach"].Value.ToString();
                txt_tensach.Text = dt_DGV.CurrentRow.Cells["TenSach"].Value.ToString();
                txt_tacgia.Text = Ham.GetFieldValues("Select TacGia from SanPham where MaSach='" + txt_masach.Text + "'");
                txt_theloai.Text = Ham.GetFieldValues("Select TenNhom FROM dbo.SanPham,dbo.NhomSP WHERE SanPham.MaNhomSach=NhomSP.MaNhomSach AND MaSach='" + txt_masach.Text + "'");
                txt_dongia.Text = Ham.GetFieldValues("Select Gia from SanPham where MaSach='" + txt_masach.Text + "'");
            }
        }


        private void frm_CBH_Load(object sender, EventArgs e)
        {
            Ham.FillCombo("SELECT MaKH, TenKH FROM dbo.KhachHang", cb_mkh, "MaKH", "MaKH");
            cb_mkh.SelectedIndex = -1;
            Ham.FillCombo("SELECT MaNV, HoTenNV FROM dbo.NhanVien", cb_manv, "MaNV", "MaNV");
            cb_manv.SelectedIndex = -1;
            LoadDataGridView();
            DefautValue();
            txt_mhd.Text = MaHD;
            if (txt_mhd.Text != "")
            {
                string sql, sql1, sql2;
                sql = "SELECT MaHD FROM dbo.CTHoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_mhd.Text = Ham.GetFieldValues(sql);
                LoadDataGridView();
                sql1 = "Select MaNV from HoaDon Where MaHD='" + txt_mhd.Text + "'";
                cb_manv.Text = Ham.GetFieldValues(sql1);
                sql2 = "Select MaKH from HoaDon Where MaHD='" + txt_mhd.Text + "'";
                cb_mkh.Text = Ham.GetFieldValues(sql2);
                sql1 = "Select TienTToan From dbo.HoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_tongtien.Text = Ham.GetFieldValues(sql1);
                sql1 = "Select GiamGia From dbo.HoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_giamgia.Text = Ham.GetFieldValues(sql1);
                sql1 = "Select NgayLap From dbo.HoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_ngayban.Text = Ham.GetFieldValues(sql1);
            }
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaSP,a.TenSP,b.Tien FROM dbo.SanPham AS a INNER JOIN dbo.CTHoaDon AS b ON b.MaSP = a.MaSP INNER JOIN dbo.HoaDon AS c ON c.MaHD = b.MaHD WHERE c.MaHD='" + txt_mhd.Text + "'";
            dboCTHDB = Ham.GetDataToTable(sql);
            dt_DGV.DataSource = dboCTHDB;
            dt_DGV.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);
            dt_DGV.Columns[0].HeaderText = "Mã SP";
            dt_DGV.Columns[1].HeaderText = "Tên SP";
            dt_DGV.Columns[2].HeaderText = "Đơn giá";
            dt_DGV.Columns[0].Width = 93;
            dt_DGV.Columns[1].Width = 325;
            dt_DGV.Columns[2].Width = 87;
            this.dt_DGV.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dt_DGV.AllowUserToAddRows = false;
            dt_DGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_DGV.AllowUserToResizeColumns = false;
            dt_DGV.AllowUserToDeleteRows = false;
            dt_DGV.AutoGenerateColumns = false;
            dt_DGV.AllowUserToAddRows = false;
            if (dt_DGV.Rows.Count != 0)
            {
                dt_DGV.CurrentCell.Selected = true;
            }
            if (txt_giamgia.Text=="0")
            {
                lb_giamgia.Visible = false;
            }
            txt_tennv.ReadOnly = true;
            txt_sdtnv.ReadOnly = true;
            txt_dcnv.ReadOnly = true;
            txt_tenkh.ReadOnly = true;
            txt_diachi.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            txt_masach.ReadOnly = true;
            txt_theloai.ReadOnly = true;
            txt_tensach.ReadOnly = true;
            txt_dongia.ReadOnly = true;
            txt_tacgia.ReadOnly = true;

        }
        private void DefautValue()
        {
            txt_tenkh.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_tennv.Text = "";
            txt_sdtnv.Text = "";
            txt_dcnv.Text = "";
            txt_masach.Text = "";
            txt_theloai.Text = "";
            txt_tensach.Text = "";
            txt_dongia.Text = "";
            txt_tacgia.Text = "";
            txt_mhd.Text = "";
            txt_ngayban.Text = "";
            txt_giamgia.Text = "0";
            txt_tongtien.Text = "0";
            cb_manv.SelectedIndex = -1;
            cb_mkh.SelectedIndex = -1;
            ResetPermit();
        }
        private void ResetPermit()
        {
            cb_manv.Enabled = false;
            cb_mkh.Enabled = false;
            txt_tennv.ReadOnly = true;
            txt_sdtnv.ReadOnly = true;
            txt_dcnv.ReadOnly = true;
            txt_tenkh.ReadOnly = true;
            txt_diachi.ReadOnly = true;
            txt_sdt.ReadOnly = true;
        }
        private void Permit()
        {
            cb_manv.Enabled = true;
            cb_mkh.Enabled = true;
            txt_tennv.ReadOnly = false;
            txt_sdtnv.ReadOnly = false;
            txt_dcnv.ReadOnly = false;
            txt_tenkh.ReadOnly = false;
            txt_diachi.ReadOnly = false;
            txt_sdt.ReadOnly = false;
        }
        private void cb_manv_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cb_manv.Text == "")
            {
                txt_tennv.Text = "";
                txt_sdtnv.Text = "";
                txt_dcnv.Text = "";
            }
            str = "Select HoTenNV from dbo.NhanVien where MaNV ='" + cb_manv.SelectedValue + "'";
            txt_tennv.Text = Ham.GetFieldValues(str);
            str = "Select DiaChi from dbo.NhanVien where MaNV = '" + cb_manv.SelectedValue + "'";
            txt_dcnv.Text = Ham.GetFieldValues(str);
            str = "Select SDTNV from dbo.NhanVien where MaNV= '" + cb_manv.SelectedValue + "'";
            txt_sdtnv.Text = Ham.GetFieldValues(str);
        }

        private void cb_mkh_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cb_mkh.Text == "")
            {
                txt_tenkh.Text = "";
                txt_diachi.Text = "";
                txt_sdt.Text = "";
            }
            str = "Select TenKH from dbo.KhachHang where MaKH = '" + cb_mkh.SelectedValue + "'";
            txt_tenkh.Text = Ham.GetFieldValues(str);
            str = "Select Dchi from dbo.KhachHang where MaKH = '" + cb_mkh.SelectedValue + "'";
            txt_diachi.Text = Ham.GetFieldValues(str);
            str = "Select SDTKH from dbo.KhachHang where MaKH= '" + cb_mkh.SelectedValue + "'";
            txt_sdt.Text = Ham.GetFieldValues(str);
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_mhd.Text != "")
            {
                string sql, sql1, sql2;
                sql = "SELECT MaHD FROM dbo.CTHoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_mhd.Text = Ham.GetFieldValues(sql);
                LoadDataGridView();
                sql1 = "Select MaNV from HoaDon Where MaHD='" + txt_mhd.Text + "'";
                cb_manv.Text = Ham.GetFieldValues(sql1);
                sql2 = "Select MaKH from HoaDon Where MaHD='" + txt_mhd.Text + "'";
                cb_mkh.Text = Ham.GetFieldValues(sql2);
                sql1 = "Select TongTien From dbo.HoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_tongtien.Text = Ham.GetFieldValues(sql1);
                sql1 = "Select GiamGia From dbo.HoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_giamgia.Text = Ham.GetFieldValues(sql1);
                sql1 = "Select NgayLap From dbo.HoaDon Where MaHD='" + txt_mhd.Text + "'";
                txt_ngayban.Text = Ham.GetFieldValues(sql1);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mhd.Focus();
            }

        }

        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            if (txt_giamgia.Visible==true)
            {
                if(Convert.ToInt32(txt_giamgia.Text)>1000)
                {
                    lb_giamgia.Text = "đ(ngàn đồng)";
                }
                else
                {
                    lb_giamgia.Text = "%(phần trăm)";
                }
            }
        }

        private void bt_huyload_Click(object sender, EventArgs e)
        {
                dt_DGV.DataSource = null;
                dt_DGV.Refresh();
                DefautValue();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            frm_DonDatHang frm_DonDatHang = new frm_DonDatHang();
            frm_DonDatHang.ShowDialog();
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}