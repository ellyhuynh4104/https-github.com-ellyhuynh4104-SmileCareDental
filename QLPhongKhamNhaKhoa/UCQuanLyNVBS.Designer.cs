namespace QLPhongKhamNhaKhoa
{
    partial class UCQuanLyNVBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuanLyNVBS));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_NVBS = new System.Windows.Forms.DataGridView();
            this.btn_Load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thêmNhânViênBácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaNhânViênBácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênBácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NVBS)).BeginInit();
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
            this.thêmNhânViênBácSĩToolStripMenuItem,
            this.sửaNhânViênBácSĩToolStripMenuItem,
            this.xóaNhânViênBácSĩToolStripMenuItem,
            this.thốngKêBệnhNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1469, 75);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêBệnhNhânToolStripMenuItem
            // 
            this.thốngKêBệnhNhânToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêBệnhNhânToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thốngKêBệnhNhânToolStripMenuItem.Name = "thốngKêBệnhNhânToolStripMenuItem";
            this.thốngKêBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(48, 71);
            this.thốngKêBệnhNhânToolStripMenuItem.Text = "    ";
            // 
            // dgv_NVBS
            // 
            this.dgv_NVBS.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NVBS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NVBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NVBS.EnableHeadersVisualStyles = false;
            this.dgv_NVBS.Location = new System.Drawing.Point(0, 245);
            this.dgv_NVBS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_NVBS.Name = "dgv_NVBS";
            this.dgv_NVBS.RowHeadersWidth = 51;
            this.dgv_NVBS.RowTemplate.Height = 24;
            this.dgv_NVBS.Size = new System.Drawing.Size(1464, 1522);
            this.dgv_NVBS.TabIndex = 3;
            this.dgv_NVBS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NVBS_CellContentClick);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(1346, 171);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(118, 51);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "LOAD";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
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
            this.label2.TabIndex = 6;
            this.label2.Text = "Quản lý nhân viên bác sĩ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1348, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 51);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(712, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(615, 50);
            this.txtSearch.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Danh sách nhân viên, bác sĩ:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(904, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1277, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // thêmNhânViênBácSĩToolStripMenuItem
            // 
            this.thêmNhânViênBácSĩToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmNhânViênBácSĩToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.thêmNhânViênBácSĩToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmNhânViênBácSĩToolStripMenuItem.Image")));
            this.thêmNhânViênBácSĩToolStripMenuItem.Name = "thêmNhânViênBácSĩToolStripMenuItem";
            this.thêmNhânViênBácSĩToolStripMenuItem.Size = new System.Drawing.Size(239, 71);
            this.thêmNhânViênBácSĩToolStripMenuItem.Text = "Thêm Nhân Viên";
            this.thêmNhânViênBácSĩToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênBácSĩToolStripMenuItem_Click);
            // 
            // sửaNhânViênBácSĩToolStripMenuItem
            // 
            this.sửaNhânViênBácSĩToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sửaNhânViênBácSĩToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.sửaNhânViênBácSĩToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sửaNhânViênBácSĩToolStripMenuItem.Image")));
            this.sửaNhânViênBácSĩToolStripMenuItem.Name = "sửaNhânViênBácSĩToolStripMenuItem";
            this.sửaNhânViênBácSĩToolStripMenuItem.Size = new System.Drawing.Size(225, 71);
            this.sửaNhânViênBácSĩToolStripMenuItem.Text = "Sửa Nhân Viên ";
            this.sửaNhânViênBácSĩToolStripMenuItem.Click += new System.EventHandler(this.sửaNhânViênBácSĩToolStripMenuItem_Click);
            // 
            // xóaNhânViênBácSĩToolStripMenuItem
            // 
            this.xóaNhânViênBácSĩToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaNhânViênBácSĩToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.xóaNhânViênBácSĩToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaNhânViênBácSĩToolStripMenuItem.Image")));
            this.xóaNhânViênBácSĩToolStripMenuItem.Name = "xóaNhânViênBácSĩToolStripMenuItem";
            this.xóaNhânViênBácSĩToolStripMenuItem.Size = new System.Drawing.Size(224, 71);
            this.xóaNhânViênBácSĩToolStripMenuItem.Text = "Xóa Nhân viên ";
            this.xóaNhânViênBácSĩToolStripMenuItem.Click += new System.EventHandler(this.xóaNhânViênBácSĩToolStripMenuItem_Click);
            // 
            // UCQuanLyNVBS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.dgv_NVBS);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCQuanLyNVBS";
            this.Size = new System.Drawing.Size(1469, 1767);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NVBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênBácSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaNhânViênBácSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênBácSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_NVBS;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}
