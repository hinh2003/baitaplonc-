namespace Quanlycanbo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btndonvi = new System.Windows.Forms.Button();
            this.btnluong = new System.Windows.Forms.Button();
            this.btntuoi = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbdonvi = new System.Windows.Forms.ComboBox();
            this.cbtrinhdo = new System.Windows.Forms.ComboBox();
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.cbluong = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(777, 400);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(167, 48);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm giáo viên";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(97, 389);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(167, 36);
            this.txtten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên:";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(97, 467);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(167, 36);
            this.txtsdt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trình độ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đơn vị:";
            // 
            // txttuoi
            // 
            this.txttuoi.Location = new System.Drawing.Point(97, 602);
            this.txttuoi.Multiline = true;
            this.txttuoi.Name = "txttuoi";
            this.txttuoi.Size = new System.Drawing.Size(167, 36);
            this.txttuoi.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lương:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 613);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tuổi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(777, 465);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(167, 48);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa Thông tin";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(777, 532);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(167, 48);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btndonvi
            // 
            this.btndonvi.Location = new System.Drawing.Point(983, 532);
            this.btndonvi.Name = "btndonvi";
            this.btndonvi.Size = new System.Drawing.Size(167, 48);
            this.btndonvi.TabIndex = 18;
            this.btndonvi.Text = "Danh sách đơn vị";
            this.btndonvi.UseVisualStyleBackColor = true;
            this.btndonvi.Click += new System.EventHandler(this.btndonvi_Click);
            // 
            // btnluong
            // 
            this.btnluong.Location = new System.Drawing.Point(983, 400);
            this.btnluong.Name = "btnluong";
            this.btnluong.Size = new System.Drawing.Size(167, 48);
            this.btnluong.TabIndex = 19;
            this.btnluong.Text = "Lương theo đơn vị";
            this.btnluong.UseVisualStyleBackColor = true;
            this.btnluong.Click += new System.EventHandler(this.btnluong_Click);
            // 
            // btntuoi
            // 
            this.btntuoi.Location = new System.Drawing.Point(983, 465);
            this.btntuoi.Name = "btntuoi";
            this.btntuoi.Size = new System.Drawing.Size(167, 48);
            this.btntuoi.TabIndex = 20;
            this.btntuoi.Text = "Danh sách tuổi hưu";
            this.btntuoi.UseVisualStyleBackColor = true;
            this.btntuoi.Click += new System.EventHandler(this.btntuoi_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(97, 545);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(167, 36);
            this.txtemail.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email:";
            // 
            // cbdonvi
            // 
            this.cbdonvi.FormattingEnabled = true;
            this.cbdonvi.Location = new System.Drawing.Point(514, 400);
            this.cbdonvi.Name = "cbdonvi";
            this.cbdonvi.Size = new System.Drawing.Size(165, 24);
            this.cbdonvi.TabIndex = 23;
            // 
            // cbtrinhdo
            // 
            this.cbtrinhdo.FormattingEnabled = true;
            this.cbtrinhdo.Location = new System.Drawing.Point(514, 478);
            this.cbtrinhdo.Name = "cbtrinhdo";
            this.cbtrinhdo.Size = new System.Drawing.Size(165, 24);
            this.cbtrinhdo.TabIndex = 24;
            // 
            // cbchucvu
            // 
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(514, 549);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(165, 24);
            this.cbchucvu.TabIndex = 25;
            // 
            // cbluong
            // 
            this.cbluong.FormattingEnabled = true;
            this.cbluong.Location = new System.Drawing.Point(514, 614);
            this.cbluong.Name = "cbluong";
            this.cbluong.Size = new System.Drawing.Size(165, 24);
            this.cbluong.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 48);
            this.button2.TabIndex = 28;
            this.button2.Text = "Danh sách theo Chức vụ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(777, 332);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(167, 44);
            this.txttimkiem.TabIndex = 29;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(983, 328);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(167, 48);
            this.btntim.TabIndex = 30;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(777, 664);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 48);
            this.button3.TabIndex = 31;
            this.button3.Text = "Hiển Thị";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(983, 664);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 48);
            this.button4.TabIndex = 32;
            this.button4.Text = "Sắp xếp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 724);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbluong);
            this.Controls.Add(this.cbchucvu);
            this.Controls.Add(this.cbtrinhdo);
            this.Controls.Add(this.cbdonvi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btntuoi);
            this.Controls.Add(this.btnluong);
            this.Controls.Add(this.btndonvi);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndonvi;
        private System.Windows.Forms.Button btnluong;
        private System.Windows.Forms.Button btntuoi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbdonvi;
        private System.Windows.Forms.ComboBox cbtrinhdo;
        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.ComboBox cbluong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

