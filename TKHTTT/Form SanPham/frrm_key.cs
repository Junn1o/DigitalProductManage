using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLySach.Class;

namespace TKHTTT
{
    public partial class Frrm_key : Form
    {
        DataTable dboKey;
        public static string MaSP;
        public Frrm_key()
        {
            InitializeComponent();
        }

        private void frrm_key_Load(object sender, EventArgs e)
        {
            lb_TuaDe.Text = "Quản lý key của "+ Ham.GetFieldValues("Select TenSP from SanPham where MaSP = '" + MaSP + "'")+"";
            ProcessAddButton();
            ProcessEditButton();
            LoadDataGridView();
            txt_keyss.Enabled = false;
            bt_sosanh.Enabled = false;
        }
        private void LoadDataGridView()
        {
            dboKey = Ham.GetDataToTable("Select Id,KeyCode,TrangThai from DigiKey where MaSP='"+MaSP+"'");
            dt_key.DataSource = dboKey;
            dt_key.AllowUserToAddRows = false;
            dt_key.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_key.AllowUserToResizeColumns = false;
            dt_key.AllowUserToDeleteRows = false;
            dt_key.AutoGenerateColumns = false;
            dt_key.AllowUserToAddRows = false;
            if (dt_key.Rows.Count != 0)
            {
                dt_key.CurrentCell.Selected = true;
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (bt_sua.Text == "Đang Sửa...")
            {
                if (dboKey.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool result = CheckCondition();
                if (result == false)
                {
                    return;
                }
                sql = "Update DigiKey Set KeyCode=N'" + Ham.Encrypt(txt_key.Text.ToString()) + "'Where MaSP='" + MaSP + "'And Id='"+dt_key.CurrentRow.Cells["id"].Value.ToString()+"'";
                Ham.RunSQL(sql);
                bt_sua.Text = "Sửa";
                txt_keyss.Text = "";
                txt_key.Enabled = true;
                LoadDataGridView();
                ProcessEditButton();
                ResetValues();
            }
            else
            {
                bool result = CheckCondition();
                if (result == false)
                {
                    return;
                }
                int id = Convert.ToInt32(Ham.GetFieldValues("Select Count(id) from Digikey where MaSP='" + MaSP + "'"))+1;
                sql = "Insert Into DigiKey Values('"+id.ToString()+"',N'"+Ham.Encrypt(txt_key.Text.ToString())+"','"+MaSP+"',N'Chưa Sử Dụng')";
                Ham.RunSQL(sql);
                bt_them.Text = "Thêm";
                txt_keyss.Text = "";
                txt_key.Enabled = true;
                LoadDataGridView();
                ProcessAddButton();
                ResetValues();
            }
        }
        private void bt_sosanh_Click(object sender, EventArgs e)
        {
            if (txt_key.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn key", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_key.Focus();
                return;
            }
            string ss1 = txt_keyss.Text;
            if (Ham.Encrypt(ss1).ToString() == txt_key.Text.ToString())
            {
                MessageBox.Show("Key khớp với dữ liệu có sẵn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Key không khớp với dữ liệu có sẵn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_keyss.Enabled = false;
            bt_sosanh.Enabled = false;
        }

        private void dt_key_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Đang Thêm...")
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_key.Focus();
                return;
            }
            if (bt_sua.Text == "Đang Sửa...")
            {
                MessageBox.Show("Đang ở chế độ sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_key.Focus();
                return;
            }
            if (dboKey.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_key.Text = dt_key.CurrentRow.Cells["KeyCode"].Value.ToString();
            txt_keyss.Text = "";
            txt_keyss.Enabled = true;
            bt_sosanh.Enabled = true;
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dboKey.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_key.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn key nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá key đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete From Digikey where MaSP='" + MaSP + "' And Keycode=N'" + txt_key.Text.ToString() + "'";
                Ham.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }













        public bool CheckCondition()
        {
            if (txt_key.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập key", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_key.Focus();
                return false;
            }
            else
                return true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bt_them.Text = "Đang Thêm...";
            txt_keyss.Text = "";
            txt_keyss.Enabled=false;
            ProcessAddButton();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (dboKey.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_key.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_keyss.Text = "";
            txt_key.Enabled = false;
            bt_sua.Text = "Đang Sửa...";
            ProcessEditButton();
        }
        public void ProcessEditButton()
        {
            if (bt_sua.Text == "Đang Sửa...")
            {
                bt_sua.TextAlign = ContentAlignment.MiddleRight;
                bt_luu.Enabled = true;
                bt_sua.Enabled = false;
                bt_xoa.Enabled = false;
                bt_bo.Enabled = true;
                bt_them.Enabled = false;
                OffReadOnly();
            }
            if (bt_sua.Text == "Sửa")
            {
                bt_bo.Enabled = false;
                bt_xoa.Enabled = true;
                bt_them.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                bt_sua.TextAlign = ContentAlignment.MiddleCenter;
                ResetValues();
                OnReadOnly();
            }
        }
        public void ProcessAddButton()
        {
            if (bt_them.Text == "Đang Thêm...")
            {
                bt_them.TextAlign = ContentAlignment.MiddleRight;
                bt_luu.Enabled = true;
                bt_sua.Enabled = false;
                bt_xoa.Enabled = false;
                bt_bo.Enabled = true;
                bt_them.Enabled = false;
                ResetValues();
                OffReadOnly();
            }
            if (bt_them.Text == "Thêm")
            {
                bt_bo.Enabled = false;
                bt_xoa.Enabled = true;
                bt_them.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                bt_them.TextAlign = ContentAlignment.MiddleCenter;
                ResetValues();
                OnReadOnly();
            }
        }
        public void ResetValues()
        {
            txt_key.Text = "";
            txt_keyss.Text = "";
        }
        public void OnReadOnly()
        {
            txt_key.ReadOnly = true;
            txt_key.Enabled = false;
        }
        public void OffReadOnly()
        {
            txt_key.ReadOnly = false;
            txt_key.Enabled = true;
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
                    ProcessEditButton();
                }
                if (bt_them.Text == "Đang Thêm...")
                {
                    bt_them.Text = "Thêm";
                    ProcessAddButton();
                }
            }
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
