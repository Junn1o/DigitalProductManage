using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLySach.Class;

namespace TKHTTT
{
    public partial class frm_NhomSP : Form
    {
        DataTable dboNhomSP;
        public frm_NhomSP()
        {
            InitializeComponent();
            Ham.Connect();
        }

        private void NhomSP_Load(object sender, EventArgs e)
        {
            txt_mnsach.Enabled = false;
            bt_luu.Enabled = false;
            bt_bo.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = false;
            LoadDataGridView();
            txt_tenhom.ReadOnly = true;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaTheLoai,a.TenTheLoai,a.DanhMuc,(SELECT COUNT(b.MaSP) FROM CTTheLoai AS b WHERE a.MaTheLoai=b.MaTheLoai) AS SoSP FROM TheLoai AS a";
            dboNhomSP = Ham.GetDataToTable(sql);
            dt_NhomSach.DataSource = dboNhomSP;
            dt_NhomSach.AllowUserToAddRows = false;
            dt_NhomSach.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_NhomSach.AllowUserToResizeColumns = false;
            dt_NhomSach.AllowUserToDeleteRows = false;
            dt_NhomSach.AutoGenerateColumns = false;
            dt_NhomSach.AllowUserToAddRows = false;
            if (dt_NhomSach.Rows.Count != 0)
            {
                dt_NhomSach.CurrentCell.Selected = true;
            }
            cb_danhmuc.DataSource = Ham.GetDataToTable("SELECT DISTINCT DanhMuc FROM dbo.TheLoai");
            cb_danhmuc.ValueMember = "DanhMuc";
        }
        private void dtNhomSach_Click(object sender, EventArgs e)
        {
            if (bt_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mnsach.Focus();
                return;
            }
            if (dboNhomSP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (bt_sua.Text == "Đang Sửa...")
            {
                MessageBox.Show("Đang ở chế độ sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenhom.Focus();
                return;
            }
            txt_mnsach.Text = dt_NhomSach.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txt_tenhom.Text = dt_NhomSach.CurrentRow.Cells["TenTheLoai"].Value.ToString();
            cb_danhmuc.Text = dt_NhomSach.CurrentRow.Cells["DanhMuc"].Value.ToString();
            lsbx_sp.DataSource = Ham.GetDataToTable("SELECT a.TenSP FROM dbo.SanPham AS a INNER JOIN dbo.CTTheLoai AS b ON b.MaSP = a.MaSP WHERE b.MaTheLoai='"+txt_mnsach.Text.ToString()+"'");
            lsbx_sp.ValueMember = "TenSP";
            
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
        }
        private void ResetValue()
        {
            txt_mnsach.Text = "";
            txt_tenhom.Text = "";
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
            ResetValue();
            txt_mnsach.Enabled = true;
            txt_mnsach.Focus();
            txt_tenhom.ReadOnly = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (dboNhomSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mnsach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bt_sua.Text = "Đang Sửa...";
            bt_luu.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_bo.Enabled = true;
            bt_them.Enabled = false;
            txt_tenhom.ReadOnly = false;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (bt_sua.Text == "Đang Sửa...")
            {
                string sql;
                if (txt_tenhom.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tên nhóm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "UPDATE TheLoai SET TenTheLoai=N'" + txt_tenhom.Text.ToString() + "',DanhMuc=N'"+cb_danhmuc.Text.ToString()+"' WHERE MaTheLoai='" + txt_mnsach.Text + "'";
                Ham.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                bt_sua.Text = "Sửa";
                bt_bo.Enabled = false;
                bt_xoa.Enabled = true;
                bt_them.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                txt_mnsach.Enabled = false;
                txt_tenhom.ReadOnly = true;
            }
            else
            {
                string sql;
                if (txt_mnsach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_mnsach.Focus();
                    return;
                }
                if (txt_tenhom.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tenhom.Focus();
                    return;
                }
                sql = "INSERT INTO TheLoai VALUES('" + txt_tenhom.Text.ToString() + "',N'" + cb_danhmuc.Text.ToString() + "')";
                Ham.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                bt_xoa.Enabled = true;
                bt_bo.Enabled = false;
                bt_them.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                txt_mnsach.Enabled = false;
                txt_tenhom.ReadOnly = true;
                bt_them.Text = "Thêm";
                bt_them.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void bt_bo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc hủy?", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ResetValue();
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
                txt_mnsach.Enabled = false;
                txt_tenhom.ReadOnly = true;
            }
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dboNhomSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mnsach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE From TheLoai WHERE MaTheLoai='" + txt_mnsach.Text.ToString() + "'";
                Ham.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
