namespace BAITAPLON_HCG_NHOM08
{
    partial class Form_Events
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenSuKien = new System.Windows.Forms.TextBox();
            this.txt_MaSuKien = new System.Windows.Forms.TextBox();
            this.dgv_SuKien = new System.Windows.Forms.DataGridView();
            this.masukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 35;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(334, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 42);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sự Kiện";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(492, 124);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(97, 41);
            this.btn_Sua.TabIndex = 32;
            this.btn_Sua.Text = "Sửa  ";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(492, 77);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(97, 41);
            this.btn_Them.TabIndex = 31;
            this.btn_Them.Text = "Thêm  ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên sự kiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã sự kiện";
            // 
            // txt_TenSuKien
            // 
            this.txt_TenSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSuKien.Location = new System.Drawing.Point(227, 142);
            this.txt_TenSuKien.Name = "txt_TenSuKien";
            this.txt_TenSuKien.Size = new System.Drawing.Size(238, 26);
            this.txt_TenSuKien.TabIndex = 28;
            // 
            // txt_MaSuKien
            // 
            this.txt_MaSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSuKien.Location = new System.Drawing.Point(227, 84);
            this.txt_MaSuKien.Name = "txt_MaSuKien";
            this.txt_MaSuKien.Size = new System.Drawing.Size(238, 26);
            this.txt_MaSuKien.TabIndex = 27;
            // 
            // dgv_SuKien
            // 
            this.dgv_SuKien.AllowUserToAddRows = false;
            this.dgv_SuKien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SuKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masukien,
            this.tensukien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SuKien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SuKien.Location = new System.Drawing.Point(121, 206);
            this.dgv_SuKien.Name = "dgv_SuKien";
            this.dgv_SuKien.ReadOnly = true;
            this.dgv_SuKien.RowHeadersWidth = 51;
            this.dgv_SuKien.Size = new System.Drawing.Size(549, 318);
            this.dgv_SuKien.TabIndex = 26;
            this.dgv_SuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuKien_CellClick);
            this.dgv_SuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuKien_CellContentClick);
            // 
            // masukien
            // 
            this.masukien.DataPropertyName = "mask";
            this.masukien.HeaderText = "Mã";
            this.masukien.MinimumWidth = 6;
            this.masukien.Name = "masukien";
            this.masukien.ReadOnly = true;
            this.masukien.Width = 60;
            // 
            // tensukien
            // 
            this.tensukien.DataPropertyName = "tensukien";
            this.tensukien.HeaderText = "Tên sự kiện";
            this.tensukien.MinimumWidth = 6;
            this.tensukien.Name = "tensukien";
            this.tensukien.ReadOnly = true;
            this.tensukien.Width = 500;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(609, 78);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(97, 39);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa  ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(776, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenSuKien);
            this.Controls.Add(this.txt_MaSuKien);
            this.Controls.Add(this.dgv_SuKien);
            this.Name = "Form_Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Form_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenSuKien;
        private System.Windows.Forms.TextBox txt_MaSuKien;
        private System.Windows.Forms.DataGridView dgv_SuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensukien;
        private System.Windows.Forms.Button btn_Xoa;
    }
}