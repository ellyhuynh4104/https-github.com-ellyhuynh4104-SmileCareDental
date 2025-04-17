namespace QLPhongKhamNhaKhoa
{
    partial class UCThongKeDoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cartesianChart_DoanhThu = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNam = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.btnThang = new System.Windows.Forms.Button();
            this.lblNam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-58, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 141);
            this.dataGridView1.TabIndex = 6;
            // 
            // cartesianChart_DoanhThu
            // 
            this.cartesianChart_DoanhThu.Location = new System.Drawing.Point(3, 150);
            this.cartesianChart_DoanhThu.Name = "cartesianChart_DoanhThu";
            this.cartesianChart_DoanhThu.Size = new System.Drawing.Size(1227, 569);
            this.cartesianChart_DoanhThu.TabIndex = 7;
            this.cartesianChart_DoanhThu.Text = "cartesianChart_DoanhThu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNam);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.btnThang);
            this.panel1.Controls.Add(this.lblNam);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1254, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 720);
            this.panel1.TabIndex = 8;
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNam.Location = new System.Drawing.Point(9, 436);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(188, 85);
            this.btnNam.TabIndex = 4;
            this.btnNam.Text = "Thống kê theo năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(81, 12);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 40);
            this.cbNam.TabIndex = 2;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThang.Location = new System.Drawing.Point(9, 620);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(188, 85);
            this.btnThang.TabIndex = 1;
            this.btnThang.Text = "Thống kê các tháng trong năm";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(3, 20);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(76, 32);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm";
            // 
            // UCThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cartesianChart_DoanhThu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1517, 837);
            this.Load += new System.EventHandler(this.UCThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LiveCharts.WinForms.CartesianChart cartesianChart_DoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Label lblNam;
    }
}
