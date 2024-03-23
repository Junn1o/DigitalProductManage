using QuanLySach.Class;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TKHTTT
{
    public partial class frm_trangcanhan : Form
    {
        public static string MaNV;
        public frm_trangcanhan()
        {
            InitializeComponent();
            Ham.Connect();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
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
                bt_bo.Enabled = true;
                OffReadOnly();
            }
            if (bt_sua.Text == "Sửa")
            {
                bt_bo.Enabled = false;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                bt_sua.TextAlign = ContentAlignment.MiddleCenter;
                ResetValues();
                OnReadOnly();
            }
        }
        //Hàm Load Data Vào Form
        private void ResetValues()
        {
            txt_mnv.Text = MaNV;
            txt_ten.Text = Ham.GetFieldValues("Select HoTenNV from NhanVien Where MaNV='" + MaNV + "'");
            txt_diachi.Text = Ham.GetFieldValues("Select DiaChi from NhanVien Where MaNV='" + MaNV + "'");
            txt_gioitinh.Text = Ham.GetFieldValues("Select GioiTinh from NhanVien Where MaNV='" + MaNV + "'").Trim();
            mkt_ngaysinh.Text = Ham.GetFieldValues("Select NgaySinhNV from NhanVien Where MaNV='" + MaNV + "'");
            txt_sdt.Text = Ham.GetFieldValues("Select SDTNV from NhanVien Where MaNV='" + MaNV + "'");
            txt_trangthai.Text = Ham.GetFieldValues("Select TrangThai from NhanVien Where MaNV='" + MaNV + "'");
            txt_chucvu.Text = Ham.GetFieldValues("Select ChucVu from NhanVien Where MaNV='" + MaNV + "'");
            byte[] imgData = (byte[])(Ham.GetDataToTable("Select AnhNV from NhanVien Where MaNV='" + MaNV + "'").Rows[0][0]);
            var stream = new MemoryStream(imgData);
            pictureBox1.Image = Image.FromStream(stream);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        // hàm không cho chỉnh sửa trên form
        private void OnReadOnly()
        {
            txt_diachi.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            txt_gioitinh.ReadOnly = true;
            txt_ten.ReadOnly = true;
            mkt_ngaysinh.ReadOnly = true;
            txt_chucvu.ReadOnly = true;
            txt_trangthai.ReadOnly = true;
            bt_chon.Visible = false;
        }
        // hàm không phục hồi quyền chỉnh sửa trên form
        private void OffReadOnly()
        {
            txt_diachi.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            txt_gioitinh.ReadOnly = false;
            txt_ten.ReadOnly = false;
            mkt_ngaysinh.ReadOnly = false;
            bt_chon.Visible = true;
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
            }
        }

        private void frm_trangcanhann_Load(object sender, EventArgs e)
        {
            bt_luu.Enabled = false;
            bt_bo.Enabled = false;
            bt_sua.Enabled = true;
            bt_chon.Visible = false;
            OnReadOnly();
            ResetValues();
            ProcessEditButton();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string sql;
            bool result = CheckCondition();
            if (result == false)
            {
                return;
            }
            if (pictureBox1.Image == null)
            {
                sql = "UPDATE NhanVien SET  HoTenNV=N'" + txt_ten.Text.Trim().ToString() + "',GioiTinh = N'" + txt_gioitinh.Text.Trim().ToString() + "',DiaChi =N'" + txt_diachi.Text.Trim().ToString() + "',SDTNV='" + txt_sdt.Text.ToString() + "' WHERE MaNV='" + txt_mnv.Text.ToString().Trim() + "'";
                Ham.RunSQL(sql);
            }
            else
            {
                sql = "UPDATE NhanVien SET  HoTenNV=N'" + txt_ten.Text.Trim().ToString() + "',GioiTinh = N'" + txt_gioitinh.Text.Trim().ToString() + "',NgaySinhNV='" + Ham.ConvertDateTime(mkt_ngaysinh.Text.ToString()) + "',DiaChi =N'" + txt_diachi.Text.Trim().ToString() + "',SDTNV='" + txt_sdt.Text.ToString().Trim() + "',ANHNV=@pic WHERE MaNV='" + txt_mnv.Text.ToString() + "'";
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                Ham.ImportImg(sql, pic);
            }
            MessageBox.Show("Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bt_sua.Text = "Sửa";
            ProcessEditButton();
        }
        public bool CheckCondition()
        {
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ten.Focus();
                return false;
            }
            if (txt_gioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giới tính của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_gioitinh.Focus();
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
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return false;
            }
            else
                return true;
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

        private void bt_quanly_Click(object sender, EventArgs e)
        {
            frm_doimatkhau.MaNV = txt_mnv.Text.ToString();
            frm_doimatkhau frm_DMK = new frm_doimatkhau();
            frm_DMK.ShowDialog();
        }

        private void bt_dong_Click(object sender, EventArgs e)
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
    }
}
