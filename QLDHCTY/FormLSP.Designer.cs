using System.Drawing;

namespace QLDHCTY
{
    partial class FormLSP
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
            this.lbl_MaLoai = new System.Windows.Forms.Label();
            this.lbl_TenLoai = new System.Windows.Forms.Label();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.grp_TT = new System.Windows.Forms.GroupBox();
            this.btn_ThemLSP = new System.Windows.Forms.Button();
            this.btn_SuaLSP = new System.Windows.Forms.Button();
            this.btn_XoaLSP = new System.Windows.Forms.Button();
            this.btn_XuatBCLSP = new System.Windows.Forms.Button();
            this.grp_ChucNang = new System.Windows.Forms.GroupBox();
            this.grp_dgv = new System.Windows.Forms.GroupBox();
            this.dgv_LoaiSP = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grp_TKSX = new System.Windows.Forms.GroupBox();
            this.comboBox_SX = new System.Windows.Forms.ComboBox();
            this.lbl_TKLSP = new System.Windows.Forms.Label();
            this.txt_TKTenLoai = new System.Windows.Forms.TextBox();
            this.lbl_SXLSP = new System.Windows.Forms.Label();
            this.grp_TT.SuspendLayout();
            this.grp_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSP)).BeginInit();
            this.grp_TKSX.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_MaLoai
            // 
            this.lbl_MaLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaLoai.AutoSize = true;
            this.lbl_MaLoai.Location = new System.Drawing.Point(52, 31);
            this.lbl_MaLoai.Name = "lbl_MaLoai";
            this.lbl_MaLoai.Size = new System.Drawing.Size(45, 13);
            this.lbl_MaLoai.TabIndex = 0;
            this.lbl_MaLoai.Text = "Mã Loại";
            // 
            // lbl_TenLoai
            // 
            this.lbl_TenLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenLoai.AutoSize = true;
            this.lbl_TenLoai.Location = new System.Drawing.Point(52, 60);
            this.lbl_TenLoai.Name = "lbl_TenLoai";
            this.lbl_TenLoai.Size = new System.Drawing.Size(49, 13);
            this.lbl_TenLoai.TabIndex = 1;
            this.lbl_TenLoai.Text = "Tên Loại";
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaLoai.Location = new System.Drawing.Point(114, 28);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(180, 20);
            this.txt_MaLoai.TabIndex = 2;
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenLoai.Location = new System.Drawing.Point(114, 57);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(180, 20);
            this.txt_TenLoai.TabIndex = 3;
            // 
            // grp_TT
            // 
            this.grp_TT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TT.Controls.Add(this.txt_TenLoai);
            this.grp_TT.Controls.Add(this.lbl_MaLoai);
            this.grp_TT.Controls.Add(this.txt_MaLoai);
            this.grp_TT.Controls.Add(this.lbl_TenLoai);
            this.grp_TT.Location = new System.Drawing.Point(12, 37);
            this.grp_TT.Name = "grp_TT";
            this.grp_TT.Size = new System.Drawing.Size(341, 86);
            this.grp_TT.TabIndex = 4;
            this.grp_TT.TabStop = false;
            this.grp_TT.Text = "Thông Tin";
            // 
            // btn_ThemLSP
            // 
            this.btn_ThemLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemLSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLSP.ForeColor = System.Drawing.Color.White;
            this.btn_ThemLSP.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_ThemLSP.Location = new System.Drawing.Point(33, 29);
            this.btn_ThemLSP.Name = "btn_ThemLSP";
            this.btn_ThemLSP.Size = new System.Drawing.Size(105, 26);
            this.btn_ThemLSP.TabIndex = 5;
            this.btn_ThemLSP.Text = "Thêm";
            this.btn_ThemLSP.UseVisualStyleBackColor = false;
            this.btn_ThemLSP.Click += new System.EventHandler(this.btn_ThemLSP_Click);
            this.btn_ThemLSP.Resize += new System.EventHandler(this.btn_Them_Resize);
            // 
            // btn_SuaLSP
            // 
            this.btn_SuaLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SuaLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_SuaLSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SuaLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaLSP.ForeColor = System.Drawing.Color.White;
            this.btn_SuaLSP.Location = new System.Drawing.Point(202, 29);
            this.btn_SuaLSP.Name = "btn_SuaLSP";
            this.btn_SuaLSP.Size = new System.Drawing.Size(105, 26);
            this.btn_SuaLSP.TabIndex = 6;
            this.btn_SuaLSP.Text = "Sửa";
            this.btn_SuaLSP.UseVisualStyleBackColor = false;
            this.btn_SuaLSP.Click += new System.EventHandler(this.btn_SuaLSP_Click);
            // 
            // btn_XoaLSP
            // 
            this.btn_XoaLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XoaLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_XoaLSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLSP.ForeColor = System.Drawing.Color.White;
            this.btn_XoaLSP.Location = new System.Drawing.Point(371, 29);
            this.btn_XoaLSP.Name = "btn_XoaLSP";
            this.btn_XoaLSP.Size = new System.Drawing.Size(105, 26);
            this.btn_XoaLSP.TabIndex = 7;
            this.btn_XoaLSP.Text = "Xóa";
            this.btn_XoaLSP.UseVisualStyleBackColor = false;
            this.btn_XoaLSP.Click += new System.EventHandler(this.btn_XoaLSP_Click);
            // 
            // btn_XuatBCLSP
            // 
            this.btn_XuatBCLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XuatBCLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_XuatBCLSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XuatBCLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatBCLSP.ForeColor = System.Drawing.Color.White;
            this.btn_XuatBCLSP.Location = new System.Drawing.Point(540, 29);
            this.btn_XuatBCLSP.Name = "btn_XuatBCLSP";
            this.btn_XuatBCLSP.Size = new System.Drawing.Size(105, 26);
            this.btn_XuatBCLSP.TabIndex = 9;
            this.btn_XuatBCLSP.Text = "Xuất Báo Cáo";
            this.btn_XuatBCLSP.UseVisualStyleBackColor = false;
            this.btn_XuatBCLSP.Click += new System.EventHandler(this.btn_XuatBCLSP_Click);
            // 
            // grp_ChucNang
            // 
            this.grp_ChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_ChucNang.Controls.Add(this.btn_ThemLSP);
            this.grp_ChucNang.Controls.Add(this.btn_XuatBCLSP);
            this.grp_ChucNang.Controls.Add(this.btn_SuaLSP);
            this.grp_ChucNang.Controls.Add(this.btn_XoaLSP);
            this.grp_ChucNang.Location = new System.Drawing.Point(12, 129);
            this.grp_ChucNang.Name = "grp_ChucNang";
            this.grp_ChucNang.Size = new System.Drawing.Size(668, 78);
            this.grp_ChucNang.TabIndex = 10;
            this.grp_ChucNang.TabStop = false;
            this.grp_ChucNang.Text = "Chức Năng";
            // 
            // grp_dgv
            // 
            this.grp_dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_dgv.Location = new System.Drawing.Point(12, 213);
            this.grp_dgv.Name = "grp_dgv";
            this.grp_dgv.Size = new System.Drawing.Size(674, 201);
            this.grp_dgv.TabIndex = 11;
            this.grp_dgv.TabStop = false;
            this.grp_dgv.Text = "Danh Sách Các Loại Sản Phảm";
            // 
            // dgv_LoaiSP
            // 
            this.dgv_LoaiSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_LoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiSP.Location = new System.Drawing.Point(12, 233);
            this.dgv_LoaiSP.Name = "dgv_LoaiSP";
            this.dgv_LoaiSP.Size = new System.Drawing.Size(668, 181);
            this.dgv_LoaiSP.TabIndex = 12;
            this.dgv_LoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiSP_CellClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(279, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(137, 24);
            this.lbl_Title.TabIndex = 13;
            this.lbl_Title.Text = "Loại Sản Phẩm";
            // 
            // grp_TKSX
            // 
            this.grp_TKSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TKSX.Controls.Add(this.comboBox_SX);
            this.grp_TKSX.Controls.Add(this.lbl_TKLSP);
            this.grp_TKSX.Controls.Add(this.txt_TKTenLoai);
            this.grp_TKSX.Controls.Add(this.lbl_SXLSP);
            this.grp_TKSX.Location = new System.Drawing.Point(375, 37);
            this.grp_TKSX.Name = "grp_TKSX";
            this.grp_TKSX.Size = new System.Drawing.Size(305, 86);
            this.grp_TKSX.TabIndex = 14;
            this.grp_TKSX.TabStop = false;
            this.grp_TKSX.Text = "Tìm kiếm và Sắp Xếp";
            // 
            // comboBox_SX
            // 
            this.comboBox_SX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_SX.FormattingEnabled = true;
            this.comboBox_SX.Location = new System.Drawing.Point(88, 55);
            this.comboBox_SX.Name = "comboBox_SX";
            this.comboBox_SX.Size = new System.Drawing.Size(180, 21);
            this.comboBox_SX.TabIndex = 7;
            // 
            // lbl_TKLSP
            // 
            this.lbl_TKLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TKLSP.AutoSize = true;
            this.lbl_TKLSP.Location = new System.Drawing.Point(26, 31);
            this.lbl_TKLSP.Name = "lbl_TKLSP";
            this.lbl_TKLSP.Size = new System.Drawing.Size(49, 13);
            this.lbl_TKLSP.TabIndex = 4;
            this.lbl_TKLSP.Text = "Tên Loại";
            // 
            // txt_TKTenLoai
            // 
            this.txt_TKTenLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TKTenLoai.Location = new System.Drawing.Point(88, 28);
            this.txt_TKTenLoai.Name = "txt_TKTenLoai";
            this.txt_TKTenLoai.Size = new System.Drawing.Size(180, 20);
            this.txt_TKTenLoai.TabIndex = 6;
            this.txt_TKTenLoai.TextChanged += new System.EventHandler(this.txt_TKTenLoai_TextChanged);
            // 
            // lbl_SXLSP
            // 
            this.lbl_SXLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SXLSP.AutoSize = true;
            this.lbl_SXLSP.Location = new System.Drawing.Point(27, 60);
            this.lbl_SXLSP.Name = "lbl_SXLSP";
            this.lbl_SXLSP.Size = new System.Drawing.Size(48, 13);
            this.lbl_SXLSP.TabIndex = 5;
            this.lbl_SXLSP.Text = "Sắp Xếp";
            // 
            // FormLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 437);
            this.Controls.Add(this.grp_TKSX);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grp_TT);
            this.Controls.Add(this.grp_ChucNang);
            this.Controls.Add(this.dgv_LoaiSP);
            this.Controls.Add(this.grp_dgv);
            this.Name = "FormLSP";
            this.Text = "Form1";
            this.grp_TT.ResumeLayout(false);
            this.grp_TT.PerformLayout();
            this.grp_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSP)).EndInit();
            this.grp_TKSX.ResumeLayout(false);
            this.grp_TKSX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaLoai;
        private System.Windows.Forms.Label lbl_TenLoai;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.GroupBox grp_TT;
        private System.Windows.Forms.Button btn_ThemLSP;
        private System.Windows.Forms.Button btn_SuaLSP;
        private System.Windows.Forms.Button btn_XoaLSP;
        private System.Windows.Forms.Button btn_XuatBCLSP;
        private System.Windows.Forms.GroupBox grp_ChucNang;
        private System.Windows.Forms.GroupBox grp_dgv;
        private System.Windows.Forms.DataGridView dgv_LoaiSP;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grp_TKSX;
        private System.Windows.Forms.ComboBox comboBox_SX;
        private System.Windows.Forms.Label lbl_TKLSP;
        private System.Windows.Forms.TextBox txt_TKTenLoai;
        private System.Windows.Forms.Label lbl_SXLSP;
    }
}

