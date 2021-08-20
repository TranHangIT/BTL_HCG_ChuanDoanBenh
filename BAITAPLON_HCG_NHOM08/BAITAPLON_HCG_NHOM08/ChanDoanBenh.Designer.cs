namespace BAITAPLON_HCG_NHOM08
{
    partial class ChanDoanBenh
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
            this.components = new System.ComponentModel.Container();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listbox_KetQua = new System.Windows.Forms.ListBox();
            this.picturebox_KetQua = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_XacNhanSuKien = new System.Windows.Forms.DataGridView();
            this.mask1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensukien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_SuKien = new System.Windows.Forms.DataGridView();
            this.mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SuyDien = new System.Windows.Forms.Button();
            this.btn_XoaSuKien = new System.Windows.Forms.Button();
            this.btn_ThemSuKien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.txtmask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttensk = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_KetQua)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XacNhanSuKien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Pink;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(796, 305);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(110, 53);
            this.btn_Refresh.TabIndex = 32;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listbox_KetQua);
            this.groupBox3.Controls.Add(this.picturebox_KetQua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(957, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 199);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả chẩn đoán";
            // 
            // listbox_KetQua
            // 
            this.listbox_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_KetQua.FormattingEnabled = true;
            this.listbox_KetQua.ItemHeight = 20;
            this.listbox_KetQua.Location = new System.Drawing.Point(14, 25);
            this.listbox_KetQua.Name = "listbox_KetQua";
            this.listbox_KetQua.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listbox_KetQua.Size = new System.Drawing.Size(463, 164);
            this.listbox_KetQua.TabIndex = 6;
            // 
            // picturebox_KetQua
            // 
            this.picturebox_KetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_KetQua.Location = new System.Drawing.Point(6, 283);
            this.picturebox_KetQua.Name = "picturebox_KetQua";
            this.picturebox_KetQua.Size = new System.Drawing.Size(250, 10);
            this.picturebox_KetQua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_KetQua.TabIndex = 7;
            this.picturebox_KetQua.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_XacNhanSuKien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(937, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 296);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các triệu chứng đã chọn";
            // 
            // dgv_XacNhanSuKien
            // 
            this.dgv_XacNhanSuKien.AllowUserToAddRows = false;
            this.dgv_XacNhanSuKien.AllowUserToDeleteRows = false;
            this.dgv_XacNhanSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XacNhanSuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mask1,
            this.tensukien1});
            this.dgv_XacNhanSuKien.Location = new System.Drawing.Point(12, 23);
            this.dgv_XacNhanSuKien.Name = "dgv_XacNhanSuKien";
            this.dgv_XacNhanSuKien.ReadOnly = true;
            this.dgv_XacNhanSuKien.RowHeadersWidth = 51;
            this.dgv_XacNhanSuKien.Size = new System.Drawing.Size(502, 264);
            this.dgv_XacNhanSuKien.TabIndex = 2;
            this.dgv_XacNhanSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_XacNhanSuKien_CellClick);
            // 
            // mask1
            // 
            this.mask1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mask1.DataPropertyName = "mask";
            this.mask1.HeaderText = "Mã triệu chứng";
            this.mask1.MinimumWidth = 6;
            this.mask1.Name = "mask1";
            this.mask1.ReadOnly = true;
            this.mask1.Width = 134;
            // 
            // tensukien1
            // 
            this.tensukien1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensukien1.DataPropertyName = "tensukien";
            this.tensukien1.HeaderText = "Tên triệu chứng";
            this.tensukien1.MinimumWidth = 6;
            this.tensukien1.Name = "tensukien1";
            this.tensukien1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SuKien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 651);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng các triệu chứng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_SuKien
            // 
            this.dgv_SuKien.AllowUserToAddRows = false;
            this.dgv_SuKien.AllowUserToDeleteRows = false;
            this.dgv_SuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mask,
            this.tensukien});
            this.dgv_SuKien.Location = new System.Drawing.Point(6, 23);
            this.dgv_SuKien.Name = "dgv_SuKien";
            this.dgv_SuKien.ReadOnly = true;
            this.dgv_SuKien.RowHeadersWidth = 51;
            this.dgv_SuKien.Size = new System.Drawing.Size(415, 622);
            this.dgv_SuKien.TabIndex = 1;
            this.dgv_SuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuKien_CellClick);
            // 
            // mask
            // 
            this.mask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mask.DataPropertyName = "mask";
            this.mask.HeaderText = "Mã triệu chứng";
            this.mask.MinimumWidth = 6;
            this.mask.Name = "mask";
            this.mask.ReadOnly = true;
            this.mask.Width = 134;
            // 
            // tensukien
            // 
            this.tensukien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensukien.DataPropertyName = "tensukien";
            this.tensukien.HeaderText = "Tên triệu chứng";
            this.tensukien.MinimumWidth = 6;
            this.tensukien.Name = "tensukien";
            this.tensukien.ReadOnly = true;
            // 
            // btn_SuyDien
            // 
            this.btn_SuyDien.BackColor = System.Drawing.Color.Tomato;
            this.btn_SuyDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuyDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuyDien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuyDien.Location = new System.Drawing.Point(1100, 365);
            this.btn_SuyDien.Name = "btn_SuyDien";
            this.btn_SuyDien.Size = new System.Drawing.Size(138, 48);
            this.btn_SuyDien.TabIndex = 27;
            this.btn_SuyDien.Text = "Chẩn Đoán";
            this.btn_SuyDien.UseVisualStyleBackColor = false;
            this.btn_SuyDien.Click += new System.EventHandler(this.btn_SuyDien_Click);
            // 
            // btn_XoaSuKien
            // 
            this.btn_XoaSuKien.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_XoaSuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaSuKien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaSuKien.Location = new System.Drawing.Point(654, 302);
            this.btn_XoaSuKien.Name = "btn_XoaSuKien";
            this.btn_XoaSuKien.Size = new System.Drawing.Size(110, 56);
            this.btn_XoaSuKien.TabIndex = 26;
            this.btn_XoaSuKien.Text = "Xóa Triệu Chứng";
            this.btn_XoaSuKien.UseVisualStyleBackColor = false;
            this.btn_XoaSuKien.Click += new System.EventHandler(this.btn_XoaSuKien_Click);
            // 
            // btn_ThemSuKien
            // 
            this.btn_ThemSuKien.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ThemSuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSuKien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemSuKien.Location = new System.Drawing.Point(499, 303);
            this.btn_ThemSuKien.Name = "btn_ThemSuKien";
            this.btn_ThemSuKien.Size = new System.Drawing.Size(110, 56);
            this.btn_ThemSuKien.TabIndex = 25;
            this.btn_ThemSuKien.Text = "Thêm Triệu Chứng";
            this.btn_ThemSuKien.UseVisualStyleBackColor = false;
            this.btn_ThemSuKien.Click += new System.EventHandler(this.btn_ThemSuKien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã triệu chứng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1112, 634);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 54);
            this.button4.TabIndex = 36;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtmask
            // 
            this.txtmask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmask.Location = new System.Drawing.Point(645, 158);
            this.txtmask.Name = "txtmask";
            this.txtmask.Size = new System.Drawing.Size(227, 26);
            this.txtmask.TabIndex = 37;
            this.txtmask.TextChanged += new System.EventHandler(this.txtmask_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên triệu chứng";
            // 
            // txttensk
            // 
            this.txttensk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensk.Location = new System.Drawing.Point(645, 215);
            this.txttensk.Name = "txttensk";
            this.txttensk.Size = new System.Drawing.Size(227, 26);
            this.txttensk.TabIndex = 37;
            this.txttensk.TextChanged += new System.EventHandler(this.txttensk_TextChanged);
            // 
            // ChanDoanBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1482, 690);
            this.Controls.Add(this.txttensk);
            this.Controls.Add(this.txtmask);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SuyDien);
            this.Controls.Add(this.btn_XoaSuKien);
            this.Controls.Add(this.btn_ThemSuKien);
            this.Name = "ChanDoanBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chẩn Đoán Bệnh";
            this.Load += new System.EventHandler(this.XuLy_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_KetQua)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XacNhanSuKien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listbox_KetQua;
        private System.Windows.Forms.PictureBox picturebox_KetQua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_XacNhanSuKien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SuKien;
        private System.Windows.Forms.Button btn_SuyDien;
        private System.Windows.Forms.Button btn_XoaSuKien;
        private System.Windows.Forms.Button btn_ThemSuKien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtmask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttensk;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensukien1;
    }
}