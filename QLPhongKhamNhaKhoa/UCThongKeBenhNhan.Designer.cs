namespace QLPhongKhamNhaKhoa
{
    partial class UCThongKeBenhNhan
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
            this.cartesianChart_BenhNhan = new LiveCharts.WinForms.CartesianChart();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_TKBN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKBN)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart_BenhNhan
            // 
            this.cartesianChart_BenhNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cartesianChart_BenhNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cartesianChart_BenhNhan.Location = new System.Drawing.Point(51, 26);
            this.cartesianChart_BenhNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartesianChart_BenhNhan.Name = "cartesianChart_BenhNhan";
            this.cartesianChart_BenhNhan.Size = new System.Drawing.Size(1411, 412);
            this.cartesianChart_BenhNhan.TabIndex = 1;
            this.cartesianChart_BenhNhan.Text = "cartesianChart_BenhNhan";
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.Location = new System.Drawing.Point(421, 571);
            this.btnThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(192, 79);
            this.btnThang.TabIndex = 11;
            this.btnThang.Text = "Thống kê các tháng trong năm";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Location = new System.Drawing.Point(177, 571);
            this.btnNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(193, 79);
            this.btnNam.TabIndex = 10;
            this.btnNam.Text = "Thống kê theo năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(177, 517);
            this.cbNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(436, 28);
            this.cbNam.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Năm ";
            // 
            // dgv_TKBN
            // 
            this.dgv_TKBN.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv_TKBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKBN.Location = new System.Drawing.Point(827, 446);
            this.dgv_TKBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_TKBN.Name = "dgv_TKBN";
            this.dgv_TKBN.RowHeadersWidth = 51;
            this.dgv_TKBN.RowTemplate.Height = 24;
            this.dgv_TKBN.Size = new System.Drawing.Size(635, 286);
            this.dgv_TKBN.TabIndex = 12;
            // 
            // UCThongKeBenhNhan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.btnThang);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_TKBN);
            this.Controls.Add(this.cartesianChart_BenhNhan);
            this.Name = "UCThongKeBenhNhan";
            this.Size = new System.Drawing.Size(1517, 837);
            this.Load += new System.EventHandler(this.UCThongKeBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart_BenhNhan;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_TKBN;
    }
}
