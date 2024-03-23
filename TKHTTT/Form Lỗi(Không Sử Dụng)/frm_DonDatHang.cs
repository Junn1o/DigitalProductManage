using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySach.Class;

namespace TKHTTT
{
    public partial class frm_DonDatHang : Form
    {
        public frm_DonDatHang()
        {
            InitializeComponent();
            Ham.Connect();
            rd_KH.Checked = true;
        }

        private void DonDatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn Chưa Nhập Từ Khóa Tìm KIếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_theloai.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Loại Tìm KIếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            listBox1.Items.Clear();
            string theloai = cb_theloai.SelectedItem.ToString();
            switch (theloai)
            {
                case "Mã Sách" :
                        string sql = "Select * from SanPham where MaSach like '%" + txt_timkiem.Text.Trim() + "%'";
                        Ham.GetDataToTable(sql);
                        for (int i = 0; i<Ham.GetDataToTable(sql).Rows.Count;i++)
                            {
                                listBox1.Items.Add(Ham.GetDataToTable(sql).Rows[i][1].ToString());
                            }
                        break;

                case "Tên Sách":
                    string sql1 = "Select * from SanPham where TenSach like N'%" + txt_timkiem.Text.Trim() + "%'";
                    Ham.GetDataToTable(sql1);
                    for (int i = 0; i < Ham.GetDataToTable(sql1).Rows.Count; i++)
                    {
                        listBox1.Items.Add(Ham.GetDataToTable(sql1).Rows[i][1].ToString());
                    }
                    break;
                case "Tác Giả":
                    string sql2 = "Select * from SanPham where TacGia like N'%" + txt_timkiem.Text.Trim() + "%'";
                    Ham.GetDataToTable(sql2);
                    for (int i = 0; i < Ham.GetDataToTable(sql2).Rows.Count; i++)
                    {
                        listBox1.Items.Add(Ham.GetDataToTable(sql2).Rows[i][1].ToString());
                    }
                    break;
                case "Thể Loại":
                    string sql3 = "SELECT MaSach,TenSach,TenNhom,SoLuongSach,Gia FROM dbo.SanPham,dbo.NhomSP WHERE NhomSP.MaNhomSach=SanPham.MaNhomSach AND TenNhom like N'%" + txt_timkiem.Text.Trim() + "%'";
                    Ham.GetDataToTable(sql3);
                    for (int i = 0; i < Ham.GetDataToTable(sql3).Rows.Count; i++)
                    {
                        listBox1.Items.Add(Ham.GetDataToTable(sql3).Rows[i][1].ToString());
                    }
                    break;
                default:
                    MessageBox.Show("Bạn chưa chọn loại tìm kiếm" + theloai);
                    cb_theloai.Focus();
                    break;
            }
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (txt_soluong.Text.Trim() == "0")
                {
                    MessageBox.Show("Sản Phẩm Này Đã Hết Hàng Vui Lòng Chọn Sản Phẩm Khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                txt_soluong.Clear();
                if (listBox1.SelectedItems.Count > 0)
                {
                    while (listBox1.SelectedItems.Count > 0)
                    {
                        listBox2.Items.Add(listBox1.SelectedItem);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Sách Để Thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                txt_soluong.Clear();
                if (listBox2.SelectedItems.Count > 0)
                {
                    while (listBox2.SelectedItems.Count > 0)
                    {
                        listBox1.Items.Add(listBox2.SelectedItem);
                        listBox2.Items.Remove(listBox2.SelectedItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Sách Để Bỏ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cb_makhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cb_makhach.Text == "")
            {
                txt_tenKh.Text = "";
                txt_diachi.Text = "";
                txt_sdt.Text = "";
            }
            str = "Select TenKH from dbo.KhachHang where MaKH = '" + cb_makhach.SelectedValue + "'";
            txt_tenKh.Text = Ham.GetFieldValues(str);
            str = "Select Dchi from dbo.KhachHang where MaKH = '" + cb_makhach.SelectedValue + "'";
            txt_diachi.Text = Ham.GetFieldValues(str);
            str = "Select SDTKH from dbo.KhachHang where MaKH= '" + cb_makhach.SelectedValue + "'";
            txt_sdt.Text = Ham.GetFieldValues(str);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(cb_makhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_makhach.Focus();
                return;
            }
            if (cb_maNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maNV.Focus();
                return;
            }
            if (listBox2.Items.Count == 0 )
            {
                MessageBox.Show("Bạn chưa có sản phẩm nào trong giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maNV.Focus();
                return;
            }
            string sql;
            txt_maHD.Text = Ham.CreateKey("HD");
            sql = "INSERT INTO dbo.HoaDon(MaHD,MaKH,MaNV,NgayLap,TienTToan) VALUES ('" + txt_maHD.Text.Trim() + "','" + cb_makhach.Text.Trim() + "','" + cb_maNV.Text.Trim() + "','"+ dtp_NL.Value.ToString() + "','" + 0 + "')";
            Ham.RunSQL(sql);
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string MaSach = Ham.GetDataToTable("Select MaSach from dbo.SanPham where TenSach=N'" + listBox2.Items[i].ToString().Trim() + "'").Rows[0][0].ToString().Trim(); 
                string ThanhTien = Ham.GetDataToTable("SELECT gia FROM dbo.SanPham WHERE MaSach='" + MaSach + "'").Rows[0][0].ToString().Trim();
                string sql1 = "INSERT INTO dbo.CTHoaDon (MaCTHD,MaHD,MaSach,SoLuong,ThanhTien) values('" + i.ToString() + "','" + txt_maHD.Text.ToString().Trim() + "','" + MaSach + "','" + 1 + "','" + Convert.ToInt32(ThanhTien) + "')";
                Ham.RunSQL(sql1);
            }
            frm_HoaDon.MaHD = txt_maHD.Text.Trim();
            frm_HoaDon frm = new frm_HoaDon();
            frm.ShowDialog();
            rd_KH.Checked = true;
            ResetValue();
            LoadData();
        }
        private void ResetValue()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            txt_maHD.Text = "";
            cb_theloai.SelectedIndex = -1;
        }
        public void LoadData()
        {
            string sql = "Select * From dbo.SanPham";
            Ham.GetDataToTable(sql);
            for (int i = 0; i < Ham.GetDataToTable(sql).Rows.Count; i++)
            {
                listBox1.Items.Add(Ham.GetDataToTable(sql).Rows[i][1].ToString());
            }
            Ham.FillCombo("SELECT MaKH, TenKH FROM dbo.KhachHang", cb_makhach, "MaKH", "MaKH");
            cb_makhach.SelectedIndex = -1;
            Ham.FillCombo("SELECT MaNV, HoTenNV FROM dbo.NhanVien", cb_maNV, "MaNV", "MaNV");
            cb_maNV.SelectedIndex = -1;
        }

        private void cb_maNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cb_maNV.Text == "")
            {
                txt_tenNV.Text = "";
                txt_diachiNV.Text = "";
                txt_sdtNV.Text = "";
            }
            str = "Select HoTenNV from dbo.NhanVien where MaNV = '" + cb_maNV.SelectedValue + "'";
            txt_tenNV.Text = Ham.GetFieldValues(str);
            str = "Select DiaChi from dbo.NhanVien where MaNV = '" + cb_maNV.SelectedValue + "'";
            txt_diachiNV.Text = Ham.GetFieldValues(str);
            str = "Select SDTNV from dbo.NhanVien where MaNV= '" + cb_maNV.SelectedValue + "'";
            txt_sdtNV.Text = Ham.GetFieldValues(str);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_KH.Checked==true)
            {
                groupBox3.Visible = false;
                groupBox4.Visible = true;
            }
        }

        private void rd_NV_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_NV.Checked == true)
            {
                groupBox4.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                textBox1.Text = listBox2.SelectedItem.ToString();
                string sql = "SELECT TacGia FROM dbo.SanPham WHERE TenSach=N'"+textBox1.Text.ToString()+"'";
                textBox2.Text = Ham.GetFieldValues(sql);
                string sql2 = "SELECT Gia FROM dbo.SanPham WHERE TenSach=N'" + textBox1.Text.ToString() + "'";
                textBox3.Text = Ham.GetFieldValues(sql2);
                string sql3 = "SELECT SoLuongSach FROM dbo.SanPham WHERE TenSach=N'" + textBox1.Text.ToString() + "'";
                txt_soluong.Text = Ham.GetFieldValues(sql3);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                string sql = "SELECT TacGia FROM dbo.SanPham WHERE TenSach=N'" + textBox1.Text.ToString() + "'";
                textBox2.Text = Ham.GetFieldValues(sql);
                string sql2 = "SELECT Gia FROM dbo.SanPham WHERE TenSach=N'" + textBox1.Text.ToString() + "'";
                textBox3.Text = Ham.GetFieldValues(sql2);
                string sql3 = "SELECT SoLuongSach FROM dbo.SanPham WHERE TenSach=N'" + textBox1.Text.ToString() + "'";
                txt_soluong.Text = Ham.GetFieldValues(sql3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_xoatk_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LoadData();
            txt_timkiem.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
