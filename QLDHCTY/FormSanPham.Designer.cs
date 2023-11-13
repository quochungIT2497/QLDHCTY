namespace QLDHCTY
{
    partial class FormSanPham
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
            this.panel_ThaoTac = new System.Windows.Forms.Panel();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.grp_ChucNang = new System.Windows.Forms.GroupBox();
            this.rbtn_Xoa = new QLDHCTY.RoundButton();
            this.rbtn_Sua = new QLDHCTY.RoundButton();
            this.rbtn_Them = new QLDHCTY.RoundButton();
            this.grp_TT = new System.Windows.Forms.GroupBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.txt_MaLSP = new System.Windows.Forms.TextBox();
            this.comboBox_DVT = new System.Windows.Forms.ComboBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.lbl_MaNCC = new System.Windows.Forms.Label();
            this.lbl_MaLSP = new System.Windows.Forms.Label();
            this.lbl_DVT = new System.Windows.Forms.Label();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.lbl_MaSP = new System.Windows.Forms.Label();
            this.grp_dgvSP = new System.Windows.Forms.GroupBox();
            this.dgv_SP = new System.Windows.Forms.DataGridView();
            this.grp_TKSX = new System.Windows.Forms.GroupBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.comboBox_SX = new System.Windows.Forms.ComboBox();
            this.lbl_SX = new System.Windows.Forms.Label();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_ThaoTac.SuspendLayout();
            this.grp_ChucNang.SuspendLayout();
            this.grp_TT.SuspendLayout();
            this.grp_dgvSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).BeginInit();
            this.grp_TKSX.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ThaoTac
            // 
            this.panel_ThaoTac.Controls.Add(this.btn_Luu);
            this.panel_ThaoTac.Controls.Add(this.grp_ChucNang);
            this.panel_ThaoTac.Controls.Add(this.grp_TT);
            this.panel_ThaoTac.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_ThaoTac.Location = new System.Drawing.Point(495, 0);
            this.panel_ThaoTac.Name = "panel_ThaoTac";
            this.panel_ThaoTac.Size = new System.Drawing.Size(214, 437);
            this.panel_ThaoTac.TabIndex = 0;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(0, 0);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(214, 33);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Thống Kê";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // grp_ChucNang
            // 
            this.grp_ChucNang.Controls.Add(this.rbtn_Xoa);
            this.grp_ChucNang.Controls.Add(this.rbtn_Sua);
            this.grp_ChucNang.Controls.Add(this.rbtn_Them);
            this.grp_ChucNang.Location = new System.Drawing.Point(0, 300);
            this.grp_ChucNang.Name = "grp_ChucNang";
            this.grp_ChucNang.Size = new System.Drawing.Size(214, 134);
            this.grp_ChucNang.TabIndex = 1;
            this.grp_ChucNang.TabStop = false;
            this.grp_ChucNang.Text = "Thanh xử Lý";
            // 
            // rbtn_Xoa
            // 
            this.rbtn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Xoa.BorderColor = System.Drawing.Color.Silver;
            this.rbtn_Xoa.ButtonColor = System.Drawing.Color.Red;
            this.rbtn_Xoa.Location = new System.Drawing.Point(53, 91);
            this.rbtn_Xoa.Name = "rbtn_Xoa";
            this.rbtn_Xoa.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Xoa.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtn_Xoa.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.rbtn_Xoa.Size = new System.Drawing.Size(113, 30);
            this.rbtn_Xoa.TabIndex = 2;
            this.rbtn_Xoa.Text = "Xóa";
            this.rbtn_Xoa.TextColor = System.Drawing.Color.Black;
            this.rbtn_Xoa.UseVisualStyleBackColor = true;
            this.rbtn_Xoa.Click += new System.EventHandler(this.rbtn_Xoa_Click);
            // 
            // rbtn_Sua
            // 
            this.rbtn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Sua.BorderColor = System.Drawing.Color.Silver;
            this.rbtn_Sua.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtn_Sua.Location = new System.Drawing.Point(53, 55);
            this.rbtn_Sua.Name = "rbtn_Sua";
            this.rbtn_Sua.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtn_Sua.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtn_Sua.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtn_Sua.Size = new System.Drawing.Size(113, 30);
            this.rbtn_Sua.TabIndex = 1;
            this.rbtn_Sua.Text = "Sửa";
            this.rbtn_Sua.TextColor = System.Drawing.Color.Black;
            this.rbtn_Sua.UseVisualStyleBackColor = true;
            this.rbtn_Sua.Click += new System.EventHandler(this.rbtn_Sua_Click);
            // 
            // rbtn_Them
            // 
            this.rbtn_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Them.BorderColor = System.Drawing.Color.Silver;
            this.rbtn_Them.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbtn_Them.Location = new System.Drawing.Point(53, 19);
            this.rbtn_Them.Name = "rbtn_Them";
            this.rbtn_Them.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtn_Them.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtn_Them.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtn_Them.Size = new System.Drawing.Size(113, 30);
            this.rbtn_Them.TabIndex = 0;
            this.rbtn_Them.Text = "Thêm";
            this.rbtn_Them.TextColor = System.Drawing.Color.Black;
            this.rbtn_Them.UseVisualStyleBackColor = true;
            this.rbtn_Them.Click += new System.EventHandler(this.rbtn_Them_Click);
            // 
            // grp_TT
            // 
            this.grp_TT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TT.Controls.Add(this.txt_MaNCC);
            this.grp_TT.Controls.Add(this.txt_MaLSP);
            this.grp_TT.Controls.Add(this.comboBox_DVT);
            this.grp_TT.Controls.Add(this.txt_TenSP);
            this.grp_TT.Controls.Add(this.txt_MaSP);
            this.grp_TT.Controls.Add(this.lbl_MaNCC);
            this.grp_TT.Controls.Add(this.lbl_MaLSP);
            this.grp_TT.Controls.Add(this.lbl_DVT);
            this.grp_TT.Controls.Add(this.lbl_TenSP);
            this.grp_TT.Controls.Add(this.lbl_MaSP);
            this.grp_TT.Location = new System.Drawing.Point(0, 41);
            this.grp_TT.Name = "grp_TT";
            this.grp_TT.Size = new System.Drawing.Size(214, 253);
            this.grp_TT.TabIndex = 0;
            this.grp_TT.TabStop = false;
            this.grp_TT.Text = "Thông Tin";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaNCC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_MaNCC.Location = new System.Drawing.Point(86, 208);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(116, 20);
            this.txt_MaNCC.TabIndex = 9;
            // 
            // txt_MaLSP
            // 
            this.txt_MaLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaLSP.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_MaLSP.Location = new System.Drawing.Point(86, 163);
            this.txt_MaLSP.Name = "txt_MaLSP";
            this.txt_MaLSP.Size = new System.Drawing.Size(116, 20);
            this.txt_MaLSP.TabIndex = 8;
            // 
            // comboBox_DVT
            // 
            this.comboBox_DVT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_DVT.FormattingEnabled = true;
            this.comboBox_DVT.Location = new System.Drawing.Point(86, 118);
            this.comboBox_DVT.Name = "comboBox_DVT";
            this.comboBox_DVT.Size = new System.Drawing.Size(116, 21);
            this.comboBox_DVT.TabIndex = 7;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSP.Location = new System.Drawing.Point(86, 73);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(116, 20);
            this.txt_TenSP.TabIndex = 6;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSP.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_MaSP.Location = new System.Drawing.Point(86, 28);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(116, 20);
            this.txt_MaSP.TabIndex = 5;
            // 
            // lbl_MaNCC
            // 
            this.lbl_MaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaNCC.AutoSize = true;
            this.lbl_MaNCC.Location = new System.Drawing.Point(14, 211);
            this.lbl_MaNCC.Name = "lbl_MaNCC";
            this.lbl_MaNCC.Size = new System.Drawing.Size(53, 13);
            this.lbl_MaNCC.TabIndex = 4;
            this.lbl_MaNCC.Text = "Mã NCC :";
            // 
            // lbl_MaLSP
            // 
            this.lbl_MaLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaLSP.AutoSize = true;
            this.lbl_MaLSP.Location = new System.Drawing.Point(14, 166);
            this.lbl_MaLSP.Name = "lbl_MaLSP";
            this.lbl_MaLSP.Size = new System.Drawing.Size(54, 13);
            this.lbl_MaLSP.TabIndex = 3;
            this.lbl_MaLSP.Text = "Mã Loại : ";
            // 
            // lbl_DVT
            // 
            this.lbl_DVT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DVT.AutoSize = true;
            this.lbl_DVT.Location = new System.Drawing.Point(14, 121);
            this.lbl_DVT.Name = "lbl_DVT";
            this.lbl_DVT.Size = new System.Drawing.Size(66, 13);
            this.lbl_DVT.TabIndex = 2;
            this.lbl_DVT.Text = "Đơn vị tính :";
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Location = new System.Drawing.Point(14, 76);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(49, 13);
            this.lbl_TenSP.TabIndex = 1;
            this.lbl_TenSP.Text = "Tên SP :";
            // 
            // lbl_MaSP
            // 
            this.lbl_MaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaSP.AutoSize = true;
            this.lbl_MaSP.Location = new System.Drawing.Point(14, 31);
            this.lbl_MaSP.Name = "lbl_MaSP";
            this.lbl_MaSP.Size = new System.Drawing.Size(45, 13);
            this.lbl_MaSP.TabIndex = 0;
            this.lbl_MaSP.Text = "Mã SP :";
            // 
            // grp_dgvSP
            // 
            this.grp_dgvSP.Controls.Add(this.dgv_SP);
            this.grp_dgvSP.Location = new System.Drawing.Point(5, 103);
            this.grp_dgvSP.Name = "grp_dgvSP";
            this.grp_dgvSP.Size = new System.Drawing.Size(484, 334);
            this.grp_dgvSP.TabIndex = 1;
            this.grp_dgvSP.TabStop = false;
            this.grp_dgvSP.Text = "Danh Sách:";
            // 
            // dgv_SP
            // 
            this.dgv_SP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SP.Location = new System.Drawing.Point(0, 19);
            this.dgv_SP.Name = "dgv_SP";
            this.dgv_SP.Size = new System.Drawing.Size(484, 315);
            this.dgv_SP.TabIndex = 0;
            this.dgv_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellClick);
            // 
            // grp_TKSX
            // 
            this.grp_TKSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TKSX.Controls.Add(this.txt_TK);
            this.grp_TKSX.Controls.Add(this.comboBox_SX);
            this.grp_TKSX.Controls.Add(this.lbl_SX);
            this.grp_TKSX.Controls.Add(this.lbl_TK);
            this.grp_TKSX.Location = new System.Drawing.Point(5, 41);
            this.grp_TKSX.Name = "grp_TKSX";
            this.grp_TKSX.Size = new System.Drawing.Size(484, 56);
            this.grp_TKSX.TabIndex = 2;
            this.grp_TKSX.TabStop = false;
            this.grp_TKSX.Text = "Tìm Kiếm và Sắp Xếp";
            // 
            // txt_TK
            // 
            this.txt_TK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TK.Location = new System.Drawing.Point(78, 24);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(134, 20);
            this.txt_TK.TabIndex = 3;
            this.txt_TK.TextChanged += new System.EventHandler(this.txt_TK_TextChanged);
            // 
            // comboBox_SX
            // 
            this.comboBox_SX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_SX.FormattingEnabled = true;
            this.comboBox_SX.Location = new System.Drawing.Point(316, 23);
            this.comboBox_SX.Name = "comboBox_SX";
            this.comboBox_SX.Size = new System.Drawing.Size(134, 21);
            this.comboBox_SX.TabIndex = 2;
            // 
            // lbl_SX
            // 
            this.lbl_SX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SX.AutoSize = true;
            this.lbl_SX.Location = new System.Drawing.Point(253, 26);
            this.lbl_SX.Name = "lbl_SX";
            this.lbl_SX.Size = new System.Drawing.Size(57, 13);
            this.lbl_SX.TabIndex = 1;
            this.lbl_SX.Text = "Sắp Xếp : ";
            // 
            // lbl_TK
            // 
            this.lbl_TK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Location = new System.Drawing.Point(16, 26);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(56, 13);
            this.lbl_TK.TabIndex = 0;
            this.lbl_TK.Text = "Tìm Kiếm :";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Title.Location = new System.Drawing.Point(153, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(213, 24);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Danh Sách Sản Phẩm";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 437);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grp_TKSX);
            this.Controls.Add(this.grp_dgvSP);
            this.Controls.Add(this.panel_ThaoTac);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.panel_ThaoTac.ResumeLayout(false);
            this.grp_ChucNang.ResumeLayout(false);
            this.grp_TT.ResumeLayout(false);
            this.grp_TT.PerformLayout();
            this.grp_dgvSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).EndInit();
            this.grp_TKSX.ResumeLayout(false);
            this.grp_TKSX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ThaoTac;
        private System.Windows.Forms.GroupBox grp_ChucNang;
        private System.Windows.Forms.GroupBox grp_TT;
        private System.Windows.Forms.GroupBox grp_dgvSP;
        private System.Windows.Forms.DataGridView dgv_SP;
        private System.Windows.Forms.GroupBox grp_TKSX;
        private System.Windows.Forms.Button btn_Luu;
        private RoundButton rbtn_Xoa;
        private RoundButton rbtn_Sua;
        private RoundButton rbtn_Them;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.TextBox txt_MaLSP;
        private System.Windows.Forms.ComboBox comboBox_DVT;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.Label lbl_MaNCC;
        private System.Windows.Forms.Label lbl_MaLSP;
        private System.Windows.Forms.Label lbl_DVT;
        private System.Windows.Forms.Label lbl_TenSP;
        private System.Windows.Forms.Label lbl_MaSP;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.ComboBox comboBox_SX;
        private System.Windows.Forms.Label lbl_SX;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.Label lbl_Title;
    }
}