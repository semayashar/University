namespace UniMan
{
    partial class Students
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            studDel = new Button();
            studEdit = new Button();
            studSave = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            studGenderCB = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            studTelTb = new TextBox();
            studDepNamet = new TextBox();
            studNamet = new TextBox();
            label14 = new Label();
            studDOBTP = new DateTimePicker();
            label15 = new Label();
            label16 = new Label();
            studDepIDcb = new ComboBox();
            studAdresstb = new RichTextBox();
            label17 = new Label();
            label11 = new Label();
            studSemcb = new ComboBox();
            studDepIdtb = new Panel();
            label18 = new Label();
            StudDGV = new DataGridView();
            homeBtn = new Label();
            depBtn = new Label();
            studBtn = new Label();
            profBtn = new Label();
            courBtn = new Label();
            feesBtn = new Label();
            salaryBtn = new Label();
            colBtn = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            studDepIdtb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // studDel
            // 
            studDel.Cursor = Cursors.Hand;
            studDel.Location = new Point(420, 258);
            studDel.Name = "studDel";
            studDel.Size = new Size(136, 31);
            studDel.TabIndex = 155;
            studDel.Text = "Delete";
            studDel.UseVisualStyleBackColor = true;
            studDel.Click += studDel_Click;
            // 
            // studEdit
            // 
            studEdit.Cursor = Cursors.Hand;
            studEdit.Location = new Point(240, 258);
            studEdit.Name = "studEdit";
            studEdit.Size = new Size(136, 31);
            studEdit.TabIndex = 154;
            studEdit.Text = "Edit";
            studEdit.UseVisualStyleBackColor = true;
            studEdit.Click += studEdit_Click;
            // 
            // studSave
            // 
            studSave.Cursor = Cursors.Hand;
            studSave.Location = new Point(56, 258);
            studSave.Name = "studSave";
            studSave.Size = new Size(136, 31);
            studSave.TabIndex = 153;
            studSave.Text = "Save";
            studSave.UseVisualStyleBackColor = true;
            studSave.Click += studSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(184, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 540);
            panel1.TabIndex = 134;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 540);
            panel2.TabIndex = 135;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Brown;
            panel3.Location = new Point(302, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 190);
            panel3.TabIndex = 133;
            // 
            // studGenderCB
            // 
            studGenderCB.Cursor = Cursors.Hand;
            studGenderCB.FormattingEnabled = true;
            studGenderCB.Items.AddRange(new object[] { "Male", "Female" });
            studGenderCB.Location = new Point(143, 139);
            studGenderCB.Name = "studGenderCB";
            studGenderCB.Size = new Size(132, 23);
            studGenderCB.TabIndex = 132;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Julius Sans One", 9.75F);
            label13.Location = new Point(322, 72);
            label13.Name = "label13";
            label13.Size = new Size(129, 14);
            label13.TabIndex = 131;
            label13.Text = "Department Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Julius Sans One", 9.75F);
            label12.Location = new Point(322, 184);
            label12.Name = "label12";
            label12.Size = new Size(110, 14);
            label12.TabIndex = 130;
            label12.Text = "Phone Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Julius Sans One", 9.75F);
            label10.Location = new Point(21, 72);
            label10.Name = "label10";
            label10.Size = new Size(105, 14);
            label10.TabIndex = 128;
            label10.Text = "Student Name";
            // 
            // studTelTb
            // 
            studTelTb.Cursor = Cursors.Hand;
            studTelTb.Location = new Point(461, 180);
            studTelTb.Name = "studTelTb";
            studTelTb.Size = new Size(132, 23);
            studTelTb.TabIndex = 127;
            // 
            // studDepNamet
            // 
            studDepNamet.Cursor = Cursors.Hand;
            studDepNamet.Location = new Point(463, 63);
            studDepNamet.Name = "studDepNamet";
            studDepNamet.Size = new Size(132, 23);
            studDepNamet.TabIndex = 126;
            // 
            // studNamet
            // 
            studNamet.Cursor = Cursors.Hand;
            studNamet.Location = new Point(143, 65);
            studNamet.Name = "studNamet";
            studNamet.Size = new Size(132, 23);
            studNamet.TabIndex = 124;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Julius Sans One", 9.75F);
            label14.Location = new Point(21, 143);
            label14.Name = "label14";
            label14.Size = new Size(58, 14);
            label14.TabIndex = 156;
            label14.Text = "Gender";
            // 
            // studDOBTP
            // 
            studDOBTP.Cursor = Cursors.Hand;
            studDOBTP.Location = new Point(143, 102);
            studDOBTP.Name = "studDOBTP";
            studDOBTP.Size = new Size(132, 23);
            studDOBTP.TabIndex = 158;
            studDOBTP.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Julius Sans One", 9.75F);
            label15.Location = new Point(21, 109);
            label15.Name = "label15";
            label15.Size = new Size(103, 14);
            label15.TabIndex = 159;
            label15.Text = "Date of birth";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Julius Sans One", 9.75F);
            label16.Location = new Point(322, 109);
            label16.Name = "label16";
            label16.Size = new Size(108, 14);
            label16.TabIndex = 161;
            label16.Text = "Department ID";
            // 
            // studDepIDcb
            // 
            studDepIDcb.Cursor = Cursors.Hand;
            studDepIDcb.FormattingEnabled = true;
            studDepIDcb.Location = new Point(463, 102);
            studDepIDcb.Name = "studDepIDcb";
            studDepIDcb.Size = new Size(132, 23);
            studDepIDcb.TabIndex = 160;
            studDepIDcb.SelectionChangeCommitted += studDepIDcb_SelectionChangeCommitted;
            // 
            // studAdresstb
            // 
            studAdresstb.Cursor = Cursors.Hand;
            studAdresstb.Location = new Point(143, 180);
            studAdresstb.Name = "studAdresstb";
            studAdresstb.Size = new Size(135, 51);
            studAdresstb.TabIndex = 162;
            studAdresstb.Text = "";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Julius Sans One", 9.75F);
            label17.Location = new Point(21, 184);
            label17.Name = "label17";
            label17.Size = new Size(62, 14);
            label17.TabIndex = 163;
            label17.Text = "Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Julius Sans One", 9.75F);
            label11.Location = new Point(322, 148);
            label11.Name = "label11";
            label11.Size = new Size(64, 14);
            label11.TabIndex = 165;
            label11.Text = "Semester";
            // 
            // studSemcb
            // 
            studSemcb.Cursor = Cursors.Hand;
            studSemcb.FormattingEnabled = true;
            studSemcb.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            studSemcb.Location = new Point(463, 141);
            studSemcb.Name = "studSemcb";
            studSemcb.Size = new Size(132, 23);
            studSemcb.TabIndex = 164;
            // 
            // studDepIdtb
            // 
            studDepIdtb.BorderStyle = BorderStyle.FixedSingle;
            studDepIdtb.Controls.Add(label18);
            studDepIdtb.Controls.Add(label11);
            studDepIdtb.Controls.Add(studSemcb);
            studDepIdtb.Controls.Add(label17);
            studDepIdtb.Controls.Add(studAdresstb);
            studDepIdtb.Controls.Add(label16);
            studDepIdtb.Controls.Add(studDepIDcb);
            studDepIdtb.Controls.Add(label15);
            studDepIdtb.Controls.Add(studDOBTP);
            studDepIdtb.Controls.Add(label14);
            studDepIdtb.Controls.Add(studDel);
            studDepIdtb.Controls.Add(studEdit);
            studDepIdtb.Controls.Add(studSave);
            studDepIdtb.Controls.Add(panel3);
            studDepIdtb.Controls.Add(studGenderCB);
            studDepIdtb.Controls.Add(label13);
            studDepIdtb.Controls.Add(label12);
            studDepIdtb.Controls.Add(label10);
            studDepIdtb.Controls.Add(studTelTb);
            studDepIdtb.Controls.Add(studDepNamet);
            studDepIdtb.Controls.Add(studNamet);
            studDepIdtb.Location = new Point(216, 12);
            studDepIdtb.Name = "studDepIdtb";
            studDepIdtb.Size = new Size(629, 307);
            studDepIdtb.TabIndex = 166;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Julius Sans One", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(253, 19);
            label18.Name = "label18";
            label18.Size = new Size(94, 18);
            label18.TabIndex = 166;
            label18.Text = "Students";
            // 
            // StudDGV
            // 
            StudDGV.AllowUserToAddRows = false;
            StudDGV.AllowUserToDeleteRows = false;
            StudDGV.AllowUserToResizeColumns = false;
            StudDGV.AllowUserToResizeRows = false;
            StudDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudDGV.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StudDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StudDGV.GridColor = SystemColors.ScrollBar;
            StudDGV.Location = new Point(216, 325);
            StudDGV.Name = "StudDGV";
            StudDGV.Size = new Size(629, 183);
            StudDGV.TabIndex = 167;
            StudDGV.CellContentClick += StudDGV_CellContentClick;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeBtn.AutoSize = true;
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.Font = new Font("Lucida Handwriting", 9.75F);
            homeBtn.Location = new Point(60, 87);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(50, 17);
            homeBtn.TabIndex = 168;
            homeBtn.Text = "Home";
            homeBtn.Click += homeBtn_Click;
            // 
            // depBtn
            // 
            depBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            depBtn.AutoSize = true;
            depBtn.Cursor = Cursors.Hand;
            depBtn.Font = new Font("Lucida Handwriting", 9.75F);
            depBtn.Location = new Point(60, 177);
            depBtn.Name = "depBtn";
            depBtn.Size = new Size(96, 17);
            depBtn.TabIndex = 169;
            depBtn.Text = "Department";
            depBtn.Click += depBtn_Click;
            // 
            // studBtn
            // 
            studBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studBtn.AutoSize = true;
            studBtn.Cursor = Cursors.Hand;
            studBtn.Font = new Font("Lucida Handwriting", 9.75F);
            studBtn.Location = new Point(60, 132);
            studBtn.Name = "studBtn";
            studBtn.Size = new Size(65, 17);
            studBtn.TabIndex = 170;
            studBtn.Text = "Student";
            studBtn.Click += studBtn_Click;
            // 
            // profBtn
            // 
            profBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profBtn.AutoSize = true;
            profBtn.Cursor = Cursors.Hand;
            profBtn.Font = new Font("Lucida Handwriting", 9.75F);
            profBtn.Location = new Point(60, 227);
            profBtn.Name = "profBtn";
            profBtn.Size = new Size(74, 17);
            profBtn.TabIndex = 171;
            profBtn.Text = "Professor";
            profBtn.Click += profBtn_Click;
            // 
            // courBtn
            // 
            courBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courBtn.AutoSize = true;
            courBtn.Cursor = Cursors.Hand;
            courBtn.Font = new Font("Lucida Handwriting", 9.75F);
            courBtn.Location = new Point(60, 267);
            courBtn.Name = "courBtn";
            courBtn.Size = new Size(63, 17);
            courBtn.TabIndex = 172;
            courBtn.Text = "Courses";
            courBtn.Click += courBtn_Click;
            // 
            // feesBtn
            // 
            feesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feesBtn.AutoSize = true;
            feesBtn.Cursor = Cursors.Hand;
            feesBtn.Font = new Font("Lucida Handwriting", 9.75F);
            feesBtn.Location = new Point(60, 317);
            feesBtn.Name = "feesBtn";
            feesBtn.Size = new Size(38, 17);
            feesBtn.TabIndex = 173;
            feesBtn.Text = "Fees";
            feesBtn.Click += feesBtn_Click;
            // 
            // salaryBtn
            // 
            salaryBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salaryBtn.AutoSize = true;
            salaryBtn.Cursor = Cursors.Hand;
            salaryBtn.Font = new Font("Lucida Handwriting", 9.75F);
            salaryBtn.Location = new Point(60, 362);
            salaryBtn.Name = "salaryBtn";
            salaryBtn.Size = new Size(54, 17);
            salaryBtn.TabIndex = 174;
            salaryBtn.Text = "Salary";
            salaryBtn.Click += salaryBtn_Click;
            // 
            // colBtn
            // 
            colBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            colBtn.AutoSize = true;
            colBtn.Cursor = Cursors.Hand;
            colBtn.Font = new Font("Lucida Handwriting", 9.75F);
            colBtn.Location = new Point(56, 412);
            colBtn.Name = "colBtn";
            colBtn.Size = new Size(67, 17);
            colBtn.TabIndex = 175;
            colBtn.Text = "Colleges";
            colBtn.Click += colBtn_Click;
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
            label9.TabIndex = 176;
            label9.Text = "Log out";
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 177;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 178;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 180;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 264);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 181;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 310);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 182;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 357);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 183;
            pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 171);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 179;
            pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 406);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 184;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 479);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 185;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(12, 12);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(50, 50);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 186;
            pictureBox10.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Julius Sans One", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(100, 53);
            label1.TabIndex = 100;
            label1.Text = "University of Roseland";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Brown;
            panel4.Location = new Point(72, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 50);
            panel4.TabIndex = 134;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 521);
            Controls.Add(panel4);
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
            Controls.Add(StudDGV);
            Controls.Add(studDepIdtb);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            panel1.ResumeLayout(false);
            studDepIdtb.ResumeLayout(false);
            studDepIdtb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button studDel;
        private Button studEdit;
        private Button studSave;
        private Panel panel1;
        private Panel panel3;
        private ComboBox studGenderCB;
        private Label label13;
        private Label label12;
        private Label label10;
        private TextBox studTelTb;
        private TextBox studDepNamet;
        private TextBox studNamet;
        private Label label14;
        private DateTimePicker studDOBTP;
        private Label label15;
        private Label label16;
        private ComboBox studDepIDcb;
        private RichTextBox studAdresstb;
        private Label label17;
        private Label label11;
        private ComboBox studSemcb;
        private Panel studDepIdtb;
        private Label label18;
        private DataGridView StudDGV;
        private Label homeBtn;
        private Label depBtn;
        private Label studBtn;
        private Label profBtn;
        private Label courBtn;
        private Label feesBtn;
        private Label salaryBtn;
        private Label colBtn;
        private Label label9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Panel panel2;
        private PictureBox pictureBox10;
        private Label label1;
        private Panel panel4;
    }
}