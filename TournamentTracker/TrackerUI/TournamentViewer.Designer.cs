namespace TrackerUI
{
    partial class TournamentViewer
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
            this.headerLabek = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cmbRound = new System.Windows.Forms.ComboBox();
            this.chkUnplay = new System.Windows.Forms.CheckBox();
            this.lboxMatches = new System.Windows.Forms.ListBox();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.lblTeamtwo = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.txtTeamoneScore = new System.Windows.Forms.TextBox();
            this.txtTeamtwoScore = new System.Windows.Forms.TextBox();
            this.lblVersus = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabek
            // 
            this.headerLabek.AutoSize = true;
            this.headerLabek.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabek.Location = new System.Drawing.Point(12, 9);
            this.headerLabek.Name = "headerLabek";
            this.headerLabek.Size = new System.Drawing.Size(214, 50);
            this.headerLabek.TabIndex = 0;
            this.headerLabek.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(209, 9);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(150, 50);
            this.lblTournamentName.TabIndex = 0;
            this.lblTournamentName.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(14, 83);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(94, 37);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round";
            // 
            // cmbRound
            // 
            this.cmbRound.FormattingEnabled = true;
            this.cmbRound.Location = new System.Drawing.Point(114, 82);
            this.cmbRound.Name = "cmbRound";
            this.cmbRound.Size = new System.Drawing.Size(245, 38);
            this.cmbRound.TabIndex = 2;
            // 
            // chkUnplay
            // 
            this.chkUnplay.AutoSize = true;
            this.chkUnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUnplay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnplay.Location = new System.Drawing.Point(114, 138);
            this.chkUnplay.Name = "chkUnplay";
            this.chkUnplay.Size = new System.Drawing.Size(209, 41);
            this.chkUnplay.TabIndex = 3;
            this.chkUnplay.Text = "Unplayed Only";
            this.chkUnplay.UseVisualStyleBackColor = true;
            // 
            // lboxMatches
            // 
            this.lboxMatches.FormattingEnabled = true;
            this.lboxMatches.ItemHeight = 30;
            this.lboxMatches.Location = new System.Drawing.Point(21, 189);
            this.lboxMatches.Name = "lboxMatches";
            this.lboxMatches.Size = new System.Drawing.Size(338, 304);
            this.lboxMatches.TabIndex = 4;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOne.Location = new System.Drawing.Point(383, 189);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(165, 37);
            this.lblTeamOne.TabIndex = 5;
            this.lblTeamOne.Text = "<team one>";
            // 
            // lblTeamtwo
            // 
            this.lblTeamtwo.AutoSize = true;
            this.lblTeamtwo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamtwo.Location = new System.Drawing.Point(383, 378);
            this.lblTeamtwo.Name = "lblTeamtwo";
            this.lblTeamtwo.Size = new System.Drawing.Size(165, 37);
            this.lblTeamtwo.TabIndex = 5;
            this.lblTeamtwo.Text = "<team two>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneScore.Location = new System.Drawing.Point(405, 252);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamOneScore.TabIndex = 5;
            this.lblTeamOneScore.Text = "Score";
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoScore.Location = new System.Drawing.Point(405, 441);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamTwoScore.TabIndex = 5;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // txtTeamoneScore
            // 
            this.txtTeamoneScore.Location = new System.Drawing.Point(493, 255);
            this.txtTeamoneScore.Name = "txtTeamoneScore";
            this.txtTeamoneScore.Size = new System.Drawing.Size(149, 35);
            this.txtTeamoneScore.TabIndex = 6;
            // 
            // txtTeamtwoScore
            // 
            this.txtTeamtwoScore.Location = new System.Drawing.Point(493, 444);
            this.txtTeamtwoScore.Name = "txtTeamtwoScore";
            this.txtTeamtwoScore.Size = new System.Drawing.Size(149, 35);
            this.txtTeamtwoScore.TabIndex = 6;
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.Location = new System.Drawing.Point(486, 315);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(60, 37);
            this.lblVersus.TabIndex = 7;
            this.lblVersus.Text = ".VS.";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(596, 315);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(119, 48);
            this.btnScore.TabIndex = 8;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 522);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.txtTeamtwoScore);
            this.Controls.Add(this.txtTeamoneScore);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamtwo);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.lboxMatches);
            this.Controls.Add(this.chkUnplay);
            this.Controls.Add(this.cmbRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.headerLabek);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "TournamentViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Viewer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabek;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cmbRound;
        private System.Windows.Forms.CheckBox chkUnplay;
        private System.Windows.Forms.ListBox lboxMatches;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.Label lblTeamtwo;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.TextBox txtTeamoneScore;
        private System.Windows.Forms.TextBox txtTeamtwoScore;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.Button btnScore;
    }
}

