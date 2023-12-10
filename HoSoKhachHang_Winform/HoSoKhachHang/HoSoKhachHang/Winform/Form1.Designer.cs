namespace HoSoKhachHang
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtTKH = new System.Windows.Forms.TextBox();
            this.txtEml = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNoR = new System.Windows.Forms.TextBox();
            this.txtNoP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTTP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpNhanPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpTraPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv1.Location = new System.Drawing.Point(630, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(1294, 1024);
            this.dgv1.TabIndex = 0;
            // 
            // btnAddCus
            // 
            this.btnAddCus.Location = new System.Drawing.Point(198, 952);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(180, 47);
            this.btnAddCus.TabIndex = 1;
            this.btnAddCus.Text = "Thêm khách hàng";
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(224, 142);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(308, 26);
            this.txtMDP.TabIndex = 2;
            // 
            // txtTKH
            // 
            this.txtTKH.Location = new System.Drawing.Point(224, 194);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(308, 26);
            this.txtTKH.TabIndex = 3;
            // 
            // txtEml
            // 
            this.txtEml.Location = new System.Drawing.Point(224, 249);
            this.txtEml.Name = "txtEml";
            this.txtEml.Size = new System.Drawing.Size(308, 26);
            this.txtEml.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(224, 315);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(308, 26);
            this.txtSDT.TabIndex = 6;
            // 
            // txtNoR
            // 
            this.txtNoR.Location = new System.Drawing.Point(224, 737);
            this.txtNoR.Name = "txtNoR";
            this.txtNoR.Size = new System.Drawing.Size(308, 26);
            this.txtNoR.TabIndex = 9;
            // 
            // txtNoP
            // 
            this.txtNoP.Location = new System.Drawing.Point(224, 793);
            this.txtNoP.Name = "txtNoP";
            this.txtNoP.Size = new System.Drawing.Size(308, 26);
            this.txtNoP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã đặt phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số điện thoại";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.ItemHeight = 30;
            this.cbGender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(224, 370);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(308, 36);
            this.cbGender.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Loại phòng";
            // 
            // cbLP
            // 
            this.cbLP.BackColor = System.Drawing.Color.Transparent;
            this.cbLP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLP.ForeColor = System.Drawing.Color.Black;
            this.cbLP.ItemHeight = 30;
            this.cbLP.Items.AddRange(new object[] {
            "Standard",
            "Deluxe "});
            this.cbLP.Location = new System.Drawing.Point(224, 446);
            this.cbLP.Name = "cbLP";
            this.cbLP.Size = new System.Drawing.Size(308, 36);
            this.cbLP.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày đặt phòng";
            // 
            // dtpDay
            // 
            this.dtpDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.dtpDay.Checked = true;
            this.dtpDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDay.ForeColor = System.Drawing.Color.White;
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDay.Location = new System.Drawing.Point(224, 512);
            this.dtpDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(308, 46);
            this.dtpDay.TabIndex = 21;
            this.dtpDay.Value = new System.DateTime(2023, 12, 9, 9, 18, 58, 382);
            this.dtpDay.ValueChanged += new System.EventHandler(this.dtpDay_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 794);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số lượng người";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 741);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Số lượng phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 842);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Trạng thái phòng";
            // 
            // cbTTP
            // 
            this.cbTTP.BackColor = System.Drawing.Color.Transparent;
            this.cbTTP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTTP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTTP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTTP.ForeColor = System.Drawing.Color.Black;
            this.cbTTP.ItemHeight = 30;
            this.cbTTP.Items.AddRange(new object[] {
            "Da Thanh Toan",
            "Chua Thanh Toan"});
            this.cbTTP.Location = new System.Drawing.Point(224, 842);
            this.cbTTP.Name = "cbTTP";
            this.cbTTP.Size = new System.Drawing.Size(308, 36);
            this.cbTTP.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(180, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(274, 45);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cập nhật hồ sơ";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(12, 12);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(25, 25);
            this.guna2CircleButton2.TabIndex = 28;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 34);
            this.label12.TabIndex = 27;
            this.label12.Text = "HOME";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 593);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ngày nhận phòng";
            // 
            // dtpNhanPhong
            // 
            this.dtpNhanPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.dtpNhanPhong.Checked = true;
            this.dtpNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNhanPhong.ForeColor = System.Drawing.Color.White;
            this.dtpNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNhanPhong.Location = new System.Drawing.Point(224, 581);
            this.dtpNhanPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNhanPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNhanPhong.Name = "dtpNhanPhong";
            this.dtpNhanPhong.Size = new System.Drawing.Size(308, 46);
            this.dtpNhanPhong.TabIndex = 30;
            this.dtpNhanPhong.Value = new System.DateTime(2023, 12, 9, 9, 18, 58, 382);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 663);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "Ngày trả phòng";
            // 
            // dtpTraPhong
            // 
            this.dtpTraPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.dtpTraPhong.Checked = true;
            this.dtpTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTraPhong.ForeColor = System.Drawing.Color.White;
            this.dtpTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTraPhong.Location = new System.Drawing.Point(224, 651);
            this.dtpTraPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTraPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTraPhong.Name = "dtpTraPhong";
            this.dtpTraPhong.Size = new System.Drawing.Size(308, 46);
            this.dtpTraPhong.TabIndex = 32;
            this.dtpTraPhong.Value = new System.DateTime(2023, 12, 9, 9, 18, 58, 382);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1024);
            this.Controls.Add(this.dtpTraPhong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpNhanPhong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTTP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbLP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoP);
            this.Controls.Add(this.txtNoR);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEml);
            this.Controls.Add(this.txtTKH);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "No.8 Holtel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.TextBox txtTKH;
        private System.Windows.Forms.TextBox txtEml;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNoR;
        private System.Windows.Forms.TextBox txtNoP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbLP;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cbTTP;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNhanPhong;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTraPhong;
    }
}

