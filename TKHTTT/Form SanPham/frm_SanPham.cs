using QuanLySach.Class;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace TKHTTT
{
    public partial class frm_SanPham : Form
    {
        DataTable dboSP;
        public frm_SanPham()
        {
            InitializeComponent();
            Ham.Connect();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            ProcessAddButton();
            ProcessEditButton();
            LoadDataGridView();
            OnReadOnly();
            ResetValues();
            cb_danhmuc.SelectedIndex = 0;
        }
        private void ResetValues()
        {
            txt_masanpham.Text = "";
            txt_tensanpham.Text = "";
            cb_danhmuc.Text = "";
            txt_slg.Text = "0";
            txt_gia.Text = "0";
            rtxt_mota.Text = "";
            cb_danhmuc.SelectedIndex = -1;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT DISTINCT a.TenSP,a.Gia,CAST(a.MoTa AS NVARCHAR(max)) AS Mota,c.DanhMuc,CAST(a.AnhSP AS VARBINARY(max)) AS AnhSP, " +
                "SUBSTRING( ( SELECT ',' + d.TenTheLoai AS[text()] FROM dbo.TheLoai AS d INNER JOIN dbo.CTTheLoai AS f ON f.MaTheLoai = d.MaTheLoai WHERE f.MaSP=a.MaSP FOR XML PATH('')), 2, 1000 ) AS TenTheLoai FROM SanPham AS a " +
                "INNER JOIN CTTheLoai AS b ON b.MaSP = a.MaSP " +
                "INNER JOIN TheLoai AS c ON c.MaTheLoai = b.MaTheLoai";
            dboSP = Ham.GetDataToTable(sql);
            dt_SP.DataSource = dboSP;
            dt_SP.AllowUserToAddRows = false;
            dt_SP.EditMode = DataGridViewEditMode.EditProgrammatically;
            dt_SP.AllowUserToResizeColumns = false;
            dt_SP.AllowUserToDeleteRows = false;
            dt_SP.AutoGenerateColumns = false;
            dt_SP.AllowUserToAddRows = false;
            if (dt_SP.Rows.Count != 0)
            {
                dt_SP.CurrentCell.Selected = true;
            }
            cb_danhmuc.DataSource = Ham.GetDataToTable("SELECT DISTINCT DanhMuc FROM dbo.TheLoai");
            cb_danhmuc.ValueMember = "DanhMuc";
            lb_theloai.DataSource = Ham.GetDataToTable("SELECT * FROM dbo.TheLoai Where DanhMuc=N'" + cb_danhmuc.Text.ToString() + "'");
            lb_theloai.ValueMember = "TenTheLoai";
            lb_theloai.SelectedIndex = -1;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bt_them.Text = "Đang Thêm...";
            ProcessAddButton();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string sql, sql1;
            if (bt_sua.Text == "Đang Sửa...")
            {
                if (dboSP.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool result = CheckCondition();
                if (result == false)
                {
                    return;
                }
                if (pictureBox1.Image == null)
                {
                    sql = "sp_SuaSanPham_noImg";
                    string value1 = txt_tensanpham.Text.ToString();
                    string value2 = txt_gia.Text.ToString();
                    string value3 = rtxt_mota.Text.ToString();
                    string value4 = txt_masanpham.Text.ToString();
                    Ham.sp_Product_nImg(sql, value1, value2, value3, value4);
                    int i = 0;
                    foreach (object selecteditem in lb_theloai.SelectedItems)
                    {
                        i++;
                        DataRowView dr = (DataRowView)selecteditem;
                        string selectedValue = dr["tentheloai"].ToString();
                        string MaTheLoai = Ham.GetFieldValues("Select MaTheLoai from TheLoai where TenTheLoai=N'" + selectedValue + "'");
                        sql1 = "Insert into CTTheLoai VALUES ('" + i.ToString() + "','" + MaTheLoai.ToString() + "','" + txt_masanpham.Text.ToString().Trim() + "')";
                        Ham.RunSQL(sql1);
                    }
                }
                else
                {
                    sql = "sp_SuaSanPham";
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    string value1 = txt_tensanpham.Text.ToString();
                    string value2 = txt_gia.Text.ToString();
                    string value3 = rtxt_mota.Text.ToString();
                    string value4 = txt_masanpham.Text.ToString();
                    Ham.sp_Product(sql, value1, value2, pic, value3, value4);
                    int i = 0;
                    foreach (object selecteditem in lb_theloai.SelectedItems)
                    {
                        i++;
                        DataRowView dr = (DataRowView)selecteditem;
                        string selectedValue = dr["tentheloai"].ToString();
                        string MaTheLoai = Ham.GetFieldValues("Select MaTheLoai from TheLoai where TenTheLoai=N'" + selectedValue + "'");
                        //MessageBox.Show(""+ selectedValue + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sql1 = "Insert into CTTheLoai VALUES ('" + i.ToString() + "','" + MaTheLoai.ToString() + "','" + txt_masanpham.Text.ToString().Trim() + "')";
                        Ham.RunSQL(sql1);
                    }
                }
                bt_sua.Text = "Sửa";
                LoadDataGridView();
                ResetValues();
                ProcessEditButton();
            }
            // code thêm sản phẩm vào database
            else
            {
                bool result = CheckCondition();
                if (result == false)
                {
                    return;
                }
                // kiểm tra picturebox có dữ liệu không nếu null thì thực hiện chạy sql nếu có thì chạy sql1
                if (pictureBox1.Image == null)
                {
                    sql = "INSERT INTO SanPham VALUES ( N'" + txt_tensanpham.Text.ToString() + "','" + txt_gia.Text.ToString() + "','null','" + rtxt_mota.Text.ToString().Trim() + "')";
                    Ham.RunSQL(sql);
                    int i = 0;
                    foreach (object selecteditem in lb_theloai.SelectedItems)
                    {
                        i++;
                        DataRowView dr = (DataRowView)selecteditem;
                        string selectedValue = dr["tentheloai"].ToString();
                        string MaTheLoai = Ham.GetFieldValues("Select MaTheLoai from TheLoai where TenTheLoai=N'" + selectedValue + "'");
                        string MaSP = Ham.GetFieldValues("Select MaSP from SanPham where TenSP=N'" + txt_tensanpham.Text.ToString() + "'And Gia='" + txt_gia.Text.ToString() + "'And Mota Like N'" + rtxt_mota.Text.ToString() + "'");
                        //MessageBox.Show(""+ selectedValue + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sql1 = "Insert into CTTheLoai VALUES ('" + i.ToString() + "','" + MaTheLoai.ToString() + "','" + MaSP + "')";
                        Ham.RunSQL(sql1);
                    }
                }
                else
                {
                    sql = "INSERT INTO SanPham VALUES ( N'" + txt_tensanpham.Text.ToString() + "','" + txt_gia.Text.ToString() + "',@pic,'" + rtxt_mota.Text.ToString().Trim() + "')";
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    Ham.ImportImg(sql, pic);
                    int i = 0;
                    foreach (object selecteditem in lb_theloai.SelectedItems)
                    {
                        i++;
                        DataRowView dr = (DataRowView)selecteditem;
                        string selectedValue = dr["tentheloai"].ToString();
                        string MaTheLoai = Ham.GetFieldValues("Select MaTheLoai from TheLoai where TenTheLoai=N'" + selectedValue + "'");
                        string MaSP = Ham.GetFieldValues("Select MaSP from SanPham where TenSP=N'" + txt_tensanpham.Text.ToString() + "'And Gia='" + txt_gia.Text.ToString() + "'And Mota Like N'" + rtxt_mota.Text.ToString() + "'");
                        //MessageBox.Show(""+ selectedValue + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sql1 = "Insert into CTTheLoai VALUES ('" + i.ToString() + "','" + MaTheLoai.ToString() + "','" + MaSP + "')";
                        Ham.RunSQL(sql1);
                    }
                }
                bt_them.Text = "Thêm";
                LoadDataGridView();
                ResetValues();
                ProcessAddButton();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (dboSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_masanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bt_sua.Text = "Đang Sửa...";
            ProcessEditButton();
        }
        // hàm không cho chỉnh sửa trên form
        public void OnReadOnly()
        {
            txt_tensanpham.ReadOnly = true;
            txt_gia.ReadOnly = true;
            rtxt_mota.ReadOnly = true;
            cb_danhmuc.Enabled = false;
            bt_chonanhsanpham.Visible = false;
            lb_theloai.Enabled = false;
        }
        // hàm cho chỉnh sửa trên form
        public void OffReadOnly()
        {
            txt_tensanpham.ReadOnly = false;
            txt_gia.ReadOnly = false;
            rtxt_mota.ReadOnly = false;
            cb_danhmuc.Enabled = true;
            bt_chonanhsanpham.Visible = true;
            lb_theloai.Enabled = true;
        }
        // hàm check điều kiện nhập vào
        public bool CheckCondition()
        {
            if (txt_tensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensanpham.Focus();
                return false;
            }
            if (cb_danhmuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn thể loại của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_danhmuc.Focus();
                return false;
            }
            if (txt_gia == null)
            {
                MessageBox.Show("Bạn phải nhập giá cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_gia.Focus();
                return false;
            }
            else
                return true;
        }

        // hàm xử lí button trên form
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

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dboSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_masanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá sản phẩm " + txt_tensanpham.Text.ToString() + " đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "sp_XoaSP";
                string value = txt_masanpham.Text.ToString();
                Ham.sp_XoaSP(sql, value);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            if (bt_luu.Enabled == true)
            {
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

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_slg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Đang Thêm...")
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_masanpham.Focus();
                return;
            }
            if (bt_sua.Text == "Đang Sửa...")
            {
                MessageBox.Show("Đang ở chế độ sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensanpham.Focus();
                return;
            }
            frm_NhomSP frmnhsp = new frm_NhomSP();
            frmnhsp.ShowDialog();
        }
        private void bt_chonanhsanpham_Click(object sender, EventArgs e)
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

        private void cb_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_theloai.DataSource = Ham.GetDataToTable("SELECT * FROM dbo.TheLoai Where DanhMuc=N'" + cb_danhmuc.Text.ToString() + "'");
            lb_theloai.ValueMember = "TenTheLoai";
        }

        private void dt_SP_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Đang Thêm...")
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_masanpham.Focus();
                return;
            }
            if (bt_sua.Text == "Đang Sửa...")
            {
                MessageBox.Show("Đang ở chế độ sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensanpham.Focus();
                return;
            }
            if (dboSP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lb_theloai.SelectedIndex = -1;
            txt_tensanpham.Text = dt_SP.CurrentRow.Cells["TenSP"].Value.ToString();
            cb_danhmuc.Text = dt_SP.CurrentRow.Cells["DanhMuc"].Value.ToString();
            rtxt_mota.Text = dt_SP.CurrentRow.Cells["Mota"].Value.ToString();
            txt_gia.Text = dt_SP.CurrentRow.Cells["Gia"].Value.ToString();
            txt_masanpham.Text = Ham.GetFieldValues("Select MaSP from SanPham where TenSP=N'" + txt_tensanpham.Text.Trim().ToString() + "' And Mota Like N'" + rtxt_mota.Text.Trim().ToString() + "' And Gia='" + txt_gia.Text.ToString() + "'");
            txt_slg.Text = Ham.GetFieldValues("SELECT COUNT(Keycode) FROM dbo.DigiKey INNER JOIN dbo.SanPham ON SanPham.MaSP = DigiKey.MaSP where SanPham.MaSP = '" + txt_masanpham.Text.ToString() + "'And DigiKey.TrangThai=N'Chưa Sử Dụng'");
            for (int i = 0; i < Ham.GetDataToTable("SELECT b.TenTheLoai FROM dbo.CTTheLoai AS a INNER JOIN dbo.TheLoai AS b ON b.MaTheLoai = a.MaTheLoai WHERE a.MaSP='" + txt_masanpham.Text.ToString() + "'AND b.DanhMuc='" + cb_danhmuc.Text.ToString() + "'").Rows.Count; i++)
            {
                lb_theloai.SelectedValue = Ham.GetDataToTable("SELECT * FROM dbo.CTTheLoai AS a INNER JOIN dbo.TheLoai AS b ON b.MaTheLoai = a.MaTheLoai WHERE a.MaSP='" + txt_masanpham.Text.ToString() + "'").Rows[i][4].ToString();
            }
            if (dt_SP.CurrentRow.Cells["AnhSP"].Value.ToString() != null && dt_SP.CurrentRow.Cells["AnhSP"].Value != DBNull.Value)
            {
                byte[] imgData = (byte[])(dt_SP.CurrentRow.Cells["AnhSP"].Value);
                var stream = new MemoryStream(imgData);
                pictureBox1.Image = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void bt_kiemtra_Click(object sender, EventArgs e)
        {
            Frrm_key.MaSP = txt_masanpham.Text.ToString();
            Frrm_key frrm_Key = new Frrm_key();
            frrm_Key.ShowDialog();
        }
    }
}
