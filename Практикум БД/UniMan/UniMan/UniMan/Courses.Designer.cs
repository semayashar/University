namespace UniMan
{
    partial class Courses
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses));
            label14 = new Label();
            course_delete = new Button();
            course_edit = new Button();
            course_save = new Button();
            panel5 = new Panel();
            label16 = new Label();
            course_DID = new ComboBox();
            label15 = new Label();
            panel3 = new Panel();
            course_PID = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            course_DurH = new TextBox();
            course_DN = new TextBox();
            course_PN = new TextBox();
            course_CN = new TextBox();
            panel1 = new Panel();
            CourseDGV = new DataGridView();
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
            panel4 = new Panel();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDGV).BeginInit();
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
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Julius Sans One", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(265, 19);
            label14.Name = "label14";
            label14.Size = new Size(77, 18);
            label14.TabIndex = 26;
            label14.Text = "Course";
            // 
            // course_delete
            // 
            course_delete.Location = new Point(428, 180);
            course_delete.Name = "course_delete";
            course_delete.Size = new Size(136, 31);
            course_delete.TabIndex = 121;
            course_delete.Text = "Delete";
            course_delete.UseVisualStyleBackColor = true;
            course_delete.Click += course_delete_Click;
            // 
            // course_edit
            // 
            course_edit.Location = new Point(248, 180);
            course_edit.Name = "course_edit";
            course_edit.Size = new Size(136, 31);
            course_edit.TabIndex = 120;
            course_edit.Text = "Edit";
            course_edit.UseVisualStyleBackColor = true;
            course_edit.Click += course_edit_Click;
            // 
            // course_save
            // 
            course_save.Location = new Point(64, 180);
            course_save.Name = "course_save";
            course_save.Size = new Size(136, 31);
            course_save.TabIndex = 119;
            course_save.Text = "Save";
            course_save.UseVisualStyleBackColor = true;
            course_save.Click += course_save_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label16);
            panel5.Controls.Add(course_DID);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(course_delete);
            panel5.Controls.Add(course_edit);
            panel5.Controls.Add(course_save);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(course_PID);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(course_DurH);
            panel5.Controls.Add(course_DN);
            panel5.Controls.Add(course_PN);
            panel5.Controls.Add(course_CN);
            panel5.Location = new Point(199, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(658, 233);
            panel5.TabIndex = 144;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Julius Sans One", 9.75F);
            label16.Location = new Point(320, 95);
            label16.Name = "label16";
            label16.Size = new Size(108, 14);
            label16.TabIndex = 124;
            label16.Text = "Department ID";
            // 
            // course_DID
            // 
            course_DID.Cursor = Cursors.Hand;
            course_DID.FormattingEnabled = true;
            course_DID.Location = new Point(482, 91);
            course_DID.Name = "course_DID";
            course_DID.Size = new Size(118, 23);
            course_DID.TabIndex = 123;
            course_DID.SelectionChangeCommitted += course_DID_SelectionChangeCommitted;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Julius Sans One", 9.75F);
            label15.Location = new Point(319, 135);
            label15.Name = "label15";
            label15.Size = new Size(98, 14);
            label15.TabIndex = 122;
            label15.Text = "Professor ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Brown;
            panel3.Location = new Point(308, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 110);
            panel3.TabIndex = 99;
            // 
            // course_PID
            // 
            course_PID.Cursor = Cursors.Hand;
            course_PID.FormattingEnabled = true;
            course_PID.Location = new Point(482, 132);
            course_PID.Name = "course_PID";
            course_PID.Size = new Size(118, 23);
            course_PID.TabIndex = 98;
            course_PID.SelectionChangeCommitted += course_PID_SelectionChangeCommitted;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Julius Sans One", 9.75F);
            label13.Location = new Point(22, 95);
            label13.Name = "label13";
            label13.Size = new Size(129, 14);
            label13.TabIndex = 97;
            label13.Text = "Department Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Julius Sans One", 9.75F);
            label12.Location = new Point(319, 59);
            label12.Name = "label12";
            label12.Size = new Size(145, 14);
            label12.TabIndex = 96;
            label12.Text = "Duration in hours";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Julius Sans One", 9.75F);
            label11.Location = new Point(22, 135);
            label11.Name = "label11";
            label11.Size = new Size(118, 14);
            label11.TabIndex = 95;
            label11.Text = "Professor name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Julius Sans One", 9.75F);
            label10.Location = new Point(22, 59);
            label10.Name = "label10";
            label10.Size = new Size(99, 14);
            label10.TabIndex = 94;
            label10.Text = "Course Name";
            // 
            // course_DurH
            // 
            course_DurH.Cursor = Cursors.Hand;
            course_DurH.Location = new Point(482, 56);
            course_DurH.Name = "course_DurH";
            course_DurH.Size = new Size(118, 23);
            course_DurH.TabIndex = 93;
            // 
            // course_DN
            // 
            course_DN.Cursor = Cursors.Hand;
            course_DN.Enabled = false;
            course_DN.Location = new Point(157, 91);
            course_DN.Name = "course_DN";
            course_DN.Size = new Size(133, 23);
            course_DN.TabIndex = 92;
            // 
            // course_PN
            // 
            course_PN.Cursor = Cursors.Hand;
            course_PN.Enabled = false;
            course_PN.Location = new Point(157, 131);
            course_PN.Name = "course_PN";
            course_PN.Size = new Size(132, 23);
            course_PN.TabIndex = 91;
            // 
            // course_CN
            // 
            course_CN.Cursor = Cursors.Hand;
            course_CN.Location = new Point(157, 52);
            course_CN.Name = "course_CN";
            course_CN.Size = new Size(132, 23);
            course_CN.TabIndex = 90;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(183, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 557);
            panel1.TabIndex = 125;
            // 
            // CourseDGV
            // 
            CourseDGV.AllowUserToAddRows = false;
            CourseDGV.AllowUserToDeleteRows = false;
            CourseDGV.AllowUserToResizeColumns = false;
            CourseDGV.AllowUserToResizeRows = false;
            CourseDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CourseDGV.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Julius Sans One", 9.75F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CourseDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CourseDGV.GridColor = SystemColors.ScrollBar;
            CourseDGV.Location = new Point(199, 251);
            CourseDGV.Name = "CourseDGV";
            CourseDGV.Size = new Size(658, 258);
            CourseDGV.TabIndex = 168;
            CourseDGV.CellContentClick += CourseDGV_CellContentClick;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 479);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 203;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 407);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 202;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 172);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 197;
            pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 358);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 201;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 311);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 200;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 265);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 199;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 220);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 198;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 196;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 195;
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
            label9.TabIndex = 194;
            label9.Text = "Log out";
            label9.Click += label9_Click;
            // 
            // colBtn
            // 
            colBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            colBtn.AutoSize = true;
            colBtn.Cursor = Cursors.Hand;
            colBtn.Font = new Font("Lucida Handwriting", 9.75F);
            colBtn.Location = new Point(56, 413);
            colBtn.Name = "colBtn";
            colBtn.Size = new Size(67, 17);
            colBtn.TabIndex = 193;
            colBtn.Text = "Colleges";
            colBtn.Click += colBtn_Click;
            // 
            // salaryBtn
            // 
            salaryBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salaryBtn.AutoSize = true;
            salaryBtn.Cursor = Cursors.Hand;
            salaryBtn.Font = new Font("Lucida Handwriting", 9.75F);
            salaryBtn.Location = new Point(60, 363);
            salaryBtn.Name = "salaryBtn";
            salaryBtn.Size = new Size(54, 17);
            salaryBtn.TabIndex = 192;
            salaryBtn.Text = "Salary";
            salaryBtn.Click += salaryBtn_Click;
            // 
            // feesBtn
            // 
            feesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feesBtn.AutoSize = true;
            feesBtn.Cursor = Cursors.Hand;
            feesBtn.Font = new Font("Lucida Handwriting", 9.75F);
            feesBtn.Location = new Point(60, 318);
            feesBtn.Name = "feesBtn";
            feesBtn.Size = new Size(38, 17);
            feesBtn.TabIndex = 191;
            feesBtn.Text = "Fees";
            feesBtn.Click += feesBtn_Click;
            // 
            // courBtn
            // 
            courBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courBtn.AutoSize = true;
            courBtn.Cursor = Cursors.Hand;
            courBtn.Font = new Font("Lucida Handwriting", 9.75F);
            courBtn.Location = new Point(60, 268);
            courBtn.Name = "courBtn";
            courBtn.Size = new Size(63, 17);
            courBtn.TabIndex = 190;
            courBtn.Text = "Courses";
            courBtn.Click += courBtn_Click;
            // 
            // profBtn
            // 
            profBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profBtn.AutoSize = true;
            profBtn.Cursor = Cursors.Hand;
            profBtn.Font = new Font("Lucida Handwriting", 9.75F);
            profBtn.Location = new Point(60, 228);
            profBtn.Name = "profBtn";
            profBtn.Size = new Size(74, 17);
            profBtn.TabIndex = 189;
            profBtn.Text = "Professor";
            profBtn.Click += profBtn_Click;
            // 
            // studBtn
            // 
            studBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studBtn.AutoSize = true;
            studBtn.Cursor = Cursors.Hand;
            studBtn.Font = new Font("Lucida Handwriting", 9.75F);
            studBtn.Location = new Point(60, 133);
            studBtn.Name = "studBtn";
            studBtn.Size = new Size(65, 17);
            studBtn.TabIndex = 188;
            studBtn.Text = "Student";
            studBtn.Click += studBtn_Click;
            // 
            // depBtn
            // 
            depBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            depBtn.AutoSize = true;
            depBtn.Cursor = Cursors.Hand;
            depBtn.Font = new Font("Lucida Handwriting", 9.75F);
            depBtn.Location = new Point(60, 178);
            depBtn.Name = "depBtn";
            depBtn.Size = new Size(96, 17);
            depBtn.TabIndex = 187;
            depBtn.Text = "Department";
            depBtn.Click += depBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeBtn.AutoSize = true;
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.Font = new Font("Lucida Handwriting", 9.75F);
            homeBtn.Location = new Point(60, 88);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(50, 17);
            homeBtn.TabIndex = 186;
            homeBtn.Text = "Home";
            homeBtn.Click += homeBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Brown;
            panel4.Location = new Point(72, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 50);
            panel4.TabIndex = 215;
            // 
            // label1
            // 
            label1.Font = new Font("Julius Sans One", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(100, 53);
            label1.TabIndex = 214;
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
            pictureBox10.TabIndex = 216;
            pictureBox10.TabStop = false;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 521);
            Controls.Add(panel4);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox10);
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
            Controls.Add(CourseDGV);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Courses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Courses";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDGV).EndInit();
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Button course_delete;
        private Button course_edit;
        private Button course_save;
        private Panel panel5;
        private Label label16;
        private ComboBox course_DID;
        private Label label15;
        private Panel panel3;
        private ComboBox course_PID;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox course_DurH;
        private TextBox course_DN;
        private TextBox course_PN;
        private TextBox course_CN;
        private Panel panel1;
        private DataGridView CourseDGV;
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
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox10;
    }
}