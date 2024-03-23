
namespace TKHTTT
{
    partial class frm_QLLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLLogin));
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.rd_QT = new System.Windows.Forms.RadioButton();
            this.rd_NV = new System.Windows.Forms.RadioButton();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.dt_Login = new System.Windows.Forms.DataGridView();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_bo = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(547, 164);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(182, 26);
            this.txt_ten.TabIndex = 4;
            // 
            // rd_QT
            // 
            this.rd_QT.AutoSize = true;
            this.rd_QT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_QT.ForeColor = System.Drawing.Color.DarkBlue;
            this.rd_QT.Location = new System.Drawing.Point(371, 67);
            this.rd_QT.Name = "rd_QT";
            this.rd_QT.Size = new System.Drawing.Size(80, 23);
            this.rd_QT.TabIndex = 1;
            this.rd_QT.TabStop = true;
            this.rd_QT.Text = "Quản Trị";
            this.rd_QT.UseVisualStyleBackColor = true;
            this.rd_QT.CheckedChanged += new System.EventHandler(this.rd_QT_CheckedChanged);
            // 
            // rd_NV
            // 
            this.rd_NV.AutoSize = true;
            this.rd_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_NV.ForeColor = System.Drawing.Color.DarkBlue;
            this.rd_NV.Location = new System.Drawing.Point(509, 69);
            this.rd_NV.Name = "rd_NV";
            this.rd_NV.Size = new System.Drawing.Size(91, 23);
            this.rd_NV.TabIndex = 2;
            this.rd_NV.TabStop = true;
            this.rd_NV.Text = "Nhân Viên";
            this.rd_NV.UseVisualStyleBackColor = true;
            this.rd_NV.CheckedChanged += new System.EventHandler(this.rd_NV_CheckedChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(547, 209);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(182, 26);
            this.txt_sdt.TabIndex = 5;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(547, 261);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(182, 85);
            this.txt_diachi.TabIndex = 6;
            // 
            // cb_nv
            // 
            this.cb_nv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(547, 117);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(182, 27);
            this.cb_nv.TabIndex = 3;
            this.cb_nv.SelectedIndexChanged += new System.EventHandler(this.cb_nv_SelectedIndexChanged);
            // 
            // dt_Login
            // 
            this.dt_Login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Login.Location = new System.Drawing.Point(78, 352);
            this.dt_Login.Name = "dt_Login";
            this.dt_Login.RowHeadersWidth = 51;
            this.dt_Login.RowTemplate.Height = 24;
            this.dt_Login.Size = new System.Drawing.Size(651, 135);
            this.dt_Login.TabIndex = 13;
            this.dt_Login.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Login_CellClick);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.Location = new System.Drawing.Point(173, 169);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(182, 26);
            this.txt_taikhoan.TabIndex = 1;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(173, 214);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(182, 26);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // bt_them
            // 
            this.bt_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_them.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_them.Image = global::TKHTTT.Properties.Resources.Add1;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(768, 54);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(146, 37);
            this.bt_them.TabIndex = 7;
            this.bt_them.Text = "&Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_bo
            // 
            this.bt_bo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_bo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_bo.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_bo.Image = global::TKHTTT.Properties.Resources.cancel;
            this.bt_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bo.Location = new System.Drawing.Point(768, 190);
            this.bt_bo.Margin = new System.Windows.Forms.Padding(2);
            this.bt_bo.Name = "bt_bo";
            this.bt_bo.Size = new System.Drawing.Size(146, 35);
            this.bt_bo.TabIndex = 10;
            this.bt_bo.Text = "&Hủy";
            this.bt_bo.UseVisualStyleBackColor = true;
            this.bt_bo.Click += new System.EventHandler(this.bt_bo_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_luu.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_luu.Image")));
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(768, 145);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(146, 35);
            this.bt_luu.TabIndex = 9;
            this.bt_luu.Text = "&Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_xoa.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_xoa.Image = global::TKHTTT.Properties.Resources.Del;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(768, 235);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(146, 35);
            this.bt_xoa.TabIndex = 11;
            this.bt_xoa.Text = "&Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_dong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_dong.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_dong.Image = global::TKHTTT.Properties.Resources.Close;
            this.bt_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dong.Location = new System.Drawing.Point(768, 379);
            this.bt_dong.Margin = new System.Windows.Forms.Padding(2);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(146, 60);
            this.bt_dong.TabIndex = 12;
            this.bt_dong.Text = "&Thoát";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.bt_sua.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_sua.Image = global::TKHTTT.Properties.Resources.Edit;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(768, 99);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(146, 35);
            this.bt_sua.TabIndex = 8;
            this.bt_sua.Text = "&Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(418, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(418, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(418, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(418, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(74, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mật Khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(74, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tài Khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(467, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(328, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cho";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(366, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quản Lí Tài Khoản";
            // 
            // frm_QLLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 540);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_bo);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.dt_Login);
            this.Controls.Add(this.cb_nv);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.rd_NV);
            this.Controls.Add(this.rd_QT);
            this.Controls.Add(this.txt_ten);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_QLLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_QLLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.RadioButton rd_QT;
        private System.Windows.Forms.RadioButton rd_NV;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.ComboBox cb_nv;
        private System.Windows.Forms.DataGridView dt_Login;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_bo;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}