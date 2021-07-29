namespace NATO.GUI
{
    partial class ListItem
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
            this.lbDM = new System.Windows.Forms.Label();
            this.lbChitiet = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(15, 242);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(126, 20);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Ten San Pham";
            // 
            // lbDM
            // 
            this.lbDM.AutoSize = true;
            this.lbDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDM.Location = new System.Drawing.Point(19, 278);
            this.lbDM.Name = "lbDM";
            this.lbDM.Size = new System.Drawing.Size(76, 16);
            this.lbDM.TabIndex = 2;
            this.lbDM.Text = "Danh Muc";
            // 
            // lbChitiet
            // 
            this.lbChitiet.AutoSize = true;
            this.lbChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChitiet.Location = new System.Drawing.Point(22, 318);
            this.lbChitiet.Name = "lbChitiet";
            this.lbChitiet.Size = new System.Drawing.Size(106, 13);
            this.lbChitiet.TabIndex = 3;
            this.lbChitiet.Text = "chi tiet chi tiet chi tiet";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(19, 357);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(21, 13);
            this.lbGia.TabIndex = 4;
            this.lbGia.Text = "gia";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(146, 337);
            this.txtSL.Multiline = true;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 33);
            this.txtSL.TabIndex = 6;
            this.txtSL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbChitiet);
            this.Controls.Add(this.lbDM);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(302, 385);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbDM;
        private System.Windows.Forms.Label lbChitiet;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSL;
    }
}
