namespace QLBHVatLieuXayDung
{
    partial class FormChonKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChonKH = new System.Windows.Forms.DataGridView();
            this.btnBackChonKH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvChonKH);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(355, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn khách hàng";
            // 
            // dgvChonKH
            // 
            this.dgvChonKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChonKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvChonKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonKH.Location = new System.Drawing.Point(7, 24);
            this.dgvChonKH.Name = "dgvChonKH";
            this.dgvChonKH.Size = new System.Drawing.Size(340, 301);
            this.dgvChonKH.TabIndex = 0;
            // 
            // btnBackChonKH
            // 
            this.btnBackChonKH.BackColor = System.Drawing.Color.Transparent;
            this.btnBackChonKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackChonKH.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackChonKH.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackChonKH.Image = global::QLBHVatLieuXayDung.Properties.Resources.Back_32px;
            this.btnBackChonKH.Location = new System.Drawing.Point(3, 4);
            this.btnBackChonKH.Name = "btnBackChonKH";
            this.btnBackChonKH.Size = new System.Drawing.Size(32, 32);
            this.btnBackChonKH.TabIndex = 5;
            this.btnBackChonKH.UseVisualStyleBackColor = false;
            this.btnBackChonKH.Click += new System.EventHandler(this.btnBackChonKH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnBackChonKH);
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 40);
            this.panel1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(39, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Back";
            // 
            // FormChonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu khách hàng";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackChonKH;
        private System.Windows.Forms.DataGridView dgvChonKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}