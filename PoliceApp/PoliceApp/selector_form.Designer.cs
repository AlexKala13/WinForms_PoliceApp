namespace PoliceApp
{
    partial class selector_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transportBtn = new System.Windows.Forms.Button();
            this.driversBtn = new System.Windows.Forms.Button();
            this.finesBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "აირჩიეთ მონაცემთა ბაზა";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 120);
            this.panel1.TabIndex = 1;
            // 
            // transportBtn
            // 
            this.transportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportBtn.Location = new System.Drawing.Point(12, 180);
            this.transportBtn.Name = "transportBtn";
            this.transportBtn.Size = new System.Drawing.Size(148, 35);
            this.transportBtn.TabIndex = 2;
            this.transportBtn.Text = "ტრანსპორტი";
            this.transportBtn.UseVisualStyleBackColor = true;
            // 
            // driversBtn
            // 
            this.driversBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driversBtn.Location = new System.Drawing.Point(223, 180);
            this.driversBtn.Name = "driversBtn";
            this.driversBtn.Size = new System.Drawing.Size(148, 35);
            this.driversBtn.TabIndex = 3;
            this.driversBtn.Text = "მძღოლები";
            this.driversBtn.UseVisualStyleBackColor = true;
            this.driversBtn.Click += new System.EventHandler(this.driversBtn_Click);
            // 
            // finesBtn
            // 
            this.finesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finesBtn.Location = new System.Drawing.Point(437, 180);
            this.finesBtn.Name = "finesBtn";
            this.finesBtn.Size = new System.Drawing.Size(148, 35);
            this.finesBtn.TabIndex = 4;
            this.finesBtn.Text = "ჯარიმები";
            this.finesBtn.UseVisualStyleBackColor = true;
            // 
            // selector_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(597, 282);
            this.Controls.Add(this.finesBtn);
            this.Controls.Add(this.driversBtn);
            this.Controls.Add(this.transportBtn);
            this.Controls.Add(this.panel1);
            this.Name = "selector_form";
            this.Text = "Police App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button transportBtn;
        private System.Windows.Forms.Button driversBtn;
        private System.Windows.Forms.Button finesBtn;
    }
}