
namespace TKHTTT
{
    partial class frm_NhomSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mnsach = new System.Windows.Forms.TextBox();
            this.txt_tenhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_NhomSach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_bo = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.btdong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_danhmuc = new System.Windows.Forms.ComboBox();
            this.lsbx_sp = new System.Windows.Forms.ListBox();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_NhomSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh Sách Thể Loại";
            // 
            // txt_mnsach
            // 
            this.txt_mnsach.Location = new System.Drawing.Point(125, 110);
            this.txt_mnsach.Name = "txt_mnsach";
            this.txt_mnsach.Size = new System.Drawing.Size(78, 26);
            this.txt_mnsach.TabIndex = 16;
            // 
            // txt_tenhom
            // 
            this.txt_tenhom.Location = new System.Drawing.Point(125, 155);
            this.txt_tenhom.Multiline = true;
            this.txt_tenhom.Name = "txt_tenhom";
            this.txt_tenhom.Size = new System.Drawing.Size(156, 26);
            this.txt_tenhom.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(28, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Thể Loại ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã Thể Loại";
            // 
            // dt_NhomSach
            // 
            this.dt_NhomSach.AllowUserToDeleteRows = false;
            this.dt_NhomSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_NhomSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_NhomSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheLoai,
            this.TenTheLoai,
            this.SoSP,
            this.DanhMuc});
            this.dt_NhomSach.Location = new System.Drawing.Point(32, 253);
            this.dt_NhomSach.Name = "dt_NhomSach";
            this.dt_NhomSach.ReadOnly = true;
            this.dt_NhomSach.RowHeadersWidth = 51;
            this.dt_NhomSach.RowTemplate.Height = 24;
            this.dt_NhomSach.Size = new System.Drawing.Size(774, 158);
            this.dt_NhomSach.TabIndex = 20;
            this.dt_NhomSach.Click += new System.EventHandler(this.dtNhomSach_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.bt_bo);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.btdong);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_luu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(891, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 423);
            this.panel1.TabIndex = 39;
            // 
            // bt_them
            // 
            this.bt_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_them.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_them.Image = global::TKHTTT.Properties.Resources.Add;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(15, 19);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(134, 35);
            this.bt_them.TabIndex = 28;
            this.bt_them.Text = "&Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_bo
            // 
            this.bt_bo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_bo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_bo.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_bo.Image = global::TKHTTT.Properties.Resources.cancel;
            this.bt_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bo.Location = new System.Drawing.Point(16, 160);
            this.bt_bo.Margin = new System.Windows.Forms.Padding(2);
            this.bt_bo.Name = "bt_bo";
            this.bt_bo.Size = new System.Drawing.Size(134, 35);
            this.bt_bo.TabIndex = 37;
            this.bt_bo.Text = "&Hủy";
            this.bt_bo.UseVisualStyleBackColor = true;
            this.bt_bo.Click += new System.EventHandler(this.bt_bo_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sua.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_sua.Image = global::TKHTTT.Properties.Resources.Edit;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(15, 68);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(134, 35);
            this.bt_sua.TabIndex = 29;
            this.bt_sua.Text = "&Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // btdong
            // 
            this.btdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btdong.ForeColor = System.Drawing.Color.DarkBlue;
            this.btdong.Image = global::TKHTTT.Properties.Resources.Close;
            this.btdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdong.Location = new System.Drawing.Point(16, 321);
            this.btdong.Margin = new System.Windows.Forms.Padding(2);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(134, 60);
            this.btdong.TabIndex = 36;
            this.btdong.Text = "&Thoát";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xoa.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_xoa.Image = global::TKHTTT.Properties.Resources.Del;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(15, 214);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(134, 35);
            this.bt_xoa.TabIndex = 30;
            this.bt_xoa.Text = "&Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_luu.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_luu.Image = global::TKHTTT.Properties.Resources.save;
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(16, 115);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(134, 35);
            this.bt_luu.TabIndex = 31;
            this.bt_luu.Text = "&Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(304, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Thuộc Danh Mục";
            // 
            // cb_danhmuc
            // 
            this.cb_danhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_danhmuc.FormattingEnabled = true;
            this.cb_danhmuc.Location = new System.Drawing.Point(425, 159);
            this.cb_danhmuc.Name = "cb_danhmuc";
            this.cb_danhmuc.Size = new System.Drawing.Size(121, 27);
            this.cb_danhmuc.TabIndex = 41;
            // 
            // lsbx_sp
            // 
            this.lsbx_sp.FormattingEnabled = true;
            this.lsbx_sp.ItemHeight = 19;
            this.lsbx_sp.Location = new System.Drawing.Point(573, 59);
            this.lsbx_sp.Name = "lsbx_sp";
            this.lsbx_sp.Size = new System.Drawing.Size(233, 156);
            this.lsbx_sp.TabIndex = 42;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã Sản Phẩm";
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            this.MaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // SoSP
            // 
            this.SoSP.DataPropertyName = "SoSP";
            this.SoSP.HeaderText = "Số Sản Phẩm Thuộc";
            this.SoSP.Name = "SoSP";
            this.SoSP.ReadOnly = true;
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "DanhMuc";
            this.DanhMuc.HeaderText = "Danh Mục";
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(306, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Danh Sách Sản Phẩm Thuộc Thể Loại";
            // 
            // frm_NhomSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1051, 423);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsbx_sp);
            this.Controls.Add(this.cb_danhmuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dt_NhomSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenhom);
            this.Controls.Add(this.txt_mnsach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NhomSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Thể Loại";
            this.Load += new System.EventHandler(this.NhomSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_NhomSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mnsach;
        private System.Windows.Forms.TextBox txt_tenhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dt_NhomSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_bo;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_danhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.ListBox lsbx_sp;
        private System.Windows.Forms.Label label5;
    }
}