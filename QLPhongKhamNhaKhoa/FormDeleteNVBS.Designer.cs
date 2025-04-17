namespace QLPhongKhamNhaKhoa
{
    partial class FormDeleteNVBS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_NVBS = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txtBangCap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKinhNghiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbViTri = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.txtTenNVBS = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaNVBS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NVBS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.dgv_NVBS);
            this.groupBox1.Controls.Add(this.txtBangCap);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtKinhNghiem);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCMT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbViTri);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.radioButton_Nu);
            this.groupBox1.Controls.Add(this.radioButton_Nam);
            this.groupBox1.Controls.Add(this.txtTenNVBS);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtMaNVBS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1015, 665);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dgv_NVBS
            // 
            this.dgv_NVBS.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgv_NVBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NVBS.Location = new System.Drawing.Point(562, 54);
            this.dgv_NVBS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_NVBS.Name = "dgv_NVBS";
            this.dgv_NVBS.RowHeadersWidth = 51;
            this.dgv_NVBS.RowTemplate.Height = 24;
            this.dgv_NVBS.Size = new System.Drawing.Size(444, 580);
            this.dgv_NVBS.TabIndex = 23;
            this.dgv_NVBS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NVBS_CellContentClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Delete.Location = new System.Drawing.Point(468, 678);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(118, 51);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "OK";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txtBangCap
            // 
            this.txtBangCap.Location = new System.Drawing.Point(214, 474);
            this.txtBangCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(314, 28);
            this.txtBangCap.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(70, 478);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "Bằng cấp";
            // 
            // txtKinhNghiem
            // 
            this.txtKinhNghiem.Location = new System.Drawing.Point(214, 391);
            this.txtKinhNghiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKinhNghiem.Name = "txtKinhNghiem";
            this.txtKinhNghiem.Size = new System.Drawing.Size(314, 28);
            this.txtKinhNghiem.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 395);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Kinh nghiệm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 354);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số CMT";
            // 
            // txtCMT
            // 
            this.txtCMT.Location = new System.Drawing.Point(214, 349);
            this.txtCMT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(314, 28);
            this.txtCMT.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Vị trí";
            // 
            // cbViTri
            // 
            this.cbViTri.FormattingEnabled = true;
            this.cbViTri.Location = new System.Drawing.Point(214, 178);
            this.cbViTri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbViTri.Name = "cbViTri";
            this.cbViTri.Size = new System.Drawing.Size(194, 30);
            this.cbViTri.TabIndex = 13;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(214, 515);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(314, 119);
            this.txtGhiChu.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 520);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ghi chú";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 432);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 28);
            this.txtEmail.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 438);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(214, 266);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(314, 28);
            this.txtDiaChi.TabIndex = 8;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(324, 225);
            this.radioButton_Nu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(60, 26);
            this.radioButton_Nu.TabIndex = 7;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(214, 225);
            this.radioButton_Nam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(75, 26);
            this.radioButton_Nam.TabIndex = 6;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // txtTenNVBS
            // 
            this.txtTenNVBS.Location = new System.Drawing.Point(214, 94);
            this.txtTenNVBS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNVBS.Name = "txtTenNVBS";
            this.txtTenNVBS.Size = new System.Drawing.Size(314, 28);
            this.txtTenNVBS.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(214, 308);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(314, 28);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // txtMaNVBS
            // 
            this.txtMaNVBS.Location = new System.Drawing.Point(214, 54);
            this.txtMaNVBS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNVBS.Name = "txtMaNVBS";
            this.txtMaNVBS.Size = new System.Drawing.Size(314, 28);
            this.txtMaNVBS.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.CustomFormat = "dd/MM/yyy";
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(214, 135);
            this.dtpkNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(314, 28);
            this.dtpkNgaySinh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính";
            // 
            // FormDeleteNVBS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1023, 744);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Delete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDeleteNVBS";
            this.Text = "FormDeleteNVBS";
            this.Load += new System.EventHandler(this.FormDeleteNVBS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NVBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NVBS;
        private System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.TextBox txtBangCap;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtKinhNghiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCMT;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbViTri;
        public System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDiaChi;
        public System.Windows.Forms.RadioButton radioButton_Nu;
        public System.Windows.Forms.RadioButton radioButton_Nam;
        public System.Windows.Forms.TextBox txtTenNVBS;
        public System.Windows.Forms.TextBox txtSoDienThoai;
        public System.Windows.Forms.TextBox txtMaNVBS;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}