namespace THLQP9
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDanhSach = new System.Windows.Forms.Label();
            this.labelChinhSua = new System.Windows.Forms.Label();
            this.labelMaXB = new System.Windows.Forms.Label();
            this.labelTenXB = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(180, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(256, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Chỉnh sửa thông tin dữ liệu";
            // 
            // labelDanhSach
            // 
            this.labelDanhSach.AutoSize = true;
            this.labelDanhSach.Location = new System.Drawing.Point(25, 50);
            this.labelDanhSach.Name = "labelDanhSach";
            this.labelDanhSach.Size = new System.Drawing.Size(166, 20);
            this.labelDanhSach.TabIndex = 1;
            this.labelDanhSach.Text = "Danh sách nhà xuất bản:";
            // 
            // labelChinhSua
            // 
            this.labelChinhSua.AutoSize = true;
            this.labelChinhSua.Location = new System.Drawing.Point(340, 50);
            this.labelChinhSua.Name = "labelChinhSua";
            this.labelChinhSua.Size = new System.Drawing.Size(134, 20);
            this.labelChinhSua.TabIndex = 2;
            this.labelChinhSua.Text = "Chỉnh sửa thông tin:";
            // 
            // labelMaXB
            // 
            this.labelMaXB.AutoSize = true;
            this.labelMaXB.Location = new System.Drawing.Point(340, 90);
            this.labelMaXB.Name = "labelMaXB";
            this.labelMaXB.Size = new System.Drawing.Size(63, 20);
            this.labelMaXB.TabIndex = 3;
            this.labelMaXB.Text = "Mã NXB:";
            // 
            // labelTenXB
            // 
            this.labelTenXB.AutoSize = true;
            this.labelTenXB.Location = new System.Drawing.Point(340, 130);
            this.labelTenXB.Name = "labelTenXB";
            this.labelTenXB.Size = new System.Drawing.Size(68, 20);
            this.labelTenXB.TabIndex = 4;
            this.labelTenXB.Text = "Tên NXB:";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(340, 170);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(56, 20);
            this.labelDiaChi.TabIndex = 5;
            this.labelDiaChi.Text = "Địa chỉ:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(420, 87);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(150, 27);
            this.txtMaXB.TabIndex = 6;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(420, 127);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(150, 27);
            this.txtTenXB.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(420, 167);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(150, 27);
            this.txtDiaChi.TabIndex = 8;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChinhSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChinhSua.Location = new System.Drawing.Point(380, 220);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(150, 40);
            this.btnChinhSua.TabIndex = 9;
            this.btnChinhSua.Text = "Chỉnh sửa thông tin";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(25, 75);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 29;
            this.dgvDanhSach.Size = new System.Drawing.Size(300, 200);
            this.dgvDanhSach.TabIndex = 10;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelTenXB);
            this.Controls.Add(this.labelMaXB);
            this.Controls.Add(this.labelChinhSua);
            this.Controls.Add(this.labelDanhSach);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDanhSach;
        private System.Windows.Forms.Label labelChinhSua;
        private System.Windows.Forms.Label labelMaXB;
        private System.Windows.Forms.Label labelTenXB;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}
