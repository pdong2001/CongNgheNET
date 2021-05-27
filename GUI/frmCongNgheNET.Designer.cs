
namespace GUI
{
    partial class frmCongNgheNET
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.txtXuatSu = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblXuatSu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1020, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý sản phẩm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgSanPham
            // 
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.RowHeadersWidth = 51;
            this.dgSanPham.RowTemplate.Height = 24;
            this.dgSanPham.Size = new System.Drawing.Size(1020, 399);
            this.dgSanPham.TabIndex = 1;
            this.dgSanPham.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlInput);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnMoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 158);
            this.panel1.TabIndex = 2;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.txtXuatSu);
            this.pnlInput.Controls.Add(this.txtGiaBan);
            this.pnlInput.Controls.Add(this.txtSL);
            this.pnlInput.Controls.Add(this.txtTenSP);
            this.pnlInput.Controls.Add(this.txtMaSP);
            this.pnlInput.Controls.Add(this.lblXuatSu);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.lblMaSP);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(1020, 78);
            this.pnlInput.TabIndex = 6;
            // 
            // txtXuatSu
            // 
            this.txtXuatSu.Location = new System.Drawing.Point(854, 41);
            this.txtXuatSu.Name = "txtXuatSu";
            this.txtXuatSu.Size = new System.Drawing.Size(141, 22);
            this.txtXuatSu.TabIndex = 4;
            this.txtXuatSu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(642, 41);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(141, 22);
            this.txtGiaBan.TabIndex = 4;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(421, 41);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(141, 22);
            this.txtSL.TabIndex = 4;
            this.txtSL.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(213, 41);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(141, 22);
            this.txtTenSP.TabIndex = 4;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(5, 41);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(141, 22);
            this.txtMaSP.TabIndex = 4;
            // 
            // lblXuatSu
            // 
            this.lblXuatSu.AutoSize = true;
            this.lblXuatSu.Location = new System.Drawing.Point(893, 21);
            this.lblXuatSu.Name = "lblXuatSu";
            this.lblXuatSu.Size = new System.Drawing.Size(60, 17);
            this.lblXuatSu.TabIndex = 3;
            this.lblXuatSu.Text = "Xuất sứ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá bán:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên SP:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(44, 21);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(53, 17);
            this.lblMaSP.TabIndex = 3;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(867, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(551, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 36);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(298, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 36);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(57, 100);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(99, 36);
            this.btnMoi.TabIndex = 5;
            this.btnMoi.Text = "&Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 399);
            this.panel2.TabIndex = 3;
            // 
            // frmCongNgheNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCongNgheNET";
            this.Text = "frmCongNgheNET";
            this.Load += new System.EventHandler(this.frmCongNgheNET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtXuatSu;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblXuatSu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel panel2;
    }
}

