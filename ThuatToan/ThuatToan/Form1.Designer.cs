namespace ThuatToan
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbThuatToan = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.grpDanhSachVaTim = new System.Windows.Forms.GroupBox();
            this.lstDSSauKhiSapXep = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapSoDeTimBST = new System.Windows.Forms.TextBox();
            this.btnTimBST = new System.Windows.Forms.Button();
            this.grpXayDungCayBST = new System.Windows.Forms.GroupBox();
            this.pnlCayBST = new System.Windows.Forms.Panel();
            this.btnThemCay = new System.Windows.Forms.Button();
            this.txtNhapSoDeXoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grpBST = new System.Windows.Forms.GroupBox();
            this.btnLoadExcelBST = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhapSoBST = new System.Windows.Forms.TextBox();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnLoadTxt = new System.Windows.Forms.Button();
            this.grpDanhSach.SuspendLayout();
            this.grpDanhSachVaTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpXayDungCayBST.SuspendLayout();
            this.grpBST.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(60, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhập vào một số: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(929, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "THUẬT TOÁN SẮP XẾP VÀ BINARYSEARCHTREE";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lstDanhSach);
            this.grpDanhSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpDanhSach.Location = new System.Drawing.Point(12, 167);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(216, 537);
            this.grpDanhSach.TabIndex = 22;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.BackColor = System.Drawing.Color.LightGray;
            this.lstDanhSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstDanhSach.ForeColor = System.Drawing.Color.Navy;
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 19;
            this.lstDanhSach.Location = new System.Drawing.Point(6, 23);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(204, 498);
            this.lstDanhSach.TabIndex = 0;
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(217, 73);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(421, 22);
            this.txtNhapSo.TabIndex = 23;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(420, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 56);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbThuatToan
            // 
            this.cmbThuatToan.FormattingEnabled = true;
            this.cmbThuatToan.Items.AddRange(new object[] {
            "Selection Sort",
            "Quick Sort"});
            this.cmbThuatToan.Location = new System.Drawing.Point(18, 137);
            this.cmbThuatToan.Name = "cmbThuatToan";
            this.cmbThuatToan.Size = new System.Drawing.Size(267, 24);
            this.cmbThuatToan.TabIndex = 19;
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSapXep.ForeColor = System.Drawing.Color.Aqua;
            this.btnSapXep.Location = new System.Drawing.Point(291, 132);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(100, 33);
            this.btnSapXep.TabIndex = 18;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // grpDanhSachVaTim
            // 
            this.grpDanhSachVaTim.Controls.Add(this.lstDSSauKhiSapXep);
            this.grpDanhSachVaTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpDanhSachVaTim.Location = new System.Drawing.Point(234, 166);
            this.grpDanhSachVaTim.Name = "grpDanhSachVaTim";
            this.grpDanhSachVaTim.Size = new System.Drawing.Size(268, 538);
            this.grpDanhSachVaTim.TabIndex = 24;
            this.grpDanhSachVaTim.TabStop = false;
            this.grpDanhSachVaTim.Text = "Danh sách sau khi sắp xếp:";
            // 
            // lstDSSauKhiSapXep
            // 
            this.lstDSSauKhiSapXep.BackColor = System.Drawing.Color.LightGray;
            this.lstDSSauKhiSapXep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDSSauKhiSapXep.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstDSSauKhiSapXep.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstDSSauKhiSapXep.FormattingEnabled = true;
            this.lstDSSauKhiSapXep.ItemHeight = 19;
            this.lstDSSauKhiSapXep.Location = new System.Drawing.Point(0, 24);
            this.lstDSSauKhiSapXep.Name = "lstDSSauKhiSapXep";
            this.lstDSSauKhiSapXep.Size = new System.Drawing.Size(262, 496);
            this.lstDSSauKhiSapXep.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(1068, 655);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 49);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Vui lòng chọn 1 thuật toán sắp xếp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nhập giá trị cần tìm:";
            // 
            // txtNhapSoDeTimBST
            // 
            this.txtNhapSoDeTimBST.Location = new System.Drawing.Point(9, 102);
            this.txtNhapSoDeTimBST.Name = "txtNhapSoDeTimBST";
            this.txtNhapSoDeTimBST.Size = new System.Drawing.Size(267, 27);
            this.txtNhapSoDeTimBST.TabIndex = 27;
            // 
            // btnTimBST
            // 
            this.btnTimBST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTimBST.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimBST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTimBST.Location = new System.Drawing.Point(282, 102);
            this.btnTimBST.Name = "btnTimBST";
            this.btnTimBST.Size = new System.Drawing.Size(255, 33);
            this.btnTimBST.TabIndex = 28;
            this.btnTimBST.Text = "Tìm";
            this.btnTimBST.UseVisualStyleBackColor = false;
            this.btnTimBST.Click += new System.EventHandler(this.btnTimBST_Click);
            // 
            // grpXayDungCayBST
            // 
            this.grpXayDungCayBST.Controls.Add(this.pnlCayBST);
            this.grpXayDungCayBST.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpXayDungCayBST.Location = new System.Drawing.Point(508, 253);
            this.grpXayDungCayBST.Name = "grpXayDungCayBST";
            this.grpXayDungCayBST.Size = new System.Drawing.Size(561, 451);
            this.grpXayDungCayBST.TabIndex = 29;
            this.grpXayDungCayBST.TabStop = false;
            this.grpXayDungCayBST.Text = "Xây dựng cây BST";
            // 
            // pnlCayBST
            // 
            this.pnlCayBST.BackColor = System.Drawing.Color.Silver;
            this.pnlCayBST.Location = new System.Drawing.Point(19, 21);
            this.pnlCayBST.Name = "pnlCayBST";
            this.pnlCayBST.Size = new System.Drawing.Size(525, 430);
            this.pnlCayBST.TabIndex = 0;
            this.pnlCayBST.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCayBST_Paint);
            // 
            // btnThemCay
            // 
            this.btnThemCay.BackColor = System.Drawing.Color.Silver;
            this.btnThemCay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThemCay.Location = new System.Drawing.Point(430, 9);
            this.btnThemCay.Name = "btnThemCay";
            this.btnThemCay.Size = new System.Drawing.Size(107, 78);
            this.btnThemCay.TabIndex = 30;
            this.btnThemCay.Text = "Thêm Cây";
            this.btnThemCay.UseVisualStyleBackColor = false;
            this.btnThemCay.Click += new System.EventHandler(this.btnThemCay_Click);
            // 
            // txtNhapSoDeXoa
            // 
            this.txtNhapSoDeXoa.Location = new System.Drawing.Point(9, 159);
            this.txtNhapSoDeXoa.Name = "txtNhapSoDeXoa";
            this.txtNhapSoDeXoa.Size = new System.Drawing.Size(267, 27);
            this.txtNhapSoDeXoa.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nhập giá trị cần xóa:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Black;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnXoa.Location = new System.Drawing.Point(286, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(251, 34);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grpBST
            // 
            this.grpBST.Controls.Add(this.btnLoadTxt);
            this.grpBST.Controls.Add(this.btnLoadExcelBST);
            this.grpBST.Controls.Add(this.label6);
            this.grpBST.Controls.Add(this.txtNhapSoBST);
            this.grpBST.Controls.Add(this.label4);
            this.grpBST.Controls.Add(this.btnThemCay);
            this.grpBST.Controls.Add(this.btnXoa);
            this.grpBST.Controls.Add(this.txtNhapSoDeTimBST);
            this.grpBST.Controls.Add(this.label5);
            this.grpBST.Controls.Add(this.btnTimBST);
            this.grpBST.Controls.Add(this.txtNhapSoDeXoa);
            this.grpBST.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpBST.Location = new System.Drawing.Point(644, 54);
            this.grpBST.Name = "grpBST";
            this.grpBST.Size = new System.Drawing.Size(551, 193);
            this.grpBST.TabIndex = 34;
            this.grpBST.TabStop = false;
            this.grpBST.Text = "BinarySearchTree";
            // 
            // btnLoadExcelBST
            // 
            this.btnLoadExcelBST.BackColor = System.Drawing.Color.Silver;
            this.btnLoadExcelBST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadExcelBST.Location = new System.Drawing.Point(272, 9);
            this.btnLoadExcelBST.Name = "btnLoadExcelBST";
            this.btnLoadExcelBST.Size = new System.Drawing.Size(149, 40);
            this.btnLoadExcelBST.TabIndex = 37;
            this.btnLoadExcelBST.Text = "Tải dữ liệu Excel";
            this.btnLoadExcelBST.UseVisualStyleBackColor = false;
            this.btnLoadExcelBST.Click += new System.EventHandler(this.btnLoadExcelBST_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nhập vào một node vào cây:";
            // 
            // txtNhapSoBST
            // 
            this.txtNhapSoBST.Location = new System.Drawing.Point(6, 48);
            this.txtNhapSoBST.Name = "txtNhapSoBST";
            this.txtNhapSoBST.Size = new System.Drawing.Size(267, 27);
            this.txtNhapSoBST.TabIndex = 35;
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadExcel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoadExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadExcel.Location = new System.Drawing.Point(528, 101);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(110, 56);
            this.btnLoadExcel.TabIndex = 36;
            this.btnLoadExcel.Text = "Tải dữ liệu Excel";
            this.btnLoadExcel.UseVisualStyleBackColor = false;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // btnLoadTxt
            // 
            this.btnLoadTxt.BackColor = System.Drawing.Color.Silver;
            this.btnLoadTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadTxt.Location = new System.Drawing.Point(272, 50);
            this.btnLoadTxt.Name = "btnLoadTxt";
            this.btnLoadTxt.Size = new System.Drawing.Size(149, 37);
            this.btnLoadTxt.TabIndex = 38;
            this.btnLoadTxt.Text = "Tải dữ liệu TxT";
            this.btnLoadTxt.UseVisualStyleBackColor = false;
            this.btnLoadTxt.Click += new System.EventHandler(this.btnLoadTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 741);
            this.Controls.Add(this.btnLoadExcel);
            this.Controls.Add(this.grpBST);
            this.Controls.Add(this.grpXayDungCayBST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbThuatToan);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.grpDanhSachVaTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "ThuatToan";
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSachVaTim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpXayDungCayBST.ResumeLayout(false);
            this.grpBST.ResumeLayout(false);
            this.grpBST.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbThuatToan;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.GroupBox grpDanhSachVaTim;
        private System.Windows.Forms.ListBox lstDSSauKhiSapXep;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhapSoDeTimBST;
        private System.Windows.Forms.Button btnTimBST;
        private System.Windows.Forms.GroupBox grpXayDungCayBST;
        private System.Windows.Forms.Panel pnlCayBST;
        private System.Windows.Forms.Button btnThemCay;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhapSoDeXoa;
        private System.Windows.Forms.GroupBox grpBST;
        private System.Windows.Forms.TextBox txtNhapSoBST;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnLoadExcelBST;
        private System.Windows.Forms.Button btnLoadTxt;
    }
}

