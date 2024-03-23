using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLySach.Class;
using System.IO;

namespace TKHTTT
{
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
            Ham.Connect();
        }
        public static string MaHD;

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDaTaGridview();
            txt_tkh.Text = Ham.GetFieldValues("SELECT a.TenKH FROM dbo.KhachHang AS a JOIN dbo.HoaDon AS b on b.MaKH = a.MaKH WHERE b.MaHD='" + MaHD+"'");
            txt_tnv.Text = Ham.GetFieldValues("SELECT a.HoTenNV FROM dbo.NhanVien AS a JOIN dbo.HoaDon AS b on b.MaNV = a.MaNV WHERE b.MaHD='" + MaHD + "'");
            bt_thoat.Enabled = false;
        }
        private void LoadDaTaGridview()
        {
            txt_maHD.Text = MaHD;
            string sql = "SELECT b.MaCTHD,a.TenSP,b.Tien,a.AnhSP FROM SanPham AS a INNER JOIN CTHoaDon AS b ON b.MaSP = a.MaSP INNER JOIN HoaDon AS c ON c.MaHD = b.MaHD WHERE b.MaHD='" + MaHD + "'";
            dt_CTHD.DataSource = Ham.GetDataToTable(sql);
            string sql1 = "SELECT TongTien from HoaDon Where MaHD='" + MaHD + "'";
            txt_tongtien.Text = Ham.GetFieldValues(sql1);
            dt_CTHD.ReadOnly = true;
            dt_CTHD.AllowUserToResizeColumns = false;
            dt_CTHD.AllowUserToDeleteRows = false;
            dt_CTHD.AutoGenerateColumns = false;
            dt_CTHD.AllowUserToAddRows = false;
            cb_giamgia.SelectedItem = "%";
            txt_giamgia.Text = "0";
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string sql = "Update HoaDon Set TongTien='" + Convert.ToInt32(txt_tongtien.Text.Trim().ToString()) + "',GiamGia='" + Convert.ToInt32(txt_giamgia.Text.Trim().ToString()) +"'Where MaHD = '" + MaHD + "'";
            Ham.RunSQL(sql);
            for (int i = 0;i< Convert.ToInt32(Ham.GetFieldValues("Select Count(MaCTHD) From CTHoaDon Where MaHD='" + MaHD + "'")); i++)
            {
                string MaSP = Ham.GetFieldValues("SELECT MaSP FROM CTHoaDon WHERE MaCTHD='"+i.ToString()+"' AND MaHD='"+MaHD+"'");
                string id = Ham.GetFieldValues("SELECT TOP 1 id FROM DigiKey WHERE MaSP='"+ MaSP + "' AND TrangThai=N'Chưa Sử Dụng' ORDER BY NEWID()");
                Ham.RunSQL("Update DigiKey Set TrangThai=N'Đã Sử Dụng' Where Id='"+id+"' And MaSP='"+MaSP+"'");
                Ham.RunSQL("Update CTHoaDon Set Id='" + id + "' Where MaSP='" + MaSP + "' And MaHD='"+MaHD+"'");
            }
            MessageBox.Show("Đã lưu hóa đơn thành công với Mã Hóa Đơn Là " + MaHD , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bt_luu.Enabled = false;
            bt_huydon.Enabled = false;
            bt_thoat.Enabled = true;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Là Muốn Hủy Đơn", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sql = "DELETE CTHoaDon WHERE MaHD ='" + MaHD + "'";
                Ham.RunSqlDel(sql);
                string sql1 = "DELETE HoaDon WHERE MaHD ='" + MaHD + "'";
                Ham.RunSqlDel(sql1);
                this.Close();
            }
        }

        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, gg;
            string sql = "Select sum(Tien) as Tien from CTHoaDon where MaHD='" + MaHD + "'";
            string tien = Ham.GetFieldValues(sql);
            string loai = cb_giamgia.SelectedItem.ToString();
            if (loai == "%")
            {
                if (txt_giamgia.Text == "")
                {
                    gg = 0;
                }
                else
                {
                    gg = Convert.ToDouble(txt_giamgia.Text);
                }
                tt = Convert.ToDouble(tien) * ((100 - gg) / 100);
                txt_tongtien.Text = tt.ToString();
            }
            if (loai=="đ")
            {
                if (txt_giamgia.Text == "")
                {
                    gg = 0;
                }
                else
                {
                    gg = Convert.ToDouble(txt_giamgia.Text);
                }
                tt = Convert.ToDouble(tien) - gg;
                txt_tongtien.Text = tt.ToString();
            }
        }
        private void txt_solg_Leave(object sender, EventArgs e)
        {

        }

        private void cb_giamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_giamgia.Text = "0";
        }

        private void dt_CTHD_Click(object sender, EventArgs e)
        {
            txt_CTHD.Text = dt_CTHD.CurrentRow.Cells["MaCTHD"].Value.ToString();
            txt_tensach.Text = dt_CTHD.CurrentRow.Cells["TenSP"].Value.ToString();
            txt_tien.Text = dt_CTHD.CurrentRow.Cells["Tien"].Value.ToString();
            if (dt_CTHD.CurrentRow.Cells["AnhSP"].Value.ToString() != null && dt_CTHD.CurrentRow.Cells["AnhSP"].Value != DBNull.Value)
            {
                byte[] imgData = (byte[])(dt_CTHD.CurrentRow.Cells["AnhSP"].Value);
                var stream = new MemoryStream(imgData);
                ptrbx_anhSP.Image = Image.FromStream(stream);
                ptrbx_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (bt_luu.Enabled==false)
            {
                txt_keycode.Text = Ham.Decrypt(Ham.GetFieldValues("SELECT a.KeyCode FROM DigiKey AS a INNER JOIN  CTHoaDon AS b ON b.Id = a.Id AND b.MaSP = a.MaSP WHERE b.MaHD='"+MaHD+"' AND b.MaCTHD='"+txt_CTHD.Text.ToString()+"'"));
            }
            if (bt_luu.Enabled == true)
            {
                txt_keycode.Text = "Chưa Thanh Toán Thì Key Sẽ Không Hiển Thị";
            }
            else
            {
                ptrbx_anhSP.Image = null;
            }
        }

        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
