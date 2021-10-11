namespace detai.GUI
{
    partial class QUANLYDIEMTHISINH
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
            this.TXTDIEMTOAN = new System.Windows.Forms.TextBox();
            this.TXTDIEMNGUVAN = new System.Windows.Forms.TextBox();
            this.TXTDIEMANHVAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LVWDSTHISINH = new System.Windows.Forms.ListView();
            this.MATS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HOTEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYSINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIOITINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIACHI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNHAPDIEM = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TXTMATS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHOTEN = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTDIEMTOAN
            // 
            this.TXTDIEMTOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDIEMTOAN.Location = new System.Drawing.Point(193, 100);
            this.TXTDIEMTOAN.Name = "TXTDIEMTOAN";
            this.TXTDIEMTOAN.Size = new System.Drawing.Size(100, 22);
            this.TXTDIEMTOAN.TabIndex = 0;
            // 
            // TXTDIEMNGUVAN
            // 
            this.TXTDIEMNGUVAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDIEMNGUVAN.Location = new System.Drawing.Point(193, 150);
            this.TXTDIEMNGUVAN.Name = "TXTDIEMNGUVAN";
            this.TXTDIEMNGUVAN.Size = new System.Drawing.Size(100, 22);
            this.TXTDIEMNGUVAN.TabIndex = 0;
            // 
            // TXTDIEMANHVAN
            // 
            this.TXTDIEMANHVAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDIEMANHVAN.Location = new System.Drawing.Point(193, 199);
            this.TXTDIEMANHVAN.Name = "TXTDIEMANHVAN";
            this.TXTDIEMANHVAN.Size = new System.Drawing.Size(100, 22);
            this.TXTDIEMANHVAN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm Ngữ Văn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm Anh Văn";
            // 
            // LVWDSTHISINH
            // 
            this.LVWDSTHISINH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MATS,
            this.HOTEN,
            this.NGAYSINH,
            this.GIOITINH,
            this.DIACHI});
            this.LVWDSTHISINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVWDSTHISINH.FullRowSelect = true;
            this.LVWDSTHISINH.GridLines = true;
            this.LVWDSTHISINH.HideSelection = false;
            this.LVWDSTHISINH.Location = new System.Drawing.Point(449, 12);
            this.LVWDSTHISINH.Name = "LVWDSTHISINH";
            this.LVWDSTHISINH.Size = new System.Drawing.Size(800, 283);
            this.LVWDSTHISINH.TabIndex = 2;
            this.LVWDSTHISINH.UseCompatibleStateImageBehavior = false;
            this.LVWDSTHISINH.View = System.Windows.Forms.View.Details;
            this.LVWDSTHISINH.SelectedIndexChanged += new System.EventHandler(this.LVWDSTHISINH_SelectedIndexChanged);
            this.LVWDSTHISINH.Click += new System.EventHandler(this.LVWDSTHISINH_Click);
            // 
            // MATS
            // 
            this.MATS.Text = "Mã Thí Sinh";
            this.MATS.Width = 101;
            // 
            // HOTEN
            // 
            this.HOTEN.Text = "Họ Tên";
            this.HOTEN.Width = 163;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.Text = "Ngày Sinh";
            this.NGAYSINH.Width = 98;
            // 
            // GIOITINH
            // 
            this.GIOITINH.Text = "Giới Tính";
            this.GIOITINH.Width = 73;
            // 
            // DIACHI
            // 
            this.DIACHI.Text = "Địa Chỉ";
            this.DIACHI.Width = 292;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Thí Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 4;
            // 
            // BTNHAPDIEM
            // 
            this.BTNHAPDIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHAPDIEM.Location = new System.Drawing.Point(82, 261);
            this.BTNHAPDIEM.Name = "BTNHAPDIEM";
            this.BTNHAPDIEM.Size = new System.Drawing.Size(104, 43);
            this.BTNHAPDIEM.TabIndex = 6;
            this.BTNHAPDIEM.Text = "NHẬP ĐIỂM";
            this.BTNHAPDIEM.UseVisualStyleBackColor = true;
            this.BTNHAPDIEM.Click += new System.EventHandler(this.BTNHAPDIEM_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(258, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "XÓA ĐIỂM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TXTMATS
            // 
            this.TXTMATS.AutoSize = true;
            this.TXTMATS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMATS.Location = new System.Drawing.Point(183, 27);
            this.TXTMATS.Name = "TXTMATS";
            this.TXTMATS.Size = new System.Drawing.Size(110, 17);
            this.TXTMATS.TabIndex = 7;
            this.TXTMATS.Text = "Chọn Thí Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Họ Tên ";
            // 
            // lbHOTEN
            // 
            this.lbHOTEN.AutoSize = true;
            this.lbHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHOTEN.Location = new System.Drawing.Point(183, 62);
            this.lbHOTEN.Name = "lbHOTEN";
            this.lbHOTEN.Size = new System.Drawing.Size(110, 17);
            this.lbHOTEN.TabIndex = 9;
            this.lbHOTEN.Text = "Chọn Thí Sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbHOTEN);
            this.groupBox1.Controls.Add(this.TXTDIEMTOAN);
            this.groupBox1.Controls.Add(this.TXTDIEMNGUVAN);
            this.groupBox1.Controls.Add(this.TXTMATS);
            this.groupBox1.Controls.Add(this.TXTDIEMANHVAN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 242);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Điểm Thí Sinh";
            // 
            // QUANLYDIEMTHISINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTNHAPDIEM);
            this.Controls.Add(this.LVWDSTHISINH);
            this.Name = "QUANLYDIEMTHISINH";
            this.Text = "QUANLYDIEMTHISINH";
            this.Load += new System.EventHandler(this.QUANLYDIEMTHISINH_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QUANLYDIEMTHISINH_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXTDIEMTOAN;
        private System.Windows.Forms.TextBox TXTDIEMNGUVAN;
        private System.Windows.Forms.TextBox TXTDIEMANHVAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView LVWDSTHISINH;
        private System.Windows.Forms.ColumnHeader MATS;
        private System.Windows.Forms.ColumnHeader HOTEN;
        private System.Windows.Forms.ColumnHeader NGAYSINH;
        private System.Windows.Forms.ColumnHeader GIOITINH;
        private System.Windows.Forms.ColumnHeader DIACHI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNHAPDIEM;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label TXTMATS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHOTEN;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}