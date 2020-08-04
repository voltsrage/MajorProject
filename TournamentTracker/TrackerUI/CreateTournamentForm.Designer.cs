namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.txtTeamoneScore = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.bthCreatePrize = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.cmbSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.lboxtournamentPlayer = new System.Windows.Forms.ListBox();
            this.lblTeamPlayer1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lboxPrizes = new System.Windows.Forms.ListBox();
            this.lblTeamPlayer2 = new System.Windows.Forms.Label();
            this.btnDeletePrize = new System.Windows.Forms.Button();
            this.lkLblCreateTeam = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(325, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament:";
            // 
            // txtTeamoneScore
            // 
            this.txtTeamoneScore.Location = new System.Drawing.Point(21, 110);
            this.txtTeamoneScore.Name = "txtTeamoneScore";
            this.txtTeamoneScore.Size = new System.Drawing.Size(263, 35);
            this.txtTeamoneScore.TabIndex = 8;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(14, 70);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(236, 37);
            this.lblTournamentName.TabIndex = 7;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.Location = new System.Drawing.Point(14, 163);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(125, 37);
            this.lblEntryFee.TabIndex = 7;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(135, 166);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(149, 35);
            this.txtEntryFee.TabIndex = 8;
            this.txtEntryFee.Text = "0";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.Location = new System.Drawing.Point(64, 307);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(171, 48);
            this.btnAddTeam.TabIndex = 9;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // bthCreatePrize
            // 
            this.bthCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bthCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.bthCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bthCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthCreatePrize.Location = new System.Drawing.Point(64, 399);
            this.bthCreatePrize.Name = "bthCreatePrize";
            this.bthCreatePrize.Size = new System.Drawing.Size(171, 48);
            this.bthCreatePrize.TabIndex = 9;
            this.bthCreatePrize.Text = "Create Prize";
            this.bthCreatePrize.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.Location = new System.Drawing.Point(274, 467);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(246, 48);
            this.btnCreateTournament.TabIndex = 9;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeletePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeletePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.Location = new System.Drawing.Point(635, 110);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(119, 72);
            this.btnDeletePlayer.TabIndex = 9;
            this.btnDeletePlayer.Text = "Delete Selected";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // cmbSelectTeam
            // 
            this.cmbSelectTeam.FormattingEnabled = true;
            this.cmbSelectTeam.Location = new System.Drawing.Point(21, 262);
            this.cmbSelectTeam.Name = "cmbSelectTeam";
            this.cmbSelectTeam.Size = new System.Drawing.Size(263, 38);
            this.cmbSelectTeam.TabIndex = 11;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(14, 222);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.lblSelectTeam.TabIndex = 10;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // lboxtournamentPlayer
            // 
            this.lboxtournamentPlayer.FormattingEnabled = true;
            this.lboxtournamentPlayer.ItemHeight = 30;
            this.lboxtournamentPlayer.Location = new System.Drawing.Point(332, 110);
            this.lboxtournamentPlayer.Name = "lboxtournamentPlayer";
            this.lboxtournamentPlayer.Size = new System.Drawing.Size(297, 154);
            this.lboxtournamentPlayer.TabIndex = 12;
            // 
            // lblTeamPlayer1
            // 
            this.lblTeamPlayer1.AutoSize = true;
            this.lblTeamPlayer1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPlayer1.Location = new System.Drawing.Point(325, 70);
            this.lblTeamPlayer1.Name = "lblTeamPlayer1";
            this.lblTeamPlayer1.Size = new System.Drawing.Size(184, 37);
            this.lblTeamPlayer1.TabIndex = 7;
            this.lblTeamPlayer1.Text = "Teams/Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 7;
            // 
            // lboxPrizes
            // 
            this.lboxPrizes.FormattingEnabled = true;
            this.lboxPrizes.ItemHeight = 30;
            this.lboxPrizes.Location = new System.Drawing.Point(332, 307);
            this.lboxPrizes.Name = "lboxPrizes";
            this.lboxPrizes.Size = new System.Drawing.Size(297, 154);
            this.lboxPrizes.TabIndex = 12;
            // 
            // lblTeamPlayer2
            // 
            this.lblTeamPlayer2.AutoSize = true;
            this.lblTeamPlayer2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPlayer2.Location = new System.Drawing.Point(325, 267);
            this.lblTeamPlayer2.Name = "lblTeamPlayer2";
            this.lblTeamPlayer2.Size = new System.Drawing.Size(184, 37);
            this.lblTeamPlayer2.TabIndex = 7;
            this.lblTeamPlayer2.Text = "Teams/Players";
            // 
            // btnDeletePrize
            // 
            this.btnDeletePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeletePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeletePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeletePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePrize.Location = new System.Drawing.Point(635, 307);
            this.btnDeletePrize.Name = "btnDeletePrize";
            this.btnDeletePrize.Size = new System.Drawing.Size(119, 72);
            this.btnDeletePrize.TabIndex = 9;
            this.btnDeletePrize.Text = "Delete Selected";
            this.btnDeletePrize.UseVisualStyleBackColor = true;
            // 
            // lkLblCreateTeam
            // 
            this.lkLblCreateTeam.AutoSize = true;
            this.lkLblCreateTeam.Location = new System.Drawing.Point(179, 229);
            this.lkLblCreateTeam.Name = "lkLblCreateTeam";
            this.lkLblCreateTeam.Size = new System.Drawing.Size(114, 30);
            this.lkLblCreateTeam.TabIndex = 13;
            this.lkLblCreateTeam.TabStop = true;
            this.lkLblCreateTeam.Text = "create new";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 526);
            this.Controls.Add(this.lkLblCreateTeam);
            this.Controls.Add(this.lboxPrizes);
            this.Controls.Add(this.lboxtournamentPlayer);
            this.Controls.Add(this.cmbSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.btnDeletePrize);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.bthCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.txtTeamoneScore);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTeamPlayer2);
            this.Controls.Add(this.lblTeamPlayer1);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CreateTournamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Tournament Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox txtTeamoneScore;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button bthCreatePrize;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.ComboBox cmbSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ListBox lboxtournamentPlayer;
        private System.Windows.Forms.Label lblTeamPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxPrizes;
        private System.Windows.Forms.Label lblTeamPlayer2;
        private System.Windows.Forms.Button btnDeletePrize;
        private System.Windows.Forms.LinkLabel lkLblCreateTeam;
    }
}