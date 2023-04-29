namespace AI_CNPM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            this.rtb_Xuat = new System.Windows.Forms.RichTextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.Goi_Y = new System.Windows.Forms.ListBox();
            this.btn_dong_y = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Nhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nhap.Location = new System.Drawing.Point(132, 93);
            this.txt_Nhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Nhap.Multiline = true;
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(583, 37);
            this.txt_Nhap.TabIndex = 0;
            this.txt_Nhap.TextChanged += new System.EventHandler(this.txt_Nhap_TextChanged);
            this.txt_Nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nhap_KeyPress);
            // 
            // rtb_Xuat
            // 
            this.rtb_Xuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_Xuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Xuat.Location = new System.Drawing.Point(34, 250);
            this.rtb_Xuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtb_Xuat.Name = "rtb_Xuat";
            this.rtb_Xuat.Size = new System.Drawing.Size(817, 296);
            this.rtb_Xuat.TabIndex = 1;
            this.rtb_Xuat.Text = "";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Tim.BackColor = System.Drawing.Color.Yellow;
            this.btn_Tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(730, 93);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(121, 37);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm Kiếm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // Goi_Y
            // 
            this.Goi_Y.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Goi_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goi_Y.FormattingEnabled = true;
            this.Goi_Y.ItemHeight = 20;
            this.Goi_Y.Location = new System.Drawing.Point(132, 142);
            this.Goi_Y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Goi_Y.Name = "Goi_Y";
            this.Goi_Y.Size = new System.Drawing.Size(720, 84);
            this.Goi_Y.TabIndex = 6;
            this.Goi_Y.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Goi_Y_MouseDoubleClick);
            // 
            // btn_dong_y
            // 
            this.btn_dong_y.BackColor = System.Drawing.Color.Yellow;
            this.btn_dong_y.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dong_y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dong_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong_y.ForeColor = System.Drawing.Color.Black;
            this.btn_dong_y.Location = new System.Drawing.Point(416, 551);
            this.btn_dong_y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dong_y.Name = "btn_dong_y";
            this.btn_dong_y.Size = new System.Drawing.Size(121, 37);
            this.btn_dong_y.TabIndex = 7;
            this.btn_dong_y.Text = "Đồng Ý";
            this.btn_dong_y.UseVisualStyleBackColor = false;
            this.btn_dong_y.Click += new System.EventHandler(this.btn_dong_y_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "HỆ THỐNG TRA CỨU PHÁP LUẬT VỀ ĐẤT ĐAI";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(76, 142);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 93);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Tim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 595);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dong_y);
            this.Controls.Add(this.Goi_Y);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.rtb_Xuat);
            this.Controls.Add(this.txt_Nhap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HỆ THỐNG TRA CỨU PHÁP LUẬT VỀ ĐẤT ĐAI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nhap;
        private System.Windows.Forms.RichTextBox rtb_Xuat;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.ListBox Goi_Y;
        private System.Windows.Forms.Button btn_dong_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

