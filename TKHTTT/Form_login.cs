using System;
using System.Data;
using System.Windows.Forms;
using QuanLySach.Class;

namespace TKHTTT
{
    public partial class frm_login : Form
    {
        DataTable dt;
        public frm_login()
        {
            InitializeComponent();
        }
        public static string ID_USER = "";
        private string getID()
        {
            string sql;
            string id = "";
            try
            {
                Ham.Connect();
                sql = "SELECT * FROM DangNhap WHERE MaNV ='" + txtTK.Text + "' and MatKhau='" + Ham.Encrypt(txtMK.Text.ToString()) + "'";
                dt = Ham.GetDataToTable(sql);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MaNV"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                Ham.Disconnect();
            }
            return id;

        }        
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            ID_USER = getID();
            if (ID_USER != "")
            {
                frm_chinh.MaNV = ID_USER.ToString();
                frm_chinh fmain = new frm_chinh();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }


    }
}
    

