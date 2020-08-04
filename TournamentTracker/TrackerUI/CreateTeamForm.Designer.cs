namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.cmbSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.btnDeleteTeamMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.bthCreatePrize = new System.Windows.Forms.Button();
            this.btnAddTeamMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lboxTeamMembers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(221, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Team:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(21, 110);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(316, 33);
            this.txtTeamName.TabIndex = 10;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(14, 75);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(143, 32);
            this.lblTeamName.TabIndex = 9;
            this.lblTeamName.Text = "Team Name";
            // 
            // cmbSelectTeamMember
            // 
            this.cmbSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectTeamMember.FormattingEnabled = true;
            this.cmbSelectTeamMember.Location = new System.Drawing.Point(21, 181);
            this.cmbSelectTeamMember.Name = "cmbSelectTeamMember";
            this.cmbSelectTeamMember.Size = new System.Drawing.Size(316, 33);
            this.cmbSelectTeamMember.TabIndex = 13;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeamMember.Location = new System.Drawing.Point(15, 146);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(241, 32);
            this.lblSelectTeamMember.TabIndex = 12;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // btnDeleteTeamMember
            // 
            this.btnDeleteTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeamMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeamMember.Location = new System.Drawing.Point(636, 355);
            this.btnDeleteTeamMember.Name = "btnDeleteTeamMember";
            this.btnDeleteTeamMember.Size = new System.Drawing.Size(119, 72);
            this.btnDeleteTeamMember.TabIndex = 14;
            this.btnDeleteTeamMember.Text = "Delete Selected";
            this.btnDeleteTeamMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.Location = new System.Drawing.Point(260, 589);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(246, 48);
            this.btnCreateTeam.TabIndex = 15;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // bthCreatePrize
            // 
            this.bthCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bthCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.bthCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bthCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthCreatePrize.Location = new System.Drawing.Point(73, 219);
            this.bthCreatePrize.Name = "bthCreatePrize";
            this.bthCreatePrize.Size = new System.Drawing.Size(171, 48);
            this.bthCreatePrize.TabIndex = 16;
            this.bthCreatePrize.Text = "Create Member";
            this.bthCreatePrize.UseVisualStyleBackColor = true;
            // 
            // btnAddTeamMember
            // 
            this.btnAddTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeamMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeamMember.Location = new System.Drawing.Point(94, 220);
            this.btnAddTeamMember.Name = "btnAddTeamMember";
            this.btnAddTeamMember.Size = new System.Drawing.Size(171, 44);
            this.btnAddTeamMember.TabIndex = 17;
            this.btnAddTeamMember.Text = "Add Member";
            this.btnAddTeamMember.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCellphone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.bthCreatePrize);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEntryFee);
            this.groupBox1.Location = new System.Drawing.Point(21, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 273);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(144, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 33);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.Location = new System.Drawing.Point(13, 38);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(130, 32);
            this.lblEntryFee.TabIndex = 9;
            this.lblEntryFee.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(144, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 33);
            this.txtLastName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(144, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 33);
            this.txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cellphone";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellphone.Location = new System.Drawing.Point(144, 170);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(149, 33);
            this.txtCellphone.TabIndex = 10;
            // 
            // lboxTeamMembers
            // 
            this.lboxTeamMembers.FormattingEnabled = true;
            this.lboxTeamMembers.ItemHeight = 30;
            this.lboxTeamMembers.Location = new System.Drawing.Point(376, 110);
            this.lboxTeamMembers.Name = "lboxTeamMembers";
            this.lboxTeamMembers.Size = new System.Drawing.Size(254, 454);
            this.lboxTeamMembers.TabIndex = 19;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 642);
            this.Controls.Add(this.lboxTeamMembers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnAddTeamMember);
            this.Controls.Add(this.btnDeleteTeamMember);
            this.Controls.Add(this.cmbSelectTeamMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CreateTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ComboBox cmbSelectTeamMember;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.Button btnDeleteTeamMember;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Button bthCreatePrize;
        private System.Windows.Forms.Button btnAddTeamMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ListBox lboxTeamMembers;
    }
}