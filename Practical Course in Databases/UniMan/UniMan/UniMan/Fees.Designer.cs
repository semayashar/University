namespace UniMan
{
    partial class Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label14 = new Label();
            fees_Reset = new Button();
            fees_Pay = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            fees_Period = new ComboBox();
            label15 = new Label();
            label10 = new Label();
            fees_SIDcb = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            fees_Amount = new TextBox();
            fees_DNtb = new TextBox();
            fees_SNtb = new TextBox();
            panel3 = new Panel();
            label16 = new Label();
            salary_Period = new DateTimePicker();
            label17 = new Label();
            salary_PIDcb = new ComboBox();
            label19 = new Label();
            label20 = new Label();
            salary_Amount = new TextBox();
            salary_PNtb = new TextBox();
            label22 = new Label();
            salary_Reset = new Button();
            salary_Pay = new Button();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            colBtn = new Label();
            salaryBtn = new Label();
            feesBtn = new Label();
            courBtn = new Label();
            profBtn = new Label();
            studBtn = new Label();
            depBtn = new Label();
            homeBtn = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            FeesDGV = new DataGridView();
            SalaryDGV = new DataGridView();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Julius Sans One", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(128, 11);
            label14.Name = "label14";
            label14.Size = new Size(45, 18);
            label14.TabIndex = 26;
            label14.Text = "Fees";
            // 
            // fees_Reset
            // 
            fees_Reset.Cursor = Cursors.Hand;
            fees_Reset.Location = new Point(181, 222);
            fees_Reset.Name = "fees_Reset";
            fees_Reset.Size = new Size(111, 31);
            fees_Reset.TabIndex = 120;
            fees_Reset.Text = "Reset";
            fees_Reset.UseVisualStyleBackColor = true;
            // 
            // fees_Pay
            // 
            fees_Pay.Cursor = Cursors.Hand;
            fees_Pay.Location = new Point(21, 223);
            fees_Pay.Name = "fees_Pay";
            fees_Pay.Size = new Size(111, 31);
            fees_Pay.TabIndex = 119;
            fees_Pay.Text = "Pay";
            fees_Pay.UseVisualStyleBackColor = true;
            fees_Pay.Click += fees_Pay_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(182, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 545);
            panel1.TabIndex = 169;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(fees_Period);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(fees_SIDcb);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(fees_Amount);
            panel5.Controls.Add(fees_DNtb);
            panel5.Controls.Add(fees_SNtb);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(fees_Reset);
            panel5.Controls.Add(fees_Pay);
            panel5.Location = new Point(211, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(320, 279);
            panel5.TabIndex = 188;
            // 
            // fees_Period
            // 
            fees_Period.Cursor = Cursors.Hand;
            fees_Period.FormattingEnabled = true;
            fees_Period.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            fees_Period.Location = new Point(160, 137);
            fees_Period.Name = "fees_Period";
            fees_Period.Size = new Size(132, 23);
            fees_Period.TabIndex = 170;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Julius Sans One", 9.75F);
            label15.Location = new Point(21, 144);
            label15.Name = "label15";
            label15.Size = new Size(54, 14);
            label15.TabIndex = 169;
            label15.Text = "Period";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Julius Sans One", 9.75F);
            label10.Location = new Point(21, 54);
            label10.Name = "label10";
            label10.Size = new Size(83, 14);
            label10.TabIndex = 167;
            label10.Text = "Student id";
            // 
            // fees_SIDcb
            // 
            fees_SIDcb.Cursor = Cursors.Hand;
            fees_SIDcb.FormattingEnabled = true;
            fees_SIDcb.Location = new Point(160, 50);
            fees_SIDcb.Name = "fees_SIDcb";
            fees_SIDcb.Size = new Size(132, 23);
            fees_SIDcb.TabIndex = 166;
            fees_SIDcb.SelectionChangeCommitted += fees_SIDcb_SelectionChangeCommitted;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Julius Sans One", 9.75F);
            label13.Location = new Point(19, 117);
            label13.Name = "label13";
            label13.Size = new Size(129, 14);
            label13.TabIndex = 165;
            label13.Text = "Department Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Julius Sans One", 9.75F);
            label12.Location = new Point(21, 170);
            label12.Name = "label12";
            label12.Size = new Size(65, 14);
            label12.TabIndex = 164;
            label12.Text = "Amount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Julius Sans One", 9.75F);
            label11.Location = new Point(21, 86);
            label11.Name = "label11";
            label11.Size = new Size(105, 14);
            label11.TabIndex = 163;
            label11.Text = "Student Name";
            // 
            // fees_Amount
            // 
            fees_Amount.Cursor = Cursors.Hand;
            fees_Amount.Location = new Point(160, 166);
            fees_Amount.Name = "fees_Amount";
            fees_Amount.Size = new Size(132, 23);
            fees_Amount.TabIndex = 162;
            // 
            // fees_DNtb
            // 
            fees_DNtb.Cursor = Cursors.Hand;
            fees_DNtb.Enabled = false;
            fees_DNtb.Location = new Point(160, 108);
            fees_DNtb.Name = "fees_DNtb";
            fees_DNtb.Size = new Size(132, 23);
            fees_DNtb.TabIndex = 161;
            // 
            // fees_SNtb
            // 
            fees_SNtb.Cursor = Cursors.Hand;
            fees_SNtb.Enabled = false;
            fees_SNtb.Location = new Point(160, 79);
            fees_SNtb.Name = "fees_SNtb";
            fees_SNtb.Size = new Size(132, 23);
            fees_SNtb.TabIndex = 160;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label16);
            panel3.Controls.Add(salary_Period);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(salary_PIDcb);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(salary_Amount);
            panel3.Controls.Add(salary_PNtb);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(salary_Reset);
            panel3.Controls.Add(salary_Pay);
            panel3.Location = new Point(537, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 279);
            panel3.TabIndex = 189;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Julius Sans One", 9.75F);
            label16.Location = new Point(21, 118);
            label16.Name = "label16";
            label16.Size = new Size(54, 14);
            label16.TabIndex = 169;
            label16.Text = "Period";
            // 
            // salary_Period
            // 
            salary_Period.Cursor = Cursors.Hand;
            salary_Period.Location = new Point(160, 111);
            salary_Period.Name = "salary_Period";
            salary_Period.Size = new Size(132, 23);
            salary_Period.TabIndex = 168;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Julius Sans One", 9.75F);
            label17.Location = new Point(21, 54);
            label17.Name = "label17";
            label17.Size = new Size(97, 14);
            label17.TabIndex = 167;
            label17.Text = "Professor id";
            // 
            // salary_PIDcb
            // 
            salary_PIDcb.Cursor = Cursors.Hand;
            salary_PIDcb.FormattingEnabled = true;
            salary_PIDcb.Location = new Point(160, 50);
            salary_PIDcb.Name = "salary_PIDcb";
            salary_PIDcb.Size = new Size(132, 23);
            salary_PIDcb.TabIndex = 166;
            salary_PIDcb.SelectionChangeCommitted += salary_PIDcb_SelectionChangeCommitted;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Julius Sans One", 9.75F);
            label19.Location = new Point(21, 144);
            label19.Name = "label19";
            label19.Size = new Size(65, 14);
            label19.TabIndex = 164;
            label19.Text = "Amount";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Julius Sans One", 9.75F);
            label20.Location = new Point(21, 86);
            label20.Name = "label20";
            label20.Size = new Size(119, 14);
            label20.TabIndex = 163;
            label20.Text = "Professor Name";
            // 
            // salary_Amount
            // 
            salary_Amount.Cursor = Cursors.Hand;
            salary_Amount.Location = new Point(160, 140);
            salary_Amount.Name = "salary_Amount";
            salary_Amount.Size = new Size(132, 23);
            salary_Amount.TabIndex = 162;
            // 
            // salary_PNtb
            // 
            salary_PNtb.Cursor = Cursors.Hand;
            salary_PNtb.Enabled = false;
            salary_PNtb.Location = new Point(160, 79);
            salary_PNtb.Name = "salary_PNtb";
            salary_PNtb.Size = new Size(132, 23);
            salary_PNtb.TabIndex = 160;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Julius Sans One", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(128, 11);
            label22.Name = "label22";
            label22.Size = new Size(70, 18);
            label22.TabIndex = 26;
            label22.Text = "Salary";
            // 
            // salary_Reset
            // 
            salary_Reset.Cursor = Cursors.Hand;
            salary_Reset.Location = new Point(181, 222);
            salary_Reset.Name = "salary_Reset";
            salary_Reset.Size = new Size(111, 31);
            salary_Reset.TabIndex = 120;
            salary_Reset.Text = "Reset";
            salary_Reset.UseVisualStyleBackColor = true;
            // 
            // salary_Pay
            // 
            salary_Pay.Cursor = Cursors.Hand;
            salary_Pay.Location = new Point(21, 223);
            salary_Pay.Name = "salary_Pay";
            salary_Pay.Size = new Size(111, 31);
            salary_Pay.TabIndex = 119;
            salary_Pay.Text = "Pay";
            salary_Pay.UseVisualStyleBackColor = true;
            salary_Pay.Click += salary_Pay_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 479);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 207;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 404);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 206;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 201;
            pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 355);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 205;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 308);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 204;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 262);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 203;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 217);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 202;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 200;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 199;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Lucida Handwriting", 9.75F);
            label9.Location = new Point(60, 483);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 198;
            label9.Text = "Log out";
            label9.Click += label9_Click;
            // 
            // colBtn
            // 
            colBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            colBtn.AutoSize = true;
            colBtn.Cursor = Cursors.Hand;
            colBtn.Font = new Font("Lucida Handwriting", 9.75F);
            colBtn.Location = new Point(56, 410);
            colBtn.Name = "colBtn";
            colBtn.Size = new Size(67, 17);
            colBtn.TabIndex = 197;
            colBtn.Text = "Colleges";
            colBtn.Click += colBtn_Click;
            // 
            // salaryBtn
            // 
            salaryBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salaryBtn.AutoSize = true;
            salaryBtn.Cursor = Cursors.Hand;
            salaryBtn.Font = new Font("Lucida Handwriting", 9.75F);
            salaryBtn.Location = new Point(60, 360);
            salaryBtn.Name = "salaryBtn";
            salaryBtn.Size = new Size(54, 17);
            salaryBtn.TabIndex = 196;
            salaryBtn.Text = "Salary";
            salaryBtn.Click += salaryBtn_Click;
            // 
            // feesBtn
            // 
            feesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feesBtn.AutoSize = true;
            feesBtn.Cursor = Cursors.Hand;
            feesBtn.Font = new Font("Lucida Handwriting", 9.75F);
            feesBtn.Location = new Point(60, 315);
            feesBtn.Name = "feesBtn";
            feesBtn.Size = new Size(38, 17);
            feesBtn.TabIndex = 195;
            feesBtn.Text = "Fees";
            // 
            // courBtn
            // 
            courBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courBtn.AutoSize = true;
            courBtn.Cursor = Cursors.Hand;
            courBtn.Font = new Font("Lucida Handwriting", 9.75F);
            courBtn.Location = new Point(60, 265);
            courBtn.Name = "courBtn";
            courBtn.Size = new Size(63, 17);
            courBtn.TabIndex = 194;
            courBtn.Text = "Courses";
            courBtn.Click += courBtn_Click;
            // 
            // profBtn
            // 
            profBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profBtn.AutoSize = true;
            profBtn.Cursor = Cursors.Hand;
            profBtn.Font = new Font("Lucida Handwriting", 9.75F);
            profBtn.Location = new Point(60, 225);
            profBtn.Name = "profBtn";
            profBtn.Size = new Size(74, 17);
            profBtn.TabIndex = 193;
            profBtn.Text = "Professor";
            profBtn.Click += profBtn_Click;
            // 
            // studBtn
            // 
            studBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studBtn.AutoSize = true;
            studBtn.Cursor = Cursors.Hand;
            studBtn.Font = new Font("Lucida Handwriting", 9.75F);
            studBtn.Location = new Point(60, 130);
            studBtn.Name = "studBtn";
            studBtn.Size = new Size(65, 17);
            studBtn.TabIndex = 192;
            studBtn.Text = "Student";
            studBtn.Click += studBtn_Click;
            // 
            // depBtn
            // 
            depBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            depBtn.AutoSize = true;
            depBtn.Cursor = Cursors.Hand;
            depBtn.Font = new Font("Lucida Handwriting", 9.75F);
            depBtn.Location = new Point(60, 175);
            depBtn.Name = "depBtn";
            depBtn.Size = new Size(96, 17);
            depBtn.TabIndex = 191;
            depBtn.Text = "Department";
            depBtn.Click += depBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeBtn.AutoSize = true;
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.Font = new Font("Lucida Handwriting", 9.75F);
            homeBtn.Location = new Point(60, 85);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(50, 17);
            homeBtn.TabIndex = 190;
            homeBtn.Text = "Home";
            homeBtn.Click += homeBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Brown;
            panel2.Location = new Point(72, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 50);
            panel2.TabIndex = 212;
            // 
            // label1
            // 
            label1.Font = new Font("Julius Sans One", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(100, 53);
            label1.TabIndex = 211;
            label1.Text = "University of Roseland";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(12, 12);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(50, 50);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 213;
            pictureBox10.TabStop = false;
            // 
            // FeesDGV
            // 
            FeesDGV.AllowUserToAddRows = false;
            FeesDGV.AllowUserToDeleteRows = false;
            FeesDGV.AllowUserToResizeColumns = false;
            FeesDGV.AllowUserToResizeRows = false;
            FeesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FeesDGV.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Julius Sans One", 9.75F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            FeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FeesDGV.GridColor = SystemColors.ScrollBar;
            FeesDGV.Location = new Point(211, 288);
            FeesDGV.Name = "FeesDGV";
            FeesDGV.Size = new Size(320, 221);
            FeesDGV.TabIndex = 214;
            FeesDGV.CellContentClick += FeesDGV_CellContentClick;
            // 
            // SalaryDGV
            // 
            SalaryDGV.AllowUserToAddRows = false;
            SalaryDGV.AllowUserToDeleteRows = false;
            SalaryDGV.AllowUserToResizeColumns = false;
            SalaryDGV.AllowUserToResizeRows = false;
            SalaryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalaryDGV.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Julius Sans One", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SalaryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SalaryDGV.GridColor = SystemColors.ScrollBar;
            SalaryDGV.Location = new Point(537, 288);
            SalaryDGV.Name = "SalaryDGV";
            SalaryDGV.Size = new Size(320, 221);
            SalaryDGV.TabIndex = 215;
            SalaryDGV.CellContentClick += SalaryDGV_CellContentClick;
            // 
            // Fees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 521);
            Controls.Add(SalaryDGV);
            Controls.Add(FeesDGV);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(colBtn);
            Controls.Add(salaryBtn);
            Controls.Add(feesBtn);
            Controls.Add(courBtn);
            Controls.Add(profBtn);
            Controls.Add(studBtn);
            Controls.Add(depBtn);
            Controls.Add(homeBtn);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Fees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fees";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private Button fees_Reset;
        private Button fees_Pay;
        private Panel panel1;
        private Panel panel5;
        private Label label15;
        private Label label10;
        private ComboBox fees_SIDcb;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox fees_Amount;
        private TextBox fees_DNtb;
        private TextBox fees_SNtb;
        private Panel panel3;
        private Label label16;
        private DateTimePicker salary_Period;
        private Label label17;
        private ComboBox salary_PIDcb;
        private Label label19;
        private Label label20;
        private TextBox salary_Amount;
        private Label label22;
        private Button salary_Reset;
        private Button salary_Pay;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label9;
        private Label colBtn;
        private Label salaryBtn;
        private Label feesBtn;
        private Label courBtn;
        private Label profBtn;
        private Label studBtn;
        private Label depBtn;
        private Label homeBtn;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox10;
        private TextBox salary_PNtb;
        private DataGridView FeesDGV;
        private DataGridView SalaryDGV;
        private ComboBox fees_Period;
    }
}