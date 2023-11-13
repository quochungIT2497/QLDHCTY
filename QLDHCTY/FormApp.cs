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
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form Childform)//Form con trong form cha
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;//Loại bỏ viền
            Childform.Dock = DockStyle.Fill;
            panel_body.Controls.Add(Childform);
            panel_body.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }

        private void addUserControl(UserControl usercontrol)//them user control vao form
        {
            usercontrol.Dock = DockStyle.Fill;
            panel_body.Controls.Clear();
            panel_body.Controls.Add(usercontrol);
            usercontrol.BringToFront();
            usercontrol.Show();
        }
        private void pictureBox_Comp_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            slidelbl_Home.Text = "Home";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            slidelbl_Home.Text = "Home";
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormLSP());
            slidelbl_Home.Text = "Quản Lý Loại Sản Phẩm";
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            slidelbl_Home.Text = "Home";
        }

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
            slidelbl_Home.Text = "Quản Lý Nhân Viên";
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*NhaCC ncc  = new NhaCC();
            addUserControl(ncc);*/
          OpenChildForm(new FormNhaCC());
            slidelbl_Home.Text = "Danh Sách Nhà Cung Cấp";
        }

        private void đạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaiLy());
            slidelbl_Home.Text = "Danh Sách Đại Lý";
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham());
            slidelbl_Home.Text = "Quản Lý Sản Phẩm";
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDatHang());
            slidelbl_Home.Text = "Danh Sách Đơn Hàng";
        }

        private void chiTiếtHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCTDH());
            slidelbl_Home.Text = "Quản lý Hóa Đơn";
        }
    }
}
