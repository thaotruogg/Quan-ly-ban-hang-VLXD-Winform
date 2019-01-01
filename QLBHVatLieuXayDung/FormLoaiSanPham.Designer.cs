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
            this.txbLoaiSP_maLoai = new System.Windows.Forms.TextBox();
            this.txbLoaiSP_tenLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoaiSP_clear = new System.Windows.Forms.Button();
            this.btnLoaiSP_save = new System.Windows.Forms.Button();
            this.btnLoaiSP_delete = new System.Windows.Forms.Button();
            this.btnLoaiSP_edit = new System.Windows.Forms.Button();
            this.btnLoaiSP_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoaiSP_back = new System.Windows.Forms.Button();
            this.lbThemTB = new System.Windows.Forms.Label();
            this.lbThemTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLoaiSP_refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // txbLoaiSP_maLoai
            // 
            this.txbLoaiSP_maLoai.Location = new System.Drawing.Point(88, 46);
            this.txbLoaiSP_maLoai.Name = "txbLoaiSP_maLoai";
            this.txbLoaiSP_maLoai.Size = new System.Drawing.Size(178, 24);
            this.txbLoaiSP_maLoai.TabIndex = 3;
            this.txbLoaiSP_maLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbLoaiSP_tenLoai
            // 
            this.txbLoaiSP_tenLoai.Location = new System.Drawing.Point(88, 88);
            this.txbLoaiSP_tenLoai.Name = "txbLoaiSP_tenLoai";
            this.txbLoaiSP_tenLoai.Size = new System.Drawing.Size(178, 24);
            this.txbLoaiSP_tenLoai.TabIndex = 5;
            this.txbLoaiSP_tenLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.groupBox1.Controls.Add(this.btnLoaiSP_clear);
            this.groupBox1.Controls.Add(this.btnLoaiSP_save);
            this.groupBox1.Controls.Add(this.txbLoaiSP_maLoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbLoaiSP_tenLoai);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // btnLoaiSP_clear
            // 
            this.btnLoaiSP_clear.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSP_clear.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLoaiSP_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP_clear.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSP_clear.ForeColor = System.Drawing.Color.Black;
            this.btnLoaiSP_clear.Location = new System.Drawing.Point(88, 129);
            this.btnLoaiSP_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoaiSP_clear.Name = "btnLoaiSP_clear";
            this.btnLoaiSP_clear.Size = new System.Drawing.Size(80, 42);
            this.btnLoaiSP_clear.TabIndex = 24;
            this.btnLoaiSP_clear.Text = "";
            this.btnLoaiSP_clear.UseVisualStyleBackColor = false;
            this.btnLoaiSP_clear.Click += new System.EventHandler(this.btnClearLoaiSP_Click);
            // 
            // btnLoaiSP_save
            // 
            this.btnLoaiSP_save.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSP_save.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoaiSP_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP_save.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSP_save.ForeColor = System.Drawing.Color.Black;
            this.btnLoaiSP_save.Location = new System.Drawing.Point(186, 129);
            this.btnLoaiSP_save.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoaiSP_save.Name = "btnLoaiSP_save";
            this.btnLoaiSP_save.Size = new System.Drawing.Size(80, 42);
            this.btnLoaiSP_save.TabIndex = 23;
            this.btnLoaiSP_save.Text = "";
            this.btnLoaiSP_save.UseVisualStyleBackColor = false;
            this.btnLoaiSP_save.Click += new System.EventHandler(this.btnSaveLoaiSP_Click);
            // 
            // btnLoaiSP_delete
            // 
            this.btnLoaiSP_delete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSP_delete.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLoaiSP_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP_delete.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_delete.Image = global::QLBHVatLieuXayDung.Properties.Resources.Trash_Can_32px1;
            this.btnLoaiSP_delete.Location = new System.Drawing.Point(195, 250);
            this.btnLoaiSP_delete.Name = "btnLoaiSP_delete";
            this.btnLoaiSP_delete.Size = new System.Drawing.Size(90, 90);
            this.btnLoaiSP_delete.TabIndex = 20;
            this.btnLoaiSP_delete.UseVisualStyleBackColor = false;
            this.btnLoaiSP_delete.Click += new System.EventHandler(this.btnDeleteLoaiSP_Click);
            // 
            // btnLoaiSP_edit
            // 
            this.btnLoaiSP_edit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSP_edit.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLoaiSP_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP_edit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_edit.Image = global::QLBHVatLieuXayDung.Properties.Resources.Edit_32px1;
            this.btnLoaiSP_edit.Location = new System.Drawing.Point(99, 250);
            this.btnLoaiSP_edit.Name = "btnLoaiSP_edit";
            this.btnLoaiSP_edit.Size = new System.Drawing.Size(90, 90);
            this.btnLoaiSP_edit.TabIndex = 19;
            this.btnLoaiSP_edit.UseVisualStyleBackColor = false;
            this.btnLoaiSP_edit.Click += new System.EventHandler(this.btnEditLoaiSP_Click);
            // 
            // btnLoaiSP_add
            // 
            this.btnLoaiSP_add.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSP_add.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnLoaiSP_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP_add.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiSP_add.Image = global::QLBHVatLieuXayDung.Properties.Resources.Add_32px1;
            this.btnLoaiSP_add.Location = new System.Drawing.Point(3, 250);
            this.btnLoaiSP_add.Name = "btnLoaiSP_add";
            this.btnLoaiSP_add.Size = new System.Drawing.Size(90, 90);
            this.btnLoaiSP_add.TabIndex = 18;
            this.btnLoaiSP_add.UseVisualStyleBackColor = false;
            this.btnLoaiSP_add.Click += new System.EventHandler(this.btnAddLoaiSP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnLoaiSP_back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 40);
            this.panel2.TabIndex = 21;
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
            // btnLoaiSP_back
            // 
            this.btnLoaiSP_back.BackColor = System.Drawing.Color.Transparent;
            this.btnLoaiSP_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSP_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP_back.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSP_back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoaiSP_back.Image = global::QLBHVatLieuXayDung.Properties.Resources.Back_32px;
            this.btnLoaiSP_back.Location = new System.Drawing.Point(4, 4);
            this.btnLoaiSP_back.Name = "btnLoaiSP_back";
            this.btnLoaiSP_back.Size = new System.Drawing.Size(42, 32);
            this.btnLoaiSP_back.TabIndex = 6;
            this.btnLoaiSP_back.UseVisualStyleBackColor = false;
            this.btnLoaiSP_back.Click += new System.EventHandler(this.btnBackLoaiSP_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbThemTB);
            this.groupBox2.Controls.Add(this.lbThemTC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnLoaiSP_refresh);
            this.groupBox2.Controls.Add(this.dgvLoaiSP);
            this.groupBox2.Location = new System.Drawing.Point(301, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 355);
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
            // btnLoaiSP_refresh
            // 
            this.btnLoaiSP_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSP_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP_refresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoaiSP_refresh.Image = global::QLBHVatLieuXayDung.Properties.Resources.Refresh_32px;
            this.btnLoaiSP_refresh.Location = new System.Drawing.Point(6, 306);
            this.btnLoaiSP_refresh.Name = "btnLoaiSP_refresh";
            this.btnLoaiSP_refresh.Size = new System.Drawing.Size(50, 40);
            this.btnLoaiSP_refresh.TabIndex = 30;
            this.btnLoaiSP_refresh.UseVisualStyleBackColor = true;
            this.btnLoaiSP_refresh.Click += new System.EventHandler(this.btnRefreshLoaiSP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(287, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 206);
            this.panel1.TabIndex = 23;
            // 
            // FormLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoaiSP_delete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoaiSP_edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLoaiSP_add);
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
        private System.Windows.Forms.TextBox txbLoaiSP_maLoai;
        private System.Windows.Forms.TextBox txbLoaiSP_tenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoaiSP_back;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoaiSP_delete;
        private System.Windows.Forms.Button btnLoaiSP_edit;
        private System.Windows.Forms.Button btnLoaiSP_add;
        private System.Windows.Forms.Button btnLoaiSP_clear;
        private System.Windows.Forms.Button btnLoaiSP_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLoaiSP_refresh;
        private System.Windows.Forms.Label lbThemTB;
        private System.Windows.Forms.Label lbThemTC;
        private System.Windows.Forms.Panel panel1;
    }
}