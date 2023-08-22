namespace PoliceApp
{
    partial class cargrid_form
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.driverIdTb = new System.Windows.Forms.TextBox();
            this.policeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.police_dbDataSet = new PoliceApp.Police_dbDataSet();
            this.policedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policedbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.police_dbDataSet1 = new PoliceApp.Police_dbDataSet1();
            this.carstbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cars_tbTableAdapter = new PoliceApp.Police_dbDataSet1TableAdapters.Cars_tbTableAdapter();
            this.police_dbDataSet2 = new PoliceApp.Police_dbDataSet2();
            this.carstbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cars_tbTableAdapter1 = new PoliceApp.Police_dbDataSet2TableAdapters.Cars_tbTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.locationstbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locations_tbTableAdapter = new PoliceApp.Police_dbDataSetTableAdapters.Locations_tbTableAdapter();
            this.police_dbDataSet3 = new PoliceApp.Police_dbDataSet3();
            this.carstbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cars_tbTableAdapter2 = new PoliceApp.Police_dbDataSet3TableAdapters.Cars_tbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.policeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carstbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carstbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationstbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carstbBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(641, 72);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(114, 32);
            this.searchBtn.TabIndex = 26;
            this.searchBtn.Text = "ძებნა";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // cleanBtn
            // 
            this.cleanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cleanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanBtn.Location = new System.Drawing.Point(641, 27);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(114, 32);
            this.cleanBtn.TabIndex = 25;
            this.cleanBtn.Text = "გასუფთავება";
            this.cleanBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(328, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "ტრანს. ფერი";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(328, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "ბორბლების ფორმულა";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "ტრანს. ნომერი";
            // 
            // driverIdTb
            // 
            this.driverIdTb.Location = new System.Drawing.Point(45, 35);
            this.driverIdTb.Name = "driverIdTb";
            this.driverIdTb.Size = new System.Drawing.Size(137, 20);
            this.driverIdTb.TabIndex = 17;
            this.driverIdTb.TextChanged += new System.EventHandler(this.driverIdTb_TextChanged);
            // 
            // policeDataGridView
            // 
            this.policeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.policeDataGridView.EnableHeadersVisualStyles = false;
            this.policeDataGridView.Location = new System.Drawing.Point(45, 161);
            this.policeDataGridView.Name = "policeDataGridView";
            this.policeDataGridView.Size = new System.Drawing.Size(710, 276);
            this.policeDataGridView.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "მოდელი";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carstbBindingSource1;
            this.comboBox1.DisplayMember = "CarColor";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(331, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "CarColor";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.carstbBindingSource;
            this.comboBox2.DisplayMember = "WheelFormula";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(331, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.ValueMember = "WheelFormula";
            // 
            // police_dbDataSet
            // 
            this.police_dbDataSet.DataSetName = "Police_dbDataSet";
            this.police_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policedbDataSetBindingSource
            // 
            this.policedbDataSetBindingSource.DataSource = this.police_dbDataSet;
            this.policedbDataSetBindingSource.Position = 0;
            // 
            // policedbDataSetBindingSource1
            // 
            this.policedbDataSetBindingSource1.DataSource = this.police_dbDataSet;
            this.policedbDataSetBindingSource1.Position = 0;
            // 
            // police_dbDataSet1
            // 
            this.police_dbDataSet1.DataSetName = "Police_dbDataSet1";
            this.police_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carstbBindingSource
            // 
            this.carstbBindingSource.DataMember = "Cars_tb";
            this.carstbBindingSource.DataSource = this.police_dbDataSet1;
            // 
            // cars_tbTableAdapter
            // 
            this.cars_tbTableAdapter.ClearBeforeFill = true;
            // 
            // police_dbDataSet2
            // 
            this.police_dbDataSet2.DataSetName = "Police_dbDataSet2";
            this.police_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carstbBindingSource1
            // 
            this.carstbBindingSource1.DataMember = "Cars_tb";
            this.carstbBindingSource1.DataSource = this.police_dbDataSet2;
            // 
            // cars_tbTableAdapter1
            // 
            this.cars_tbTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.carstbBindingSource2;
            this.comboBox3.DisplayMember = "CarCategory";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(474, 34);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(137, 21);
            this.comboBox3.TabIndex = 34;
            this.comboBox3.ValueMember = "CarCategory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(185, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "მფლობელის პირ. ნომ.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(471, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "ტრანს. კატეგორია";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(185, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "ტრანს. რეგ. თარიღი";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.locationstbBindingSource;
            this.comboBox4.DisplayMember = "LocationName";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(474, 79);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(137, 21);
            this.comboBox4.TabIndex = 39;
            this.comboBox4.ValueMember = "LocationName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(471, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "ტრანს. რეგ. ადგილი";
            // 
            // locationstbBindingSource
            // 
            this.locationstbBindingSource.DataMember = "Locations_tb";
            this.locationstbBindingSource.DataSource = this.policedbDataSetBindingSource;
            // 
            // locations_tbTableAdapter
            // 
            this.locations_tbTableAdapter.ClearBeforeFill = true;
            // 
            // police_dbDataSet3
            // 
            this.police_dbDataSet3.DataSetName = "Police_dbDataSet3";
            this.police_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carstbBindingSource2
            // 
            this.carstbBindingSource2.DataMember = "Cars_tb";
            this.carstbBindingSource2.DataSource = this.police_dbDataSet3;
            // 
            // cars_tbTableAdapter2
            // 
            this.cars_tbTableAdapter2.ClearBeforeFill = true;
            // 
            // cargrid_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.driverIdTb);
            this.Controls.Add(this.policeDataGridView);
            this.Name = "cargrid_form";
            this.Text = "cargrid_form";
            this.Load += new System.EventHandler(this.cargrid_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carstbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carstbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationstbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carstbBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox driverIdTb;
        private System.Windows.Forms.DataGridView policeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Police_dbDataSet police_dbDataSet;
        private System.Windows.Forms.BindingSource policedbDataSetBindingSource;
        private System.Windows.Forms.BindingSource policedbDataSetBindingSource1;
        private Police_dbDataSet1 police_dbDataSet1;
        private System.Windows.Forms.BindingSource carstbBindingSource;
        private Police_dbDataSet1TableAdapters.Cars_tbTableAdapter cars_tbTableAdapter;
        private Police_dbDataSet2 police_dbDataSet2;
        private System.Windows.Forms.BindingSource carstbBindingSource1;
        private Police_dbDataSet2TableAdapters.Cars_tbTableAdapter cars_tbTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource locationstbBindingSource;
        private Police_dbDataSetTableAdapters.Locations_tbTableAdapter locations_tbTableAdapter;
        private Police_dbDataSet3 police_dbDataSet3;
        private System.Windows.Forms.BindingSource carstbBindingSource2;
        private Police_dbDataSet3TableAdapters.Cars_tbTableAdapter cars_tbTableAdapter2;
    }
}