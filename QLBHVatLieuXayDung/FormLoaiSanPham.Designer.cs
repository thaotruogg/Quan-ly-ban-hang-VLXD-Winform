namespace QLBHVatLieuXayDung
{
    partial class FormLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearLoaiSP = new System.Windows.Forms.Button();
            this.btnSaveLoaiSP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteLoaiSP = new System.Windows.Forms.Button();
            this.btnEditLoaiSP = new System.Windows.Forms.Button();
            this.btnAddLoaiSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThemTB = new System.Windows.Forms.Label();
            this.lbThemTC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBackLoaiSP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRefreshLoaiSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOẠI SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã loại";
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(88, 46);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(178, 24);
            this.txtMaLoaiSP.TabIndex = 3;
            this.txtMaLoaiSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Location = new System.Drawing.Point(88, 88);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(178, 24);
            this.txtTenLoaiSP.TabIndex = 5;
            this.txtTenLoaiSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại";
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Location = new System.Drawing.Point(6, 23);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.Size = new System.Drawing.Size(359, 279);
            this.dgvLoaiSP.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnClearLoaiSP);
            this.groupBox1.Controls.Add(this.btnSaveLoaiSP);
            this.groupBox1.Controls.Add(this.txtMaLoaiSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenLoaiSP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(189, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hủy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(237, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Lưu";
            // 
            // btnClearLoaiSP
            // 
            this.btnClearLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLoaiSP.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnClearLoaiSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Delete_32px;
            this.btnClearLoaiSP.Location = new System.Drawing.Point(186, 129);
            this.btnClearLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLoaiSP.Name = "btnClearLoaiSP";
            this.btnClearLoaiSP.Size = new System.Drawing.Size(40, 40);
            this.btnClearLoaiSP.TabIndex = 24;
            this.btnClearLoaiSP.UseVisualStyleBackColor = true;
            this.btnClearLoaiSP.Click += new System.EventHandler(this.btnClearLoaiSP_Click);
            // 
            // btnSaveLoaiSP
            // 
            this.btnSaveLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLoaiSP.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnSaveLoaiSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Save_32px;
            this.btnSaveLoaiSP.Location = new System.Drawing.Point(231, 129);
            this.btnSaveLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveLoaiSP.Name = "btnSaveLoaiSP";
            this.btnSaveLoaiSP.Size = new System.Drawing.Size(40, 40);
            this.btnSaveLoaiSP.TabIndex = 23;
            this.btnSaveLoaiSP.UseVisualStyleBackColor = true;
            this.btnSaveLoaiSP.Click += new System.EventHandler(this.btnSaveLoaiSP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnDeleteLoaiSP);
            this.panel1.Controls.Add(this.btnEditLoaiSP);
            this.panel1.Controls.Add(this.btnAddLoaiSP);
            this.panel1.Location = new System.Drawing.Point(157, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 167);
            this.panel1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(47, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "Xóa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(47, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Sửa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(34, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Thêm";
            // 
            // btnDeleteLoaiSP
            // 
            this.btnDeleteLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLoaiSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Trash_Can_32px;
            this.btnDeleteLoaiSP.Location = new System.Drawing.Point(86, 111);
            this.btnDeleteLoaiSP.Name = "btnDeleteLoaiSP";
            this.btnDeleteLoaiSP.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteLoaiSP.TabIndex = 20;
            this.btnDeleteLoaiSP.UseVisualStyleBackColor = true;
            this.btnDeleteLoaiSP.Click += new System.EventHandler(this.btnDeleteLoaiSP_Click);
            // 
            // btnEditLoaiSP
            // 
            this.btnEditLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnEditLoaiSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Edit_32px;
            this.btnEditLoaiSP.Location = new System.Drawing.Point(86, 57);
            this.btnEditLoaiSP.Name = "btnEditLoaiSP";
            this.btnEditLoaiSP.Size = new System.Drawing.Size(48, 48);
            this.btnEditLoaiSP.TabIndex = 19;
            this.btnEditLoaiSP.UseVisualStyleBackColor = true;
            this.btnEditLoaiSP.Click += new System.EventHandler(this.btnEditLoaiSP_Click);
            // 
            // btnAddLoaiSP
            // 
            this.btnAddLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnAddLoaiSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Add_32px;
            this.btnAddLoaiSP.Location = new System.Drawing.Point(86, 3);
            this.btnAddLoaiSP.Name = "btnAddLoaiSP";
            this.btnAddLoaiSP.Size = new System.Drawing.Size(48, 48);
            this.btnAddLoaiSP.TabIndex = 18;
            this.btnAddLoaiSP.UseVisualStyleBackColor = true;
            this.btnAddLoaiSP.Click += new System.EventHandler(this.btnAddLoaiSP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnBackLoaiSP);
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 40);
            this.panel2.TabIndex = 21;
            // 
            // lbThemTB
            // 
            this.lbThemTB.AutoSize = true;
            this.lbThemTB.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTB.ForeColor = System.Drawing.Color.Red;
            this.lbThemTB.Location = new System.Drawing.Point(134, 318);
            this.lbThemTB.Name = "lbThemTB";
            this.lbThemTB.Size = new System.Drawing.Size(226, 18);
            this.lbThemTB.TabIndex = 39;
            this.lbThemTB.Text = "<\\\\ Vui lòng nhập đầy đủ thông tin >";
            this.lbThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThemTC
            // 
            this.lbThemTC.AutoSize = true;
            this.lbThemTC.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTC.ForeColor = System.Drawing.Color.Green;
            this.lbThemTC.Location = new System.Drawing.Point(159, 318);
            this.lbThemTC.Name = "lbThemTC";
            this.lbThemTC.Size = new System.Drawing.Size(176, 18);
            this.lbThemTC.TabIndex = 38;
            this.lbThemTC.Text = "Thêm sản phẩm thành công";
            this.lbThemTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(49, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Back";
            // 
            // btnBackLoaiSP
            // 
            this.btnBackLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.btnBackLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackLoaiSP.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLoaiSP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackLoaiSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Back_32px;
            this.btnBackLoaiSP.Location = new System.Drawing.Point(4, 4);
            this.btnBackLoaiSP.Name = "btnBackLoaiSP";
            this.btnBackLoaiSP.Size = new System.Drawing.Size(42, 32);
            this.btnBackLoaiSP.TabIndex = 6;
            this.btnBackLoaiSP.UseVisualStyleBackColor = false;
            this.btnBackLoaiSP.Click += new System.EventHandler(this.btnBackLoaiSP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbThemTB);
            this.groupBox2.Controls.Add(this.lbThemTC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnRefreshLoaiSP);
            this.groupBox2.Controls.Add(this.dgvLoaiSP);
            this.groupBox2.Location = new System.Drawing.Point(301, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 351);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(62, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Làm mới";
            // 
            // btnRefreshLoaiSP
            // 
            this.btnRefreshLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshLoaiSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefreshLoaiSP.Image = global::QLBHVatLieuXayDung.Properties.Resources.Refresh_32px;
            this.btnRefreshLoaiSP.Location = new System.Drawing.Point(6, 306);
            this.btnRefreshLoaiSP.Name = "btnRefreshLoaiSP";
            this.btnRefreshLoaiSP.Size = new System.Drawing.Size(50, 40);
            this.btnRefreshLoaiSP.TabIndex = 30;
            this.btnRefreshLoaiSP.UseVisualStyleBackColor = true;
            this.btnRefreshLoaiSP.Click += new System.EventHandler(this.btnRefreshLoaiSP_Click);
            // 
            // FormLoaiSanPham
            // 
            this.AcceptButton = this.btnSaveLoaiSP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.FormLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackLoaiSP;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteLoaiSP;
        private System.Windows.Forms.Button btnEditLoaiSP;
        private System.Windows.Forms.Button btnAddLoaiSP;
        private System.Windows.Forms.Button btnClearLoaiSP;
        private System.Windows.Forms.Button btnSaveLoaiSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRefreshLoaiSP;
        private System.Windows.Forms.Label lbThemTB;
        private System.Windows.Forms.Label lbThemTC;
    }
}