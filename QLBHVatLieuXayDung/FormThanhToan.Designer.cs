﻿namespace QLBHVatLieuXayDung
{
    partial class FormThanhToan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan_reload = new System.Windows.Forms.Button();
            this.btnThanhToan_chonKH = new System.Windows.Forms.Button();
            this.lbThemTC = new System.Windows.Forms.Label();
            this.dtpTT_ngayPhieu = new System.Windows.Forms.DateTimePicker();
            this.cbxTT_maKH = new System.Windows.Forms.ComboBox();
            this.btnTT_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTT_soTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbThemTB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTimer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBackThanhToan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThanhToan_reload);
            this.groupBox1.Controls.Add(this.btnThanhToan_chonKH);
            this.groupBox1.Controls.Add(this.lbThemTC);
            this.groupBox1.Controls.Add(this.dtpTT_ngayPhieu);
            this.groupBox1.Controls.Add(this.cbxTT_maKH);
            this.groupBox1.Controls.Add(this.btnTT_save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbTT_soTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbThemTB);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh toán";
            // 
            // btnThanhToan_reload
            // 
            this.btnThanhToan_reload.FlatAppearance.BorderSize = 0;
            this.btnThanhToan_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan_reload.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan_reload.Location = new System.Drawing.Point(86, 32);
            this.btnThanhToan_reload.Name = "btnThanhToan_reload";
            this.btnThanhToan_reload.Size = new System.Drawing.Size(25, 25);
            this.btnThanhToan_reload.TabIndex = 5;
            this.btnThanhToan_reload.Text = "";
            this.btnThanhToan_reload.UseVisualStyleBackColor = true;
            this.btnThanhToan_reload.Click += new System.EventHandler(this.btnThanhToan_reload_Click);
            // 
            // btnThanhToan_chonKH
            // 
            this.btnThanhToan_chonKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan_chonKH.FlatAppearance.BorderSize = 0;
            this.btnThanhToan_chonKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan_chonKH.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan_chonKH.Location = new System.Drawing.Point(294, 31);
            this.btnThanhToan_chonKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan_chonKH.Name = "btnThanhToan_chonKH";
            this.btnThanhToan_chonKH.Size = new System.Drawing.Size(25, 25);
            this.btnThanhToan_chonKH.TabIndex = 48;
            this.btnThanhToan_chonKH.Text = "";
            this.btnThanhToan_chonKH.UseVisualStyleBackColor = true;
            this.btnThanhToan_chonKH.Click += new System.EventHandler(this.btnThanhToan_chonKH_Click);
            // 
            // lbThemTC
            // 
            this.lbThemTC.AutoSize = true;
            this.lbThemTC.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTC.ForeColor = System.Drawing.Color.Green;
            this.lbThemTC.Location = new System.Drawing.Point(80, 213);
            this.lbThemTC.Name = "lbThemTC";
            this.lbThemTC.Size = new System.Drawing.Size(176, 18);
            this.lbThemTC.TabIndex = 46;
            this.lbThemTC.Text = "Thêm sản phẩm thành công";
            this.lbThemTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTT_ngayPhieu
            // 
            this.dtpTT_ngayPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpTT_ngayPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTT_ngayPhieu.Location = new System.Drawing.Point(113, 67);
            this.dtpTT_ngayPhieu.Name = "dtpTT_ngayPhieu";
            this.dtpTT_ngayPhieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpTT_ngayPhieu.Size = new System.Drawing.Size(206, 24);
            this.dtpTT_ngayPhieu.TabIndex = 11;
            // 
            // cbxTT_maKH
            // 
            this.cbxTT_maKH.BackColor = System.Drawing.Color.Silver;
            this.cbxTT_maKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTT_maKH.DropDownHeight = 120;
            this.cbxTT_maKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTT_maKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTT_maKH.FormattingEnabled = true;
            this.cbxTT_maKH.IntegralHeight = false;
            this.cbxTT_maKH.Location = new System.Drawing.Point(113, 31);
            this.cbxTT_maKH.Name = "cbxTT_maKH";
            this.cbxTT_maKH.Size = new System.Drawing.Size(175, 25);
            this.cbxTT_maKH.TabIndex = 10;
            // 
            // btnTT_save
            // 
            this.btnTT_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTT_save.FlatAppearance.BorderSize = 0;
            this.btnTT_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnTT_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnTT_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTT_save.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT_save.ForeColor = System.Drawing.Color.Green;
            this.btnTT_save.Image = global::QLBHVatLieuXayDung.Properties.Resources.Paper_Money_32px;
            this.btnTT_save.Location = new System.Drawing.Point(229, 132);
            this.btnTT_save.Name = "btnTT_save";
            this.btnTT_save.Size = new System.Drawing.Size(90, 63);
            this.btnTT_save.TabIndex = 9;
            this.btnTT_save.TabStop = false;
            this.btnTT_save.UseVisualStyleBackColor = true;
            this.btnTT_save.Click += new System.EventHandler(this.btnTT_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền";
            // 
            // txbTT_soTien
            // 
            this.txbTT_soTien.Location = new System.Drawing.Point(113, 102);
            this.txbTT_soTien.Name = "txbTT_soTien";
            this.txbTT_soTien.Size = new System.Drawing.Size(162, 24);
            this.txbTT_soTien.TabIndex = 7;
            this.txbTT_soTien.Text = "0";
            this.txbTT_soTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày phiếu";
            // 
            // lbThemTB
            // 
            this.lbThemTB.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemTB.ForeColor = System.Drawing.Color.Red;
            this.lbThemTB.Location = new System.Drawing.Point(6, 213);
            this.lbThemTB.Name = "lbThemTB";
            this.lbThemTB.Size = new System.Drawing.Size(313, 18);
            this.lbThemTB.TabIndex = 47;
            this.lbThemTB.Text = "<\\\\ Vui lòng nhập đầy đủ thông tin >";
            this.lbThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(111, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "THANH TOÁN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnBackThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 4;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(192, 12);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(146, 17);
            this.lbTimer.TabIndex = 7;
            this.lbTimer.Text = "dd-MM-yyyy hh:mm:ss tt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(48, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Back";
            // 
            // btnBackThanhToan
            // 
            this.btnBackThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnBackThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackThanhToan.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackThanhToan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackThanhToan.Image = global::QLBHVatLieuXayDung.Properties.Resources.Back_32px;
            this.btnBackThanhToan.Location = new System.Drawing.Point(3, 4);
            this.btnBackThanhToan.Name = "btnBackThanhToan";
            this.btnBackThanhToan.Size = new System.Drawing.Size(42, 32);
            this.btnBackThanhToan.TabIndex = 5;
            this.btnBackThanhToan.UseVisualStyleBackColor = false;
            this.btnBackThanhToan.Click += new System.EventHandler(this.btnBackThanhToan_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormThanhToan
            // 
            this.AcceptButton = this.btnTT_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTT_soTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTT_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBackThanhToan;
        private System.Windows.Forms.DateTimePicker dtpTT_ngayPhieu;
        private System.Windows.Forms.ComboBox cbxTT_maKH;
        private System.Windows.Forms.Label lbThemTB;
        private System.Windows.Forms.Label lbThemTC;
        private System.Windows.Forms.Button btnThanhToan_chonKH;
        private System.Windows.Forms.Button btnThanhToan_reload;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer1;
    }
}