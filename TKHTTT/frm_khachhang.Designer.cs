
namespace TKHTTT
{
    partial class frm_khachhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_khachhang));
            this.dt_kh = new System.Windows.Forms.DataGridView();
            this.AnhKH = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tkh = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mkh = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.cb_Gioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_bo = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.btdong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_chon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mkt_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_kh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_kh
            // 
            this.dt_kh.AllowUserToAddRows = false;
            this.dt_kh.AllowUserToDeleteRows = false;
            this.dt_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnhKH,
            this.MaKH,
            this.TenKH,
            this.GioiTinhKH,
            this.NgaySinhKH,
            this.DChi,
            this.SDTKH});
            this.dt_kh.Location = new System.Drawing.Point(19, 244);
            this.dt_kh.Margin = new System.Windows.Forms.Padding(2);
            this.dt_kh.MultiSelect = false;
            this.dt_kh.Name = "dt_kh";
            this.dt_kh.ReadOnly = true;
            this.dt_kh.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dt_kh.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_kh.RowTemplate.Height = 24;
            this.dt_kh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_kh.Size = new System.Drawing.Size(994, 178);
            this.dt_kh.TabIndex = 7;
            this.dt_kh.Click += new System.EventHandler(this.dt_kh_Click);
            // 
            // AnhKH
            // 
            this.AnhKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnhKH.DataPropertyName = "AnhKH";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.AnhKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.AnhKH.HeaderText = "Ảnh Khách Hàng";
            this.AnhKH.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AnhKH.Name = "AnhKH";
            this.AnhKH.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaKH.Width = 120;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Họ Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenKH.Width = 200;
            // 
            // GioiTinhKH
            // 
            this.GioiTinhKH.DataPropertyName = "GioiTinhKH";
            this.GioiTinhKH.HeaderText = "Giới Tính";
            this.GioiTinhKH.Name = "GioiTinhKH";
            this.GioiTinhKH.ReadOnly = true;
            this.GioiTinhKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinhKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgaySinhKH
            // 
            this.NgaySinhKH.DataPropertyName = "NgaySinhKH";
            this.NgaySinhKH.HeaderText = "Ngày Sinh";
            this.NgaySinhKH.Name = "NgaySinhKH";
            this.NgaySinhKH.ReadOnly = true;
            // 
            // DChi
            // 
            this.DChi.DataPropertyName = "DChi";
            this.DChi.HeaderText = "Địa Chỉ";
            this.DChi.Name = "DChi";
            this.DChi.ReadOnly = true;
            this.DChi.Width = 120;
            // 
            // SDTKH
            // 
            this.SDTKH.DataPropertyName = "SDTKH";
            this.SDTKH.HeaderText = "SDT";
            this.SDTKH.Name = "SDTKH";
            this.SDTKH.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(410, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(15, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txt_tkh
            // 
            this.txt_tkh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_tkh.Location = new System.Drawing.Point(130, 86);
            this.txt_tkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tkh.Name = "txt_tkh";
            this.txt_tkh.Size = new System.Drawing.Size(162, 26);
            this.txt_tkh.TabIndex = 1;
            this.txt_tkh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_tkh_KeyUp);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_sdt.Location = new System.Drawing.Point(130, 156);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(129, 26);
            this.txt_sdt.TabIndex = 4;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            this.txt_sdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sdt_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(400, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Địa Chỉ";
            // 
            // txt_mkh
            // 
            this.txt_mkh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_mkh.Location = new System.Drawing.Point(130, 56);
            this.txt_mkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mkh.Name = "txt_mkh";
            this.txt_mkh.Size = new System.Drawing.Size(69, 26);
            this.txt_mkh.TabIndex = 0;
            this.txt_mkh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mkh_KeyUp);
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(470, 54);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(390, 26);
            this.txt_dc.TabIndex = 5;
            this.txt_dc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dc_KeyUp);
            // 
            // cb_Gioitinh
            // 
            this.cb_Gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gioitinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cb_Gioitinh.Location = new System.Drawing.Point(130, 120);
            this.cb_Gioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Gioitinh.Name = "cb_Gioitinh";
            this.cb_Gioitinh.Size = new System.Drawing.Size(69, 27);
            this.cb_Gioitinh.TabIndex = 3;
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
            this.label7.TabIndex = 32;
            this.label7.Text = "Giới Tính";
            // 
            // bt_bo
            // 
            this.bt_bo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_bo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_bo.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_bo.Image = global::TKHTTT.Properties.Resources.cancel;
            this.bt_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bo.Location = new System.Drawing.Point(21, 173);
            this.bt_bo.Margin = new System.Windows.Forms.Padding(2);
            this.bt_bo.Name = "bt_bo";
            this.bt_bo.Size = new System.Drawing.Size(146, 35);
            this.bt_bo.TabIndex = 3;
            this.bt_bo.Text = "&Hủy";
            this.bt_bo.UseVisualStyleBackColor = true;
            this.bt_bo.Click += new System.EventHandler(this.bt_bo_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_sua.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_sua.Image = global::TKHTTT.Properties.Resources.Edit;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(21, 82);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(146, 35);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "&Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btdong
            // 
            this.btdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btdong.ForeColor = System.Drawing.Color.DarkBlue;
            this.btdong.Image = global::TKHTTT.Properties.Resources.Close;
            this.btdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdong.Location = new System.Drawing.Point(21, 362);
            this.btdong.Margin = new System.Windows.Forms.Padding(2);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(146, 60);
            this.btdong.TabIndex = 5;
            this.btdong.Text = "&Thoát";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_xoa.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_xoa.Image = global::TKHTTT.Properties.Resources.Del;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(21, 218);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(146, 35);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "&Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_luu.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_luu.Image")));
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(21, 128);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(146, 35);
            this.bt_luu.TabIndex = 2;
            this.bt_luu.Text = "&Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bt_them
            // 
            this.bt_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_them.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_them.Image = global::TKHTTT.Properties.Resources.Add1;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(21, 37);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(146, 37);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "&Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.btthem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.bt_bo);
            this.panel1.Controls.Add(this.bt_luu);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.btdong);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1036, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 438);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(485, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // bt_chon
            // 
            this.bt_chon.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_chon.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_chon.Image = global::TKHTTT.Properties.Resources.Add;
            this.bt_chon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chon.Location = new System.Drawing.Point(714, 90);
            this.bt_chon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_chon.Name = "bt_chon";
            this.bt_chon.Size = new System.Drawing.Size(146, 37);
            this.bt_chon.TabIndex = 48;
            this.bt_chon.Text = "&Chọn File";
            this.bt_chon.UseVisualStyleBackColor = true;
            this.bt_chon.Click += new System.EventHandler(this.bt_chon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(15, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ngày Sinh";
            // 
            // mkt_ngaysinh
            // 
            this.mkt_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.mkt_ngaysinh.Location = new System.Drawing.Point(130, 191);
            this.mkt_ngaysinh.Mask = "00/00/0000";
            this.mkt_ngaysinh.Name = "mkt_ngaysinh";
            this.mkt_ngaysinh.Size = new System.Drawing.Size(129, 26);
            this.mkt_ngaysinh.TabIndex = 49;
            this.mkt_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // frm_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1216, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mkt_ngaysinh);
            this.Controls.Add(this.bt_chon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_Gioitinh);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.txt_mkh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tkh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_kh);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frm_khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_kh)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView dt_kh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tkh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mkh;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.ComboBox cb_Gioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_bo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_chon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mkt_ngaysinh;
        private System.Windows.Forms.DataGridViewImageColumn AnhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKH;
    }
}