namespace QLPhongKhamNhaKhoa
{
    partial class UCQuanLyDieuTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuanLyDieuTri));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSửaDT = new System.Windows.Forms.Button();
            this.btnXóaDSDT = new System.Windows.Forms.Button();
            this.btnLoadDT = new System.Windows.Forms.Button();
            this.btnThêmDT = new System.Windows.Forms.Button();
            this.btnTìm = new System.Windows.Forms.Button();
            this.txtTìm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSDieuTri = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xemĐơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmDịchVụĐiềuTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDieuTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemĐơnThuốcToolStripMenuItem,
            this.thêmDịchVụĐiềuTrịToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1469, 75);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSửaDT);
            this.groupBox1.Controls.Add(this.btnXóaDSDT);
            this.groupBox1.Controls.Add(this.btnLoadDT);
            this.groupBox1.Controls.Add(this.btnThêmDT);
            this.groupBox1.Controls.Add(this.btnTìm);
            this.groupBox1.Controls.Add(this.txtTìm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1640, 147);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng ";
            // 
            // btnSửaDT
            // 
            this.btnSửaDT.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSửaDT.Location = new System.Drawing.Point(178, 51);
            this.btnSửaDT.Name = "btnSửaDT";
            this.btnSửaDT.Size = new System.Drawing.Size(118, 51);
            this.btnSửaDT.TabIndex = 8;
            this.btnSửaDT.Text = "SỬA";
            this.btnSửaDT.UseVisualStyleBackColor = false;
            this.btnSửaDT.Click += new System.EventHandler(this.btnSửaDT_Click);
            // 
            // btnXóaDSDT
            // 
            this.btnXóaDSDT.BackColor = System.Drawing.Color.PowderBlue;
            this.btnXóaDSDT.Location = new System.Drawing.Point(350, 51);
            this.btnXóaDSDT.Name = "btnXóaDSDT";
            this.btnXóaDSDT.Size = new System.Drawing.Size(118, 51);
            this.btnXóaDSDT.TabIndex = 6;
            this.btnXóaDSDT.Text = "XÓA";
            this.btnXóaDSDT.UseVisualStyleBackColor = false;
            this.btnXóaDSDT.Click += new System.EventHandler(this.btnXóaDSDT_Click);
            // 
            // btnLoadDT
            // 
            this.btnLoadDT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadDT.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLoadDT.Location = new System.Drawing.Point(523, 51);
            this.btnLoadDT.Name = "btnLoadDT";
            this.btnLoadDT.Size = new System.Drawing.Size(118, 51);
            this.btnLoadDT.TabIndex = 18;
            this.btnLoadDT.Text = "LOAD";
            this.btnLoadDT.UseVisualStyleBackColor = false;
            this.btnLoadDT.UseWaitCursor = true;
            this.btnLoadDT.Click += new System.EventHandler(this.btnLoadDT_Click);
            // 
            // btnThêmDT
            // 
            this.btnThêmDT.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThêmDT.Location = new System.Drawing.Point(9, 51);
            this.btnThêmDT.Name = "btnThêmDT";
            this.btnThêmDT.Size = new System.Drawing.Size(118, 51);
            this.btnThêmDT.TabIndex = 7;
            this.btnThêmDT.Text = "THÊM";
            this.btnThêmDT.UseVisualStyleBackColor = false;
            this.btnThêmDT.Click += new System.EventHandler(this.btnThêmDT_Click);
            // 
            // btnTìm
            // 
            this.btnTìm.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTìm.Location = new System.Drawing.Point(1347, 51);
            this.btnTìm.Name = "btnTìm";
            this.btnTìm.Size = new System.Drawing.Size(118, 51);
            this.btnTìm.TabIndex = 17;
            this.btnTìm.Text = "Search";
            this.btnTìm.UseVisualStyleBackColor = false;
            this.btnTìm.Click += new System.EventHandler(this.btnTìm_Click);
            // 
            // txtTìm
            // 
            this.txtTìm.Location = new System.Drawing.Point(715, 51);
            this.txtTìm.Multiline = true;
            this.txtTìm.Name = "txtTìm";
            this.txtTìm.Size = new System.Drawing.Size(615, 50);
            this.txtTìm.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Danh sách điều trị:";
            // 
            // dgvDSDieuTri
            // 
            this.dgvDSDieuTri.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSDieuTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSDieuTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDieuTri.EnableHeadersVisualStyles = false;
            this.dgvDSDieuTri.Location = new System.Drawing.Point(-25, 388);
            this.dgvDSDieuTri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDSDieuTri.Name = "dgvDSDieuTri";
            this.dgvDSDieuTri.RowHeadersWidth = 51;
            this.dgvDSDieuTri.RowTemplate.Height = 24;
            this.dgvDSDieuTri.Size = new System.Drawing.Size(1490, 1379);
            this.dgvDSDieuTri.TabIndex = 19;
            this.dgvDSDieuTri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDieuTri_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(380, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 81);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quản lý điều trị";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(842, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1281, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // xemĐơnThuốcToolStripMenuItem
            // 
            this.xemĐơnThuốcToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.xemĐơnThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemĐơnThuốcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.xemĐơnThuốcToolStripMenuItem.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Edit_File_26px;
            this.xemĐơnThuốcToolStripMenuItem.Name = "xemĐơnThuốcToolStripMenuItem";
            this.xemĐơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(233, 71);
            this.xemĐơnThuốcToolStripMenuItem.Text = "Xem Đơn Thuốc";
            this.xemĐơnThuốcToolStripMenuItem.Click += new System.EventHandler(this.xemĐơnThuốcToolStripMenuItem_Click);
            // 
            // thêmDịchVụĐiềuTrịToolStripMenuItem
            // 
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Add_File_26px;
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.Name = "thêmDịchVụĐiềuTrịToolStripMenuItem";
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.Size = new System.Drawing.Size(305, 71);
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.Text = "Thêm Dịch Vụ Điều Trị";
            this.thêmDịchVụĐiềuTrịToolStripMenuItem.Click += new System.EventHandler(this.thêmDịchVụĐiềuTrịToolStripMenuItem_Click);
            // 
            // UCQuanLyDieuTri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSDieuTri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCQuanLyDieuTri";
            this.Size = new System.Drawing.Size(1469, 1767);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDieuTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemĐơnThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmDịchVụĐiềuTrịToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSửaDT;
        private System.Windows.Forms.Button btnXóaDSDT;
        private System.Windows.Forms.Button btnThêmDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSDieuTri;
        private System.Windows.Forms.Button btnLoadDT;
        private System.Windows.Forms.Button btnTìm;
        private System.Windows.Forms.TextBox txtTìm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
