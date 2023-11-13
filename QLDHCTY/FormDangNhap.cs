using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDHCTY
{
    public partial class FormDangNhap : Form
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];

        public FormDangNhap()
        {
            InitializeComponent();
            location[0] = @"..\..\Resources\textbox_user_1.jpg";
            location[1] = @"..\..\Resources\textbox_user_2.jpg";
            location[2] = @"..\..\Resources\textbox_user_4.jpg";
            location[3] = @"..\..\Resources\textbox_user_5.jpg";
            location[4] = @"..\..\Resources\textbox_user_6.jpg";
            location[5] = @"..\..\Resources\textbox_user_7.jpg";
            location[6] = @"..\..\Resources\textbox_user_8.jpg";
            location[7] = @"..\..\Resources\textbox_user_9.jpg";
            location[8] = @"..\..\Resources\textbox_user_10.jpg";
            location[9] = @"..\..\Resources\textbox_user_11.jpg";
            location[10] = @"..\..\Resources\textbox_user_12.jpg";
            location[11] = @"..\..\Resources\textbox_user_13.jpg";
            location[12] = @"..\..\Resources\textbox_user_14.jpg";
            location[13] = @"..\..\Resources\textbox_user_15.jpg";
            location[14] = @"..\..\Resources\textbox_user_16.jpg";
            location[15] = @"..\..\Resources\textbox_user_17.jpg";
            location[16] = @"..\..\Resources\textbox_user_18.jpg";
            location[17] = @"..\..\Resources\textbox_user_19.jpg";
            location[18] = @"..\..\Resources\textbox_user_20.jpg";
            location[19] = @"..\..\Resources\textbox_user_21.jpg";
            location[20] = @"..\..\Resources\textbox_user_22.jpg";
            location[21] = @"..\..\Resources\textbox_user_23.jpg";
            location[22] = @"..\..\Resources\textbox_user_24.jpg";
            tounage();
            MessageBox.Show("Nhấn nút login để đăng nhập", "Thông báo", MessageBoxButtons.OK);
        }



    private void tounage()
        {
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox1.Text.Length <=15)
            {
                roundPictureBox1.Image = images[textBox1.Text.Length - 1];
                roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (textBox1.Text.Length <= 0)
            {
                roundPictureBox1.Image = Properties.Resources.debut;
            }
            else
            {
                roundPictureBox1.Image = images[22];
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Bitmap pass = new Bitmap(@"..\..\Resources\textbox_password.png");
            roundPictureBox1.Image = pass;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                roundPictureBox1.Image = images[textBox1.Text.Length - 1];
            }
            else
                roundPictureBox1.Image = Properties.Resources.debut;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//DLLIMPORT for roundcornor
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            /*this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 70, 70));*/
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FormApp fa = new FormApp();
            fa.Show();
            this.Hide();
            this.Location = fa.Location;
        }
    }
}
