namespace QLBHVatLieuXayDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMaLoaiSP = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearSP = new System.Windows.Forms.Button();
            this.btnSaveSP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhaSXofSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSPofSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSPofSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRefreshSP = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnEditSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThemTB = new System.Windows.Forms.Label();
            this.lbThemTC = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBackHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMaLoaiSP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnClearSP);
            this.groupBox1.Controls.Add(this.btnSaveSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNhaSXofSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenSPofSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSPofSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(322, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // cbxMaLoaiSP
            // 
            this.cbxMaLoaiSP.DisplayMember = "maSanPham";
            this.cbxMaLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaLoaiSP.FormattingEnabled = true;
            this.cbxMaLoaiSP.Location = new System.Drawing.Point(125, 112);
            this.cbxMaLoaiSP.Name = "cbxMaLoaiSP";
            this.cbxMaLoaiSP.Size = new System.Drawing.Size(189, 25);
            this.cbxMaLoaiSP.TabIndex = 27;
            this.cbxMaLoaiSP.ValueMember = "maSanPham";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(232, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Hủy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(278, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Lưu";
            // 
            // btnClearSP
            // 
            this.btnClearSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSP.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSP.ForeColor = System.Drawing.Color.White;
            this.btnClearSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Delete_32px;
            this.btnClearSP.Location = new System.Drawing.Point(229, 145);
            this.btnClearSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSP.Name = "btnClearSP";
            this.btnClearSP.Size = new System.Drawing.Size(40, 40);
            this.btnClearSP.TabIndex = 24;
            this.btnClearSP.UseVisualStyleBackColor = true;
            this.btnClearSP.Click += new System.EventHandler(this.btnClearSP_Click);
            // 
            // btnSaveSP
            // 
            this.btnSaveSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSP.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSP.ForeColor = System.Drawing.Color.White;
            this.btnSaveSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Save_32px;
            this.btnSaveSP.Location = new System.Drawing.Point(274, 145);
            this.btnSaveSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSP.Name = "btnSaveSP";
            this.btnSaveSP.Size = new System.Drawing.Size(40, 40);
            this.btnSaveSP.TabIndex = 23;
            this.btnSaveSP.UseVisualStyleBackColor = true;
            this.btnSaveSP.Click += new System.EventHandler(this.btnSaveSP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại sản phẩm";
            // 
            // txtNhaSXofSP
            // 
            this.txtNhaSXofSP.Location = new System.Drawing.Point(125, 83);
            this.txtNhaSXofSP.Name = "txtNhaSXofSP";
            this.txtNhaSXofSP.Size = new System.Drawing.Size(190, 24);
            this.txtNhaSXofSP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà sản xuất";
            // 
            // txtTenSPofSP
            // 
            this.txtTenSPofSP.Location = new System.Drawing.Point(125, 54);
            this.txtTenSPofSP.Name = "txtTenSPofSP";
            this.txtTenSPofSP.Size = new System.Drawing.Size(190, 24);
            this.txtTenSPofSP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtMaSPofSP
            // 
            this.txtMaSPofSP.Location = new System.Drawing.Point(125, 24);
            this.txtMaSPofSP.Name = "txtMaSPofSP";
            this.txtMaSPofSP.Size = new System.Drawing.Size(190, 24);
            this.txtMaSPofSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbThemTB);
            this.groupBox2.Controls.Add(this.lbThemTC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnRefreshSP);
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục sản phẩm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(62, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Làm mới";
            // 
            // btnRefreshSP
            // 
            this.btnRefreshSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefreshSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Refresh_32px;
            this.btnRefreshSP.Location = new System.Drawing.Point(6, 283);
            this.btnRefreshSP.Name = "btnRefreshSP";
            this.btnRefreshSP.Size = new System.Drawing.Size(50, 40);
            this.btnRefreshSP.TabIndex = 32;
            this.btnRefreshSP.UseVisualStyleBackColor = true;
            this.btnRefreshSP.Click += new System.EventHandler(this.btnRefreshSP_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(6, 23);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(544, 254);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDeleteSP);
            this.panel1.Controls.Add(this.btnEditSP);
            this.panel1.Controls.Add(this.btnAddSP);
            this.panel1.Location = new System.Drawing.Point(407, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 189);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(68, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Xóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(68, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sửa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(55, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thêm";
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSP.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Trash_Can_32px;
            this.btnDeleteSP.Location = new System.Drawing.Point(107, 124);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteSP.TabIndex = 11;
            this.btnDeleteSP.UseVisualStyleBackColor = false;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // btnEditSP
            // 
            this.btnEditSP.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSP.ForeColor = System.Drawing.Color.White;
            this.btnEditSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Edit_32px;
            this.btnEditSP.Location = new System.Drawing.Point(107, 70);
            this.btnEditSP.Name = "btnEditSP";
            this.btnEditSP.Size = new System.Drawing.Size(48, 48);
            this.btnEditSP.TabIndex = 10;
            this.btnEditSP.UseVisualStyleBackColor = false;
            this.btnEditSP.Click += new System.EventHandler(this.btnEditSP_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSP.ForeColor = System.Drawing.Color.White;
            this.btnAddSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Add_32px;
            this.btnAddSP.Location = new System.Drawing.Point(107, 16);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(48, 48);
            this.btnAddSP.TabIndex = 9;
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnBackHoaDon);
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 40);
            this.panel2.TabIndex = 4;
            // 
            // lbThemTB
            // 
            this.lbThemTB.AutoSize = true;
            this.lbThemTB.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTB.ForeColor = System.Drawing.Color.Red;
            this.lbThemTB.Location = new System.Drawing.Point(218, 294);
            this.lbThemTB.Name = "lbThemTB";
            this.lbThemTB.Size = new System.Drawing.Size(226, 18);
            this.lbThemTB.TabIndex = 41;
            this.lbThemTB.Text = "<\\\\ Vui lòng nhập đầy đủ thông tin >";
            this.lbThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThemTC
            // 
            this.lbThemTC.AutoSize = true;
            this.lbThemTC.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTC.ForeColor = System.Drawing.Color.Green;
            this.lbThemTC.Location = new System.Drawing.Point(243, 294);
            this.lbThemTC.Name = "lbThemTC";
            this.lbThemTC.Size = new System.Drawing.Size(176, 18);
            this.lbThemTC.TabIndex = 40;
            this.lbThemTC.Text = "Thêm sản phẩm thành công";
            this.lbThemTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(50, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Back";
            // 
            // btnBackHoaDon
            // 
            this.btnBackHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnBackHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHoaDon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHoaDon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackHoaDon.Image = global::QLBHVatLieuXayDung.Properties.Resources.Back_32px;
            this.btnBackHoaDon.Location = new System.Drawing.Point(4, 4);
            this.btnBackHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackHoaDon.Name = "btnBackHoaDon";
            this.btnBackHoaDon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBackHoaDon.Size = new System.Drawing.Size(42, 32);
            this.btnBackHoaDon.TabIndex = 28;
            this.btnBackHoaDon.UseVisualStyleBackColor = false;
            this.btnBackHoaDon.Click += new System.EventHandler(this.btnBackHoaDon_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhaSXofSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSPofSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSPofSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.Button btnEditSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Button btnClearSP;
        private System.Windows.Forms.Button btnSaveSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBackHoaDon;
        private System.Windows.Forms.ComboBox cbxMaLoaiSP;
        private System.Windows.Forms.Label lbThemTB;
        private System.Windows.Forms.Label lbThemTC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRefreshSP;
    }
}