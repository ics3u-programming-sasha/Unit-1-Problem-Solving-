namespace BasketballTeamsSashaM
{
    partial class frmBasketballTeams
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
            this.mnuBasketballTeams = new System.Windows.Forms.MenuStrip();
            this.mniCities = new System.Windows.Forms.ToolStripMenuItem();
            this.mniToronto = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCleveland = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMiami = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBoston = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbCitiesAndTeams = new System.Windows.Forms.GroupBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblCities = new System.Windows.Forms.Label();
            this.picCeltics = new System.Windows.Forms.PictureBox();
            this.picTeam = new System.Windows.Forms.PictureBox();
            this.picCavaliers = new System.Windows.Forms.PictureBox();
            this.picHeat = new System.Windows.Forms.PictureBox();
            this.mnuBasketballTeams.SuspendLayout();
            this.grbCitiesAndTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCeltics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCavaliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBasketballTeams
            // 
            this.mnuBasketballTeams.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCities});
            this.mnuBasketballTeams.Location = new System.Drawing.Point(0, 0);
            this.mnuBasketballTeams.Name = "mnuBasketballTeams";
            this.mnuBasketballTeams.Size = new System.Drawing.Size(800, 24);
            this.mnuBasketballTeams.TabIndex = 0;
            this.mnuBasketballTeams.Text = "Basketball Teams";
            // 
            // mniCities
            // 
            this.mniCities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniToronto,
            this.mniCleveland,
            this.mniMiami,
            this.mniBoston});
            this.mniCities.Name = "mniCities";
            this.mniCities.Size = new System.Drawing.Size(48, 20);
            this.mniCities.Text = "Cities";
            // 
            // mniToronto
            // 
            this.mniToronto.Name = "mniToronto";
            this.mniToronto.Size = new System.Drawing.Size(180, 22);
            this.mniToronto.Text = "Toronto";
            this.mniToronto.Click += new System.EventHandler(this.MniToronto_Click);
            // 
            // mniCleveland
            // 
            this.mniCleveland.Name = "mniCleveland";
            this.mniCleveland.Size = new System.Drawing.Size(180, 22);
            this.mniCleveland.Text = "Cleveland";
            this.mniCleveland.Click += new System.EventHandler(this.MniCleveland_Click);
            // 
            // mniMiami
            // 
            this.mniMiami.Name = "mniMiami";
            this.mniMiami.Size = new System.Drawing.Size(180, 22);
            this.mniMiami.Text = "Miami";
            this.mniMiami.Click += new System.EventHandler(this.MniMiami_Click);
            // 
            // mniBoston
            // 
            this.mniBoston.Name = "mniBoston";
            this.mniBoston.Size = new System.Drawing.Size(180, 22);
            this.mniBoston.Text = "Boston";
            this.mniBoston.Click += new System.EventHandler(this.MniBoston_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbCitiesAndTeams
            // 
            this.grbCitiesAndTeams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbCitiesAndTeams.Controls.Add(this.lblTeam);
            this.grbCitiesAndTeams.Controls.Add(this.lblCities);
            this.grbCitiesAndTeams.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCitiesAndTeams.Location = new System.Drawing.Point(193, 85);
            this.grbCitiesAndTeams.Name = "grbCitiesAndTeams";
            this.grbCitiesAndTeams.Size = new System.Drawing.Size(370, 244);
            this.grbCitiesAndTeams.TabIndex = 2;
            this.grbCitiesAndTeams.TabStop = false;
            this.grbCitiesAndTeams.Text = "Cities and Basketball Teams";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Segoe Print", 20F);
            this.lblTeam.Location = new System.Drawing.Point(165, 150);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(126, 47);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Raptors";
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Impact", 40F);
            this.lblCities.Location = new System.Drawing.Point(45, 62);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(200, 66);
            this.lblCities.TabIndex = 0;
            this.lblCities.Text = "Toronto";
            // 
            // picCeltics
            // 
            this.picCeltics.Image = global::BasketballTeamsSashaM.Properties.Resources.Celtics;
            this.picCeltics.Location = new System.Drawing.Point(-2, 27);
            this.picCeltics.Name = "picCeltics";
            this.picCeltics.Size = new System.Drawing.Size(802, 426);
            this.picCeltics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCeltics.TabIndex = 6;
            this.picCeltics.TabStop = false;
            // 
            // picTeam
            // 
            this.picTeam.Image = global::BasketballTeamsSashaM.Properties.Resources.Raptors;
            this.picTeam.Location = new System.Drawing.Point(0, 27);
            this.picTeam.Name = "picTeam";
            this.picTeam.Size = new System.Drawing.Size(800, 905);
            this.picTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTeam.TabIndex = 3;
            this.picTeam.TabStop = false;
            // 
            // picCavaliers
            // 
            this.picCavaliers.Image = global::BasketballTeamsSashaM.Properties.Resources.Cavaliers;
            this.picCavaliers.Location = new System.Drawing.Point(0, 27);
            this.picCavaliers.Name = "picCavaliers";
            this.picCavaliers.Size = new System.Drawing.Size(821, 426);
            this.picCavaliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCavaliers.TabIndex = 4;
            this.picCavaliers.TabStop = false;
            // 
            // picHeat
            // 
            this.picHeat.Image = global::BasketballTeamsSashaM.Properties.Resources.Heat;
            this.picHeat.Location = new System.Drawing.Point(-89, 27);
            this.picHeat.Name = "picHeat";
            this.picHeat.Size = new System.Drawing.Size(889, 525);
            this.picHeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHeat.TabIndex = 5;
            this.picHeat.TabStop = false;
            // 
            // frmBasketballTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuBasketballTeams);
            this.Controls.Add(this.grbCitiesAndTeams);
            this.Controls.Add(this.picTeam);
            this.Controls.Add(this.picCavaliers);
            this.Controls.Add(this.picHeat);
            this.Controls.Add(this.picCeltics);
            this.MainMenuStrip = this.mnuBasketballTeams;
            this.Name = "frmBasketballTeams";
            this.Text = "Basketball Teams by Sasha";
            this.mnuBasketballTeams.ResumeLayout(false);
            this.mnuBasketballTeams.PerformLayout();
            this.grbCitiesAndTeams.ResumeLayout(false);
            this.grbCitiesAndTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCeltics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCavaliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBasketballTeams;
        private System.Windows.Forms.ToolStripMenuItem mniCities;
        private System.Windows.Forms.ToolStripMenuItem mniToronto;
        private System.Windows.Forms.ToolStripMenuItem mniCleveland;
        private System.Windows.Forms.ToolStripMenuItem mniMiami;
        private System.Windows.Forms.ToolStripMenuItem mniBoston;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbCitiesAndTeams;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.PictureBox picTeam;
        private System.Windows.Forms.PictureBox picCavaliers;
        private System.Windows.Forms.PictureBox picHeat;
        private System.Windows.Forms.PictureBox picCeltics;
    }
}

