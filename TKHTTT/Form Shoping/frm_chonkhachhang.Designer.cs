namespace TKHTTT
{
    partial class frm_chonkhachhang
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
            this.dt_kh = new System.Windows.Forms.DataGridView();
            this.AnhKH = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.mkt_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.txt_mkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_chon = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_kh
            // 
            this.dt_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnhKH,
            this.MaKH,
            this.TenKH,
            this.GioiTinhKH,
            this.NgaySinhKH,
            this.DChi,
            this.SDTKH});
            this.dt_kh.Location = new System.Drawing.Point(11, 106);
            this.dt_kh.Margin = new System.Windows.Forms.Padding(2);
            this.dt_kh.MultiSelect = false;
            this.dt_kh.Name = "dt_kh";
            this.dt_kh.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dt_kh.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_kh.RowTemplate.Height = 24;
            this.dt_kh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_kh.Size = new System.Drawing.Size(903, 213);
            this.dt_kh.TabIndex = 8;
            this.dt_kh.Click += new System.EventHandler(this.dt_kh_Click);
            // 
            // AnhKH
            // 
            this.AnhKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnhKH.DataPropertyName = "AnhKH";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
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
            this.TenKH.HeaderText = "Tên Khách Hàng";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(28, 495);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "Ngày Sinh";
            // 
            // mkt_ngaysinh
            // 
            this.mkt_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.mkt_ngaysinh.Location = new System.Drawing.Point(143, 488);
            this.mkt_ngaysinh.Mask = "00/00/0000";
            this.mkt_ngaysinh.Name = "mkt_ngaysinh";
            this.mkt_ngaysinh.Size = new System.Drawing.Size(129, 26);
            this.mkt_ngaysinh.TabIndex = 62;
            this.mkt_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(477, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(27, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "Giới Tính";
            // 
            // cb_Gioitinh
            // 
            this.cb_Gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gioitinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cb_Gioitinh.Location = new System.Drawing.Point(143, 417);
            this.cb_Gioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Gioitinh.Name = "cb_Gioitinh";
            this.cb_Gioitinh.Size = new System.Drawing.Size(69, 27);
            this.cb_Gioitinh.TabIndex = 53;
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(477, 354);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(437, 26);
            this.txt_dc.TabIndex = 55;
            // 
            // txt_mkh
            // 
            this.txt_mkh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_mkh.Location = new System.Drawing.Point(143, 353);
            this.txt_mkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mkh.Name = "txt_mkh";
            this.txt_mkh.Size = new System.Drawing.Size(69, 26);
            this.txt_mkh.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(407, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(27, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_sdt.Location = new System.Drawing.Point(143, 453);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(129, 26);
            this.txt_sdt.TabIndex = 54;
            // 
            // txt_tkh
            // 
            this.txt_tkh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_tkh.Location = new System.Drawing.Point(143, 383);
            this.txt_tkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tkh.Name = "txt_tkh";
            this.txt_tkh.Size = new System.Drawing.Size(162, 26);
            this.txt_tkh.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(28, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(27, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // bt_chon
            // 
            this.bt_chon.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_chon.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_chon.Image = global::TKHTTT.Properties.Resources.Add;
            this.bt_chon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chon.Location = new System.Drawing.Point(759, 390);
            this.bt_chon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_chon.Name = "bt_chon";
            this.bt_chon.Size = new System.Drawing.Size(155, 39);
            this.bt_chon.TabIndex = 64;
            this.bt_chon.Text = "&Chọn Khách Hàng";
            this.bt_chon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_chon.UseVisualStyleBackColor = true;
            this.bt_chon.Click += new System.EventHandler(this.bt_chon_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(344, 33);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(256, 26);
            this.txt_timkiem.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(106, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tìm Kiếm";
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_timkiem.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_timkiem.Image = global::TKHTTT.Properties.Resources.Add;
            this.bt_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_timkiem.Location = new System.Drawing.Point(622, 30);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(104, 32);
            this.bt_timkiem.TabIndex = 67;
            this.bt_timkiem.Text = "&Tìm Kiếm";
            this.bt_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Items.AddRange(new object[] {
            "Mã Khách Hàng",
            "Tên Khách Hàng",
            "SDT"});
            this.cb_timkiem.Location = new System.Drawing.Point(200, 36);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(121, 21);
            this.cb_timkiem.TabIndex = 68;
            // 
            // frm_chonkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 567);
            this.Controls.Add(this.cb_timkiem);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.bt_chon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mkt_ngaysinh);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.dt_kh);
            this.Name = "frm_chonkhachhang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frm_chonkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_kh;
        private System.Windows.Forms.DataGridViewImageColumn AnhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mkt_ngaysinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Gioitinh;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.TextBox txt_mkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_chon;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.ComboBox cb_timkiem;
    }
}