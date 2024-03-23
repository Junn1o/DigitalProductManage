namespace TKHTTT
{
    partial class Frm_Shopping
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
            this.dt_ShPi = new System.Windows.Forms.DataGridView();
            this.AnhSP = new System.Windows.Forms.DataGridViewImageColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxt_mota = new System.Windows.Forms.RichTextBox();
            this.lb_theloai = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_masanpham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_slg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_thanhtoan = new System.Windows.Forms.Button();
            this.lb_cart = new System.Windows.Forms.Label();
            this.bt_addtocart = new System.Windows.Forms.Button();
            this.txt_danhmuc = new System.Windows.Forms.TextBox();
            this.lsbx_cart = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.bt_xoakhoigio = new System.Windows.Forms.Button();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_chonkh = new System.Windows.Forms.Button();
            this.lb_makh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ShPi)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_ShPi
            // 
            this.dt_ShPi.AllowUserToAddRows = false;
            this.dt_ShPi.AllowUserToDeleteRows = false;
            this.dt_ShPi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_ShPi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dt_ShPi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_ShPi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnhSP,
            this.TenSP,
            this.TenTheLoai,
            this.Gia,
            this.DanhMuc});
            this.dt_ShPi.Location = new System.Drawing.Point(12, 12);
            this.dt_ShPi.MultiSelect = false;
            this.dt_ShPi.Name = "dt_ShPi";
            this.dt_ShPi.ReadOnly = true;
            this.dt_ShPi.RowHeadersWidth = 51;
            this.dt_ShPi.RowTemplate.Height = 24;
            this.dt_ShPi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_ShPi.Size = new System.Drawing.Size(838, 328);
            this.dt_ShPi.TabIndex = 28;
            this.dt_ShPi.Click += new System.EventHandler(this.dt_ShPi_Click);
            // 
            // AnhSP
            // 
            this.AnhSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnhSP.DataPropertyName = "AnhSP";
            this.AnhSP.HeaderText = "Ảnh";
            this.AnhSP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AnhSP.Name = "AnhSP";
            this.AnhSP.ReadOnly = true;
            this.AnhSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "DanhMuc";
            this.DanhMuc.HeaderText = "Danh Mục";
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
            // 
            // rtxt_mota
            // 
            this.rtxt_mota.Location = new System.Drawing.Point(13, 370);
            this.rtxt_mota.Name = "rtxt_mota";
            this.rtxt_mota.Size = new System.Drawing.Size(527, 230);
            this.rtxt_mota.TabIndex = 57;
            this.rtxt_mota.Text = "";
            // 
            // lb_theloai
            // 
            this.lb_theloai.FormattingEnabled = true;
            this.lb_theloai.Location = new System.Drawing.Point(648, 518);
            this.lb_theloai.Name = "lb_theloai";
            this.lb_theloai.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_theloai.Size = new System.Drawing.Size(169, 82);
            this.lb_theloai.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(546, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 55;
            this.label8.Text = "Danh Mục";
            // 
            // txt_masanpham
            // 
            this.txt_masanpham.Location = new System.Drawing.Point(649, 371);
            this.txt_masanpham.Name = "txt_masanpham";
            this.txt_masanpham.Size = new System.Drawing.Size(71, 20);
            this.txt_masanpham.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(548, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Location = new System.Drawing.Point(649, 401);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(186, 20);
            this.txt_tensanpham.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(545, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(548, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Thể Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(546, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Số Lượng Còn";
            // 
            // txt_slg
            // 
            this.txt_slg.Location = new System.Drawing.Point(648, 458);
            this.txt_slg.Name = "txt_slg";
            this.txt_slg.Size = new System.Drawing.Size(92, 20);
            this.txt_slg.TabIndex = 52;
            this.txt_slg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(546, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Giá";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(648, 484);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(169, 20);
            this.txt_gia.TabIndex = 53;
            this.txt_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mô Tả";
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_thanhtoan.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thanhtoan.Location = new System.Drawing.Point(1152, 240);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(53, 43);
            this.bt_thanhtoan.TabIndex = 59;
            this.bt_thanhtoan.Text = "&Thanh Toán";
            this.bt_thanhtoan.UseVisualStyleBackColor = true;
            this.bt_thanhtoan.Click += new System.EventHandler(this.bt_thanhtoan_Click);
            // 
            // lb_cart
            // 
            this.lb_cart.AutoSize = true;
            this.lb_cart.BackColor = System.Drawing.SystemColors.Control;
            this.lb_cart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cart.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_cart.Location = new System.Drawing.Point(1080, 18);
            this.lb_cart.Name = "lb_cart";
            this.lb_cart.Size = new System.Drawing.Size(17, 19);
            this.lb_cart.TabIndex = 60;
            this.lb_cart.Text = "0";
            // 
            // bt_addtocart
            // 
            this.bt_addtocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addtocart.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_addtocart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_addtocart.Location = new System.Drawing.Point(860, 12);
            this.bt_addtocart.Name = "bt_addtocart";
            this.bt_addtocart.Size = new System.Drawing.Size(135, 32);
            this.bt_addtocart.TabIndex = 61;
            this.bt_addtocart.Text = "&Thêm Vào Giỏ";
            this.bt_addtocart.UseVisualStyleBackColor = true;
            this.bt_addtocart.Click += new System.EventHandler(this.bt_addtocart_Click);
            // 
            // txt_danhmuc
            // 
            this.txt_danhmuc.Location = new System.Drawing.Point(649, 431);
            this.txt_danhmuc.Name = "txt_danhmuc";
            this.txt_danhmuc.Size = new System.Drawing.Size(92, 20);
            this.txt_danhmuc.TabIndex = 62;
            this.txt_danhmuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lsbx_cart
            // 
            this.lsbx_cart.FormattingEnabled = true;
            this.lsbx_cart.Location = new System.Drawing.Point(1011, 12);
            this.lsbx_cart.Name = "lsbx_cart";
            this.lsbx_cart.Size = new System.Drawing.Size(135, 225);
            this.lsbx_cart.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(856, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tổng Tiền Hiện Tại";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(986, 245);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(160, 20);
            this.txt_tongtien.TabIndex = 65;
            this.txt_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_xoakhoigio
            // 
            this.bt_xoakhoigio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xoakhoigio.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_xoakhoigio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoakhoigio.Location = new System.Drawing.Point(860, 50);
            this.bt_xoakhoigio.Name = "bt_xoakhoigio";
            this.bt_xoakhoigio.Size = new System.Drawing.Size(135, 32);
            this.bt_xoakhoigio.TabIndex = 66;
            this.bt_xoakhoigio.Text = "&Xoá khỏi Giỏ";
            this.bt_xoakhoigio.UseVisualStyleBackColor = true;
            this.bt_xoakhoigio.Click += new System.EventHandler(this.bt_xoakhoigio_Click);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(938, 284);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(150, 20);
            this.txt_tenkh.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(856, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Khách Hàng";
            // 
            // bt_chonkh
            // 
            this.bt_chonkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_chonkh.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_chonkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chonkh.Location = new System.Drawing.Point(1094, 277);
            this.bt_chonkh.Name = "bt_chonkh";
            this.bt_chonkh.Size = new System.Drawing.Size(47, 32);
            this.bt_chonkh.TabIndex = 69;
            this.bt_chonkh.Text = "&Chọn";
            this.bt_chonkh.UseVisualStyleBackColor = true;
            this.bt_chonkh.Click += new System.EventHandler(this.bt_chonkh_Click);
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_makh.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_makh.Location = new System.Drawing.Point(1094, 285);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(17, 19);
            this.lb_makh.TabIndex = 70;
            this.lb_makh.Text = "0";
            this.lb_makh.Visible = false;
            this.lb_makh.TextChanged += new System.EventHandler(this.lb_makh_TextChanged);
            // 
            // Frm_Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 612);
            this.Controls.Add(this.bt_chonkh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.bt_xoakhoigio);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_thanhtoan);
            this.Controls.Add(this.lsbx_cart);
            this.Controls.Add(this.txt_danhmuc);
            this.Controls.Add(this.bt_addtocart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_mota);
            this.Controls.Add(this.lb_theloai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_masanpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tensanpham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_slg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.dt_ShPi);
            this.Controls.Add(this.lb_cart);
            this.Controls.Add(this.lb_makh);
            this.Name = "Frm_Shopping";
            this.Text = "Máy Bán Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Shopping_FormClosing);
            this.Load += new System.EventHandler(this.frm_Shopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_ShPi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_ShPi;
        private System.Windows.Forms.RichTextBox rtxt_mota;
        private System.Windows.Forms.ListBox lb_theloai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_masanpham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_slg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_thanhtoan;
        private System.Windows.Forms.Label lb_cart;
        private System.Windows.Forms.Button bt_addtocart;
        private System.Windows.Forms.TextBox txt_danhmuc;
        private System.Windows.Forms.DataGridViewImageColumn AnhSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.ListBox lsbx_cart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Button bt_xoakhoigio;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_chonkh;
        private System.Windows.Forms.Label lb_makh;
    }
}