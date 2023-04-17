
namespace project_login
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.linkLabelSignOut = new System.Windows.Forms.LinkLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.doctorGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPatientAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPatientPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatientNid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientName1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpecification = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelSignOut
            // 
            this.linkLabelSignOut.AutoSize = true;
            this.linkLabelSignOut.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSignOut.LinkColor = System.Drawing.Color.Black;
            this.linkLabelSignOut.Location = new System.Drawing.Point(817, 9);
            this.linkLabelSignOut.Name = "linkLabelSignOut";
            this.linkLabelSignOut.Size = new System.Drawing.Size(46, 13);
            this.linkLabelSignOut.TabIndex = 6;
            this.linkLabelSignOut.TabStop = true;
            this.linkLabelSignOut.Text = "Sign out";
            this.linkLabelSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignOut_LinkClicked);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Menu;
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(35, 195);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 27);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show doctors";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // doctorGridView
            // 
            this.doctorGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doctorGridView.Location = new System.Drawing.Point(26, 228);
            this.doctorGridView.Name = "doctorGridView";
            this.doctorGridView.Size = new System.Drawing.Size(551, 377);
            this.doctorGridView.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(187, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(314, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 27);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPatientAddress
            // 
            this.lblPatientAddress.AutoSize = true;
            this.lblPatientAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientAddress.Location = new System.Drawing.Point(671, 329);
            this.lblPatientAddress.Name = "lblPatientAddress";
            this.lblPatientAddress.Size = new System.Drawing.Size(49, 13);
            this.lblPatientAddress.TabIndex = 28;
            this.lblPatientAddress.Text = "..............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(612, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address :";
            // 
            // lblPatientPhone
            // 
            this.lblPatientPhone.AutoSize = true;
            this.lblPatientPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientPhone.Location = new System.Drawing.Point(671, 300);
            this.lblPatientPhone.Name = "lblPatientPhone";
            this.lblPatientPhone.Size = new System.Drawing.Size(49, 13);
            this.lblPatientPhone.TabIndex = 26;
            this.lblPatientPhone.Text = "..............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(612, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Phone :";
            // 
            // lblPatientNid
            // 
            this.lblPatientNid.AutoSize = true;
            this.lblPatientNid.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientNid.Location = new System.Drawing.Point(671, 276);
            this.lblPatientNid.Name = "lblPatientNid";
            this.lblPatientNid.Size = new System.Drawing.Size(49, 13);
            this.lblPatientNid.TabIndex = 24;
            this.lblPatientNid.Text = "..............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(612, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "NID  :";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Location = new System.Drawing.Point(671, 245);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(49, 13);
            this.lblPatientName.TabIndex = 22;
            this.lblPatientName.Text = "..............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(612, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name  :";
            // 
            // lblPatientName1
            // 
            this.lblPatientName1.AutoSize = true;
            this.lblPatientName1.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName1.Location = new System.Drawing.Point(599, 164);
            this.lblPatientName1.Name = "lblPatientName1";
            this.lblPatientName1.Size = new System.Drawing.Size(112, 31);
            this.lblPatientName1.TabIndex = 30;
            this.lblPatientName1.Text = "..............";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Patient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(612, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "You are looking for :";
            // 
            // lblSpecification
            // 
            this.lblSpecification.AutoSize = true;
            this.lblSpecification.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecification.Location = new System.Drawing.Point(720, 359);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(49, 13);
            this.lblSpecification.TabIndex = 34;
            this.lblSpecification.Text = "..............";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(32, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(416, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Please select how you want to see the list of doctors and press \"Show Doctors\" bu" +
    "tton";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Show All donors",
            "Show donors of blood groupI\'m looking for",
            "Show donors of my district"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "show all doctors",
            "show doctors of the specification I\'m looking for"});
            this.comboBox1.Location = new System.Drawing.Point(34, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(395, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 629);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSpecification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPatientName1);
            this.Controls.Add(this.lblPatientAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPatientPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPatientNid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.doctorGridView);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.linkLabelSignOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Profile";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelSignOut;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView doctorGridView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPatientAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPatientPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPatientNid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientName1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSpecification;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}