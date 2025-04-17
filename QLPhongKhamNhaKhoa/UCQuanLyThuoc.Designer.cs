namespace QLPhongKhamNhaKhoa
{
    partial class UCQuanLyThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuanLyThuoc));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.DataGrid_QuanLyThuoc = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thêmThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(399, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 81);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản lý thuốc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThuốcToolStripMenuItem,
            this.sửaThuốcToolStripMenuItem,
            this.xóaThuốcToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1469, 75);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // DataGrid_QuanLyThuoc
            // 
            this.DataGrid_QuanLyThuoc.AllowUserToOrderColumns = true;
            this.DataGrid_QuanLyThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGrid_QuanLyThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_QuanLyThuoc.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_QuanLyThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_QuanLyThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QuanLyThuoc.EnableHeadersVisualStyles = false;
            this.DataGrid_QuanLyThuoc.GridColor = System.Drawing.Color.Ivory;
            this.DataGrid_QuanLyThuoc.Location = new System.Drawing.Point(3, 245);
            this.DataGrid_QuanLyThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGrid_QuanLyThuoc.Name = "DataGrid_QuanLyThuoc";
            this.DataGrid_QuanLyThuoc.RowHeadersWidth = 51;
            this.DataGrid_QuanLyThuoc.RowTemplate.Height = 24;
            this.DataGrid_QuanLyThuoc.Size = new System.Drawing.Size(1463, 1522);
            this.DataGrid_QuanLyThuoc.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(727, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(615, 50);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1348, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 51);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(1348, 172);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 51);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Danh sách thuốc:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1214, 172);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 51);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(847, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1292, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // thêmThuốcToolStripMenuItem
            // 
            this.thêmThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmThuốcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thêmThuốcToolStripMenuItem.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Add_File_26px;
            this.thêmThuốcToolStripMenuItem.Name = "thêmThuốcToolStripMenuItem";
            this.thêmThuốcToolStripMenuItem.Size = new System.Drawing.Size(189, 69);
            this.thêmThuốcToolStripMenuItem.Text = "Thêm thuốc";
            this.thêmThuốcToolStripMenuItem.Click += new System.EventHandler(this.thêmThuốcToolStripMenuItem_Click);
            // 
            // sửaThuốcToolStripMenuItem
            // 
            this.sửaThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sửaThuốcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sửaThuốcToolStripMenuItem.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Edit_File_26px;
            this.sửaThuốcToolStripMenuItem.Name = "sửaThuốcToolStripMenuItem";
            this.sửaThuốcToolStripMenuItem.Size = new System.Drawing.Size(168, 69);
            this.sửaThuốcToolStripMenuItem.Text = "Sửa thuốc";
            this.sửaThuốcToolStripMenuItem.Click += new System.EventHandler(this.sửaThuốcToolStripMenuItem_Click);
            // 
            // xóaThuốcToolStripMenuItem
            // 
            this.xóaThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaThuốcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xóaThuốcToolStripMenuItem.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Delete_File_26px;
            this.xóaThuốcToolStripMenuItem.Name = "xóaThuốcToolStripMenuItem";
            this.xóaThuốcToolStripMenuItem.Size = new System.Drawing.Size(170, 69);
            this.xóaThuốcToolStripMenuItem.Text = "Xóa thuốc";
            this.xóaThuốcToolStripMenuItem.Click += new System.EventHandler(this.xóaThuốcToolStripMenuItem_Click);
            // 
            // UCQuanLyThuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DataGrid_QuanLyThuoc);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label2);
            this.Name = "UCQuanLyThuoc";
            this.Size = new System.Drawing.Size(1469, 1767);
            this.Load += new System.EventHandler(this.UCQuanLyThuoc_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThuốcToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGrid_QuanLyThuoc;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
    }
}
