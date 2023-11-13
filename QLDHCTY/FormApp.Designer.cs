namespace QLDHCTY
{
    partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.panel_body = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.slidelbl_Home = new QLDHCTY.SlidingLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_body.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Controls.Add(this.pictureBox1);
            this.panel_body.Controls.Add(this.menuStrip1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 75);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(714, 476);
            this.panel_body.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.loạiSảnPhẩmToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.đạiLýToolStripMenuItem,
            this.NhânViênToolStripMenuItem,
            this.đơnHàngToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.loạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm";
            this.loạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click_1);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // đạiLýToolStripMenuItem
            // 
            this.đạiLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.đạiLýToolStripMenuItem.Name = "đạiLýToolStripMenuItem";
            this.đạiLýToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.đạiLýToolStripMenuItem.Text = "Đại Lý";
            this.đạiLýToolStripMenuItem.Click += new System.EventHandler(this.đạiLýToolStripMenuItem_Click);
            // 
            // NhânViênToolStripMenuItem
            // 
            this.NhânViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem";
            this.NhânViênToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.NhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.NhânViênToolStripMenuItem.Click += new System.EventHandler(this.NhânViênToolStripMenuItem_Click);
            // 
            // đơnHàngToolStripMenuItem1
            // 
            this.đơnHàngToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtHóaĐơnToolStripMenuItem,
            this.chiTiếtHóaĐơnToolStripMenuItem1});
            this.đơnHàngToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.đơnHàngToolStripMenuItem1.Name = "đơnHàngToolStripMenuItem1";
            this.đơnHàngToolStripMenuItem1.Size = new System.Drawing.Size(84, 23);
            this.đơnHàngToolStripMenuItem1.Text = "Đơn Hàng";
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.chiTiếtHóaĐơnToolStripMenuItem.Text = "Danh Sách Đơn Hàng";
            this.chiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem1
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem1.Name = "chiTiếtHóaĐơnToolStripMenuItem1";
            this.chiTiếtHóaĐơnToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.chiTiếtHóaĐơnToolStripMenuItem1.Text = "Chi Tiết Hóa Đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem1.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_top.BackgroundImage")));
            this.panel_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_top.Controls.Add(this.btn_thoat);
            this.panel_top.Controls.Add(this.slidelbl_Home);
            this.panel_top.Controls.Add(this.pictureBox2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(714, 75);
            this.panel_top.TabIndex = 1;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_thoat.Location = new System.Drawing.Point(607, 25);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 38);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseMnemonic = false;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // slidelbl_Home
            // 
            this.slidelbl_Home.BackColor = System.Drawing.Color.Transparent;
            this.slidelbl_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.slidelbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slidelbl_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.slidelbl_Home.Location = new System.Drawing.Point(170, 25);
            this.slidelbl_Home.Margin = new System.Windows.Forms.Padding(0);
            this.slidelbl_Home.Name = "slidelbl_Home";
            this.slidelbl_Home.Size = new System.Drawing.Size(259, 44);
            this.slidelbl_Home.Slide = true;
            this.slidelbl_Home.SlideTime = 100;
            this.slidelbl_Home.TabIndex = 0;
            this.slidelbl_Home.Text = "Home";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(714, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 551);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Name = "FormApp";
            this.Text = "Form1";
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_body;
        private SlidingLabel slidelbl_Home;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}