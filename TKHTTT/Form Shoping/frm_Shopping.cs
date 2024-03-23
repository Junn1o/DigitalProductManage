using QuanLySach.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace TKHTTT
{
    public partial class Frm_Shopping : Form
    {
        public static string sql;
        public static string MaNV;
        DataTable dboShp;
        public Frm_Shopping()
        {
            InitializeComponent();
            Ham.Connect();
        }

        private void frm_Shopping_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            lsbx_cart.ValueMember = "TenSP";
            lb_cart.Text = "0";
        }
        public void LoadDataGridView()
        {
            sql = "SELECT DISTINCT a.TenSP,a.Gia,c.DanhMuc,CAST(a.AnhSP AS VARBINARY(max)) AS AnhSP, SUBSTRING( ( SELECT d.TenTheLoai AS[text()] FROM dbo.TheLoai AS d INNER JOIN dbo.CTTheLoai AS f ON f.MaTheLoai = d.MaTheLoai WHERE f.MaSP=a.MaSP FOR XML PATH('')), 2, 1000 ) AS TenTheLoai FROM SanPham AS a INNER JOIN CTTheLoai AS b ON b.MaSP = a.MaSP INNER JOIN TheLoai AS c ON c.MaTheLoai = b.MaTheLoai";
            dboShp = Ham.GetDataToTable(sql);
            dt_ShPi.DataSource = dboShp;
            if (dt_ShPi.Rows.Count != 0)
            {
                dt_ShPi.CurrentRow.Selected = true;
            }
            lb_cart.Visible = false;
        }

        private void dt_ShPi_Click(object sender, EventArgs e)
        {
            txt_tensanpham.Text = dt_ShPi.CurrentRow.Cells["TenSP"].Value.ToString();
            txt_danhmuc.Text = dt_ShPi.CurrentRow.Cells["DanhMuc"].Value.ToString();
            txt_gia.Text = dt_ShPi.CurrentRow.Cells["Gia"].Value.ToString();
            txt_masanpham.Text = Ham.GetFieldValues("Select MaSP from SanPham where TenSP=N'" + txt_tensanpham.Text.Trim().ToString() + "' And Gia='" + txt_gia.Text.ToString() + "'");
            txt_slg.Text = Ham.GetFieldValues("SELECT COUNT(Keycode) FROM dbo.DigiKey INNER JOIN dbo.SanPham ON SanPham.MaSP = DigiKey.MaSP where SanPham.MaSP = '" + txt_masanpham.Text.ToString() + "'And DigiKey.TrangThai=N'Chưa Sử Dụng'");
            rtxt_mota.Text = Ham.GetFieldValues("Select Mota from SanPham Where MaSP='" + txt_masanpham.Text.ToString() + "'");
            lb_theloai.DataSource = Ham.GetDataToTable("SELECT a.TenTheLoai FROM TheLoai as a inner join CTTheLoai as b on a.MaTheLoai=b.MaTheLoai Where b.MaSP=N'" + txt_masanpham.Text.ToString() + "'");
            lb_theloai.ValueMember = "TenTheLoai";
            for (int i = 0; i < Ham.GetDataToTable("SELECT b.TenTheLoai FROM dbo.CTTheLoai AS a INNER JOIN dbo.TheLoai AS b ON b.MaTheLoai = a.MaTheLoai WHERE a.MaSP='" + txt_masanpham.Text.ToString() + "'AND b.DanhMuc='" + txt_danhmuc.Text.ToString() + "'").Rows.Count; i++)
            {
                lb_theloai.SelectedValue = Ham.GetDataToTable("SELECT * FROM dbo.CTTheLoai AS a INNER JOIN dbo.TheLoai AS b ON b.MaTheLoai = a.MaTheLoai WHERE a.MaSP='" + txt_masanpham.Text.ToString() + "'").Rows[i][4].ToString();
            }
        }

        private void bt_addtocart_Click(object sender, EventArgs e)
        {
            if (lsbx_cart.Items.Contains(dt_ShPi.CurrentRow.Cells["TenSP"].Value.ToString()))
            {
                MessageBox.Show("Sản phẩm đã tồn tại");
                return;
            }
            if (txt_slg.Text == "0")
            {
                MessageBox.Show("Sản phẩm này đã hết hàng vui lòng chọn sản phẩm khác");
                return;
            }
            if (txt_masanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Chọn Sản Phẩm");
                return;
            }
            if (lb_cart.Text=="0")
            {
                lb_cart.Text = Ham.CreateKey("DH");
                sql = "Insert Into DonHang(MaDH,TongTien) Values('" + lb_cart.Text.ToString().Trim() + "','0')";
                Ham.RunSQL(sql);
                lsbx_cart.SelectedItem = dt_ShPi.CurrentRow.Cells["TenSP"].Value.ToString();
                string item = dt_ShPi.CurrentRow.Cells["TenSP"].Value.ToString();
                lsbx_cart.Items.Add(item);
                lsbx_cart.SelectedItem = item;
                string tam;
                tam = lsbx_cart.SelectedIndex.ToString();
                sql = "Insert Into CTDonHang Values('" + lb_cart.Text.ToString().Trim() + "','" + tam + "','" + txt_masanpham.Text.ToString().Trim() + "',(Select Gia from SanPham where MaSP='" + txt_masanpham.Text.ToString() + "'))";
                Ham.RunSQL(sql);
                sql = "Update DonHang Set TongTien=(SELECT SUM(Gia) FROM dbo.SanPham AS a INNER JOIN dbo.CTDonHang AS b ON b.MaSP = a.MaSP WHERE b.MaDH='" + lb_cart.Text.ToString().Trim() + "') WHERE DonHang.MaDH ='" + lb_cart.Text.ToString().Trim() + "'";
                Ham.RunSQL(sql);
                sql = "Select TongTien From DonHang Where MaDH='" + lb_cart.Text.ToString().Trim() + "'";
                txt_tongtien.Text = Ham.GetFieldValues(sql);
                lsbx_cart.SelectedIndex = -1;
            }
            else
            {
                lsbx_cart.SelectedItem = dt_ShPi.CurrentRow.Cells["TenSP"].Value.ToString();
                string item = dt_ShPi.CurrentRow.Cells["TenSP"].Value.ToString();
                lsbx_cart.Items.Add(item);
                lsbx_cart.SelectedItem = item;
                string tam;
                tam = lsbx_cart.SelectedIndex.ToString();
                sql = "Insert Into CTDonHang Values('" + lb_cart.Text.ToString().Trim() + "','" + tam + "','" + txt_masanpham.Text.ToString().Trim() + "',(Select Gia from SanPham where MaSP='" + txt_masanpham.Text.ToString() + "'))";
                Ham.RunSQL(sql);
                sql = "Update DonHang Set TongTien=(SELECT SUM(Gia) FROM dbo.SanPham AS a INNER JOIN dbo.CTDonHang AS b ON b.MaSP = a.MaSP WHERE b.MaDH='" + lb_cart.Text.ToString().Trim() + "') WHERE DonHang.MaDH ='" + lb_cart.Text.ToString().Trim() + "'";
                Ham.RunSQL(sql);
                sql = "Select TongTien From DonHang Where MaDH='" + lb_cart.Text.ToString().Trim() + "'";
                txt_tongtien.Text = Ham.GetFieldValues(sql);
                lsbx_cart.SelectedIndex = -1;
            }
        }

        private void Frm_Shopping_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lb_cart.Text != "0")
            {
                sql = "Delete From CTDonHang where MaDH='" + lb_cart.Text.ToString() + "'";
                Ham.RunSqlDel(sql);
                sql = "Delete From DonHang where MaDH='" + lb_cart.Text.ToString() + "'";
                Ham.RunSqlDel(sql);
            }
            else
            {
                return;
            }
        }

        private void bt_xoakhoigio_Click(object sender, EventArgs e)
        {
            if (lsbx_cart.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
            }
            else
            {
                if (lsbx_cart.SelectedItems.Count > 0)
                {
                    while (lsbx_cart.SelectedItems.Count > 0)
                    {
                        string tam = lsbx_cart.SelectedIndex.ToString();
                        sql = "Delete From CTDonHang where MaCTDH='" + tam + "'And MaDH='" + lb_cart.Text.ToString() + "'";
                        Ham.RunSqlDel(sql);
                        lsbx_cart.Items.Remove(lsbx_cart.SelectedItem);
                    }
                }
            }
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            if (lb_makh.Text == "0")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng");
                return;
            }
            string CurrentDay = DateTime.Now.ToString("yyyy/MM/dd");
            frm_HoaDon.MaHD = Ham.CreateKey("HD");
            string mahd = frm_HoaDon.MaHD.ToString();
            sql = "INSERT INTO HoaDon(MaNV,MaHD,MaKH,NgayLap,TongTien) VALUES ('"+MaNV+"','" + mahd + "','"+lb_makh.Text.ToString()+"','"+CurrentDay.ToString().Trim()+"'," +
                "(Select TongTien From DonHang Where MaDH='"+lb_cart.Text.ToString() + "'))";
            Ham.RunSQL(sql);
            for (int i = 0; i < lsbx_cart.Items.Count; i++)
            {
                sql = "INSERT INTO CTHoaDon(MaHD,MaCTHD,MaSP,Tien) VALUES ('" + mahd + "','"+i.ToString()+"',(Select MaSP from CTDonHang where MaDH='" + lb_cart.Text.ToString().Trim() + "' " +
                    "And MaCTDH='"+i.ToString()+"'),(Select Tien from CTDonHang " +
                    "where MaDH='" + lb_cart.Text.ToString().Trim() + "'And MaCTDH='"+i.ToString()+"'))";
                Ham.RunSQL(sql);
            }
            frm_HoaDon frm_HD = new frm_HoaDon();
            frm_HD.ShowDialog();
            lb_makh.Text = "0";
            lb_makh.Text = "0";
            txt_tenkh.Clear();
        }
        public void SetValue(String value)
        {
            lb_makh.Text = value;
        }

        private void bt_chonkh_Click(object sender, EventArgs e)
        {
            frm_chonkhachhang frm_Chonkhachhang = new frm_chonkhachhang(SetValue);
            frm_Chonkhachhang.ShowDialog();
        }

        private void lb_makh_TextChanged(object sender, EventArgs e)
        {
            if(lb_makh.Text!="0")
            {
                txt_tenkh.Text = Ham.GetFieldValues("Select TenKH from KhachHang where MaKH='" + lb_makh.Text + "'");
            }
        }
    }
}
