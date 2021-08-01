namespace NATO.GUI
{
    partial class QuanTriTaiKhoan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kLMQSDataSet1 = new NATO.KLMQSDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kLMQSDataSet = new NATO.KLMQSDataSet();
            this.kLMQSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new NATO.KLMQSDataSet1TableAdapters.TAIKHOANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLMQSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLMQSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLMQSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1653, 743);
            this.dataGridView1.TabIndex = 0;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.kLMQSDataSet1;
            // 
            // kLMQSDataSet1
            // 
            this.kLMQSDataSet1.DataSetName = "KLMQSDataSet1";
            this.kLMQSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 42);
            this.textBox1.TabIndex = 2;
            // 
            // kLMQSDataSet
            // 
            this.kLMQSDataSet.DataSetName = "KLMQSDataSet";
            this.kLMQSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kLMQSDataSetBindingSource
            // 
            this.kLMQSDataSetBindingSource.DataSource = this.kLMQSDataSet;
            this.kLMQSDataSetBindingSource.Position = 0;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // QuanTriTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanTriTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanTriTaiKhoan";
            this.Load += new System.EventHandler(this.QuanTriTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLMQSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLMQSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLMQSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource kLMQSDataSetBindingSource;
        private KLMQSDataSet kLMQSDataSet;
        private KLMQSDataSet1 kLMQSDataSet1;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private KLMQSDataSet1TableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
    }
}