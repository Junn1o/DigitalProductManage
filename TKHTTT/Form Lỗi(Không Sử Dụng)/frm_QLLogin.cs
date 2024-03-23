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
    public partial class frm_QLLogin : Form
    {
        DataTable dboLogin;
        public static string MaNV;
        public frm_QLLogin()
        {
            InitializeComponent();
            Ham.Connect();
        }

        private void frm_QLLogin_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            rd_QT.Checked = true;
            bt_luu.Enabled = false;
            bt_bo.Enabled = false;
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT id, MaNV, TaiKhoan From DangNhap";
            dboLogin = Ham.GetDataToTable(sql);
            dt_Login.DataSource = dboLogin;
            dt_Login.Columns[0].HeaderText = "ID Người Dùng";
            dt_Login.Columns[1].HeaderText = "Mã Nhân Viên";
            dt_Login.Columns[2].HeaderText = "Tài Khoản";
            dt_Login.Columns[0].Width = 150;
            dt_Login.Columns[1].Width = 180;
            dt_Login.Columns[2].Width = 250;
            dt_Login.AllowUserToAddRows = false;
            dt_Login.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_Login.AllowUserToResizeColumns = false;
            dt_Login.AllowUserToDeleteRows = false;
            dt_Login.AutoGenerateColumns = false;
            dt_Login.AllowUserToAddRows = false;
            if (dt_Login.Rows.Count != 0)
            {
                dt_Login.CurrentCell.Selected = true;
            }
            Ham.FillCombo("SELECT MaNV, HoTenNV FROM dbo.NhanVien", cb_nv, "MaNV", "MaNV");
            cb_nv.SelectedIndex = -1;
            this.dt_Login.DefaultCellStyle.Font = new Font("Times New Roman", 15);
            dt_Login.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);
        }

        private void cb_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cb_nv.Text == "")
            {
                txt_ten.Text = "";
                txt_diachi.Text = "";
                txt_sdt.Text = "";
            }
            str = "Select HoTenNV from dbo.NhanVien where MaNV = '" + cb_nv.SelectedValue + "'";
            txt_ten.Text = Ham.GetFieldValues(str);
            str = "Select DiaChi from dbo.NhanVien where MaNV = '" + cb_nv.SelectedValue + "'";
            txt_diachi.Text = Ham.GetFieldValues(str);
            str = "Select SDTNV from dbo.NhanVien where MaNV= '" + cb_nv.SelectedValue + "'";
            txt_sdt.Text = Ham.GetFieldValues(str);
        }
        private void ResetValues()
        {
            txt_diachi.Text = "";
            txt_matkhau.Text = "";
            txt_sdt.Text = "";
            txt_taikhoan.Text = "";
            txt_ten.Text = "";
            cb_nv.SelectedIndex = -1;
        }

        private void rd_QT_CheckedChanged(object sender, EventArgs e)
        {
            txt_diachi.Enabled = false;
            txt_sdt.Enabled = false;
            txt_ten.Enabled = false;
            cb_nv.Enabled = false;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bt_them.Text = "Đang Thêm...";
            bt_them.TextAlign = ContentAlignment.MiddleRight;
            bt_luu.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_bo.Enabled = true;
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            ResetValues();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (bt_sua.Text == "Đang Sửa...")
            {
                if (rd_QT.Checked == true)
                {
                    if (txt_taikhoan.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_nv.Focus();
                        return;
                    }
                    sql = "UPDATE dbo.DangNhap SET TaiKhoan ='" + txt_taikhoan.Text.Trim() + "',MatKhau='" + txt_matkhau.Text.Trim() + "'Where id=''";
                    Ham.RunSQL(sql);
                    bt_sua.Enabled = true;
                    bt_them.Enabled = true;
                    bt_luu.Enabled = false;
                    bt_bo.Enabled = false;
                    bt_xoa.Enabled = true;
                    bt_sua.Text = "Sửa";
                    LoadDataGridView();
                    ResetValues();
                }
                else
                {
                    if (cb_nv.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_nv.Focus();
                        return;
                    }
                    if (txt_taikhoan.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_nv.Focus();
                        return;
                    }
                    sql = "UPDATE dbo.DangNhap SET TaiKhoan ='" + txt_taikhoan.Text.Trim() + "',MatKhau='" + txt_matkhau.Text.Trim() + "',MaNV='"+cb_nv.Text.Trim()+"'Where id=''";
                    Ham.RunSQL(sql);
                    bt_sua.Enabled = true;
                    bt_them.Enabled = true;
                    bt_luu.Enabled = false;
                    bt_bo.Enabled = false;
                    bt_xoa.Enabled = true;
                    bt_sua.Text = "Sửa";
                    bt_them.TextAlign = ContentAlignment.MiddleCenter;
                    LoadDataGridView();
                    ResetValues();
                }
            }
            if (bt_them.Text == "Đang Thêm...")
            {
                if (rd_QT.Checked == true)
                {
                    if (txt_taikhoan.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_nv.Focus();
                        return;
                    }
                    sql = "Insert Into DangNhap(id,TaiKhoan,MatKhau) VALUES ('','" + txt_taikhoan.Text.Trim() + "','" + txt_matkhau.Text.Trim() + "')";
                    Ham.RunSQL(sql);
                    bt_sua.Enabled = true;
                    bt_them.Enabled = true;
                    bt_luu.Enabled = false;
                    bt_bo.Enabled = false;
                    bt_xoa.Enabled = true;
                    bt_them.Text = "Thêm";
                    bt_them.TextAlign = ContentAlignment.MiddleCenter;
                    LoadDataGridView();
                    ResetValues();
                }
                else
                {
                    if (cb_nv.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_nv.Focus();
                        return;
                    }
                    if (txt_taikhoan.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_nv.Focus();
                        return;
                    }
                    sql = "Insert Into DangNhap VALUES ('','" + cb_nv.Text.Trim() + "','" + txt_taikhoan.Text.Trim() + "','" + txt_matkhau.Text.Trim() + "')";
                    Ham.RunSQL(sql);
                    bt_sua.Enabled = true;
                    bt_them.Enabled = true;
                    bt_luu.Enabled = false;
                    bt_bo.Enabled = false;
                    bt_xoa.Enabled = true;
                    bt_them.Text = "Thêm";
                    bt_them.TextAlign = ContentAlignment.MiddleCenter;
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (dboLogin.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bt_sua.Text = "Đang Sửa...";
            bt_luu.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_bo.Enabled = true;
            bt_them.Enabled = false;
        }

        private void dt_Login_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bt_sua.Text == "Đang Sửa...")
            {
                MessageBox.Show("Đang ở chế độ sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_nv.Focus();
                return;
            }
            if (dt_Login.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (bt_sua.Text != "Đang Sửa...")
            {
                bt_xoa.Enabled = true;
            }
            txt_taikhoan.Text = dt_Login.CurrentRow.Cells["TaiKhoan"].Value.ToString();
            txt_matkhau.Text = Ham.GetFieldValues("Select MatKhau from DangNhap where TaiKhoan='" + txt_taikhoan.Text.Trim() + "'");
            cb_nv.Text = dt_Login.CurrentRow.Cells["MaNV"].Value.ToString();
        }

        private void rd_NV_CheckedChanged(object sender, EventArgs e)
        {
            txt_diachi.Enabled = true;
            txt_sdt.Enabled = true;
            txt_ten.Enabled = true;
            cb_nv.Enabled = true;
        }

        private void bt_bo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc hủy?", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ResetValues();
                if (bt_sua.Text == "Đang Sửa...")
                {
                    bt_sua.Text = "Sửa";
                }
                if (bt_them.Text == "Đang Thêm...")
                {
                    bt_them.Text = "Thêm";
                    bt_them.TextAlign = ContentAlignment.MiddleCenter;
                }
                bt_bo.Enabled = false;
                bt_them.Enabled = true;
                bt_xoa.Enabled = false;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dboLogin.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE DangNhap WHERE id=''";
                Ham.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            if (bt_luu.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Tác Vụ Hiện Tại Chưa Lưu Bạn Có Chắc Là Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
