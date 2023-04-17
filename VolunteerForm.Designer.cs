
namespace project_login
{
    partial class VolunteerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolunteerForm));
            this.linkLabelSignOut = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.volunteerGridView = new System.Windows.Forms.DataGridView();
            this.lblVolunteerName1 = new System.Windows.Forms.Label();
            this.lblVolunteerAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVolunteerPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVolunteerNid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVolunteerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelSignOut
            // 
            this.linkLabelSignOut.AutoSize = true;
            this.linkLabelSignOut.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSignOut.LinkColor = System.Drawing.Color.Black;
            this.linkLabelSignOut.Location = new System.Drawing.Point(846, 9);
            this.linkLabelSignOut.Name = "linkLabelSignOut";
            this.linkLabelSignOut.Size = new System.Drawing.Size(46, 13);
            this.linkLabelSignOut.TabIndex = 5;
            this.linkLabelSignOut.TabStop = true;
            this.linkLabelSignOut.Text = "Sign out";
            this.linkLabelSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignOut_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(186, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(320, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Menu;
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(31, 170);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 27);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show students";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // volunteerGridView
            // 
            this.volunteerGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volunteerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.volunteerGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volunteerGridView.Location = new System.Drawing.Point(12, 213);
            this.volunteerGridView.Name = "volunteerGridView";
            this.volunteerGridView.Size = new System.Drawing.Size(535, 424);
            this.volunteerGridView.TabIndex = 11;
            // 
            // lblVolunteerName1
            // 
            this.lblVolunteerName1.AutoSize = true;
            this.lblVolunteerName1.BackColor = System.Drawing.Color.Transparent;
            this.lblVolunteerName1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolunteerName1.Location = new System.Drawing.Point(602, 189);
            this.lblVolunteerName1.Name = "lblVolunteerName1";
            this.lblVolunteerName1.Size = new System.Drawing.Size(112, 31);
            this.lblVolunteerName1.TabIndex = 16;
            this.lblVolunteerName1.Text = "..............";
            // 
            // lblVolunteerAddress
            // 
            this.lblVolunteerAddress.AutoSize = true;
            this.lblVolunteerAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblVolunteerAddress.Location = new System.Drawing.Point(665, 353);
            this.lblVolunteerAddress.Name = "lblVolunteerAddress";
            this.lblVolunteerAddress.Size = new System.Drawing.Size(49, 13);
            this.lblVolunteerAddress.TabIndex = 28;
            this.lblVolunteerAddress.Text = "..............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(606, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address :";
            // 
            // lblVolunteerPhone
            // 
            this.lblVolunteerPhone.AutoSize = true;
            this.lblVolunteerPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblVolunteerPhone.Location = new System.Drawing.Point(665, 324);
            this.lblVolunteerPhone.Name = "lblVolunteerPhone";
            this.lblVolunteerPhone.Size = new System.Drawing.Size(49, 13);
            this.lblVolunteerPhone.TabIndex = 26;
            this.lblVolunteerPhone.Text = "..............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(606, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Phone :";
            // 
            // lblVolunteerNid
            // 
            this.lblVolunteerNid.AutoSize = true;
            this.lblVolunteerNid.BackColor = System.Drawing.Color.Transparent;
            this.lblVolunteerNid.Location = new System.Drawing.Point(665, 300);
            this.lblVolunteerNid.Name = "lblVolunteerNid";
            this.lblVolunteerNid.Size = new System.Drawing.Size(49, 13);
            this.lblVolunteerNid.TabIndex = 24;
            this.lblVolunteerNid.Text = "..............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(606, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "NID  :";
            // 
            // lblVolunteerName
            // 
            this.lblVolunteerName.AutoSize = true;
            this.lblVolunteerName.BackColor = System.Drawing.Color.Transparent;
            this.lblVolunteerName.Location = new System.Drawing.Point(665, 269);
            this.lblVolunteerName.Name = "lblVolunteerName";
            this.lblVolunteerName.Size = new System.Drawing.Size(49, 13);
            this.lblVolunteerName.TabIndex = 22;
            this.lblVolunteerName.Text = "..............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(606, 270);
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
            this.label5.Location = new System.Drawing.Point(605, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Volunteer";
            // 
            // VolunteerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 667);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVolunteerAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVolunteerPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVolunteerNid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVolunteerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVolunteerName1);
            this.Controls.Add(this.volunteerGridView);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.linkLabelSignOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VolunteerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volunteer Profile";
            this.Load += new System.EventHandler(this.VolunteerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volunteerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelSignOut;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView volunteerGridView;
        private System.Windows.Forms.Label lblVolunteerName1;
        private System.Windows.Forms.Label lblVolunteerAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVolunteerPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVolunteerNid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVolunteerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}