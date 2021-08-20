namespace BAITAPLON_HCG_NHOM08
{
    partial class SuyDien
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
            this.rtbSuyDien = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Các Bước Suy Diễn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbSuyDien
            // 
            this.rtbSuyDien.Location = new System.Drawing.Point(48, 94);
            this.rtbSuyDien.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSuyDien.Name = "rtbSuyDien";
            this.rtbSuyDien.Size = new System.Drawing.Size(741, 423);
            this.rtbSuyDien.TabIndex = 2;
            this.rtbSuyDien.Text = "";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(326, 533);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 53);
            this.button4.TabIndex = 12;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SuyDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(844, 588);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSuyDien);
            this.Name = "SuyDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuyDien";
            this.Load += new System.EventHandler(this.SuyDien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSuyDien;
        private System.Windows.Forms.Button button4;
    }
}