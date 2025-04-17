namespace QLPhongKhamNhaKhoa
{
    partial class FormDeleteLichHen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLichHen = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Xóa lịch hẹn mã:";
            // 
            // txtMaLichHen
            // 
            this.txtMaLichHen.Location = new System.Drawing.Point(259, 36);
            this.txtMaLichHen.Name = "txtMaLichHen";
            this.txtMaLichHen.Size = new System.Drawing.Size(138, 26);
            this.txtMaLichHen.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 66);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(38, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 66);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormDeleteLichHen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(428, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLichHen);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXoa);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormDeleteLichHen";
            this.Text = "FormDeleteLichHen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnXoa;
    }
}