using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDHCTY
{
    public partial class FormLSP : Form
    {
        public FormLSP()
        {
            InitializeComponent();
            btn_ThemLSP.Resize += btn_Them_Resize;
        }
 
        private void btn_Them_Resize(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Image resize = new Bitmap(button.Image, new Size(button.Image.Width, (button.Height - 13)));
        }

        private void btn_ThemLSP_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaLSP_Click(object sender, EventArgs e)
        {

        }

        private void btn_XoaLSP_Click(object sender, EventArgs e)
        {

        }

        private void btn_XuatBCLSP_Click(object sender, EventArgs e)
        {

        }

        private void dgv_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_TKTenLoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
