namespace CircSasha
{
    partial class frmCirc
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
            this.File = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(800, 24);
            this.File.TabIndex = 0;
            this.File.Text = "mnuFile";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.lblInstructions.Location = new System.Drawing.Point(116, 107);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(286, 26);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Enter the radius of the circle: ";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(475, 113);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalculate.Location = new System.Drawing.Point(335, 224);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 37);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.lblCircumference.Location = new System.Drawing.Point(189, 358);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(213, 26);
            this.lblCircumference.TabIndex = 4;
            this.lblCircumference.Text = "The circumference is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.lblAnswer.Location = new System.Drawing.Point(470, 358);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 26);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "???";
            // 
            // frmCirc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.File);
            this.MainMenuStrip = this.File;
            this.Name = "frmCirc";
            this.Text = "Circumference of a Circle by Sasha";
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.Label lblAnswer;
    }
}

