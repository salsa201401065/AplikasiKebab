
namespace UAS_PV3_047_065
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_id = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnopendownload = new System.Windows.Forms.Button();
            this.btnsavedownload = new System.Windows.Forms.Button();
            this.btnopenupload = new System.Windows.Forms.Button();
            this.btnsaveupload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tes Download File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tes Upload File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Dari Database ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input Untuk Diload";
            // 
            // Input_id
            // 
            this.Input_id.Location = new System.Drawing.Point(597, 235);
            this.Input_id.Name = "Input_id";
            this.Input_id.Size = new System.Drawing.Size(70, 22);
            this.Input_id.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 174);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(470, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 161);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 183);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnopendownload
            // 
            this.btnopendownload.Location = new System.Drawing.Point(470, 264);
            this.btnopendownload.Name = "btnopendownload";
            this.btnopendownload.Size = new System.Drawing.Size(79, 47);
            this.btnopendownload.TabIndex = 8;
            this.btnopendownload.Text = "Open Download";
            this.btnopendownload.UseVisualStyleBackColor = true;
            this.btnopendownload.Click += new System.EventHandler(this.btnopendownload_Click);
            // 
            // btnsavedownload
            // 
            this.btnsavedownload.Location = new System.Drawing.Point(587, 264);
            this.btnsavedownload.Name = "btnsavedownload";
            this.btnsavedownload.Size = new System.Drawing.Size(80, 47);
            this.btnsavedownload.TabIndex = 9;
            this.btnsavedownload.Text = "Save Download";
            this.btnsavedownload.UseVisualStyleBackColor = true;
            this.btnsavedownload.Click += new System.EventHandler(this.btnsavedownload_Click);
            // 
            // btnopenupload
            // 
            this.btnopenupload.Location = new System.Drawing.Point(28, 264);
            this.btnopenupload.Name = "btnopenupload";
            this.btnopenupload.Size = new System.Drawing.Size(75, 47);
            this.btnopenupload.TabIndex = 10;
            this.btnopenupload.Text = "Open Upload";
            this.btnopenupload.UseVisualStyleBackColor = true;
            this.btnopenupload.Click += new System.EventHandler(this.btnopenupload_Click);
            // 
            // btnsaveupload
            // 
            this.btnsaveupload.Location = new System.Drawing.Point(127, 264);
            this.btnsaveupload.Name = "btnsaveupload";
            this.btnsaveupload.Size = new System.Drawing.Size(75, 47);
            this.btnsaveupload.TabIndex = 11;
            this.btnsaveupload.Text = "Save Upload";
            this.btnsaveupload.UseVisualStyleBackColor = true;
            this.btnsaveupload.Click += new System.EventHandler(this.btnsaveupload_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.btnsaveupload);
            this.Controls.Add(this.btnopenupload);
            this.Controls.Add(this.btnsavedownload);
            this.Controls.Add(this.btnopendownload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Input_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Upload and Download dari DB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input_id;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnopendownload;
        private System.Windows.Forms.Button btnsavedownload;
        private System.Windows.Forms.Button btnopenupload;
        private System.Windows.Forms.Button btnsaveupload;
    }
}