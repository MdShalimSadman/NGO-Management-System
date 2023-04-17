
namespace project_login
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.linkLabelSignOut = new System.Windows.Forms.LinkLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.lblStudentName1 = new System.Windows.Forms.Label();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStudentPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentNid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelSignOut
            // 
            this.linkLabelSignOut.AutoSize = true;
            this.linkLabelSignOut.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSignOut.LinkColor = System.Drawing.Color.Black;
            this.linkLabelSignOut.Location = new System.Drawing.Point(783, 9);
            this.linkLabelSignOut.Name = "linkLabelSignOut";
            this.linkLabelSignOut.Size = new System.Drawing.Size(46, 13);
            this.linkLabelSignOut.TabIndex = 7;
            this.linkLabelSignOut.TabStop = true;
            this.linkLabelSignOut.Text = "Sign out";
            this.linkLabelSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignOut_LinkClicked);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Menu;
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(28, 143);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 27);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Show teachers";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(181, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(315, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 27);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // studentGridView
            // 
            this.studentGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentGridView.Location = new System.Drawing.Point(12, 190);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(521, 392);
            this.studentGridView.TabIndex = 16;
            // 
            // lblStudentName1
            // 
            this.lblStudentName1.AutoSize = true;
            this.lblStudentName1.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName1.Location = new System.Drawing.Point(595, 163);
            this.lblStudentName1.Name = "lblStudentName1";
            this.lblStudentName1.Size = new System.Drawing.Size(112, 31);
            this.lblStudentName1.TabIndex = 18;
            this.lblStudentName1.Text = "..............";
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentAddress.Location = new System.Drawing.Point(658, 338);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(49, 13);
            this.lblStudentAddress.TabIndex = 28;
            this.lblStudentAddress.Text = "..............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(599, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address :";
            // 
            // lblStudentPhone
            // 
            this.lblStudentPhone.AutoSize = true;
            this.lblStudentPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentPhone.Location = new System.Drawing.Point(658, 309);
            this.lblStudentPhone.Name = "lblStudentPhone";
            this.lblStudentPhone.Size = new System.Drawing.Size(49, 13);
            this.lblStudentPhone.TabIndex = 26;
            this.lblStudentPhone.Text = "..............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(599, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Phone :";
            // 
            // lblStudentNid
            // 
            this.lblStudentNid.AutoSize = true;
            this.lblStudentNid.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNid.Location = new System.Drawing.Point(658, 285);
            this.lblStudentNid.Name = "lblStudentNid";
            this.lblStudentNid.Size = new System.Drawing.Size(49, 13);
            this.lblStudentNid.TabIndex = 24;
            this.lblStudentNid.Text = "..............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(577, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "NID / BRN :";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Location = new System.Drawing.Point(658, 254);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(49, 13);
            this.lblStudentName.TabIndex = 22;
            this.lblStudentName.Text = "..............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(599, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Student";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStudentAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStudentPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudentNid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentName1);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.linkLabelSignOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelSignOut;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Label lblStudentName1;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStudentPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentNid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}