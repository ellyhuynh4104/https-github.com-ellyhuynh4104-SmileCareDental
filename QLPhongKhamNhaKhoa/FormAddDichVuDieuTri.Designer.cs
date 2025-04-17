namespace QLPhongKhamNhaKhoa
{
    partial class FormAddDichVuDieuTri
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_DichVuDT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.comboBox_DichVu = new System.Windows.Forms.ComboBox();
            this.txtMaDieuTri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVuDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Danh sách dịch vụ điều trị ";
            // 
            // dgv_DichVuDT
            // 
            this.dgv_DichVuDT.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgv_DichVuDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVuDT.Location = new System.Drawing.Point(12, 45);
            this.dgv_DichVuDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_DichVuDT.Name = "dgv_DichVuDT";
            this.dgv_DichVuDT.RowHeadersWidth = 51;
            this.dgv_DichVuDT.RowTemplate.Height = 24;
            this.dgv_DichVuDT.Size = new System.Drawing.Size(726, 188);
            this.dgv_DichVuDT.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Controls.Add(this.comboBox_DichVu);
            this.groupBox1.Controls.Add(this.txtMaDieuTri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(724, 359);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã điều trị";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(569, 190);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 51);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(174, 151);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 158);
            this.listBox1.TabIndex = 6;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(569, 68);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(118, 51);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // comboBox_DichVu
            // 
            this.comboBox_DichVu.FormattingEnabled = true;
            this.comboBox_DichVu.Location = new System.Drawing.Point(176, 88);
            this.comboBox_DichVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_DichVu.Name = "comboBox_DichVu";
            this.comboBox_DichVu.Size = new System.Drawing.Size(314, 30);
            this.comboBox_DichVu.TabIndex = 4;
            // 
            // txtMaDieuTri
            // 
            this.txtMaDieuTri.Enabled = false;
            this.txtMaDieuTri.Location = new System.Drawing.Point(174, 31);
            this.txtMaDieuTri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDieuTri.Name = "txtMaDieuTri";
            this.txtMaDieuTri.Size = new System.Drawing.Size(314, 28);
            this.txtMaDieuTri.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            // 
            // FormAddDichVuDieuTri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(758, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_DichVuDT);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddDichVuDieuTri";
            this.Text = "FormAddDichVuDieuTri";
            this.Load += new System.EventHandler(this.FormAddDichVuDieuTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVuDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_DichVuDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox comboBox_DichVu;
        public System.Windows.Forms.TextBox txtMaDieuTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}