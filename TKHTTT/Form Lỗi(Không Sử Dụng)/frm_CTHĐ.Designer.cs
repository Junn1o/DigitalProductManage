
namespace TKHTTT
{
    partial class form_CTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btdong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_DGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbmnv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_huyload = new System.Windows.Forms.Button();
            this.lb_giamgia = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.txt_ngayban = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mhd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_mkh = new System.Windows.Forms.ComboBox();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_theloai = new System.Windows.Forms.TextBox();
            this.txt_tacgia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbms = new System.Windows.Forms.Label();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_sdtnv = new System.Windows.Forms.TextBox();
            this.txt_dcnv = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btdong
            // 
            this.btdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdong.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btdong.ForeColor = System.Drawing.Color.DarkBlue;
            this.btdong.Image = global::TKHTTT.Properties.Resources.Close;
            this.btdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdong.Location = new System.Drawing.Point(897, 532);
            this.btdong.Margin = new System.Windows.Forms.Padding(2);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(104, 42);
            this.btdong.TabIndex = 13;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(414, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chi Tiết Hóa Đơn";
            // 
            // dt_DGV
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_DGV.Location = new System.Drawing.Point(11, 307);
            this.dt_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.dt_DGV.MultiSelect = false;
            this.dt_DGV.Name = "dt_DGV";
            this.dt_DGV.RowHeadersWidth = 51;
            this.dt_DGV.RowTemplate.Height = 24;
            this.dt_DGV.Size = new System.Drawing.Size(668, 212);
            this.dt_DGV.TabIndex = 15;
            this.dt_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_DB_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "SĐT Khách Hàng :";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_tennv.Location = new System.Drawing.Point(149, 52);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(251, 25);
            this.txt_tennv.TabIndex = 21;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_tenkh.Location = new System.Drawing.Point(162, 51);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(252, 25);
            this.txt_tenkh.TabIndex = 24;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_sdt.Location = new System.Drawing.Point(162, 85);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(251, 25);
            this.txt_sdt.TabIndex = 25;
            // 
            // lbmnv
            // 
            this.lbmnv.AutoSize = true;
            this.lbmnv.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lbmnv.Location = new System.Drawing.Point(10, 53);
            this.lbmnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmnv.Name = "lbmnv";
            this.lbmnv.Size = new System.Drawing.Size(106, 17);
            this.lbmnv.TabIndex = 27;
            this.lbmnv.Text = "Nhân Viên Bán :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.bt_huyload);
            this.groupBox1.Controls.Add(this.lb_giamgia);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.txt_giamgia);
            this.groupBox1.Controls.Add(this.bt_timkiem);
            this.groupBox1.Controls.Add(this.txt_ngayban);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_mhd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(683, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(318, 212);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết Hóa Đơn";
            // 
            // bt_huyload
            // 
            this.bt_huyload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_huyload.Location = new System.Drawing.Point(186, 55);
            this.bt_huyload.Name = "bt_huyload";
            this.bt_huyload.Size = new System.Drawing.Size(121, 31);
            this.bt_huyload.TabIndex = 53;
            this.bt_huyload.Text = "Hủy Load";
            this.bt_huyload.UseVisualStyleBackColor = true;
            this.bt_huyload.Click += new System.EventHandler(this.bt_huyload_Click);
            // 
            // lb_giamgia
            // 
            this.lb_giamgia.AutoSize = true;
            this.lb_giamgia.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_giamgia.Location = new System.Drawing.Point(223, 134);
            this.lb_giamgia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_giamgia.Name = "lb_giamgia";
            this.lb_giamgia.Size = new System.Drawing.Size(20, 18);
            this.lb_giamgia.TabIndex = 52;
            this.lb_giamgia.Text = "%";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(107, 172);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(116, 25);
            this.txt_tongtien.TabIndex = 51;
            this.txt_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(107, 132);
            this.txt_giamgia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(116, 25);
            this.txt_giamgia.TabIndex = 50;
            this.txt_giamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_giamgia.TextChanged += new System.EventHandler(this.txt_giamgia_TextChanged);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_timkiem.Location = new System.Drawing.Point(56, 55);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(121, 31);
            this.bt_timkiem.TabIndex = 49;
            this.bt_timkiem.Text = "Load Hóa Đơn";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // txt_ngayban
            // 
            this.txt_ngayban.Location = new System.Drawing.Point(107, 91);
            this.txt_ngayban.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ngayban.Name = "txt_ngayban";
            this.txt_ngayban.Size = new System.Drawing.Size(206, 25);
            this.txt_ngayban.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(22, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 19);
            this.label13.TabIndex = 46;
            this.label13.Text = "Tổng Tiền :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(7, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Ngày Bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Mã Hóa Đơn:";
            // 
            // txt_mhd
            // 
            this.txt_mhd.Location = new System.Drawing.Point(107, 25);
            this.txt_mhd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mhd.Name = "txt_mhd";
            this.txt_mhd.Size = new System.Drawing.Size(169, 25);
            this.txt_mhd.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(23, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Giảm Giá :";
            // 
            // cb_mkh
            // 
            this.cb_mkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_mkh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mkh.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.cb_mkh.FormattingEnabled = true;
            this.cb_mkh.Location = new System.Drawing.Point(162, 18);
            this.cb_mkh.Margin = new System.Windows.Forms.Padding(2);
            this.cb_mkh.Name = "cb_mkh";
            this.cb_mkh.Size = new System.Drawing.Size(92, 25);
            this.cb_mkh.TabIndex = 41;
            this.cb_mkh.TextChanged += new System.EventHandler(this.cb_mkh_TextChanged);
            // 
            // cb_manv
            // 
            this.cb_manv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_manv.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(149, 18);
            this.cb_manv.Margin = new System.Windows.Forms.Padding(2);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(92, 25);
            this.cb_manv.TabIndex = 40;
            this.cb_manv.TextChanged += new System.EventHandler(this.cb_manv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mã Khách Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã Nhân Viên :";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(162, 121);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(251, 25);
            this.txt_diachi.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Địa Chỉ Khách Hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_theloai);
            this.groupBox2.Controls.Add(this.txt_tacgia);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_masach);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbms);
            this.groupBox2.Controls.Add(this.txt_tensach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(11, 195);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(990, 108);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Sản Phẩm";
            // 
            // txt_theloai
            // 
            this.txt_theloai.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_theloai.Location = new System.Drawing.Point(96, 66);
            this.txt_theloai.Margin = new System.Windows.Forms.Padding(2);
            this.txt_theloai.Name = "txt_theloai";
            this.txt_theloai.Size = new System.Drawing.Size(103, 25);
            this.txt_theloai.TabIndex = 57;
            // 
            // txt_tacgia
            // 
            this.txt_tacgia.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_tacgia.Location = new System.Drawing.Point(716, 20);
            this.txt_tacgia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tacgia.Name = "txt_tacgia";
            this.txt_tacgia.Size = new System.Drawing.Size(184, 25);
            this.txt_tacgia.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(635, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "Tác Giả";
            // 
            // txt_masach
            // 
            this.txt_masach.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_masach.Location = new System.Drawing.Point(96, 24);
            this.txt_masach.Margin = new System.Windows.Forms.Padding(2);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(105, 25);
            this.txt_masach.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(4, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Mã Sản Phẩm";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_dongia.Location = new System.Drawing.Point(318, 63);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(122, 25);
            this.txt_dongia.TabIndex = 51;
            this.txt_dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(219, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Đơn Giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(4, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Thể Loại";
            // 
            // lbms
            // 
            this.lbms.AutoSize = true;
            this.lbms.BackColor = System.Drawing.SystemColors.Control;
            this.lbms.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lbms.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbms.Location = new System.Drawing.Point(219, 26);
            this.lbms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbms.Name = "lbms";
            this.lbms.Size = new System.Drawing.Size(95, 17);
            this.lbms.TabIndex = 48;
            this.lbms.Text = "Tên Sản Phẩm";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_tensach.Location = new System.Drawing.Point(318, 23);
            this.txt_tensach.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(290, 25);
            this.txt_tensach.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.cb_mkh);
            this.groupBox3.Controls.Add(this.txt_tenkh);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_sdt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_diachi);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Location = new System.Drawing.Point(577, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 163);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chi Tiết Khách Hàng Mua";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.txt_sdtnv);
            this.groupBox4.Controls.Add(this.txt_dcnv);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cb_manv);
            this.groupBox4.Controls.Add(this.txt_tennv);
            this.groupBox4.Controls.Add(this.lbmnv);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 163);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Chi Tiết Nhân Viên Bán";
            // 
            // txt_sdtnv
            // 
            this.txt_sdtnv.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_sdtnv.Location = new System.Drawing.Point(149, 85);
            this.txt_sdtnv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdtnv.Name = "txt_sdtnv";
            this.txt_sdtnv.Size = new System.Drawing.Size(251, 25);
            this.txt_sdtnv.TabIndex = 42;
            // 
            // txt_dcnv
            // 
            this.txt_dcnv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dcnv.Location = new System.Drawing.Point(149, 121);
            this.txt_dcnv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dcnv.Name = "txt_dcnv";
            this.txt_dcnv.Size = new System.Drawing.Size(251, 25);
            this.txt_dcnv.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(10, 124);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "Địa Chỉ Nhân Viên :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(10, 88);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "SĐT Nhân Viên :";
            // 
            // btthem
            // 
            this.btthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btthem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btthem.Image = global::TKHTTT.Properties.Resources.themhoadon_only_;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(683, 532);
            this.btthem.Margin = new System.Windows.Forms.Padding(2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(104, 42);
            this.btthem.TabIndex = 10;
            this.btthem.Text = "Thêm Hóa Đơn";
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // form_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 585);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_DGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdong);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_CTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frm_CBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_DGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label lbmnv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mhd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ngayban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_mkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbms;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox txt_tacgia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_theloai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_sdtnv;
        private System.Windows.Forms.TextBox txt_dcnv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.Label lb_giamgia;
        private System.Windows.Forms.Button bt_huyload;
    }
}