﻿namespace QLBHVatLieuXayDung
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbThemTC = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSanPham_refresh = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.lbThemTB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBackHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSanPham_maSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSanPham_tenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSanPham_nSX = new System.Windows.Forms.TextBox();
            this.btnSanPham_edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSanPham_add = new System.Windows.Forms.Button();
            this.btnSanPham_save = new System.Windows.Forms.Button();
            this.btnSanPham_clear = new System.Windows.Forms.Button();
            this.cbxSanPham_loaiSP = new System.Windows.Forms.ComboBox();
            this.btnSanPham_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSanPham_addLoaiSP = new System.Windows.Forms.Button();
            this.btnSanPham_reload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbThemTC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnSanPham_refresh);
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Controls.Add(this.lbThemTB);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục sản phẩm";
            // 
            // lbThemTC
            // 
            this.lbThemTC.AutoSize = true;
            this.lbThemTC.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTC.ForeColor = System.Drawing.Color.Green;
            this.lbThemTC.Location = new System.Drawing.Point(248, 294);
            this.lbThemTC.Name = "lbThemTC";
            this.lbThemTC.Size = new System.Drawing.Size(176, 18);
            this.lbThemTC.TabIndex = 40;
            this.lbThemTC.Text = "Thêm sản phẩm thành công";
            this.lbThemTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnSanPham_refresh
            // 
            this.btnSanPham_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_refresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSanPham_refresh.Image = global::QLBHVatLieuXayDung.Properties.Resources.Refresh_32px;
            this.btnSanPham_refresh.Location = new System.Drawing.Point(6, 283);
            this.btnSanPham_refresh.Name = "btnSanPham_refresh";
            this.btnSanPham_refresh.Size = new System.Drawing.Size(50, 40);
            this.btnSanPham_refresh.TabIndex = 32;
            this.btnSanPham_refresh.UseVisualStyleBackColor = true;
            this.btnSanPham_refresh.Click += new System.EventHandler(this.btnRefreshSP_Click);
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
            // lbThemTB
            // 
            this.lbThemTB.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTB.ForeColor = System.Drawing.Color.Red;
            this.lbThemTB.Location = new System.Drawing.Point(133, 294);
            this.lbThemTB.Name = "lbThemTB";
            this.lbThemTB.Size = new System.Drawing.Size(417, 18);
            this.lbThemTB.TabIndex = 41;
            this.lbThemTB.Text = "<\\\\ Vui lòng nhập đầy đủ thông tin >";
            this.lbThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnBackHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 40);
            this.panel2.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txbSanPham_maSP
            // 
            this.txbSanPham_maSP.Location = new System.Drawing.Point(179, 24);
            this.txbSanPham_maSP.Name = "txbSanPham_maSP";
            this.txbSanPham_maSP.Size = new System.Drawing.Size(190, 24);
            this.txbSanPham_maSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtSanPham_tenSP
            // 
            this.txtSanPham_tenSP.Location = new System.Drawing.Point(179, 54);
            this.txtSanPham_tenSP.Name = "txtSanPham_tenSP";
            this.txtSanPham_tenSP.Size = new System.Drawing.Size(190, 24);
            this.txtSanPham_tenSP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà sản xuất";
            // 
            // txbSanPham_nSX
            // 
            this.txbSanPham_nSX.Location = new System.Drawing.Point(179, 83);
            this.txbSanPham_nSX.Name = "txbSanPham_nSX";
            this.txbSanPham_nSX.Size = new System.Drawing.Size(190, 24);
            this.txbSanPham_nSX.TabIndex = 4;
            // 
            // btnSanPham_edit
            // 
            this.btnSanPham_edit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_edit.FlatAppearance.BorderSize = 0;
            this.btnSanPham_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSanPham_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_edit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_edit.Image = global::QLBHVatLieuXayDung.Properties.Resources.Edit_32px1;
            this.btnSanPham_edit.Location = new System.Drawing.Point(433, 81);
            this.btnSanPham_edit.Name = "btnSanPham_edit";
            this.btnSanPham_edit.Size = new System.Drawing.Size(142, 58);
            this.btnSanPham_edit.TabIndex = 10;
            this.btnSanPham_edit.UseVisualStyleBackColor = false;
            this.btnSanPham_edit.Click += new System.EventHandler(this.btnEditSP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại sản phẩm";
            // 
            // btnSanPham_add
            // 
            this.btnSanPham_add.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_add.FlatAppearance.BorderSize = 0;
            this.btnSanPham_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnSanPham_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_add.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_add.Image = global::QLBHVatLieuXayDung.Properties.Resources.Add_32px1;
            this.btnSanPham_add.Location = new System.Drawing.Point(433, 15);
            this.btnSanPham_add.Name = "btnSanPham_add";
            this.btnSanPham_add.Size = new System.Drawing.Size(142, 58);
            this.btnSanPham_add.TabIndex = 9;
            this.btnSanPham_add.UseVisualStyleBackColor = false;
            this.btnSanPham_add.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // btnSanPham_save
            // 
            this.btnSanPham_save.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_save.FlatAppearance.BorderSize = 0;
            this.btnSanPham_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSanPham_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_save.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham_save.ForeColor = System.Drawing.Color.Black;
            this.btnSanPham_save.Location = new System.Drawing.Point(288, 152);
            this.btnSanPham_save.Margin = new System.Windows.Forms.Padding(4);
            this.btnSanPham_save.Name = "btnSanPham_save";
            this.btnSanPham_save.Size = new System.Drawing.Size(80, 42);
            this.btnSanPham_save.TabIndex = 23;
            this.btnSanPham_save.Text = "";
            this.btnSanPham_save.UseVisualStyleBackColor = false;
            this.btnSanPham_save.Click += new System.EventHandler(this.btnSaveSP_Click);
            // 
            // btnSanPham_clear
            // 
            this.btnSanPham_clear.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_clear.FlatAppearance.BorderSize = 0;
            this.btnSanPham_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSanPham_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_clear.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham_clear.ForeColor = System.Drawing.Color.Black;
            this.btnSanPham_clear.Location = new System.Drawing.Point(179, 152);
            this.btnSanPham_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btnSanPham_clear.Name = "btnSanPham_clear";
            this.btnSanPham_clear.Size = new System.Drawing.Size(80, 42);
            this.btnSanPham_clear.TabIndex = 24;
            this.btnSanPham_clear.Text = "";
            this.btnSanPham_clear.UseVisualStyleBackColor = false;
            this.btnSanPham_clear.Click += new System.EventHandler(this.btnClearSP_Click);
            // 
            // cbxSanPham_loaiSP
            // 
            this.cbxSanPham_loaiSP.BackColor = System.Drawing.Color.Silver;
            this.cbxSanPham_loaiSP.DisplayMember = "maSanPham";
            this.cbxSanPham_loaiSP.DropDownHeight = 100;
            this.cbxSanPham_loaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSanPham_loaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSanPham_loaiSP.FormattingEnabled = true;
            this.cbxSanPham_loaiSP.IntegralHeight = false;
            this.cbxSanPham_loaiSP.ItemHeight = 17;
            this.cbxSanPham_loaiSP.Location = new System.Drawing.Point(179, 112);
            this.cbxSanPham_loaiSP.Name = "cbxSanPham_loaiSP";
            this.cbxSanPham_loaiSP.Size = new System.Drawing.Size(159, 25);
            this.cbxSanPham_loaiSP.TabIndex = 27;
            this.cbxSanPham_loaiSP.ValueMember = "maSanPham";
            // 
            // btnSanPham_delete
            // 
            this.btnSanPham_delete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_delete.FlatAppearance.BorderSize = 0;
            this.btnSanPham_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSanPham_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_delete.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSanPham_delete.Image = global::QLBHVatLieuXayDung.Properties.Resources.Trash_Can_48px;
            this.btnSanPham_delete.Location = new System.Drawing.Point(433, 147);
            this.btnSanPham_delete.Name = "btnSanPham_delete";
            this.btnSanPham_delete.Size = new System.Drawing.Size(142, 58);
            this.btnSanPham_delete.TabIndex = 11;
            this.btnSanPham_delete.UseVisualStyleBackColor = false;
            this.btnSanPham_delete.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(423, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 202);
            this.panel1.TabIndex = 12;
            // 
            // btnSanPham_addLoaiSP
            // 
            this.btnSanPham_addLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_addLoaiSP.FlatAppearance.BorderSize = 0;
            this.btnSanPham_addLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_addLoaiSP.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham_addLoaiSP.Location = new System.Drawing.Point(344, 113);
            this.btnSanPham_addLoaiSP.Name = "btnSanPham_addLoaiSP";
            this.btnSanPham_addLoaiSP.Size = new System.Drawing.Size(25, 25);
            this.btnSanPham_addLoaiSP.TabIndex = 28;
            this.btnSanPham_addLoaiSP.Text = "";
            this.btnSanPham_addLoaiSP.UseVisualStyleBackColor = true;
            this.btnSanPham_addLoaiSP.Click += new System.EventHandler(this.btnSanPham_addLoaiSP_Click);
            // 
            // btnSanPham_reload
            // 
            this.btnSanPham_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_reload.FlatAppearance.BorderSize = 0;
            this.btnSanPham_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham_reload.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham_reload.Location = new System.Drawing.Point(151, 112);
            this.btnSanPham_reload.Name = "btnSanPham_reload";
            this.btnSanPham_reload.Size = new System.Drawing.Size(25, 25);
            this.btnSanPham_reload.TabIndex = 29;
            this.btnSanPham_reload.Text = "";
            this.btnSanPham_reload.UseVisualStyleBackColor = true;
            this.btnSanPham_reload.Click += new System.EventHandler(this.btnSanPham_reload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSanPham_reload);
            this.groupBox1.Controls.Add(this.btnSanPham_addLoaiSP);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnSanPham_delete);
            this.groupBox1.Controls.Add(this.cbxSanPham_loaiSP);
            this.groupBox1.Controls.Add(this.btnSanPham_clear);
            this.groupBox1.Controls.Add(this.btnSanPham_save);
            this.groupBox1.Controls.Add(this.btnSanPham_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSanPham_edit);
            this.groupBox1.Controls.Add(this.txbSanPham_nSX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSanPham_tenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbSanPham_maSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(578, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 608);
            this.Controls.Add(this.panel2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBackHoaDon;
        private System.Windows.Forms.Label lbThemTB;
        private System.Windows.Forms.Label lbThemTC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSanPham_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSanPham_maSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSanPham_tenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSanPham_nSX;
        private System.Windows.Forms.Button btnSanPham_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSanPham_add;
        private System.Windows.Forms.Button btnSanPham_save;
        private System.Windows.Forms.Button btnSanPham_clear;
        private System.Windows.Forms.ComboBox cbxSanPham_loaiSP;
        private System.Windows.Forms.Button btnSanPham_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSanPham_addLoaiSP;
        private System.Windows.Forms.Button btnSanPham_reload;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}