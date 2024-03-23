using System;
using System.Windows.Forms;
using QuanLySach.Class;

namespace TKHTTT
{
    public partial class frm_chinh : Form
    {
        public static string MaNV;
        public frm_chinh()
        {
            InitializeComponent();
        }

        private void doanhThuNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DTBH frdtbh = new frm_DTBH();
            frdtbh.ShowDialog();
        }

        private void btdx_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất?", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frm_login frmlg = new frm_login();
                frmlg.Show();
            }

        }

        private void frm_chinh_Load(object sender, EventArgs e)
        {
            Ham.Connect();
            label4.Text = "Chào, " + Ham.GetFieldValues("Select HoTenNV From NhanVien where MaNV='"+MaNV+"'");
        }


        private void nhânViênKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhanvien frmnv = new frm_nhanvien();
            frmnv.ShowDialog();
        }

        private void khoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SanPham frmsp = new frm_SanPham();
            frmsp.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_khachhang frmkh = new frm_khachhang();
            frmkh.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhomSP frmnsp = new frm_NhomSP();
            frmnsp.ShowDialog();
        }
        private void hóaĐơnToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frm_DSHoaDon frmdshd = new frm_DSHoaDon();
            frmdshd.ShowDialog();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_CTHD frmcthd = new form_CTHD();
            frmcthd.ShowDialog();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc thoát?", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            frm_DTBH dTBH = new frm_DTBH();
            dTBH.ShowDialog();
        }

        private void bt_bill_Click(object sender, EventArgs e)
        {
            frm_DSHoaDon dSHoaDon = new frm_DSHoaDon();
            dSHoaDon.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_trangcanhan.MaNV = MaNV;
            frm_trangcanhan frm_QLLogin = new frm_trangcanhan();
            frm_QLLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question.MaNV = MaNV;
            Question question = new Question();
            question.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Shopping.MaNV = MaNV;
            Frm_Shopping frm_DonDatHang = new Frm_Shopping();
            frm_DonDatHang.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void máyBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Shopping frm_DonDatHang = new Frm_Shopping();
            frm_DonDatHang.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_SanPham frm_SanPham = new frm_SanPham();
            frm_SanPham.ShowDialog();
        }
    }
}
