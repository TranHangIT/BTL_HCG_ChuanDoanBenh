namespace BAITAPLON_HCG_NHOM08
{
    partial class Form_Rules
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
            this.txt_VePhai = new System.Windows.Forms.TextBox();
            this.txt_VeTrai = new System.Windows.Forms.TextBox();
            this.txt_MaLuat = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dgv_Luat = new System.Windows.Forms.DataGridView();
            this.MaLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeTrai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VePhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luat)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_VePhai
            // 
            this.txt_VePhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VePhai.Location = new System.Drawing.Point(253, 192);
            this.txt_VePhai.Name = "txt_VePhai";
            this.txt_VePhai.Size = new System.Drawing.Size(198, 26);
            this.txt_VePhai.TabIndex = 30;
            // 
            // txt_VeTrai
            // 
            this.txt_VeTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VeTrai.Location = new System.Drawing.Point(253, 144);
            this.txt_VeTrai.Name = "txt_VeTrai";
            this.txt_VeTrai.Size = new System.Drawing.Size(195, 26);
            this.txt_VeTrai.TabIndex = 29;
            // 
            // txt_MaLuat
            // 
            this.txt_MaLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLuat.Location = new System.Drawing.Point(253, 97);
            this.txt_MaLuat.Name = "txt_MaLuat";
            this.txt_MaLuat.Size = new System.Drawing.Size(198, 26);
            this.txt_MaLuat.TabIndex = 28;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(509, 101);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(112, 47);
            this.btn_Them.TabIndex = 27;
            this.btn_Them.Text = "Thêm Luật";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(509, 168);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(112, 50);
            this.btn_Sua.TabIndex = 26;
            this.btn_Sua.Text = "Sửa Luật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dgv_Luat
            // 
            this.dgv_Luat.AllowUserToAddRows = false;
            this.dgv_Luat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Luat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Luat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Luat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuat,
            this.VeTrai,
            this.VePhai});
            this.dgv_Luat.Location = new System.Drawing.Point(143, 267);
            this.dgv_Luat.Name = "dgv_Luat";
            this.dgv_Luat.ReadOnly = true;
            this.dgv_Luat.RowHeadersWidth = 51;
            this.dgv_Luat.Size = new System.Drawing.Size(571, 284);
            this.dgv_Luat.TabIndex = 24;
            this.dgv_Luat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Luat_CellClick);
            // 
            // MaLuat
            // 
            this.MaLuat.DataPropertyName = "maluat";
            this.MaLuat.HeaderText = "Mã luật";
            this.MaLuat.MinimumWidth = 6;
            this.MaLuat.Name = "MaLuat";
            this.MaLuat.ReadOnly = true;
            this.MaLuat.Width = 150;
            // 
            // VeTrai
            // 
            this.VeTrai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VeTrai.DataPropertyName = "vetrai";
            this.VeTrai.HeaderText = "Vế trái";
            this.VeTrai.MinimumWidth = 6;
            this.VeTrai.Name = "VeTrai";
            this.VeTrai.ReadOnly = true;
            // 
            // VePhai
            // 
            this.VePhai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VePhai.DataPropertyName = "vephai";
            this.VePhai.HeaderText = "Vế phải";
            this.VePhai.MinimumWidth = 6;
            this.VePhai.Name = "VePhai";
            this.VePhai.ReadOnly = true;
            this.VePhai.Width = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Vế Trái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Vế Phải";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã Luật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(350, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tập Luật";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(642, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(642, 101);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(109, 47);
            this.btn_Xoa.TabIndex = 25;
            this.btn_Xoa.Text = "Xóa  Luật";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form_Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(862, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_VePhai);
            this.Controls.Add(this.txt_VeTrai);
            this.Controls.Add(this.txt_MaLuat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dgv_Luat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            this.Load += new System.EventHandler(this.Form_Rules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_VePhai;
        private System.Windows.Forms.TextBox txt_VeTrai;
        private System.Windows.Forms.TextBox txt_MaLuat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dgv_Luat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeTrai;
        private System.Windows.Forms.DataGridViewTextBoxColumn VePhai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Xoa;
    }
}