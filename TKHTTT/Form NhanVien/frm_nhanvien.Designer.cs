
namespace TKHTTT
{
    partial class frm_nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nhanvien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_mnv = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tnv = new System.Windows.Forms.TextBox();
            this.dt_NV = new System.Windows.Forms.DataGridView();
            this.cb_Gioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_bo = new System.Windows.Forms.Button();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_chon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mkt_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.bt_quanly = new System.Windows.Forms.Button();
            this.AnhNV = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_NV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mnv
            // 
            this.txt_mnv.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_mnv.Location = new System.Drawing.Point(124, 57);
            this.txt_mnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mnv.Name = "txt_mnv";
            this.txt_mnv.Size = new System.Drawing.Size(78, 26);
            this.txt_mnv.TabIndex = 2;
            this.txt_mnv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mnv_KeyUp);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_sdt.Location = new System.Drawing.Point(124, 156);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(129, 26);
            this.txt_sdt.TabIndex = 5;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_tnv
            // 
            this.txt_tnv.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_tnv.Location = new System.Drawing.Point(124, 87);
            this.txt_tnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tnv.Name = "txt_tnv";
            this.txt_tnv.Size = new System.Drawing.Size(185, 26);
            this.txt_tnv.TabIndex = 3;
            this.txt_tnv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_tnv_KeyUp);
            // 
            // dt_NV
            // 
            this.dt_NV.AllowUserToAddRows = false;
            this.dt_NV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_NV.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dt_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnhNV,
            this.MaNV,
            this.HoTenNV,
            this.NgaySinhNV,
            this.GioiTinh,
            this.DiaChi,
            this.SDTNV,
            this.TrangThai,
            this.ChucVu});
            this.dt_NV.Location = new System.Drawing.Point(19, 244);
            this.dt_NV.MultiSelect = false;
            this.dt_NV.Name = "dt_NV";
            this.dt_NV.ReadOnly = true;
            this.dt_NV.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dt_NV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dt_NV.RowTemplate.Height = 24;
            this.dt_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_NV.Size = new System.Drawing.Size(996, 178);
            this.dt_NV.TabIndex = 8;
            this.dt_NV.Click += new System.EventHandler(this.dt_NV_Click);
            // 
            // cb_Gioitinh
            // 
            this.cb_Gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gioitinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cb_Gioitinh.FormattingEnabled = true;
            this.cb_Gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_Gioitinh.Location = new System.Drawing.Point(124, 120);
            this.cb_Gioitinh.Name = "cb_Gioitinh";
            this.cb_Gioitinh.Size = new System.Drawing.Size(78, 27);
            this.cb_Gioitinh.TabIndex = 4;
            this.cb_Gioitinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Gioitinh_KeyPress);
            this.cb_Gioitinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cb_Gioitinh_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(14, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(486, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Địa Chỉ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(14, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DodgerBlue;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(15, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "SĐT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DodgerBlue;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(14, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(420, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.bt_luu);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_dong);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_bo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1042, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 441);
            this.panel1.TabIndex = 7;
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_them.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_them.Image = global::TKHTTT.Properties.Resources.Add;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(21, 37);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(146, 37);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "&Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.btthem_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_luu.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_luu.Image = global::TKHTTT.Properties.Resources.save;
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(21, 128);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(146, 37);
            this.bt_luu.TabIndex = 2;
            this.bt_luu.Text = "&Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_xoa.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_xoa.Image = global::TKHTTT.Properties.Resources.Del;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(21, 218);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(146, 37);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "&Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_dong.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_dong.Image = global::TKHTTT.Properties.Resources.Close;
            this.bt_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dong.Location = new System.Drawing.Point(21, 358);
            this.bt_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(146, 64);
            this.bt_dong.TabIndex = 5;
            this.bt_dong.Text = "&Thoát";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_sua.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_sua.Image = global::TKHTTT.Properties.Resources.Edit;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(21, 82);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(146, 37);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "&Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // bt_bo
            // 
            this.bt_bo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_bo.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_bo.Image = global::TKHTTT.Properties.Resources.cancel;
            this.bt_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bo.Location = new System.Drawing.Point(21, 173);
            this.bt_bo.Margin = new System.Windows.Forms.Padding(2);
            this.bt_bo.Name = "bt_bo";
            this.bt_bo.Size = new System.Drawing.Size(146, 37);
            this.bt_bo.TabIndex = 3;
            this.bt_bo.Text = "&Hủy";
            this.bt_bo.UseVisualStyleBackColor = true;
            this.bt_bo.Click += new System.EventHandler(this.bt_bo_Click);
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_dc.Location = new System.Drawing.Point(568, 54);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(447, 26);
            this.txt_dc.TabIndex = 41;
            this.txt_dc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dc_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(646, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // bt_chon
            // 
            this.bt_chon.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_chon.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_chon.Image = global::TKHTTT.Properties.Resources.Add;
            this.bt_chon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chon.Location = new System.Drawing.Point(869, 90);
            this.bt_chon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_chon.Name = "bt_chon";
            this.bt_chon.Size = new System.Drawing.Size(146, 37);
            this.bt_chon.TabIndex = 45;
            this.bt_chon.Text = "&Chọn File";
            this.bt_chon.UseVisualStyleBackColor = true;
            this.bt_chon.Click += new System.EventHandler(this.bt_chon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(14, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Ngày Sinh";
            // 
            // mkt_ngaysinh
            // 
            this.mkt_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.mkt_ngaysinh.Location = new System.Drawing.Point(124, 191);
            this.mkt_ngaysinh.Mask = "00/00/0000";
            this.mkt_ngaysinh.Name = "mkt_ngaysinh";
            this.mkt_ngaysinh.Size = new System.Drawing.Size(129, 26);
            this.mkt_ngaysinh.TabIndex = 64;
            this.mkt_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(333, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tình Trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(333, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Chức Vụ";
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_trangthai.Location = new System.Drawing.Point(425, 120);
            this.txt_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(185, 26);
            this.txt_trangthai.TabIndex = 68;
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_chucvu.Location = new System.Drawing.Point(425, 191);
            this.txt_chucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(185, 26);
            this.txt_chucvu.TabIndex = 69;
            // 
            // bt_quanly
            // 
            this.bt_quanly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_quanly.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_quanly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_quanly.Location = new System.Drawing.Point(869, 203);
            this.bt_quanly.Name = "bt_quanly";
            this.bt_quanly.Size = new System.Drawing.Size(146, 35);
            this.bt_quanly.TabIndex = 70;
            this.bt_quanly.Text = "&Đặt Lại Mật Khẩu";
            this.bt_quanly.UseVisualStyleBackColor = true;
            this.bt_quanly.Click += new System.EventHandler(this.bt_quanly_Click);
            // 
            // AnhNV
            // 
            this.AnhNV.DataPropertyName = "AnhNV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.AnhNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.AnhNV.HeaderText = "Ảnh Nhân Viên";
            this.AnhNV.MinimumWidth = 10;
            this.AnhNV.Name = "AnhNV";
            this.AnhNV.ReadOnly = true;
            this.AnhNV.Width = 201;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MaNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 120;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.HoTenNV.DefaultCellStyle = dataGridViewCellStyle4;
            this.HoTenNV.HeaderText = "Họ Tên Nhân Viên";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            this.HoTenNV.Width = 200;
            // 
            // NgaySinhNV
            // 
            this.NgaySinhNV.DataPropertyName = "NgaySinhNV";
            this.NgaySinhNV.HeaderText = "Ngày Sinh";
            this.NgaySinhNV.Name = "NgaySinhNV";
            this.NgaySinhNV.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.GioiTinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle6;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDTNV
            // 
            this.SDTNV.DataPropertyName = "SDTNV";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SDTNV.DefaultCellStyle = dataGridViewCellStyle7;
            this.SDTNV.HeaderText = "SDT";
            this.SDTNV.Name = "SDTNV";
            this.SDTNV.ReadOnly = true;
            this.SDTNV.Width = 120;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1221, 441);
            this.Controls.Add(this.bt_quanly);
            this.Controls.Add(this.txt_chucvu);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mkt_ngaysinh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_chon);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_Gioitinh);
            this.Controls.Add(this.dt_NV);
            this.Controls.Add(this.txt_tnv);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_mnv);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nhanvien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên ";
            this.Load += new System.EventHandler(this.frm_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_NV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_mnv;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tnv;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.DataGridView dt_NV;
        private System.Windows.Forms.ComboBox cb_Gioitinh;
        private System.Windows.Forms.Button bt_bo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.Button bt_chon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkt_ngaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.Button bt_quanly;
        private System.Windows.Forms.DataGridViewImageColumn AnhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
    }
}