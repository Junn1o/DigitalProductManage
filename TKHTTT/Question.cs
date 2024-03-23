using QuanLySach.Class;
using System;
using System.Windows.Forms;

namespace TKHTTT
{
    public partial class Question : Form
    {
        public static string MaNV;
        public Question()
        {
            InitializeComponent();
        }

        private void bt_nv_Click(object sender, EventArgs e)
        {
            string check = Ham.GetFieldValues("Select ChucVu from NhanVien Where MaNV='" + MaNV + "'");
            if (check.ToString().ToLower() == "nhân viên")
            {
                MessageBox.Show("Bạn Không Có Quyền Vào Đây", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_nhanvien frm_Nhanvien = new frm_nhanvien();
                frm_Nhanvien.Show();
                this.Hide();
                this.Close();
            }
        }

        private void bt_kh_Click(object sender, EventArgs e)
        {
            frm_khachhang frm_Khachhang = new frm_khachhang();
            frm_Khachhang.Show();
            this.Hide();
            this.Close();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Question_Load(object sender, EventArgs e)
        {

        }
    }
}
