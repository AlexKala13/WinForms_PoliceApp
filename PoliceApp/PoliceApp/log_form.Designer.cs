namespace PoliceApp
{
    partial class log_form
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
            this.officerTextBox = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Label();
            this.authLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.officerLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // officerTextBox
            // 
            this.officerTextBox.Location = new System.Drawing.Point(400, 190);
            this.officerTextBox.Name = "officerTextBox";
            this.officerTextBox.Size = new System.Drawing.Size(227, 20);
            this.officerTextBox.TabIndex = 0;
            this.officerTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(160, 36);
            this.logo.TabIndex = 2;
            this.logo.Text = "Police App";
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLabel.Location = new System.Drawing.Point(430, 89);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(180, 36);
            this.authLabel.TabIndex = 3;
            this.authLabel.Text = "ავტორიზაცია";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 464);
            this.panel1.TabIndex = 4;
            // 
            // officerLabel
            // 
            this.officerLabel.AutoSize = true;
            this.officerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officerLabel.Location = new System.Drawing.Point(396, 152);
            this.officerLabel.Name = "officerLabel";
            this.officerLabel.Size = new System.Drawing.Size(103, 24);
            this.officerLabel.TabIndex = 6;
            this.officerLabel.Text = "ოფიცრის ID";
            this.officerLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(396, 221);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 24);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "პაროლი";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(400, 259);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(227, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterBtn.Location = new System.Drawing.Point(436, 317);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(165, 30);
            this.enterBtn.TabIndex = 9;
            this.enterBtn.Text = "შესვლა";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongLabel.Location = new System.Drawing.Point(344, 386);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(0, 24);
            this.wrongLabel.TabIndex = 10;
            this.wrongLabel.Click += new System.EventHandler(this.wrongLabel_Click);
            // 
            // log_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 464);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.officerLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.officerTextBox);
            this.Name = "log_form";
            this.Text = "Police App";
            this.Load += new System.EventHandler(this.log_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox officerTextBox;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label officerLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label wrongLabel;
    }
}

