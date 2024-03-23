
namespace TKHTTT
{
    partial class frm_DTBH
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
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.bt_loc = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tu = new System.Windows.Forms.Label();
            this.lb_den = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu Sản Phẩm Bán Được";
            // 
            // txt_tong
            // 
            this.txt_tong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong.Location = new System.Drawing.Point(331, 190);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(107, 26);
            this.txt_tong.TabIndex = 6;
            this.txt_tong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_loc
            // 
            this.bt_loc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_loc.Location = new System.Drawing.Point(211, 184);
            this.bt_loc.Name = "bt_loc";
            this.bt_loc.Size = new System.Drawing.Size(82, 34);
            this.bt_loc.TabIndex = 20;
            this.bt_loc.Text = "Lọc";
            this.bt_loc.UseVisualStyleBackColor = true;
            this.bt_loc.Click += new System.EventHandler(this.bt_loc_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 140);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(227, 26);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "đ";
            // 
            // lb_tu
            // 
            this.lb_tu.AutoSize = true;
            this.lb_tu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tu.Location = new System.Drawing.Point(194, 53);
            this.lb_tu.Name = "lb_tu";
            this.lb_tu.Size = new System.Drawing.Size(27, 19);
            this.lb_tu.TabIndex = 18;
            this.lb_tu.Text = "Từ";
            // 
            // lb_den
            // 
            this.lb_den.AutoSize = true;
            this.lb_den.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_den.Location = new System.Drawing.Point(194, 118);
            this.lb_den.Name = "lb_den";
            this.lb_den.Size = new System.Drawing.Size(34, 19);
            this.lb_den.TabIndex = 19;
            this.lb_den.Text = "Đến";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bt_thoat.Image = global::TKHTTT.Properties.Resources.Close;
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(542, 195);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(100, 49);
            this.bt_thoat.TabIndex = 24;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // frm_DTBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(654, 256);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_loc);
            this.Controls.Add(this.lb_den);
            this.Controls.Add(this.lb_tu);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DTBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu Bán Hàng";
            this.Load += new System.EventHandler(this.frm_DTBH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button bt_loc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tu;
        private System.Windows.Forms.Label lb_den;
        private System.Windows.Forms.Button bt_thoat;
    }
}