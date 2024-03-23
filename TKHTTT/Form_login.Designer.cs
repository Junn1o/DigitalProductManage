
namespace TKHTTT
{
    partial class frm_login
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
            this.lbdn = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdn
            // 
            this.lbdn.AutoSize = true;
            this.lbdn.BackColor = System.Drawing.Color.Transparent;
            this.lbdn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbdn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbdn.Location = new System.Drawing.Point(3, 36);
            this.lbdn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdn.Name = "lbdn";
            this.lbdn.Size = new System.Drawing.Size(150, 22);
            this.lbdn.TabIndex = 0;
            this.lbdn.Text = "Tên Đăng Nhập :";
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmk.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbmk.Location = new System.Drawing.Point(10, 91);
            this.lbmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(103, 22);
            this.lbmk.TabIndex = 1;
            this.lbmk.Text = "Mật Khẩu :";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(163, 32);
            this.txtTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(174, 30);
            this.txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(163, 92);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(174, 30);
            this.txtMK.TabIndex = 1;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.Transparent;
            this.btthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btthoat.ForeColor = System.Drawing.Color.DarkBlue;
            this.btthoat.Location = new System.Drawing.Point(232, 148);
            this.btthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(105, 33);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.bt_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_dangnhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_dangnhap.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_dangnhap.Location = new System.Drawing.Point(62, 148);
            this.bt_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(105, 33);
            this.bt_dangnhap.TabIndex = 2;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.bt_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(365, 196);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.lbdn);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdn;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bt_dangnhap;
    }
}

