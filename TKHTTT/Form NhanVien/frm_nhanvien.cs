using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySach.Class;
using System.Data.SqlClient;

namespace TKHTTT
{
    public partial class frm_nhanvien : Form
    {
        DataTable dboNV;
        public frm_nhanvien()
        {
            InitializeComponent();
            Ham.Connect();
        }
        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            bt_luu.Enabled = false;
            bt_bo.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = false;
            cb_Gioitinh.Enabled = false;
            bt_chon.Visible = false;
            txt_mnv.ReadOnly = true;
            LoadDataGridView();
        }
        private void dt_NV_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Đang Thêm...")
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mnv.Focus();
                return;
            }
            if (bt_sua.Text == "Đang Sửa...")
            {
                MessageBox.Show("Đang ở chế độ sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tnv.Focus();
                return;
            }
            if (dboNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (bt_sua.Text != "Đang Sửa...")
            {
                bt_xoa.Enabled = true;
            }
            cb_Gioitinh.ResetText();
            txt_mnv.Text = dt_NV.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_tnv.Text = dt_NV.CurrentRow.Cells["HoTenNV"].Value.ToString();
            cb_Gioitinh.SelectedText = dt_NV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txt_dc.Text = dt_NV.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_sdt.Text = dt_NV.CurrentRow.Cells["SDTNV"].Value.ToString();
            mkt_ngaysinh.Text = dt_NV.CurrentRow.Cells["NgaySinhNV"].Value.ToString();
            if (dt_NV.CurrentRow.Cells["AnhNV"].Value.ToString() != null && dt_NV.CurrentRow.Cells["AnhNV"].Value != DBNull.Value)
            {
                byte[] imgData = (byte[])(dt_NV.CurrentRow.Cells["AnhNV"].Value);
                var stream = new MemoryStream(imgData);
                pictureBox1.Image = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        private void btdong_Click(object sender, EventArgs e)
        {
            if (bt_luu.Enabled == true)
            {
                // check trạng thái có đang sửa hay thêm mới hay không
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
        private void btthem_Click(object sender, EventArgs e)
        {
            bt_them.Text = "Đang Thêm...";
            ProcessAddButton();
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            string sql, sql1;
            if (bt_sua.Text == "Đang Sửa...")
            {
                // kiểm tra các điều kiện
                if (dboNV.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool result = CheckCondition();
                if (result == false)
                {
                    return;
                }
                // kiểm tra picturebox có dữ liệu không nếu null thì thực hiện chạy sql nếu có thì chạy sql1
                if (pictureBox1.Image == null)
                {
                    sql = "UPDATE NhanVien SET  TrangThai=N'" + txt_trangthai.Text.Trim().ToString() + "',ChucVu=N'" + txt_chucvu.Text.Trim().ToString() + "',HoTenNV=N'" + txt_tnv.Text.Trim().ToString() + "',GioiTinh = N'" + cb_Gioitinh.Text.Trim().ToString() + "',DiaChi =N'" + txt_dc.Text.Trim().ToString() + "',SDTNV='" + txt_sdt.Text.ToString() + "' WHERE MaNV='" + txt_sdt.Text.ToString().Trim() + "'";
                    Ham.RunSQL(sql);
                }
                else
                {
                    sql1 = "UPDATE NhanVien SET  TrangThai=N'" + txt_trangthai.Text.Trim().ToString() + "',ChucVu=N'" + txt_chucvu.Text.Trim().ToString()+"',HoTenNV=N'" + txt_tnv.Text.Trim().ToString() + "',GioiTinh = N'" + cb_Gioitinh.Text.Trim().ToString() + "',NgaySinhNV='" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "',DiaChi =N'" + txt_dc.Text.Trim().ToString() + "',SDTNV='" + txt_sdt.Text.ToString().Trim() + "',ANHNV=@pic WHERE MaNV='" + txt_mnv.Text.ToString() + "'";
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    Ham.ImportImg(sql1, pic);
                }
                bt_sua.Text = "Sửa";
                LoadDataGridView();
                ResetValues();
                ProcessEditButton();
            }
            else
            {
                // kiểm tra các điều kiện
                bool result = CheckCondition();
                if (result == false)
                {
                    return;
                }
                // kiểm tra picturebox có dữ liệu không nếu null thì thực hiện chạy sql nếu có thì chạy sql1
                if (pictureBox1.Image == null)
                {
                    sql = "INSERT INTO NhanVien(MaNV,HoTenNV,NgaySinhNV,GioiTinh,DiaChi,SDTNV,TrangThai,ChucVu) VALUES (SELECT dbo.AUTO_MANV(),N'" + txt_tnv.Text.Trim().ToString() + "','" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "',N'" + cb_Gioitinh.Text.Trim().ToString() + "',N'" + txt_dc.Text.Trim().ToString() + "','" + txt_sdt.Text.ToString().Trim() + "',N'"+txt_trangthai.Text.Trim().ToString()+"',N'"+txt_chucvu.Text.Trim().ToString() + "')";
                    Ham.RunSQL(sql);
                    sql1 = "Inser Into DangNhap Values('" + txt_mnv.Text.ToString().Trim() + "','" + txt_mnv.Text.ToString().Trim() + "')";
                    Ham.RunSQL(sql1);
                    MessageBox.Show("Mật Khẩu Của Nhân Viên " + txt_tnv.Text.Trim().ToString() + " Là " + txt_mnv.Text.Trim().ToString() + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sql = "INSERT INTO NhanVien(MaNV,HoTenNV,NgaySinhNV,GioiTinh,DiaChi,SDTNV,AnhNV,TrangThai,ChucVu) VALUES (SELECT dbo.AUTO_MANV(),N'" + txt_tnv.Text.Trim().ToString() + "','" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "',N'" + cb_Gioitinh.Text.Trim().ToString() + "',N'" + txt_dc.Text.Trim().ToString() + "','" + txt_sdt.Text.ToString().Trim() + "',@pic,N'" + txt_trangthai.Text.Trim().ToString() + "',N'" + txt_chucvu.Text.Trim().ToString() + "')";
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    Ham.ImportImg(sql, pic);
                    sql1 = "Inser Into DangNhap Values('"+txt_mnv.Text.ToString().Trim()+"','"+txt_mnv.Text.ToString().Trim()+"')";
                    Ham.RunSQL(sql1);
                    MessageBox.Show("Mật Khẩu Của Nhân Viên "+txt_tnv.Text.Trim().ToString()+" Là "+txt_mnv.Text.Trim().ToString() + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bt_them.Text = "Thêm";
                LoadDataGridView();
                ResetValues();
                ProcessAddButton();
            }
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            if (dboNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tnv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bt_sua.Text = "Đang Sửa...";
            ProcessEditButton();
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dboNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mnv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNV='" + txt_mnv.Text + "'";
                Ham.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
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
        private void bt_chon_Click(object sender, EventArgs e)
        {
            // code xử lí nhập dữ liệu từ 
            Stream myStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFile.OpenFile()) != null)
                {
                    string Filename = openFile.FileName;
                    if (myStream.Length > 512000)
                    {
                        MessageBox.Show("File chỉ được có dung lượng 512kbs!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Chọn Upfile Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pictureBox1.Load(Filename);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }
        //hàm load data gridview
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM NhanVien";
            dboNV = Ham.GetDataToTable(sql);
            dt_NV.DataSource = dboNV;
            dt_NV.AllowUserToAddRows = false;
            dt_NV.AllowUserToResizeColumns = true;
            dt_NV.AllowUserToDeleteRows = false;
            dt_NV.AutoGenerateColumns = false;
            dt_NV.AllowUserToAddRows = false;
            dt_NV.EditMode = DataGridViewEditMode.EditProgrammatically;
            if (dboNV.Rows.Count != 0)
            {
                dt_NV.CurrentCell.Selected = true;
            }
            cb_Gioitinh.DataSource = Ham.GetDataToTable("Select DISTINCT GioiTinh from NhanVien");
            cb_Gioitinh.ValueMember = "GioiTinh";
        }
        //hàm kiểm tra điều kiện
        public bool CheckCondition()
        {
            if (txt_tnv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tnv.Focus();
                return false;
            }
            if (txt_chucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_chucvu.Focus();
                return false;
            }
            if (txt_trangthai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập trạng thái của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_trangthai.Focus();
                return false;
            }
            if (cb_Gioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giới tính của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Gioitinh.Focus();
                return false;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return false;
            }
            if (mkt_ngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkt_ngaysinh.Focus();
                return false;
            }
            if (!Ham.CheckDate(mkt_ngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh(dd/mm/yyyy)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkt_ngaysinh.Focus();
                return false;
            }
            if (txt_dc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_dc.Focus();
                return false;
            }
            else
                return true;
        }
        //hàm xử lí button edit
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
        //hàm xử lí button add
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
        // hàm reset value
        private void ResetValues()
        {
            cb_Gioitinh.SelectedIndex = -1;
            txt_mnv.Clear();
            txt_tnv.Clear();
            txt_dc.Clear();
            txt_sdt.Clear();
            txt_trangthai.Clear();
            txt_chucvu.Clear();
            mkt_ngaysinh.Clear();
        }
        // hàm không cho chỉnh sửa trên form
        private void OnReadOnly()
        {
            txt_dc.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            cb_Gioitinh.Enabled = false;
            txt_tnv.ReadOnly = true;
            txt_trangthai.ReadOnly = true;
            txt_chucvu.ReadOnly = true;
            bt_chon.Visible = false;
        }
        // hàm không phục hồi quyền chỉnh sửa trên form
        private void OffReadOnly()
        {
            txt_trangthai.ReadOnly = false;
            txt_chucvu.ReadOnly = false;
            txt_dc.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            cb_Gioitinh.Enabled = true;
            txt_tnv.ReadOnly = false;
        }




        private void cb_Gioitinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        // sự kiện cho textbox điện thoại chỉ đc nhập số
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // các sự kiện khi nhấn tab
        private void txt_mnv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_tnv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cb_Gioitinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_dc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void bt_quanly_Click(object sender, EventArgs e)
        {
            if (txt_mnv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sql = "Update DangNhap Set MatKhau='" + Ham.Encrypt(txt_mnv.Text.ToString().Trim()) + "'where MaNV='" + txt_mnv.Text.ToString() + "'";
                Ham.RunSQL(sql);
                MessageBox.Show("Mật khẩu được đổi thành "+txt_mnv.Text.ToString().Trim()+"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
