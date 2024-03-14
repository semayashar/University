namespace UniMan
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            panel4 = new Panel();
            panel6 = new Panel();
            label21 = new Label();
            pictureBox14 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            usernameTb = new TextBox();
            passwordTb = new TextBox();
            logInBtn = new Button();
            ResetBtn = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(pictureBox14);
            panel4.Location = new Point(19, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(442, 86);
            panel4.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Brown;
            panel6.Location = new Point(136, 54);
            panel6.Name = "panel6";
            panel6.Size = new Size(266, 10);
            panel6.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Julius Sans One", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(150, 33);
            label21.Name = "label21";
            label21.Size = new Size(235, 18);
            label21.TabIndex = 24;
            label21.Text = "University of Roseland";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(46, 7);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(79, 69);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 23;
            pictureBox14.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 9.749999F);
            label1.Location = new Point(130, 120);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 25;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Raleway", 9.749999F);
            label2.Location = new Point(135, 160);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 26;
            label2.Text = "Password";
            // 
            // usernameTb
            // 
            usernameTb.Cursor = Cursors.Hand;
            usernameTb.Location = new Point(207, 117);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(132, 23);
            usernameTb.TabIndex = 161;
            // 
            // passwordTb
            // 
            passwordTb.Cursor = Cursors.Hand;
            passwordTb.Location = new Point(207, 157);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(132, 23);
            passwordTb.TabIndex = 162;
            passwordTb.UseSystemPasswordChar = true;
            // 
            // logInBtn
            // 
            logInBtn.Cursor = Cursors.Hand;
            logInBtn.Font = new Font("Raleway", 9.749999F);
            logInBtn.Location = new Point(111, 222);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(111, 31);
            logInBtn.TabIndex = 163;
            logInBtn.Text = "Log in";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Cursor = Cursors.Hand;
            ResetBtn.Font = new Font("Raleway", 9.749999F);
            ResetBtn.Location = new Point(247, 222);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(111, 31);
            ResetBtn.TabIndex = 164;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 280);
            Controls.Add(ResetBtn);
            Controls.Add(logInBtn);
            Controls.Add(passwordTb);
            Controls.Add(usernameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "University of Roseland";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Panel panel6;
        private Label label21;
        private PictureBox pictureBox14;
        private Label label1;
        private Label label2;
        private TextBox usernameTb;
        private TextBox passwordTb;
        private Button logInBtn;
        private Button ResetBtn;
    }
}