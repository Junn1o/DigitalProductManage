namespace TKHTTT
{
    partial class Frrm_key
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
            this.txt_keyss = new System.Windows.Forms.TextBox();
            this.dt_key = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_TuaDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_bo = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.btdong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_sosanh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_key)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_keyss
            // 
            this.txt_keyss.Location = new System.Drawing.Point(442, 148);
            this.txt_keyss.Name = "txt_keyss";
            this.txt_keyss.Size = new System.Drawing.Size(234, 20);
            this.txt_keyss.TabIndex = 0;
            // 
            // dt_key
            // 
            this.dt_key.AllowUserToAddRows = false;
            this.dt_key.AllowUserToDeleteRows = false;
            this.dt_key.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_key.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_key.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.KeyCode,
            this.TrangThai});
            this.dt_key.Location = new System.Drawing.Point(16, 206);
            this.dt_key.MultiSelect = false;
            this.dt_key.Name = "dt_key";
            this.dt_key.ReadOnly = true;
            this.dt_key.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_key.Size = new System.Drawing.Size(660, 165);
            this.dt_key.TabIndex = 2;
            this.dt_key.Click += new System.EventHandler(this.dt_key_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // KeyCode
            // 
            this.KeyCode.DataPropertyName = "KeyCode";
            this.KeyCode.HeaderText = "Mã Key";
            this.KeyCode.Name = "KeyCode";
            this.KeyCode.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // lb_TuaDe
            // 
            this.lb_TuaDe.AutoSize = true;
            this.lb_TuaDe.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TuaDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_TuaDe.Location = new System.Drawing.Point(276, 9);
            this.lb_TuaDe.Name = "lb_TuaDe";
            this.lb_TuaDe.Size = new System.Drawing.Size(156, 29);
            this.lb_TuaDe.TabIndex = 17;
            this.lb_TuaDe.Text = "Quản Key Của";
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
            this.panel1.Location = new System.Drawing.Point(682, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 391);
            this.panel1.TabIndex = 39;
            // 
            // bt_them
            // 
            this.bt_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_them.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_them.Image = global::TKHTTT.Properties.Resources.Add;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(14, 42);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(134, 35);
            this.bt_them.TabIndex = 28;
            this.bt_them.Text = "Thêm";
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
            this.bt_bo.Location = new System.Drawing.Point(15, 183);
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
            this.bt_sua.Location = new System.Drawing.Point(14, 91);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(134, 35);
            this.bt_sua.TabIndex = 29;
            this.bt_sua.Text = "Sửa";
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
            this.btdong.Location = new System.Drawing.Point(14, 311);
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
            this.bt_xoa.Location = new System.Drawing.Point(15, 233);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(134, 35);
            this.bt_xoa.TabIndex = 30;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_luu.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_luu.Image = global::TKHTTT.Properties.Resources.save;
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(15, 138);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(134, 35);
            this.bt_luu.TabIndex = 31;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(53, 92);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(225, 20);
            this.txt_key.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Key";
            // 
            // bt_sosanh
            // 
            this.bt_sosanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sosanh.ForeColor = System.Drawing.Color.DarkBlue;
            this.bt_sosanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sosanh.Location = new System.Drawing.Point(281, 118);
            this.bt_sosanh.Name = "bt_sosanh";
            this.bt_sosanh.Size = new System.Drawing.Size(151, 32);
            this.bt_sosanh.TabIndex = 43;
            this.bt_sosanh.Text = "&So Sánh";
            this.bt_sosanh.UseVisualStyleBackColor = true;
            this.bt_sosanh.Click += new System.EventHandler(this.bt_sosanh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(445, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Key Cần So Sánh";
            // 
            // Frrm_key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_sosanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_TuaDe);
            this.Controls.Add(this.dt_key);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.txt_keyss);
            this.Name = "Frrm_key";
            this.Text = "Quản Lý Key";
            this.Load += new System.EventHandler(this.frrm_key_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_key)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_keyss;
        private System.Windows.Forms.DataGridView dt_key;
        private System.Windows.Forms.Label lb_TuaDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_bo;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_sosanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}