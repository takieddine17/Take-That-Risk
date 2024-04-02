namespace TTR_Test
{
    partial class Main_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Play_button = new System.Windows.Forms.Button();
            this.Create_Account_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Teacher_Login_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Play_button
            // 
            this.Play_button.BackColor = System.Drawing.Color.Silver;
            this.Play_button.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Play_button.Location = new System.Drawing.Point(424, 288);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(231, 70);
            this.Play_button.TabIndex = 1;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = false;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Create_Account_button
            // 
            this.Create_Account_button.BackColor = System.Drawing.Color.Silver;
            this.Create_Account_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create_Account_button.Location = new System.Drawing.Point(190, 380);
            this.Create_Account_button.Name = "Create_Account_button";
            this.Create_Account_button.Size = new System.Drawing.Size(231, 70);
            this.Create_Account_button.TabIndex = 2;
            this.Create_Account_button.Text = "Create Account";
            this.Create_Account_button.UseVisualStyleBackColor = false;
            this.Create_Account_button.Click += new System.EventHandler(this.Create_Account_button_Click_1);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.Silver;
            this.Login_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_button.Location = new System.Drawing.Point(654, 380);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(231, 70);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Teacher_Login_button
            // 
            this.Teacher_Login_button.BackColor = System.Drawing.Color.Silver;
            this.Teacher_Login_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Teacher_Login_button.Location = new System.Drawing.Point(424, 469);
            this.Teacher_Login_button.Name = "Teacher_Login_button";
            this.Teacher_Login_button.Size = new System.Drawing.Size(231, 70);
            this.Teacher_Login_button.TabIndex = 4;
            this.Teacher_Login_button.Text = "Teacher Login";
            this.Teacher_Login_button.UseVisualStyleBackColor = false;
            this.Teacher_Login_button.Click += new System.EventHandler(this.Teacher_Login_button_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 589);
            this.Controls.Add(this.Teacher_Login_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Create_Account_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main_Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Create_Account_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Teacher_Login_button;
    }
}

