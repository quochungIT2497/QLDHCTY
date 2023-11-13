namespace QLDHCTY
{
    partial class FormNhaCC
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
            this.panel_TTNCC = new System.Windows.Forms.Panel();
            this.btn_BCNCC = new System.Windows.Forms.Button();
            this.btn_SuaNCC = new System.Windows.Forms.Button();
            this.btn_XoaNCC = new System.Windows.Forms.Button();
            this.btn_TKNCC = new System.Windows.Forms.Button();
            this.btn_ThemNcc = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_btnNCC = new System.Windows.Forms.Panel();
            this.grp_TTNCC = new System.Windows.Forms.GroupBox();
            this.richTextBox_dIaChi = new System.Windows.Forms.RichTextBox();
            this.txt_NgDD = new System.Windows.Forms.TextBox();
            this.txt_TenNcc = new System.Windows.Forms.TextBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.lbl_TTNCC = new System.Windows.Forms.Label();
            this.lbl_DCNCC = new System.Windows.Forms.Label();
            this.lbl_TenNcc = new System.Windows.Forms.Label();
            this.lbl_MaNCC = new System.Windows.Forms.Label();
            this.panel_dgvNCC = new System.Windows.Forms.Panel();
            this.grp_dgvNCC = new System.Windows.Forms.GroupBox();
            this.dgv_NhaCC = new System.Windows.Forms.DataGridView();
            this.panel_TTNCC.SuspendLayout();
            this.panel_btnNCC.SuspendLayout();
            this.grp_TTNCC.SuspendLayout();
            this.panel_dgvNCC.SuspendLayout();
            this.grp_dgvNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TTNCC
            // 
            this.panel_TTNCC.BackColor = System.Drawing.Color.Navy;
            this.panel_TTNCC.Controls.Add(this.btn_BCNCC);
            this.panel_TTNCC.Controls.Add(this.btn_SuaNCC);
            this.panel_TTNCC.Controls.Add(this.btn_XoaNCC);
            this.panel_TTNCC.Controls.Add(this.btn_TKNCC);
            this.panel_TTNCC.Controls.Add(this.btn_ThemNcc);
            this.panel_TTNCC.Controls.Add(this.lbl_Title);
            this.panel_TTNCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_TTNCC.Location = new System.Drawing.Point(0, 0);
            this.panel_TTNCC.Name = "panel_TTNCC";
            this.panel_TTNCC.Size = new System.Drawing.Size(190, 447);
            this.panel_TTNCC.TabIndex = 0;
            // 
            // btn_BCNCC
            // 
            this.btn_BCNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BCNCC.BackColor = System.Drawing.Color.White;
            this.btn_BCNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BCNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BCNCC.ForeColor = System.Drawing.Color.Purple;
            this.btn_BCNCC.Location = new System.Drawing.Point(0, 377);
            this.btn_BCNCC.Name = "btn_BCNCC";
            this.btn_BCNCC.Size = new System.Drawing.Size(190, 70);
            this.btn_BCNCC.TabIndex = 9;
            this.btn_BCNCC.Text = "Xuất Báo Cáo";
            this.btn_BCNCC.UseVisualStyleBackColor = false;
            this.btn_BCNCC.Click += new System.EventHandler(this.btn_BCNCC_Click);
            // 
            // btn_SuaNCC
            // 
            this.btn_SuaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SuaNCC.BackColor = System.Drawing.Color.White;
            this.btn_SuaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SuaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNCC.ForeColor = System.Drawing.Color.Navy;
            this.btn_SuaNCC.Location = new System.Drawing.Point(0, 307);
            this.btn_SuaNCC.Name = "btn_SuaNCC";
            this.btn_SuaNCC.Size = new System.Drawing.Size(190, 70);
            this.btn_SuaNCC.TabIndex = 8;
            this.btn_SuaNCC.Text = "Sửa";
            this.btn_SuaNCC.UseVisualStyleBackColor = false;
            this.btn_SuaNCC.Click += new System.EventHandler(this.btn_SuaNCC_Click);
            // 
            // btn_XoaNCC
            // 
            this.btn_XoaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XoaNCC.BackColor = System.Drawing.Color.White;
            this.btn_XoaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_XoaNCC.Location = new System.Drawing.Point(0, 237);
            this.btn_XoaNCC.Name = "btn_XoaNCC";
            this.btn_XoaNCC.Size = new System.Drawing.Size(190, 70);
            this.btn_XoaNCC.TabIndex = 7;
            this.btn_XoaNCC.Text = "Xóa";
            this.btn_XoaNCC.UseVisualStyleBackColor = false;
            this.btn_XoaNCC.Click += new System.EventHandler(this.btn_XoaNCC_Click);
            // 
            // btn_TKNCC
            // 
            this.btn_TKNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TKNCC.BackColor = System.Drawing.Color.White;
            this.btn_TKNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TKNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TKNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_TKNCC.Location = new System.Drawing.Point(0, 97);
            this.btn_TKNCC.Name = "btn_TKNCC";
            this.btn_TKNCC.Size = new System.Drawing.Size(190, 70);
            this.btn_TKNCC.TabIndex = 5;
            this.btn_TKNCC.Text = "Tìm Kiếm";
            this.btn_TKNCC.UseVisualStyleBackColor = false;
            this.btn_TKNCC.Click += new System.EventHandler(this.btn_TKNCC_Click);
            // 
            // btn_ThemNcc
            // 
            this.btn_ThemNcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemNcc.BackColor = System.Drawing.Color.White;
            this.btn_ThemNcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ThemNcc.Location = new System.Drawing.Point(0, 167);
            this.btn_ThemNcc.Name = "btn_ThemNcc";
            this.btn_ThemNcc.Size = new System.Drawing.Size(190, 70);
            this.btn_ThemNcc.TabIndex = 6;
            this.btn_ThemNcc.Text = "Thêm";
            this.btn_ThemNcc.UseVisualStyleBackColor = false;
            this.btn_ThemNcc.Click += new System.EventHandler(this.btn_ThemNcc_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Navy;
            this.lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(6, 43);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(178, 22);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Tag = "";
            this.lbl_Title.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // panel_btnNCC
            // 
            this.panel_btnNCC.Controls.Add(this.grp_TTNCC);
            this.panel_btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_btnNCC.Location = new System.Drawing.Point(190, 0);
            this.panel_btnNCC.Name = "panel_btnNCC";
            this.panel_btnNCC.Size = new System.Drawing.Size(519, 100);
            this.panel_btnNCC.TabIndex = 1;
            // 
            // grp_TTNCC
            // 
            this.grp_TTNCC.Controls.Add(this.richTextBox_dIaChi);
            this.grp_TTNCC.Controls.Add(this.txt_NgDD);
            this.grp_TTNCC.Controls.Add(this.txt_TenNcc);
            this.grp_TTNCC.Controls.Add(this.txt_MaNCC);
            this.grp_TTNCC.Controls.Add(this.lbl_TTNCC);
            this.grp_TTNCC.Controls.Add(this.lbl_DCNCC);
            this.grp_TTNCC.Controls.Add(this.lbl_TenNcc);
            this.grp_TTNCC.Controls.Add(this.lbl_MaNCC);
            this.grp_TTNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_TTNCC.Location = new System.Drawing.Point(0, 0);
            this.grp_TTNCC.Name = "grp_TTNCC";
            this.grp_TTNCC.Size = new System.Drawing.Size(519, 100);
            this.grp_TTNCC.TabIndex = 0;
            this.grp_TTNCC.TabStop = false;
            this.grp_TTNCC.Text = "Thông Tin";
            // 
            // richTextBox_dIaChi
            // 
            this.richTextBox_dIaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_dIaChi.Location = new System.Drawing.Point(369, 25);
            this.richTextBox_dIaChi.Name = "richTextBox_dIaChi";
            this.richTextBox_dIaChi.Size = new System.Drawing.Size(128, 35);
            this.richTextBox_dIaChi.TabIndex = 8;
            this.richTextBox_dIaChi.Text = "";
            // 
            // txt_NgDD
            // 
            this.txt_NgDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NgDD.Location = new System.Drawing.Point(369, 71);
            this.txt_NgDD.Name = "txt_NgDD";
            this.txt_NgDD.Size = new System.Drawing.Size(128, 20);
            this.txt_NgDD.TabIndex = 7;
            // 
            // txt_TenNcc
            // 
            this.txt_TenNcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenNcc.Location = new System.Drawing.Point(129, 71);
            this.txt_TenNcc.Name = "txt_TenNcc";
            this.txt_TenNcc.Size = new System.Drawing.Size(128, 20);
            this.txt_TenNcc.TabIndex = 6;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaNCC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_MaNCC.Location = new System.Drawing.Point(129, 35);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(128, 20);
            this.txt_MaNCC.TabIndex = 5;
            // 
            // lbl_TTNCC
            // 
            this.lbl_TTNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TTNCC.AutoSize = true;
            this.lbl_TTNCC.Location = new System.Drawing.Point(278, 74);
            this.lbl_TTNCC.Name = "lbl_TTNCC";
            this.lbl_TTNCC.Size = new System.Drawing.Size(85, 13);
            this.lbl_TTNCC.TabIndex = 4;
            this.lbl_TTNCC.Text = "Người Đại Diện :";
            // 
            // lbl_DCNCC
            // 
            this.lbl_DCNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DCNCC.AutoSize = true;
            this.lbl_DCNCC.Location = new System.Drawing.Point(278, 38);
            this.lbl_DCNCC.Name = "lbl_DCNCC";
            this.lbl_DCNCC.Size = new System.Drawing.Size(47, 13);
            this.lbl_DCNCC.TabIndex = 3;
            this.lbl_DCNCC.Text = "Địa Chỉ :";
            // 
            // lbl_TenNcc
            // 
            this.lbl_TenNcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenNcc.AutoSize = true;
            this.lbl_TenNcc.Location = new System.Drawing.Point(70, 74);
            this.lbl_TenNcc.Name = "lbl_TenNcc";
            this.lbl_TenNcc.Size = new System.Drawing.Size(57, 13);
            this.lbl_TenNcc.TabIndex = 2;
            this.lbl_TenNcc.Text = "Tên NCC :";
            // 
            // lbl_MaNCC
            // 
            this.lbl_MaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaNCC.AutoSize = true;
            this.lbl_MaNCC.Location = new System.Drawing.Point(70, 38);
            this.lbl_MaNCC.Name = "lbl_MaNCC";
            this.lbl_MaNCC.Size = new System.Drawing.Size(53, 13);
            this.lbl_MaNCC.TabIndex = 1;
            this.lbl_MaNCC.Text = "Mã NCC :";
            // 
            // panel_dgvNCC
            // 
            this.panel_dgvNCC.Controls.Add(this.grp_dgvNCC);
            this.panel_dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dgvNCC.Location = new System.Drawing.Point(190, 100);
            this.panel_dgvNCC.Name = "panel_dgvNCC";
            this.panel_dgvNCC.Size = new System.Drawing.Size(519, 347);
            this.panel_dgvNCC.TabIndex = 2;
            // 
            // grp_dgvNCC
            // 
            this.grp_dgvNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_dgvNCC.Controls.Add(this.dgv_NhaCC);
            this.grp_dgvNCC.Location = new System.Drawing.Point(0, 0);
            this.grp_dgvNCC.Name = "grp_dgvNCC";
            this.grp_dgvNCC.Size = new System.Drawing.Size(519, 347);
            this.grp_dgvNCC.TabIndex = 1;
            this.grp_dgvNCC.TabStop = false;
            this.grp_dgvNCC.Text = "Danh Sách";
            // 
            // dgv_NhaCC
            // 
            this.dgv_NhaCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_NhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaCC.Location = new System.Drawing.Point(0, 19);
            this.dgv_NhaCC.Name = "dgv_NhaCC";
            this.dgv_NhaCC.Size = new System.Drawing.Size(519, 328);
            this.dgv_NhaCC.TabIndex = 0;
            this.dgv_NhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhaCC_CellClick);
            // 
            // FormNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 447);
            this.Controls.Add(this.panel_dgvNCC);
            this.Controls.Add(this.panel_btnNCC);
            this.Controls.Add(this.panel_TTNCC);
            this.Name = "FormNhaCC";
            this.Text = "FormNhaCC";
            this.panel_TTNCC.ResumeLayout(false);
            this.panel_TTNCC.PerformLayout();
            this.panel_btnNCC.ResumeLayout(false);
            this.grp_TTNCC.ResumeLayout(false);
            this.grp_TTNCC.PerformLayout();
            this.panel_dgvNCC.ResumeLayout(false);
            this.grp_dgvNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TTNCC;
        private System.Windows.Forms.Panel panel_btnNCC;
        private System.Windows.Forms.GroupBox grp_TTNCC;
        private System.Windows.Forms.Panel panel_dgvNCC;
        private System.Windows.Forms.GroupBox grp_dgvNCC;
        private System.Windows.Forms.DataGridView dgv_NhaCC;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label lbl_TTNCC;
        private System.Windows.Forms.Label lbl_DCNCC;
        private System.Windows.Forms.Label lbl_TenNcc;
        private System.Windows.Forms.Label lbl_MaNCC;
        private System.Windows.Forms.RichTextBox richTextBox_dIaChi;
        private System.Windows.Forms.TextBox txt_NgDD;
        private System.Windows.Forms.TextBox txt_TenNcc;
        private System.Windows.Forms.Button btn_BCNCC;
        private System.Windows.Forms.Button btn_SuaNCC;
        private System.Windows.Forms.Button btn_XoaNCC;
        private System.Windows.Forms.Button btn_TKNCC;
        private System.Windows.Forms.Button btn_ThemNcc;
    }
}