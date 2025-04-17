namespace QLPhongKhamNhaKhoa
{
    partial class FormDeleteDvu
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
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenDichVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGrid_QuanLyDichVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDichVu.Location = new System.Drawing.Point(121, 13);
            this.txtMaDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(217, 26);
            this.txtMaDichVu.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(121, 331);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 50);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "OK";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Location = new System.Drawing.Point(121, 196);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(217, 90);
            this.txtMoTa.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mô tả";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaTien.Location = new System.Drawing.Point(121, 134);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(217, 26);
            this.txtGiaTien.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giá tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên dịch vụ";
            // 
            // cbTenDichVu
            // 
            this.cbTenDichVu.FormattingEnabled = true;
            this.cbTenDichVu.Items.AddRange(new object[] {
            "Trám răng",
            "Lấy cao răng",
            "Trồng răng",
            "Niềng răng"});
            this.cbTenDichVu.Location = new System.Drawing.Point(121, 76);
            this.cbTenDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTenDichVu.Name = "cbTenDichVu";
            this.cbTenDichVu.Size = new System.Drawing.Size(217, 28);
            this.cbTenDichVu.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã dịch vụ";
            // 
            // DataGrid_QuanLyDichVu
            // 
            this.DataGrid_QuanLyDichVu.AllowUserToOrderColumns = true;
            this.DataGrid_QuanLyDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_QuanLyDichVu.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DataGrid_QuanLyDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QuanLyDichVu.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataGrid_QuanLyDichVu.Location = new System.Drawing.Point(372, 0);
            this.DataGrid_QuanLyDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGrid_QuanLyDichVu.Name = "DataGrid_QuanLyDichVu";
            this.DataGrid_QuanLyDichVu.RowHeadersWidth = 51;
            this.DataGrid_QuanLyDichVu.RowTemplate.Height = 24;
            this.DataGrid_QuanLyDichVu.Size = new System.Drawing.Size(465, 450);
            this.DataGrid_QuanLyDichVu.TabIndex = 40;
            this.DataGrid_QuanLyDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_QuanLyDichVu_CellContentClick);
            // 
            // FormDeleteDvu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.DataGrid_QuanLyDichVu);
            this.Controls.Add(this.txtMaDichVu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTenDichVu);
            this.Controls.Add(this.label1);
            this.Name = "FormDeleteDvu";
            this.Text = "FormDeleteDvu";
            this.Load += new System.EventHandler(this.FormDeleteDvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid_QuanLyDichVu;
    }
}