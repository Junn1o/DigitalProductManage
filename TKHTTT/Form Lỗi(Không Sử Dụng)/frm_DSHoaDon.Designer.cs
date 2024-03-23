
namespace TKHTTT
{
    partial class frm_DSHoaDon
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
            this.dt_dsHD = new System.Windows.Forms.DataGridView();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_timloai = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_dsHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_dsHD
            // 
            this.dt_dsHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_dsHD.Location = new System.Drawing.Point(12, 88);
            this.dt_dsHD.Name = "dt_dsHD";
            this.dt_dsHD.RowHeadersWidth = 51;
            this.dt_dsHD.Size = new System.Drawing.Size(932, 248);
            this.dt_dsHD.TabIndex = 0;
            this.dt_dsHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_dsHD_CellClick);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(182, 52);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(541, 30);
            this.txt_timkiem.TabIndex = 4;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_timkiem.Image = global::TKHTTT.Properties.Resources.Searchx16;
            this.bt_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_timkiem.Location = new System.Drawing.Point(729, 46);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(104, 36);
            this.bt_timkiem.TabIndex = 3;
            this.bt_timkiem.Text = "&Tìm kiếm";
            this.bt_timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 40);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh Sách Hóa Đơn";
            // 
            // cb_timloai
            // 
            this.cb_timloai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_timloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timloai.FormattingEnabled = true;
            this.cb_timloai.Items.AddRange(new object[] {
            "Mã Hóa Đơn",
            "Mã Khách Hàng",
            "Mã Nhân Viên",
            "Tên Khách Hàng",
            "Tên Nhân Viên"});
            this.cb_timloai.Location = new System.Drawing.Point(24, 51);
            this.cb_timloai.Name = "cb_timloai";
            this.cb_timloai.Size = new System.Drawing.Size(149, 30);
            this.cb_timloai.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::TKHTTT.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(839, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Hủy";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Image = global::TKHTTT.Properties.Resources.Close;
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(839, 379);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(105, 36);
            this.bt_thoat.TabIndex = 8;
            this.bt_thoat.Text = "&Thoát";
            this.bt_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xoa.Image = global::TKHTTT.Properties.Resources.Del;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(729, 378);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(104, 36);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "&Xóa";
            this.bt_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(84, 371);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(152, 30);
            this.txt_MaHD.TabIndex = 10;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(349, 411);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.ReadOnly = true;
            this.txt_maKH.Size = new System.Drawing.Size(58, 30);
            this.txt_maKH.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã NV";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(349, 367);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.ReadOnly = true;
            this.txt_maNV.Size = new System.Drawing.Size(58, 30);
            this.txt_maNV.TabIndex = 15;
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Location = new System.Drawing.Point(84, 415);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.ReadOnly = true;
            this.txt_ngaylap.Size = new System.Drawing.Size(152, 30);
            this.txt_ngaylap.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày Lập";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(595, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "&Mở Chi Tiết";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_DSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ngaylap);
            this.Controls.Add(this.txt_maNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.txt_MaHD);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_timloai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.dt_dsHD);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DSHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.frm_DSHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_dsHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_dsHD;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_timloai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}