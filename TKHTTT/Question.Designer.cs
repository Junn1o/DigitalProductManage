
namespace TKHTTT
{
    partial class Question
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
            this.bt_nv = new System.Windows.Forms.Button();
            this.bt_kh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_nv
            // 
            this.bt_nv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_nv.Location = new System.Drawing.Point(38, 37);
            this.bt_nv.Margin = new System.Windows.Forms.Padding(4);
            this.bt_nv.Name = "bt_nv";
            this.bt_nv.Size = new System.Drawing.Size(123, 48);
            this.bt_nv.TabIndex = 0;
            this.bt_nv.Text = "Nhân Viên";
            this.bt_nv.UseVisualStyleBackColor = true;
            this.bt_nv.Click += new System.EventHandler(this.bt_nv_Click);
            // 
            // bt_kh
            // 
            this.bt_kh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_kh.Location = new System.Drawing.Point(274, 37);
            this.bt_kh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_kh.Name = "bt_kh";
            this.bt_kh.Size = new System.Drawing.Size(124, 48);
            this.bt_kh.TabIndex = 1;
            this.bt_kh.Text = "Khách Hàng";
            this.bt_kh.UseVisualStyleBackColor = true;
            this.bt_kh.Click += new System.EventHandler(this.bt_kh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bạn Muốn Vào?";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_thoat.Location = new System.Drawing.Point(160, 106);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(117, 48);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "Hủy";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 170);
            this.ControlBox = false;
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_kh);
            this.Controls.Add(this.bt_nv);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question?";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_nv;
        private System.Windows.Forms.Button bt_kh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_thoat;
    }
}