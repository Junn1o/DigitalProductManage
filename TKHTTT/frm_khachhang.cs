using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLySach.Class;


namespace TKHTTT
{
    public partial class frm_khachhang : Form
    {
        DataTable dboKH;
        public frm_khachhang()
        {
            InitializeComponent();
            Ham.Connect();
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

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            bt_chon.Visible = false;
            bt_luu.Enabled = false;
            bt_bo.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = false;
            txt_mkh.ReadOnly = true;
            LoadDataGridView();
            OnReadOnly();
        }

        private void dt_kh_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Đang Thêm...")
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mkh.Focus();
                return;
            }
            if (bt_sua.Text == "Đang Sửa...")
            {
                MessageBox.Show("Đang ở chế độ sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tkh.Focus();
                return;
            }
            if (dboKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_Gioitinh.ResetText();
            txt_mkh.Text = dt_kh.CurrentRow.Cells["MaKH"].Value.ToString();
            txt_tkh.Text = dt_kh.CurrentRow.Cells["TenKH"].Value.ToString();
            cb_Gioitinh.SelectedText = dt_kh.CurrentRow.Cells["GioiTinhKH"].Value.ToString();
            txt_dc.Text = dt_kh.CurrentRow.Cells["DChi"].Value.ToString();
            txt_sdt.Text = dt_kh.CurrentRow.Cells["SDTKH"].Value.ToString();
            mkt_ngaysinh.Text = dt_kh.CurrentRow.Cells["NgaySinhKH"].Value.ToString();
            //kiểm tra điều kiện có ảnh trong datagridview hay không nếu không thì không load
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
            bt_xoa.Enabled = true;
        }        
        private void btthem_Click(object sender, EventArgs e)
        {
            bt_them.Text = "Đang Thêm...";
            ProcessAddButton();
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            string sql, sql1;
            // Kiểm tra đang ở trạng thái nào
            if (bt_sua.Text=="Đang Sửa...")
            {
                // kiểm tra các điều kiện
                if (dboKH.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool result = CheckCondition();
                if (result == false)
                {
                    return;
                }
                // kiểm tra picturebox có dữ liệu không nếu null thì thực hiện chạy sql, nếu có thì chạy sql1
                if (pictureBox1.Image == null)
                {
                    sql = "UPDATE dbo.KhachHang SET TenKH=N'" + txt_tkh.Text.Trim().ToString() + "',GioiTinhKH = N'" + cb_Gioitinh.Text.Trim() + "', DChi = N'" + txt_dc.Text.Trim().ToString() + "',SDTKH='" + txt_sdt.Text.ToString() + "',NgaySinhKH='" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "' WHERE MaKH='" + txt_mkh.Text + "'";
                    Ham.RunSQL(sql);
                }
                else
                {
                    sql1 = "UPDATE dbo.KhachHang SET TenKH=N'" + txt_tkh.Text.Trim().ToString() + "',GioiTinhKH = N'" + cb_Gioitinh.Text.Trim() + "',DChi = N'" + txt_dc.Text.Trim().ToString() + "',SDTKH='" + txt_sdt.Text.ToString() + "',NgaySinhKH='" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "', AnhKH=@pic WHERE MaKH='" + txt_mkh.Text + "'";
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
                    sql = "INSERT INTO KhachHang(MaKH,TenKH,DChi,GioiTinhKH,SDTKH,NgaySinhKH) VALUES ((SELECT dbo.AUTO_MAKH()),N'" + txt_tkh.Text.Trim() + "',N'" + txt_dc.Text.Trim() + "',N'" + cb_Gioitinh.Text.Trim() + "','" + txt_sdt.Text.Trim() + "','" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "')";
                    Ham.RunSQL(sql);
                }
                else
                {
                    sql1 = "INSERT INTO KhachHang(MaKH,TenKH,DChi,GioiTinhKH,SDTKH,NgaySinhKH,AnhKH) VALUES ((SELECT dbo.AUTO_MAKH()),N'" + txt_tkh.Text.Trim() + "',N'" + txt_dc.Text.Trim() + "',N'" + cb_Gioitinh.Text.Trim() + "','" + txt_sdt.Text.Trim() + "','" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "',@pic)";
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    Ham.ImportImg(sql1, pic);
                }
                bt_them.Text = "Thêm";
                LoadDataGridView();
                ResetValues();
                ProcessAddButton();
            }
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            if (dboKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mkh.Text.Trim().Length == 0)
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
            if (dboKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mkh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE KhachHang WHERE MaKH='" + txt_mkh.Text + "'";
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



        //hàm kiểm tra điều kiện
        public bool CheckCondition()
        {
            if (txt_tkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tkh.Focus();
                return false;
            }
            if (cb_Gioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giới tính của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Gioitinh.Focus();
                return false;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return false;
            }
            if (mkt_ngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Bạn phải nhập địa chỉ của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt_mkh.Clear();
            txt_tkh.Clear();
            txt_dc.Clear();
            txt_sdt.Clear();
            mkt_ngaysinh.Clear();
        }
        // hàm không cho chỉnh sửa trên form
        private void OnReadOnly()
        {
            txt_dc.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            cb_Gioitinh.Enabled = false;
            txt_tkh.ReadOnly = true;
            bt_chon.Visible = false;
        }
        // hàm không phục hồi quyền chỉnh sửa trên form
        private void OffReadOnly()
        {
            txt_dc.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            cb_Gioitinh.Enabled = true;
            txt_tkh.ReadOnly = false;
            bt_chon.Visible = true;
        }
        //hàm load datagridview
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
        private void cb_Gioitinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_mkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_tkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cb_Gioitinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_sdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_dc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
