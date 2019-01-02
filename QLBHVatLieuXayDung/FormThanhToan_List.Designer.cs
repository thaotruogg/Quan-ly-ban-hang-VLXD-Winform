namespace QLBHVatLieuXayDung
{
    partial class FormThanhToan_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan_List));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbThemTB = new System.Windows.Forms.Label();
            this.lbThemTC = new System.Windows.Forms.Label();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBackThanhToan_list = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan_delete = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbxThanhToan_maKH = new System.Windows.Forms.ComboBox();
            this.dtpThanhToan_ngayPhieu = new System.Windows.Forms.DateTimePicker();
            this.txbThanhToan_soTien = new System.Windows.Forms.TextBox();
            this.txbThanhToan_soPhieu = new System.Windows.Forms.TextBox();
            this.btnThanhToan_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThanhToan_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbThemTB);
            this.groupBox1.Controls.Add(this.lbThemTC);
            this.groupBox1.Controls.Add(this.dgvThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(14, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(649, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết";
            // 
            // lbThemTB
            // 
            this.lbThemTB.AutoSize = true;
            this.lbThemTB.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTB.ForeColor = System.Drawing.Color.Red;
            this.lbThemTB.Location = new System.Drawing.Point(214, 324);
            this.lbThemTB.Name = "lbThemTB";
            this.lbThemTB.Size = new System.Drawing.Size(226, 18);
            this.lbThemTB.TabIndex = 45;
            this.lbThemTB.Text = "<\\\\ Vui lòng nhập đầy đủ thông tin >";
            this.lbThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThemTC
            // 
            this.lbThemTC.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTC.ForeColor = System.Drawing.Color.Green;
            this.lbThemTC.Location = new System.Drawing.Point(129, 324);
            this.lbThemTC.Name = "lbThemTC";
            this.lbThemTC.Size = new System.Drawing.Size(393, 18);
            this.lbThemTC.TabIndex = 44;
            this.lbThemTC.Text = "Thêm sản phẩm thành công";
            this.lbThemTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.Location = new System.Drawing.Point(7, 25);
            this.dgvThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.Size = new System.Drawing.Size(634, 282);
            this.dgvThanhToan.TabIndex = 0;
            this.dgvThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnBackThanhToan_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 40);
            this.panel2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(49, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Back";
            // 
            // btnBackThanhToan_list
            // 
            this.btnBackThanhToan_list.BackColor = System.Drawing.Color.Transparent;
            this.btnBackThanhToan_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackThanhToan_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackThanhToan_list.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackThanhToan_list.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackThanhToan_list.Image = global::QLBHVatLieuXayDung.Properties.Resources.Back_32px;
            this.btnBackThanhToan_list.Location = new System.Drawing.Point(5, 4);
            this.btnBackThanhToan_list.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackThanhToan_list.Name = "btnBackThanhToan_list";
            this.btnBackThanhToan_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBackThanhToan_list.Size = new System.Drawing.Size(42, 32);
            this.btnBackThanhToan_list.TabIndex = 28;
            this.btnBackThanhToan_list.UseVisualStyleBackColor = false;
            this.btnBackThanhToan_list.Click += new System.EventHandler(this.btnBackThanhToan_list_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnThanhToan_delete);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.cbxThanhToan_maKH);
            this.groupBox2.Controls.Add(this.dtpThanhToan_ngayPhieu);
            this.groupBox2.Controls.Add(this.txbThanhToan_soTien);
            this.groupBox2.Controls.Add(this.txbThanhToan_soPhieu);
            this.groupBox2.Controls.Add(this.btnThanhToan_clear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnThanhToan_save);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(676, 163);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "VNĐ";
            // 
            // btnThanhToan_delete
            // 
            this.btnThanhToan_delete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThanhToan_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan_delete.FlatAppearance.BorderSize = 0;
            this.btnThanhToan_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnThanhToan_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan_delete.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan_delete.ForeColor = System.Drawing.Color.Transparent;
            this.btnThanhToan_delete.Image = global::QLBHVatLieuXayDung.Properties.Resources.Trash_Can_32px1;
            this.btnThanhToan_delete.Location = new System.Drawing.Point(523, 19);
            this.btnThanhToan_delete.Name = "btnThanhToan_delete";
            this.btnThanhToan_delete.Size = new System.Drawing.Size(142, 132);
            this.btnThanhToan_delete.TabIndex = 33;
            this.btnThanhToan_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan_delete.UseVisualStyleBackColor = false;
            this.btnThanhToan_delete.Click += new System.EventHandler(this.btnThanhToan_delete_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel8.Location = new System.Drawing.Point(503, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 154);
            this.panel8.TabIndex = 36;
            // 
            // cbxThanhToan_maKH
            // 
            this.cbxThanhToan_maKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThanhToan_maKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxThanhToan_maKH.FormattingEnabled = true;
            this.cbxThanhToan_maKH.Location = new System.Drawing.Point(159, 56);
            this.cbxThanhToan_maKH.Name = "cbxThanhToan_maKH";
            this.cbxThanhToan_maKH.Size = new System.Drawing.Size(194, 25);
            this.cbxThanhToan_maKH.TabIndex = 7;
            // 
            // dtpThanhToan_ngayPhieu
            // 
            this.dtpThanhToan_ngayPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThanhToan_ngayPhieu.Location = new System.Drawing.Point(159, 88);
            this.dtpThanhToan_ngayPhieu.Name = "dtpThanhToan_ngayPhieu";
            this.dtpThanhToan_ngayPhieu.Size = new System.Drawing.Size(194, 24);
            this.dtpThanhToan_ngayPhieu.TabIndex = 6;
            // 
            // txbThanhToan_soTien
            // 
            this.txbThanhToan_soTien.Location = new System.Drawing.Point(159, 119);
            this.txbThanhToan_soTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbThanhToan_soTien.Name = "txbThanhToan_soTien";
            this.txbThanhToan_soTien.Size = new System.Drawing.Size(151, 24);
            this.txbThanhToan_soTien.TabIndex = 5;
            this.txbThanhToan_soTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbThanhToan_soPhieu
            // 
            this.txbThanhToan_soPhieu.Location = new System.Drawing.Point(159, 25);
            this.txbThanhToan_soPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbThanhToan_soPhieu.Name = "txbThanhToan_soPhieu";
            this.txbThanhToan_soPhieu.ReadOnly = true;
            this.txbThanhToan_soPhieu.Size = new System.Drawing.Size(194, 24);
            this.txbThanhToan_soPhieu.TabIndex = 4;
            // 
            // btnThanhToan_clear
            // 
            this.btnThanhToan_clear.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThanhToan_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan_clear.FlatAppearance.BorderSize = 0;
            this.btnThanhToan_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan_clear.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan_clear.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan_clear.Location = new System.Drawing.Point(402, 88);
            this.btnThanhToan_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan_clear.Name = "btnThanhToan_clear";
            this.btnThanhToan_clear.Size = new System.Drawing.Size(100, 42);
            this.btnThanhToan_clear.TabIndex = 34;
            this.btnThanhToan_clear.Text = "";
            this.btnThanhToan_clear.UseVisualStyleBackColor = false;
            this.btnThanhToan_clear.Click += new System.EventHandler(this.btnThanhToan_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền";
            // 
            // btnThanhToan_save
            // 
            this.btnThanhToan_save.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThanhToan_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan_save.FlatAppearance.BorderSize = 0;
            this.btnThanhToan_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan_save.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan_save.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan_save.Location = new System.Drawing.Point(402, 38);
            this.btnThanhToan_save.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan_save.Name = "btnThanhToan_save";
            this.btnThanhToan_save.Size = new System.Drawing.Size(100, 42);
            this.btnThanhToan_save.TabIndex = 35;
            this.btnThanhToan_save.Text = "";
            this.btnThanhToan_save.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu";
            // 
            // FormThanhToan_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThanhToan_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thanh toán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBackThanhToan_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbThanhToan_soPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThanhToan_ngayPhieu;
        private System.Windows.Forms.TextBox txbThanhToan_soTien;
        private System.Windows.Forms.ComboBox cbxThanhToan_maKH;
        private System.Windows.Forms.Button btnThanhToan_delete;
        private System.Windows.Forms.Button btnThanhToan_clear;
        private System.Windows.Forms.Button btnThanhToan_save;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbThemTB;
        private System.Windows.Forms.Label lbThemTC;
        private System.Windows.Forms.Label label5;
    }
}