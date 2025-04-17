namespace QLPhongKhamNhaKhoa
{
    partial class UCQuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuanLyDichVu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DataGrid_QuanLyDichVu = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thêmDichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaDichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmDichVuToolStripMenuItem,
            this.xóaDichVuToolStripMenuItem,
            this.sửaDichVuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1469, 75);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DataGrid_QuanLyDichVu
            // 
            this.DataGrid_QuanLyDichVu.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_QuanLyDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_QuanLyDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QuanLyDichVu.EnableHeadersVisualStyles = false;
            this.DataGrid_QuanLyDichVu.Location = new System.Drawing.Point(0, 245);
            this.DataGrid_QuanLyDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGrid_QuanLyDichVu.Name = "DataGrid_QuanLyDichVu";
            this.DataGrid_QuanLyDichVu.RowHeadersWidth = 51;
            this.DataGrid_QuanLyDichVu.RowTemplate.Height = 24;
            this.DataGrid_QuanLyDichVu.Size = new System.Drawing.Size(1466, 1522);
            this.DataGrid_QuanLyDichVu.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(1348, 173);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 51);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.label2.Text = "Quản lý dịch vụ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách dịch vụ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(884, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // thêmDichVuToolStripMenuItem
            // 
            this.thêmDichVuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmDichVuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thêmDichVuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmDichVuToolStripMenuItem.Image")));
            this.thêmDichVuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thêmDichVuToolStripMenuItem.Name = "thêmDichVuToolStripMenuItem";
            this.thêmDichVuToolStripMenuItem.Size = new System.Drawing.Size(209, 69);
            this.thêmDichVuToolStripMenuItem.Text = "Thêm dịch vụ";
            this.thêmDichVuToolStripMenuItem.Click += new System.EventHandler(this.thêmDichVuToolStripMenuItem_Click);
            // 
            // xóaDichVuToolStripMenuItem
            // 
            this.xóaDichVuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaDichVuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xóaDichVuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaDichVuToolStripMenuItem.Image")));
            this.xóaDichVuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xóaDichVuToolStripMenuItem.Name = "xóaDichVuToolStripMenuItem";
            this.xóaDichVuToolStripMenuItem.Size = new System.Drawing.Size(190, 69);
            this.xóaDichVuToolStripMenuItem.Text = "Xóa dịch vụ";
            this.xóaDichVuToolStripMenuItem.Click += new System.EventHandler(this.xóaDichVuToolStripMenuItem_Click);
            // 
            // sửaDichVuToolStripMenuItem
            // 
            this.sửaDichVuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sửaDichVuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sửaDichVuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sửaDichVuToolStripMenuItem.Image")));
            this.sửaDichVuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sửaDichVuToolStripMenuItem.Name = "sửaDichVuToolStripMenuItem";
            this.sửaDichVuToolStripMenuItem.Size = new System.Drawing.Size(188, 69);
            this.sửaDichVuToolStripMenuItem.Text = "Sửa dịch vụ";
            this.sửaDichVuToolStripMenuItem.Click += new System.EventHandler(this.sửaDichVuToolStripMenuItem_Click);
            // 
            // UCQuanLyDichVu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.DataGrid_QuanLyDichVu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCQuanLyDichVu";
            this.Size = new System.Drawing.Size(1469, 1767);
            this.Load += new System.EventHandler(this.UCQuanLyDichVu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmDichVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaDichVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaDichVuToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGrid_QuanLyDichVu;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
