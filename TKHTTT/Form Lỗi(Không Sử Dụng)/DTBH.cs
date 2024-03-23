using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySach.Class;

namespace TKHTTT
{
    public partial class frm_DTBH : Form
    {
        public frm_DTBH()
        {
            InitializeComponent();
            Ham.Connect();
        }
        private void frm_DTBH_Load(object sender, EventArgs e)
        {

        }
        private void bt_loc_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT SUM(TienTToan) AS DoanhThu FROM dbo.HoaDon WHERE NgayLap>='"+dateTimePicker1.Value+"'And NgayLap<='"+dateTimePicker2.Value+"'";
            txt_tong.Text = Ham.GetFieldValues(sql);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
