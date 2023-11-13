namespace QLDHCTY
{
    partial class FormDatHang
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
            this.dgv_DH = new System.Windows.Forms.DataGridView();
            this.grp_dataDH = new System.Windows.Forms.GroupBox();
            this.grp_TT = new System.Windows.Forms.GroupBox();
            this.richTextBox_GhiChu = new System.Windows.Forms.RichTextBox();
            this.dtp_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_MaDL = new System.Windows.Forms.TextBox();
            this.txt_MaDH = new System.Windows.Forms.TextBox();
            this.grp_TK = new System.Windows.Forms.GroupBox();
            this.dtp_NDH = new System.Windows.Forms.DateTimePicker();
            this.lbl_TKNGDH = new System.Windows.Forms.Label();
            this.lbl_TKMaDH = new System.Windows.Forms.Label();
            this.txt_TKMaDH = new System.Windows.Forms.TextBox();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.lbl_NgDH = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_MaDL = new System.Windows.Forms.Label();
            this.lbl_MaDH = new System.Windows.Forms.Label();
            this.grp_ChucNang = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.rbtn_Luu = new QLDHCTY.RoundButton();
            this.rbtn_Xoa = new QLDHCTY.RoundButton();
            this.rbtn_Sua = new QLDHCTY.RoundButton();
            this.rbtn_Them = new QLDHCTY.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DH)).BeginInit();
            this.grp_TT.SuspendLayout();
            this.grp_TK.SuspendLayout();
            this.grp_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DH
            // 
            this.dgv_DH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DH.Location = new System.Drawing.Point(12, 239);
            this.dgv_DH.Name = "dgv_DH";
            this.dgv_DH.Size = new System.Drawing.Size(685, 186);
            this.dgv_DH.TabIndex = 0;
            this.dgv_DH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DH_CellClick);
            // 
            // grp_dataDH
            // 
            this.grp_dataDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_dataDH.Location = new System.Drawing.Point(12, 215);
            this.grp_dataDH.Name = "grp_dataDH";
            this.grp_dataDH.Size = new System.Drawing.Size(685, 210);
            this.grp_dataDH.TabIndex = 1;
            this.grp_dataDH.TabStop = false;
            this.grp_dataDH.Text = "Danh Sách:";
            // 
            // grp_TT
            // 
            this.grp_TT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TT.Controls.Add(this.richTextBox_GhiChu);
            this.grp_TT.Controls.Add(this.dtp_ngsinh);
            this.grp_TT.Controls.Add(this.txt_MaNV);
            this.grp_TT.Controls.Add(this.txt_MaDL);
            this.grp_TT.Controls.Add(this.txt_MaDH);
            this.grp_TT.Controls.Add(this.grp_TK);
            this.grp_TT.Controls.Add(this.lbl_GhiChu);
            this.grp_TT.Controls.Add(this.lbl_NgDH);
            this.grp_TT.Controls.Add(this.lbl_MaNV);
            this.grp_TT.Controls.Add(this.lbl_MaDL);
            this.grp_TT.Controls.Add(this.lbl_MaDH);
            this.grp_TT.Location = new System.Drawing.Point(12, 12);
            this.grp_TT.Name = "grp_TT";
            this.grp_TT.Size = new System.Drawing.Size(471, 197);
            this.grp_TT.TabIndex = 2;
            this.grp_TT.TabStop = false;
            this.grp_TT.Text = "Thông tin";
            // 
            // richTextBox_GhiChu
            // 
            this.richTextBox_GhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_GhiChu.Location = new System.Drawing.Point(296, 72);
            this.richTextBox_GhiChu.Name = "richTextBox_GhiChu";
            this.richTextBox_GhiChu.Size = new System.Drawing.Size(151, 39);
            this.richTextBox_GhiChu.TabIndex = 10;
            this.richTextBox_GhiChu.Text = "";
            // 
            // dtp_ngsinh
            // 
            this.dtp_ngsinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngsinh.Location = new System.Drawing.Point(296, 34);
            this.dtp_ngsinh.Name = "dtp_ngsinh";
            this.dtp_ngsinh.Size = new System.Drawing.Size(151, 20);
            this.dtp_ngsinh.TabIndex = 9;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaNV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_MaNV.Location = new System.Drawing.Point(70, 134);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(124, 20);
            this.txt_MaNV.TabIndex = 8;
            // 
            // txt_MaDL
            // 
            this.txt_MaDL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaDL.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_MaDL.Location = new System.Drawing.Point(70, 81);
            this.txt_MaDL.Name = "txt_MaDL";
            this.txt_MaDL.Size = new System.Drawing.Size(124, 20);
            this.txt_MaDL.TabIndex = 7;
            // 
            // txt_MaDH
            // 
            this.txt_MaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaDH.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_MaDH.Location = new System.Drawing.Point(70, 33);
            this.txt_MaDH.Name = "txt_MaDH";
            this.txt_MaDH.Size = new System.Drawing.Size(124, 20);
            this.txt_MaDH.TabIndex = 6;
            // 
            // grp_TK
            // 
            this.grp_TK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TK.Controls.Add(this.dtp_NDH);
            this.grp_TK.Controls.Add(this.lbl_TKNGDH);
            this.grp_TK.Controls.Add(this.lbl_TKMaDH);
            this.grp_TK.Controls.Add(this.txt_TKMaDH);
            this.grp_TK.Location = new System.Drawing.Point(232, 117);
            this.grp_TK.Name = "grp_TK";
            this.grp_TK.Size = new System.Drawing.Size(239, 80);
            this.grp_TK.TabIndex = 5;
            this.grp_TK.TabStop = false;
            this.grp_TK.Text = "Tìm Kiếm";
            // 
            // dtp_NDH
            // 
            this.dtp_NDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NDH.Location = new System.Drawing.Point(64, 54);
            this.dtp_NDH.Name = "dtp_NDH";
            this.dtp_NDH.Size = new System.Drawing.Size(151, 20);
            this.dtp_NDH.TabIndex = 11;
            this.dtp_NDH.ValueChanged += new System.EventHandler(this.dtp_NDH_ValueChanged);
            // 
            // lbl_TKNGDH
            // 
            this.lbl_TKNGDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TKNGDH.AutoSize = true;
            this.lbl_TKNGDH.Location = new System.Drawing.Point(11, 57);
            this.lbl_TKNGDH.Name = "lbl_TKNGDH";
            this.lbl_TKNGDH.Size = new System.Drawing.Size(37, 13);
            this.lbl_TKNGDH.TabIndex = 12;
            this.lbl_TKNGDH.Text = "NĐH :";
            // 
            // lbl_TKMaDH
            // 
            this.lbl_TKMaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TKMaDH.AutoSize = true;
            this.lbl_TKMaDH.Location = new System.Drawing.Point(11, 23);
            this.lbl_TKMaDH.Name = "lbl_TKMaDH";
            this.lbl_TKMaDH.Size = new System.Drawing.Size(47, 13);
            this.lbl_TKMaDH.TabIndex = 11;
            this.lbl_TKMaDH.Text = "Mã ĐH :";
            // 
            // txt_TKMaDH
            // 
            this.txt_TKMaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TKMaDH.Location = new System.Drawing.Point(64, 20);
            this.txt_TKMaDH.Name = "txt_TKMaDH";
            this.txt_TKMaDH.Size = new System.Drawing.Size(151, 20);
            this.txt_TKMaDH.TabIndex = 0;
            this.txt_TKMaDH.TextChanged += new System.EventHandler(this.txt_TKMaDH_TextChanged);
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.Location = new System.Drawing.Point(229, 84);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(50, 13);
            this.lbl_GhiChu.TabIndex = 4;
            this.lbl_GhiChu.Text = "Ghi chú :";
            // 
            // lbl_NgDH
            // 
            this.lbl_NgDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NgDH.AutoSize = true;
            this.lbl_NgDH.Location = new System.Drawing.Point(229, 36);
            this.lbl_NgDH.Name = "lbl_NgDH";
            this.lbl_NgDH.Size = new System.Drawing.Size(57, 13);
            this.lbl_NgDH.TabIndex = 3;
            this.lbl_NgDH.Text = "Ngày ĐH :";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(6, 137);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(46, 13);
            this.lbl_MaNV.TabIndex = 2;
            this.lbl_MaNV.Text = "Mã NV :";
            // 
            // lbl_MaDL
            // 
            this.lbl_MaDL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaDL.AutoSize = true;
            this.lbl_MaDL.Location = new System.Drawing.Point(6, 84);
            this.lbl_MaDL.Name = "lbl_MaDL";
            this.lbl_MaDL.Size = new System.Drawing.Size(61, 13);
            this.lbl_MaDL.TabIndex = 1;
            this.lbl_MaDL.Text = "Mã Đại Lý :";
            // 
            // lbl_MaDH
            // 
            this.lbl_MaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaDH.AutoSize = true;
            this.lbl_MaDH.Location = new System.Drawing.Point(6, 36);
            this.lbl_MaDH.Name = "lbl_MaDH";
            this.lbl_MaDH.Size = new System.Drawing.Size(47, 13);
            this.lbl_MaDH.TabIndex = 0;
            this.lbl_MaDH.Text = "Mã ĐH :";
            // 
            // grp_ChucNang
            // 
            this.grp_ChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_ChucNang.Controls.Add(this.lbl_Title);
            this.grp_ChucNang.Controls.Add(this.rbtn_Luu);
            this.grp_ChucNang.Controls.Add(this.rbtn_Xoa);
            this.grp_ChucNang.Controls.Add(this.rbtn_Sua);
            this.grp_ChucNang.Controls.Add(this.rbtn_Them);
            this.grp_ChucNang.Location = new System.Drawing.Point(489, 12);
            this.grp_ChucNang.Name = "grp_ChucNang";
            this.grp_ChucNang.Size = new System.Drawing.Size(208, 197);
            this.grp_ChucNang.TabIndex = 3;
            this.grp_ChucNang.TabStop = false;
            this.grp_ChucNang.Text = "Thanh xử lý";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Aqua;
            this.lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 33);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(190, 26);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Quản Lý Đơn Hàng";
            // 
            // rbtn_Luu
            // 
            this.rbtn_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Luu.BorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Luu.ButtonColor = System.Drawing.Color.Green;
            this.rbtn_Luu.Location = new System.Drawing.Point(109, 153);
            this.rbtn_Luu.Name = "rbtn_Luu";
            this.rbtn_Luu.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Luu.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.rbtn_Luu.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.rbtn_Luu.Size = new System.Drawing.Size(93, 34);
            this.rbtn_Luu.TabIndex = 3;
            this.rbtn_Luu.Text = "Thống Kê";
            this.rbtn_Luu.TextColor = System.Drawing.Color.White;
            this.rbtn_Luu.UseVisualStyleBackColor = true;
            this.rbtn_Luu.Click += new System.EventHandler(this.rbtn_Luu_Click);
            // 
            // rbtn_Xoa
            // 
            this.rbtn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Xoa.BorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Xoa.ButtonColor = System.Drawing.Color.Red;
            this.rbtn_Xoa.Location = new System.Drawing.Point(6, 153);
            this.rbtn_Xoa.Name = "rbtn_Xoa";
            this.rbtn_Xoa.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Xoa.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.rbtn_Xoa.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.rbtn_Xoa.Size = new System.Drawing.Size(93, 34);
            this.rbtn_Xoa.TabIndex = 2;
            this.rbtn_Xoa.Text = "Xóa";
            this.rbtn_Xoa.TextColor = System.Drawing.Color.White;
            this.rbtn_Xoa.UseVisualStyleBackColor = true;
            this.rbtn_Xoa.Click += new System.EventHandler(this.rbtn_Xoa_Click);
            // 
            // rbtn_Sua
            // 
            this.rbtn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Sua.BorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Sua.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbtn_Sua.Location = new System.Drawing.Point(109, 104);
            this.rbtn_Sua.Name = "rbtn_Sua";
            this.rbtn_Sua.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Sua.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.rbtn_Sua.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.rbtn_Sua.Size = new System.Drawing.Size(93, 34);
            this.rbtn_Sua.TabIndex = 1;
            this.rbtn_Sua.Text = "Sửa";
            this.rbtn_Sua.TextColor = System.Drawing.Color.White;
            this.rbtn_Sua.UseVisualStyleBackColor = true;
            this.rbtn_Sua.Click += new System.EventHandler(this.rbtn_Sua_Click);
            // 
            // rbtn_Them
            // 
            this.rbtn_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Them.BorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Them.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtn_Them.Location = new System.Drawing.Point(6, 104);
            this.rbtn_Them.Name = "rbtn_Them";
            this.rbtn_Them.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.rbtn_Them.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.rbtn_Them.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.rbtn_Them.Size = new System.Drawing.Size(93, 34);
            this.rbtn_Them.TabIndex = 0;
            this.rbtn_Them.Text = "Thêm";
            this.rbtn_Them.TextColor = System.Drawing.Color.White;
            this.rbtn_Them.UseVisualStyleBackColor = true;
            this.rbtn_Them.Click += new System.EventHandler(this.rbtn_Them_Click);
            // 
            // FormDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 437);
            this.Controls.Add(this.grp_ChucNang);
            this.Controls.Add(this.grp_TT);
            this.Controls.Add(this.dgv_DH);
            this.Controls.Add(this.grp_dataDH);
            this.Name = "FormDatHang";
            this.Text = "FormDatHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DH)).EndInit();
            this.grp_TT.ResumeLayout(false);
            this.grp_TT.PerformLayout();
            this.grp_TK.ResumeLayout(false);
            this.grp_TK.PerformLayout();
            this.grp_ChucNang.ResumeLayout(false);
            this.grp_ChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DH;
        private System.Windows.Forms.GroupBox grp_dataDH;
        private System.Windows.Forms.GroupBox grp_TT;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_MaDL;
        private System.Windows.Forms.TextBox txt_MaDH;
        private System.Windows.Forms.GroupBox grp_TK;
        private System.Windows.Forms.Label lbl_GhiChu;
        private System.Windows.Forms.Label lbl_NgDH;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_MaDL;
        private System.Windows.Forms.Label lbl_MaDH;
        private System.Windows.Forms.GroupBox grp_ChucNang;
        private System.Windows.Forms.DateTimePicker dtp_ngsinh;
        private System.Windows.Forms.Label lbl_TKNGDH;
        private System.Windows.Forms.Label lbl_TKMaDH;
        private System.Windows.Forms.TextBox txt_TKMaDH;
        private System.Windows.Forms.Label lbl_Title;
        private RoundButton rbtn_Luu;
        private RoundButton rbtn_Xoa;
        private RoundButton rbtn_Sua;
        private RoundButton rbtn_Them;
        private System.Windows.Forms.RichTextBox richTextBox_GhiChu;
        private System.Windows.Forms.DateTimePicker dtp_NDH;
    }
}