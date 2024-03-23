using QuanLySach.Class;
using System;
using System.Windows.Forms;

namespace TKHTTT
{
    public partial class frm_doimatkhau : Form
    {
        public static string MaNV;
        public frm_doimatkhau()
        {
            InitializeComponent();
            Ham.Connect();
        }

        private void bt_doi_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToString().Trim()=="" || textBox2.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Không Được Để Trống Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(Ham.Encrypt(textBox1.Text.ToString().Trim())==Ham.GetFieldValues("Select MatKhau from DangNhap Where MaNV='"+MaNV+"'"))
                {
                    string sql = "Update DangNhap Set MatKhau='"+Ham.Encrypt(textBox2.Text.Trim().ToString())+"'Where MaNV='"+MaNV+"'";
                    Ham.RunSQL(sql);
                    MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Cũ Sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
