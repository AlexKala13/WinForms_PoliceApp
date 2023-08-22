namespace PoliceApp
{
    partial class grid_form
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
            this.components = new System.ComponentModel.Container();
            this.policeDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.driverIdTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.driverLastnameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.driverNameTb = new System.Windows.Forms.TextBox();
            this.cityCbx = new System.Windows.Forms.ComboBox();
            this.locationstbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.police_dbDataSet = new PoliceApp.Police_dbDataSet();
            this.locations_tbTableAdapter = new PoliceApp.Police_dbDataSetTableAdapters.Locations_tbTableAdapter();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.policeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationstbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // policeDataGridView
            // 
            this.policeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.policeDataGridView.EnableHeadersVisualStyles = false;
            this.policeDataGridView.Location = new System.Drawing.Point(47, 162);
            this.policeDataGridView.Name = "policeDataGridView";
            this.policeDataGridView.Size = new System.Drawing.Size(710, 276);
            this.policeDataGridView.TabIndex = 0;
            this.policeDataGridView.DoubleClick += new System.EventHandler(this.policeDataGridView_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(302, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "მძღოლის პ.ნ.";
            // 
            // driverIdTb
            // 
            this.driverIdTb.Location = new System.Drawing.Point(305, 36);
            this.driverIdTb.Name = "driverIdTb";
            this.driverIdTb.Size = new System.Drawing.Size(137, 20);
            this.driverIdTb.TabIndex = 3;
            this.driverIdTb.TextChanged += new System.EventHandler(this.driverIdTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(302, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "ქალაქი";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(454, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "მძღოლის გვარი";
            // 
            // driverLastnameTb
            // 
            this.driverLastnameTb.Location = new System.Drawing.Point(457, 81);
            this.driverLastnameTb.Name = "driverLastnameTb";
            this.driverLastnameTb.Size = new System.Drawing.Size(137, 20);
            this.driverLastnameTb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(454, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "მძღოლის სახელი";
            // 
            // driverNameTb
            // 
            this.driverNameTb.Location = new System.Drawing.Point(457, 36);
            this.driverNameTb.Name = "driverNameTb";
            this.driverNameTb.Size = new System.Drawing.Size(137, 20);
            this.driverNameTb.TabIndex = 7;
            // 
            // cityCbx
            // 
            this.cityCbx.DataSource = this.locationstbBindingSource;
            this.cityCbx.DisplayMember = "LocationName";
            this.cityCbx.FormattingEnabled = true;
            this.cityCbx.Location = new System.Drawing.Point(305, 80);
            this.cityCbx.Name = "cityCbx";
            this.cityCbx.Size = new System.Drawing.Size(137, 21);
            this.cityCbx.TabIndex = 13;
            this.cityCbx.ValueMember = "LocationName";
            // 
            // locationstbBindingSource
            // 
            this.locationstbBindingSource.DataMember = "Locations_tb";
            this.locationstbBindingSource.DataSource = this.police_dbDataSet;
            // 
            // police_dbDataSet
            // 
            this.police_dbDataSet.DataSetName = "Police_dbDataSet";
            this.police_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locations_tbTableAdapter
            // 
            this.locations_tbTableAdapter.ClearBeforeFill = true;
            // 
            // cleanBtn
            // 
            this.cleanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cleanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanBtn.Location = new System.Drawing.Point(643, 28);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(114, 32);
            this.cleanBtn.TabIndex = 14;
            this.cleanBtn.Text = "გასუფთავება";
            this.cleanBtn.UseVisualStyleBackColor = false;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(643, 73);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(114, 32);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "ძებნა";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // grid_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.cityCbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.driverLastnameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.driverNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.driverIdTb);
            this.Controls.Add(this.policeDataGridView);
            this.Name = "grid_form";
            this.Text = "Police App";
            this.Load += new System.EventHandler(this.grid_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationstbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView policeDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox driverIdTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox driverLastnameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox driverNameTb;
        private System.Windows.Forms.ComboBox cityCbx;
        private Police_dbDataSet police_dbDataSet;
        private System.Windows.Forms.BindingSource locationstbBindingSource;
        private Police_dbDataSetTableAdapters.Locations_tbTableAdapter locations_tbTableAdapter;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}