namespace NATO.GUI
{
    partial class ListItemGioHang
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbChitiet = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbSoluong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(182, 25);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(126, 20);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Ten San Pham";
            // 
            // lbChitiet
            // 
            this.lbChitiet.AutoSize = true;
            this.lbChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChitiet.Location = new System.Drawing.Point(189, 60);
            this.lbChitiet.Name = "lbChitiet";
            this.lbChitiet.Size = new System.Drawing.Size(106, 13);
            this.lbChitiet.TabIndex = 4;
            this.lbChitiet.Text = "chi tiet chi tiet chi tiet";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(189, 96);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(21, 13);
            this.lbGia.TabIndex = 5;
            this.lbGia.Text = "gia";
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Location = new System.Drawing.Point(189, 139);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(47, 13);
            this.lbSoluong.TabIndex = 6;
            this.lbSoluong.Text = "so luong";
            // 
            // ListItemGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbSoluong);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbChitiet);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListItemGioHang";
            this.Size = new System.Drawing.Size(550, 160);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbChitiet;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbSoluong;
    }
}
