namespace QLDHCTY
{
    partial class FormNhanVien
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
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.grp_dataNV = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_HTNV = new System.Windows.Forms.Label();
            this.lbl_NSNV = new System.Windows.Forms.Label();
            this.lbl_DCNV = new System.Windows.Forms.Label();
            this.lbl_SDTNV = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.richTextBox_DCNV = new System.Windows.Forms.RichTextBox();
            this.DTP_NS = new System.Windows.Forms.DateTimePicker();
            this.txt_HTNV = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.grp_TTNV = new System.Windows.Forms.GroupBox();
            this.grp_TK = new System.Windows.Forms.GroupBox();
            this.ComboBoxSX = new System.Windows.Forms.ComboBox();
            this.txt_TKSDT = new System.Windows.Forms.TextBox();
            this.txt_TKHT = new System.Windows.Forms.TextBox();
            this.lbl_SX = new System.Windows.Forms.Label();
            this.lbl_TKSDT = new System.Windows.Forms.Label();
            this.lbl_TKHT = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_TKNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.panel_TT = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.grp_dataNV.SuspendLayout();
            this.grp_TTNV.SuspendLayout();
            this.grp_TK.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.panel_TT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_NV
            // 
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Location = new System.Drawing.Point(6, 19);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.Size = new System.Drawing.Size(457, 323);
            this.dgv_NV.TabIndex = 0;
            this.dgv_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellClick);
            // 
            // grp_dataNV
            // 
            this.grp_dataNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_dataNV.Controls.Add(this.dgv_NV);
            this.grp_dataNV.Location = new System.Drawing.Point(0, 37);
            this.grp_dataNV.Name = "grp_dataNV";
            this.grp_dataNV.Size = new System.Drawing.Size(463, 348);
            this.grp_dataNV.TabIndex = 1;
            this.grp_dataNV.TabStop = false;
            this.grp_dataNV.Text = "Danh Sách";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Title.Location = new System.Drawing.Point(111, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(247, 26);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Danh Sách Nhân Viên";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(14, 33);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(43, 13);
            this.lbl_MaNV.TabIndex = 3;
            this.lbl_MaNV.Text = "Mã NV:";
            // 
            // lbl_HTNV
            // 
            this.lbl_HTNV.AutoSize = true;
            this.lbl_HTNV.Location = new System.Drawing.Point(14, 71);
            this.lbl_HTNV.Name = "lbl_HTNV";
            this.lbl_HTNV.Size = new System.Drawing.Size(46, 13);
            this.lbl_HTNV.TabIndex = 4;
            this.lbl_HTNV.Text = "Họ Tên:";
            // 
            // lbl_NSNV
            // 
            this.lbl_NSNV.AutoSize = true;
            this.lbl_NSNV.Location = new System.Drawing.Point(14, 112);
            this.lbl_NSNV.Name = "lbl_NSNV";
            this.lbl_NSNV.Size = new System.Drawing.Size(59, 13);
            this.lbl_NSNV.TabIndex = 5;
            this.lbl_NSNV.Text = "Ngày Sinh:";
            // 
            // lbl_DCNV
            // 
            this.lbl_DCNV.AutoSize = true;
            this.lbl_DCNV.Location = new System.Drawing.Point(14, 147);
            this.lbl_DCNV.Name = "lbl_DCNV";
            this.lbl_DCNV.Size = new System.Drawing.Size(44, 13);
            this.lbl_DCNV.TabIndex = 6;
            this.lbl_DCNV.Text = "Địa Chỉ:";
            // 
            // lbl_SDTNV
            // 
            this.lbl_SDTNV.AutoSize = true;
            this.lbl_SDTNV.Location = new System.Drawing.Point(14, 216);
            this.lbl_SDTNV.Name = "lbl_SDTNV";
            this.lbl_SDTNV.Size = new System.Drawing.Size(32, 13);
            this.lbl_SDTNV.TabIndex = 7;
            this.lbl_SDTNV.Text = "SĐT:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaNV.Location = new System.Drawing.Point(85, 30);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(100, 20);
            this.txt_MaNV.TabIndex = 8;
            // 
            // richTextBox_DCNV
            // 
            this.richTextBox_DCNV.Location = new System.Drawing.Point(88, 144);
            this.richTextBox_DCNV.Name = "richTextBox_DCNV";
            this.richTextBox_DCNV.Size = new System.Drawing.Size(100, 54);
            this.richTextBox_DCNV.TabIndex = 10;
            this.richTextBox_DCNV.Text = "";
            // 
            // DTP_NS
            // 
            this.DTP_NS.Location = new System.Drawing.Point(85, 106);
            this.DTP_NS.Name = "DTP_NS";
            this.DTP_NS.Size = new System.Drawing.Size(108, 20);
            this.DTP_NS.TabIndex = 11;
            // 
            // txt_HTNV
            // 
            this.txt_HTNV.Location = new System.Drawing.Point(85, 68);
            this.txt_HTNV.Name = "txt_HTNV";
            this.txt_HTNV.Size = new System.Drawing.Size(100, 20);
            this.txt_HTNV.TabIndex = 9;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(88, 216);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(100, 20);
            this.txt_SDT.TabIndex = 12;
            // 
            // grp_TTNV
            // 
            this.grp_TTNV.Controls.Add(this.txt_SDT);
            this.grp_TTNV.Controls.Add(this.txt_MaNV);
            this.grp_TTNV.Controls.Add(this.txt_HTNV);
            this.grp_TTNV.Controls.Add(this.lbl_MaNV);
            this.grp_TTNV.Controls.Add(this.DTP_NS);
            this.grp_TTNV.Controls.Add(this.lbl_SDTNV);
            this.grp_TTNV.Controls.Add(this.lbl_HTNV);
            this.grp_TTNV.Controls.Add(this.lbl_NSNV);
            this.grp_TTNV.Controls.Add(this.richTextBox_DCNV);
            this.grp_TTNV.Controls.Add(this.lbl_DCNV);
            this.grp_TTNV.Location = new System.Drawing.Point(3, 126);
            this.grp_TTNV.Name = "grp_TTNV";
            this.grp_TTNV.Size = new System.Drawing.Size(226, 258);
            this.grp_TTNV.TabIndex = 13;
            this.grp_TTNV.TabStop = false;
            this.grp_TTNV.Text = "Thông Tin";
            // 
            // grp_TK
            // 
            this.grp_TK.Controls.Add(this.ComboBoxSX);
            this.grp_TK.Controls.Add(this.txt_TKSDT);
            this.grp_TK.Controls.Add(this.txt_TKHT);
            this.grp_TK.Controls.Add(this.lbl_SX);
            this.grp_TK.Controls.Add(this.lbl_TKSDT);
            this.grp_TK.Controls.Add(this.lbl_TKHT);
            this.grp_TK.Location = new System.Drawing.Point(3, 12);
            this.grp_TK.Name = "grp_TK";
            this.grp_TK.Size = new System.Drawing.Size(226, 108);
            this.grp_TK.TabIndex = 14;
            this.grp_TK.TabStop = false;
            this.grp_TK.Text = "Tìm kiếm và Sắp Xếp";
            // 
            // ComboBoxSX
            // 
            this.ComboBoxSX.FormattingEnabled = true;
            this.ComboBoxSX.Items.AddRange(new object[] {
            "Họ Tên",
            "Mã NV"});
            this.ComboBoxSX.Location = new System.Drawing.Point(85, 81);
            this.ComboBoxSX.Name = "ComboBoxSX";
            this.ComboBoxSX.Size = new System.Drawing.Size(108, 21);
            this.ComboBoxSX.TabIndex = 5;
            // 
            // txt_TKSDT
            // 
            this.txt_TKSDT.Location = new System.Drawing.Point(85, 51);
            this.txt_TKSDT.Name = "txt_TKSDT";
            this.txt_TKSDT.Size = new System.Drawing.Size(108, 20);
            this.txt_TKSDT.TabIndex = 4;
            // 
            // txt_TKHT
            // 
            this.txt_TKHT.Location = new System.Drawing.Point(85, 21);
            this.txt_TKHT.Name = "txt_TKHT";
            this.txt_TKHT.Size = new System.Drawing.Size(108, 20);
            this.txt_TKHT.TabIndex = 3;
            // 
            // lbl_SX
            // 
            this.lbl_SX.AutoSize = true;
            this.lbl_SX.Location = new System.Drawing.Point(14, 84);
            this.lbl_SX.Name = "lbl_SX";
            this.lbl_SX.Size = new System.Drawing.Size(51, 13);
            this.lbl_SX.TabIndex = 2;
            this.lbl_SX.Text = "Sắp Xếp:";
            // 
            // lbl_TKSDT
            // 
            this.lbl_TKSDT.AutoSize = true;
            this.lbl_TKSDT.Location = new System.Drawing.Point(14, 54);
            this.lbl_TKSDT.Name = "lbl_TKSDT";
            this.lbl_TKSDT.Size = new System.Drawing.Size(32, 13);
            this.lbl_TKSDT.TabIndex = 1;
            this.lbl_TKSDT.Text = "SĐT:";
            // 
            // lbl_TKHT
            // 
            this.lbl_TKHT.AutoSize = true;
            this.lbl_TKHT.Location = new System.Drawing.Point(14, 25);
            this.lbl_TKHT.Name = "lbl_TKHT";
            this.lbl_TKHT.Size = new System.Drawing.Size(46, 13);
            this.lbl_TKHT.TabIndex = 0;
            this.lbl_TKHT.Text = "Họ Tên:";
            // 
            // panel_button
            // 
            this.panel_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_button.Controls.Add(this.btn_Luu);
            this.panel_button.Controls.Add(this.btn_XoaNV);
            this.panel_button.Controls.Add(this.btn_TKNV);
            this.panel_button.Controls.Add(this.btn_SuaNV);
            this.panel_button.Controls.Add(this.btn_ThemNV);
            this.panel_button.Location = new System.Drawing.Point(0, 383);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(698, 54);
            this.panel_button.TabIndex = 15;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(565, 0);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(140, 54);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_XoaNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_XoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaNV.ForeColor = System.Drawing.Color.White;
            this.btn_XoaNV.Location = new System.Drawing.Point(425, 0);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(140, 54);
            this.btn_XoaNV.TabIndex = 3;
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.UseVisualStyleBackColor = false;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_TKNV
            // 
            this.btn_TKNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_TKNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_TKNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TKNV.ForeColor = System.Drawing.Color.White;
            this.btn_TKNV.Location = new System.Drawing.Point(285, 0);
            this.btn_TKNV.Name = "btn_TKNV";
            this.btn_TKNV.Size = new System.Drawing.Size(140, 54);
            this.btn_TKNV.TabIndex = 2;
            this.btn_TKNV.Text = "Tìm Kiếm";
            this.btn_TKNV.UseVisualStyleBackColor = false;
            this.btn_TKNV.Click += new System.EventHandler(this.btn_TKNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_SuaNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaNV.ForeColor = System.Drawing.Color.White;
            this.btn_SuaNV.Location = new System.Drawing.Point(145, 0);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(140, 54);
            this.btn_SuaNV.TabIndex = 1;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.UseVisualStyleBackColor = false;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_ThemNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNV.ForeColor = System.Drawing.Color.White;
            this.btn_ThemNV.Location = new System.Drawing.Point(0, 0);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(145, 54);
            this.btn_ThemNV.TabIndex = 0;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = false;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // panel_TT
            // 
            this.panel_TT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_TT.Controls.Add(this.grp_TK);
            this.panel_TT.Controls.Add(this.grp_TTNV);
            this.panel_TT.Location = new System.Drawing.Point(469, 0);
            this.panel_TT.Name = "panel_TT";
            this.panel_TT.Size = new System.Drawing.Size(229, 385);
            this.panel_TT.TabIndex = 16;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 437);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grp_dataNV);
            this.Controls.Add(this.panel_TT);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.grp_dataNV.ResumeLayout(false);
            this.grp_TTNV.ResumeLayout(false);
            this.grp_TTNV.PerformLayout();
            this.grp_TK.ResumeLayout(false);
            this.grp_TK.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.panel_TT.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.GroupBox grp_dataNV;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_HTNV;
        private System.Windows.Forms.Label lbl_NSNV;
        private System.Windows.Forms.Label lbl_DCNV;
        private System.Windows.Forms.Label lbl_SDTNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.RichTextBox richTextBox_DCNV;
        private System.Windows.Forms.DateTimePicker DTP_NS;
        private System.Windows.Forms.TextBox txt_HTNV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.GroupBox grp_TTNV;
        private System.Windows.Forms.GroupBox grp_TK;
        private System.Windows.Forms.ComboBox ComboBoxSX;
        private System.Windows.Forms.TextBox txt_TKSDT;
        private System.Windows.Forms.TextBox txt_TKHT;
        private System.Windows.Forms.Label lbl_SX;
        private System.Windows.Forms.Label lbl_TKSDT;
        private System.Windows.Forms.Label lbl_TKHT;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_TT;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_TKNV;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.Button btn_ThemNV;
    }
}