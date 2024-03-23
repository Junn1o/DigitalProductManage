
namespace TKHTTT
{
    partial class frm_HoaDon
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
            this.dt_CTHD = new System.Windows.Forms.DataGridView();
            this.MaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhSP = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CTHD = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.txt_tien = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_giamgia = new System.Windows.Forms.ComboBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_huydon = new System.Windows.Forms.Button();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_keycode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptrbx_anhSP = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_tnv = new System.Windows.Forms.TextBox();
            this.txt_tkh = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_CTHD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbx_anhSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_CTHD
            // 
            this.dt_CTHD.AllowUserToAddRows = false;
            this.dt_CTHD.AllowUserToDeleteRows = false;
            this.dt_CTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTHD,
            this.TenSP,
            this.Tien,
            this.AnhSP});
            this.dt_CTHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt_CTHD.Location = new System.Drawing.Point(10, 11);
            this.dt_CTHD.MultiSelect = false;
            this.dt_CTHD.Name = "dt_CTHD";
            this.dt_CTHD.ReadOnly = true;
            this.dt_CTHD.RowHeadersWidth = 51;
            this.dt_CTHD.RowTemplate.Height = 24;
            this.dt_CTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_CTHD.Size = new System.Drawing.Size(1061, 209);
            this.dt_CTHD.TabIndex = 0;
            this.dt_CTHD.Click += new System.EventHandler(this.dt_CTHD_Click);
            // 
            // MaCTHD
            // 
            this.MaCTHD.DataPropertyName = "MaCTHD";
            this.MaCTHD.HeaderText = "STT";
            this.MaCTHD.MinimumWidth = 6;
            this.MaCTHD.Name = "MaCTHD";
            this.MaCTHD.ReadOnly = true;
            this.MaCTHD.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 550;
            // 
            // Tien
            // 
            this.Tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tien.DataPropertyName = "Tien";
            this.Tien.HeaderText = "Giá";
            this.Tien.MinimumWidth = 6;
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            // 
            // AnhSP
            // 
            this.AnhSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnhSP.DataPropertyName = "AnhSP";
            this.AnhSP.HeaderText = "Ảnh Sản Phẩm";
            this.AnhSP.MinimumWidth = 6;
            this.AnhSP.Name = "AnhSP";
            this.AnhSP.ReadOnly = true;
            this.AnhSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnhSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sản Phẩm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá :";
            // 
            // txt_CTHD
            // 
            this.txt_CTHD.Location = new System.Drawing.Point(141, 59);
            this.txt_CTHD.Name = "txt_CTHD";
            this.txt_CTHD.ReadOnly = true;
            this.txt_CTHD.Size = new System.Drawing.Size(159, 19);
            this.txt_CTHD.TabIndex = 4;
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensach.Location = new System.Drawing.Point(141, 94);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.ReadOnly = true;
            this.txt_tensach.Size = new System.Drawing.Size(159, 21);
            this.txt_tensach.TabIndex = 5;
            // 
            // txt_tien
            // 
            this.txt_tien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tien.Location = new System.Drawing.Point(141, 133);
            this.txt_tien.Name = "txt_tien";
            this.txt_tien.ReadOnly = true;
            this.txt_tien.Size = new System.Drawing.Size(159, 21);
            this.txt_tien.TabIndex = 6;
            this.txt_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_tien.Leave += new System.EventHandler(this.txt_solg_Leave);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(88, 62);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(159, 21);
            this.txt_tongtien.TabIndex = 8;
            this.txt_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng Tiền :";
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giamgia.Location = new System.Drawing.Point(88, 26);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(106, 21);
            this.txt_giamgia.TabIndex = 10;
            this.txt_giamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_giamgia.TextChanged += new System.EventHandler(this.txt_giamgia_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giảm Giá :";
            // 
            // cb_giamgia
            // 
            this.cb_giamgia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_giamgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_giamgia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_giamgia.FormattingEnabled = true;
            this.cb_giamgia.Items.AddRange(new object[] {
            "%",
            "đ"});
            this.cb_giamgia.Location = new System.Drawing.Point(200, 26);
            this.cb_giamgia.Name = "cb_giamgia";
            this.cb_giamgia.Size = new System.Drawing.Size(48, 23);
            this.cb_giamgia.TabIndex = 11;
            this.cb_giamgia.SelectedIndexChanged += new System.EventHandler(this.cb_giamgia_SelectedIndexChanged);
            // 
            // bt_luu
            // 
            this.bt_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(466, 562);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(195, 28);
            this.bt_luu.TabIndex = 13;
            this.bt_luu.Text = "Thanh Toán";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_huydon
            // 
            this.bt_huydon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_huydon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huydon.Location = new System.Drawing.Point(667, 562);
            this.bt_huydon.Name = "bt_huydon";
            this.bt_huydon.Size = new System.Drawing.Size(195, 28);
            this.bt_huydon.TabIndex = 14;
            this.bt_huydon.Text = "Hủy Đơn";
            this.bt_huydon.UseVisualStyleBackColor = true;
            this.bt_huydon.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // txt_maHD
            // 
            this.txt_maHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maHD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHD.Location = new System.Drawing.Point(141, 19);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.ReadOnly = true;
            this.txt_maHD.Size = new System.Drawing.Size(159, 21);
            this.txt_maHD.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã Hóa Đơn :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_keycode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ptrbx_anhSP);
            this.panel1.Controls.Add(this.txt_maHD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_CTHD);
            this.panel1.Controls.Add(this.txt_tensach);
            this.panel1.Controls.Add(this.txt_tien);
            this.panel1.Location = new System.Drawing.Point(10, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 201);
            this.panel1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Key :";
            // 
            // txt_keycode
            // 
            this.txt_keycode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_keycode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_keycode.Location = new System.Drawing.Point(141, 172);
            this.txt_keycode.Name = "txt_keycode";
            this.txt_keycode.ReadOnly = true;
            this.txt_keycode.Size = new System.Drawing.Size(159, 21);
            this.txt_keycode.TabIndex = 20;
            this.txt_keycode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "STT :";
            // 
            // ptrbx_anhSP
            // 
            this.ptrbx_anhSP.Location = new System.Drawing.Point(357, 19);
            this.ptrbx_anhSP.Name = "ptrbx_anhSP";
            this.ptrbx_anhSP.Size = new System.Drawing.Size(203, 174);
            this.ptrbx_anhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbx_anhSP.TabIndex = 17;
            this.ptrbx_anhSP.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_tongtien);
            this.panel2.Controls.Add(this.txt_giamgia);
            this.panel2.Controls.Add(this.cb_giamgia);
            this.panel2.Location = new System.Drawing.Point(621, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 201);
            this.panel2.TabIndex = 20;
            // 
            // txt_tnv
            // 
            this.txt_tnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tnv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tnv.Location = new System.Drawing.Point(151, 442);
            this.txt_tnv.Name = "txt_tnv";
            this.txt_tnv.ReadOnly = true;
            this.txt_tnv.Size = new System.Drawing.Size(159, 21);
            this.txt_tnv.TabIndex = 18;
            // 
            // txt_tkh
            // 
            this.txt_tkh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tkh.Location = new System.Drawing.Point(151, 489);
            this.txt_tkh.Name = "txt_tkh";
            this.txt_tkh.ReadOnly = true;
            this.txt_tkh.Size = new System.Drawing.Size(159, 21);
            this.txt_tkh.TabIndex = 18;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(7, 447);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(124, 16);
            this.lb_1.TabIndex = 18;
            this.lb_1.Text = "Tên Nhân Viên Bán :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên Khách Hàng Mua :";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(868, 562);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(195, 28);
            this.bt_thoat.TabIndex = 21;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click_1);
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 630);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.txt_tkh);
            this.Controls.Add(this.txt_tnv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_huydon);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.dt_CTHD);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_CTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbx_anhSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_CTHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CTHD;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.TextBox txt_tien;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_giamgia;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_huydon;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptrbx_anhSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tnv;
        private System.Windows.Forms.TextBox txt_tkh;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_keycode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.DataGridViewImageColumn AnhSP;
        private System.Windows.Forms.Button bt_thoat;
    }
}