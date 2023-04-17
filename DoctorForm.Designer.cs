
namespace project_login
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.lblDocName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.doctorGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDoctorName1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoctorNid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoctorPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDoctorAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpecification = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Location = new System.Drawing.Point(54, 124);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(0, 13);
            this.lblDocName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(804, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Menu;
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(22, 168);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 27);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Patients";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(153, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(276, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorGridView
            // 
            this.doctorGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doctorGridView.Location = new System.Drawing.Point(22, 219);
            this.doctorGridView.Name = "doctorGridView";
            this.doctorGridView.Size = new System.Drawing.Size(504, 392);
            this.doctorGridView.TabIndex = 10;
            this.doctorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(572, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name  :";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(631, 263);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(49, 13);
            this.lblDoctorName.TabIndex = 13;
            this.lblDoctorName.Text = "..............";
            this.lblDoctorName.Click += new System.EventHandler(this.lblDoctorName_Click);
            // 
            // lblDoctorName1
            // 
            this.lblDoctorName1.AutoSize = true;
            this.lblDoctorName1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName1.Location = new System.Drawing.Point(559, 164);
            this.lblDoctorName1.Name = "lblDoctorName1";
            this.lblDoctorName1.Size = new System.Drawing.Size(112, 31);
            this.lblDoctorName1.TabIndex = 14;
            this.lblDoctorName1.Text = "..............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(572, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "NID  :";
            // 
            // lblDoctorNid
            // 
            this.lblDoctorNid.AutoSize = true;
            this.lblDoctorNid.Location = new System.Drawing.Point(631, 294);
            this.lblDoctorNid.Name = "lblDoctorNid";
            this.lblDoctorNid.Size = new System.Drawing.Size(49, 13);
            this.lblDoctorNid.TabIndex = 16;
            this.lblDoctorNid.Text = "..............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(572, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phone :";
            // 
            // lblDoctorPhone
            // 
            this.lblDoctorPhone.AutoSize = true;
            this.lblDoctorPhone.Location = new System.Drawing.Point(631, 318);
            this.lblDoctorPhone.Name = "lblDoctorPhone";
            this.lblDoctorPhone.Size = new System.Drawing.Size(49, 13);
            this.lblDoctorPhone.TabIndex = 18;
            this.lblDoctorPhone.Text = "..............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(572, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Address :";
            // 
            // lblDoctorAddress
            // 
            this.lblDoctorAddress.AutoSize = true;
            this.lblDoctorAddress.Location = new System.Drawing.Point(631, 347);
            this.lblDoctorAddress.Name = "lblDoctorAddress";
            this.lblDoctorAddress.Size = new System.Drawing.Size(49, 13);
            this.lblDoctorAddress.TabIndex = 20;
            this.lblDoctorAddress.Text = "..............";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(572, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Specification :";
            // 
            // lblSpecification
            // 
            this.lblSpecification.AutoSize = true;
            this.lblSpecification.Location = new System.Drawing.Point(652, 375);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(49, 13);
            this.lblSpecification.TabIndex = 22;
            this.lblSpecification.Text = "..............";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Doctor";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Show All donors",
            "Show donors of blood groupI\'m looking for",
            "Show donors of my district"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "show all patients",
            "show patients of the specification I\'m looking for"});
            this.comboBox1.Location = new System.Drawing.Point(22, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(395, 21);
            this.comboBox1.TabIndex = 60;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(19, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(419, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Please select how you want to see the list of patients and press \"Show Patients\" " +
    "button";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 623);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSpecification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDoctorAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDoctorPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDoctorNid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDoctorName1);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDocName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Profile";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView doctorGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDoctorName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoctorNid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoctorPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDoctorAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSpecification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}