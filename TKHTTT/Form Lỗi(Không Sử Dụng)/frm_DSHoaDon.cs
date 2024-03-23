using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySach.Class;
using System.Data.SqlClient;

namespace TKHTTT
{
    public partial class frm_DSHoaDon : Form
    {
        DataTable dboDS;
        public frm_DSHoaDon()
        {
            InitializeComponent();
            Ham.Connect();
        }

        private void frm_DSHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHD,TenKH,HoTenNV,NgayLap,GiamGia,TienTToan FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaKH=KhachHang.MaKH AND HoaDon.MaNV=NhanVien.MaNV";
            dboDS = Ham.GetDataToTable(sql);
            dt_dsHD.DataSource = dboDS;
            dt_dsHD.Columns[0].HeaderText = "Mã Hóa Đơn";
            dt_dsHD.Columns[1].HeaderText = "Tên Khách Hàng";
            dt_dsHD.Columns[2].HeaderText = "Nhân Viên Bán";
            dt_dsHD.Columns[3].HeaderText = "Ngày Lập";
            dt_dsHD.Columns[4].HeaderText = "Giảm Giá";
            dt_dsHD.Columns[5].HeaderText = "Thành Tiền";
            dt_dsHD.Columns[0].Width = 147;
            dt_dsHD.Columns[1].Width = 200;
            dt_dsHD.Columns[2].Width = 180;
            dt_dsHD.Columns[3].Width = 140;
            dt_dsHD.Columns[4].Width = 102;
            dt_dsHD.Columns[5].Width = 102;
            dt_dsHD.AllowUserToAddRows = false;
            dt_dsHD.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_dsHD.AllowUserToResizeColumns = false;
            dt_dsHD.AllowUserToDeleteRows = false;
            dt_dsHD.AutoGenerateColumns = false;
            dt_dsHD.AllowUserToAddRows = false;
            if (dt_dsHD.Rows.Count != 0)
            {
                dt_dsHD.CurrentCell.Selected = true;
            }
        }
        public void LoadDataGridView2()
        {
            dt_dsHD.DataSource = dboDS;
            dt_dsHD.Columns[0].HeaderText = "Mã Hóa Đơn";
            dt_dsHD.Columns[1].HeaderText = "Tên Khách Hàng";
            dt_dsHD.Columns[2].HeaderText = "Nhân Viên Bán";
            dt_dsHD.Columns[3].HeaderText = "Ngày Lập";
            dt_dsHD.Columns[4].HeaderText = "Giảm Giá";
            dt_dsHD.Columns[5].HeaderText = "Thành Tiền";
            dt_dsHD.Columns[0].Width = 147;
            dt_dsHD.Columns[1].Width = 200;
            dt_dsHD.Columns[2].Width = 180;
            dt_dsHD.Columns[3].Width = 140;
            dt_dsHD.Columns[4].Width = 102;
            dt_dsHD.Columns[5].Width = 102;
            dt_dsHD.AllowUserToAddRows = false;
            dt_dsHD.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_dsHD.AllowUserToResizeColumns = false;
            dt_dsHD.AllowUserToDeleteRows = false;
            dt_dsHD.AutoGenerateColumns = false;
            dt_dsHD.AllowUserToAddRows = false;
            if (dt_dsHD.Rows.Count != 0)
            {
                dt_dsHD.CurrentCell.Selected = true;
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_timkiem.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Từ Khóa Tìm Kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cb_timloai.SelectedItem.ToString() == "Mã Hóa Đơn")
                {
                    sql = "SELECT MaHD,TenKH,HoTenNV,NgayLap,GiamGia,TienTToan FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaKH=KhachHang.MaKH AND HoaDon.MaNV=NhanVien.MaNV AND MaHD like '%" + txt_timkiem.Text.Trim() + "%'";
                    dboDS = Ham.GetDataToTable(sql);
                    if (dboDS.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu bạn tìm kiếm vui lòng thử tìm kiếm từ khóa thích hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LoadDataGridView2();
                        for (int i = 0; i < Ham.GetDataToTable(sql).Rows.Count; i++)
                        {
                            dt_dsHD.DataSource = Ham.GetDataToTable(sql);
                        }
                        this.dt_dsHD.Sort(this.dt_dsHD.Columns["MaHD"], ListSortDirection.Ascending);
                    }
                }
                if (cb_timloai.SelectedItem.ToString() == "Tên Khách Hàng")
                {
                    sql = "SELECT MaHD,TenKH,HoTenNV,NgayLap,GiamGia,TienTToan FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaKH=KhachHang.MaKH AND HoaDon.MaNV=NhanVien.MaNV AND TenKH like N'%" + txt_timkiem.Text.Trim() + "%'";
                    dboDS = Ham.GetDataToTable(sql);
                    if (dboDS.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu bạn tìm kiếm vui lòng thử tìm kiếm từ khóa thích hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LoadDataGridView2();
                        for (int i = 0; i < Ham.GetDataToTable(sql).Rows.Count; i++)
                        {
                            dt_dsHD.DataSource = Ham.GetDataToTable(sql);
                        }
                        this.dt_dsHD.Sort(this.dt_dsHD.Columns["TenKH"], ListSortDirection.Ascending);
                    }

                }
                if (cb_timloai.SelectedItem.ToString() == "Tên Nhân Viên")
                {
                    sql = "SELECT MaHD,TenKH,HoTenNV,NgayLap,GiamGia,TienTToan FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaKH=KhachHang.MaKH AND HoaDon.MaNV=NhanVien.MaNV AND HoTenNV like N'%" + txt_timkiem.Text.Trim() + "%'";
                    dboDS = Ham.GetDataToTable(sql);
                    if (dboDS.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu bạn tìm kiếm vui lòng thử tìm kiếm từ khóa thích hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LoadDataGridView2();
                        for (int i = 0; i < Ham.GetDataToTable(sql).Rows.Count; i++)
                        {
                            dt_dsHD.DataSource = Ham.GetDataToTable(sql);
                        }
                        this.dt_dsHD.Sort(this.dt_dsHD.Columns["HoTenNV"], ListSortDirection.Ascending);
                    }

                }
                if (cb_timloai.SelectedItem.ToString() == "Mã Nhân Viên")
                {
                    sql = "SELECT MaHD,TenKH,HoTenNV,NgayLap,GiamGia,TienTToan FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaKH=KhachHang.MaKH AND HoaDon.MaNV=NhanVien.MaNV AND HoaDon.MaNV like N'%" + txt_timkiem.Text.Trim() + "%'";
                    dboDS = Ham.GetDataToTable(sql);
                    if (dboDS.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu bạn tìm kiếm vui lòng thử tìm kiếm từ khóa thích hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LoadDataGridView2();
                        for (int i = 0; i < Ham.GetDataToTable(sql).Rows.Count; i++)
                        {
                            dt_dsHD.DataSource = Ham.GetDataToTable(sql);
                        }
                        this.dt_dsHD.Sort(this.dt_dsHD.Columns["HoTenNV"], ListSortDirection.Ascending);
                    }
                }
                if (cb_timloai.SelectedItem.ToString() == "Mã Khách Hàng")
                {
                    sql = "SELECT MaHD,TenKH,HoTenNV,NgayLap,GiamGia,TienTToan FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaKH=KhachHang.MaKH AND HoaDon.MaNV=NhanVien.MaNV AND HoaDon.MaKH like N'%" + txt_timkiem.Text.Trim() + "%'";
                    dboDS = Ham.GetDataToTable(sql);
                    if (dboDS.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu bạn tìm kiếm vui lòng thử tìm kiếm từ khóa thích hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LoadDataGridView2();
                        for (int i = 0; i < Ham.GetDataToTable(sql).Rows.Count; i++)
                        {
                            dt_dsHD.DataSource = Ham.GetDataToTable(sql);
                        }
                        this.dt_dsHD.Sort(this.dt_dsHD.Columns["TenKH"], ListSortDirection.Ascending);
                    }

                }
                if (cb_timloai.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Bạn Chưa Chọn Loại Tìm Kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    return;
                }
            }
        }

        private void dt_dsHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dboDS.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_MaHD.Text = dt_dsHD.CurrentRow.Cells["MaHD"].Value.ToString();
            txt_maKH.Text = Ham.GetFieldValues("Select MaKH from HoaDon Where MaHD='" + txt_MaHD.Text.Trim() + "'");
            txt_maNV.Text = Ham.GetFieldValues("Select MaNV from HoaDon Where MaHD='" + txt_MaHD.Text.Trim() + "'");
            txt_ngaylap.Text = dt_dsHD.CurrentRow.Cells["NgayLap"].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dboDS.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE dbo.CTHoaDon WHERE MaHD='" + txt_MaHD.Text.Trim() + "'";
                Ham.RunSQL(sql);
                sql = "DELETE dbo.HoaDon WHERE MaHD='" + txt_MaHD.Text.Trim() + "'";
                Ham.RunSqlDel(sql);
                LoadDataGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            form_CTHD.MaHD = txt_MaHD.Text.Trim();
            form_CTHD frm_CTHD = new form_CTHD();
            frm_CTHD.ShowDialog();
        }
    }
}
