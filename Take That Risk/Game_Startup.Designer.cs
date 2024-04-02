namespace TTR_Test
{
    partial class Game_Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Startup));
            this.Next_button = new System.Windows.Forms.Button();
            this.rules_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.Color.DarkGray;
            this.Next_button.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next_button.ForeColor = System.Drawing.Color.Black;
            this.Next_button.Location = new System.Drawing.Point(869, 617);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(183, 52);
            this.Next_button.TabIndex = 1;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = false;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // rules_textBox
            // 
            this.rules_textBox.BackColor = System.Drawing.Color.DarkGray;
            this.rules_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rules_textBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rules_textBox.Location = new System.Drawing.Point(8, 8);
            this.rules_textBox.Multiline = true;
            this.rules_textBox.Name = "rules_textBox";
            this.rules_textBox.ReadOnly = true;
            this.rules_textBox.Size = new System.Drawing.Size(1044, 600);
            this.rules_textBox.TabIndex = 0;
            this.rules_textBox.Text = resources.GetString("rules_textBox.Text");
            this.rules_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(8, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Game_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rules_textBox);
            this.Controls.Add(this.Next_button);
            this.MaximizeBox = false;
            this.Name = "Game_Startup";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.TextBox rules_textBox;
        private System.Windows.Forms.Button button2;
    }
}