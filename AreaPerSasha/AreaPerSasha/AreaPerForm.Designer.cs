namespace AreaPerSasha
{
    partial class frmAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAPerimeter = new System.Windows.Forms.Label();
            this.lblAArea = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(119, 88);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(106, 28);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(326, 93);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(326, 193);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCalculate.Location = new System.Drawing.Point(556, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 39);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblPerimeter.Location = new System.Drawing.Point(195, 293);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(155, 28);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "The perimeter is:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblArea.Location = new System.Drawing.Point(237, 377);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(107, 28);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "The area is:";
            // 
            // lblAPerimeter
            // 
            this.lblAPerimeter.AutoSize = true;
            this.lblAPerimeter.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblAPerimeter.Location = new System.Drawing.Point(489, 293);
            this.lblAPerimeter.Name = "lblAPerimeter";
            this.lblAPerimeter.Size = new System.Drawing.Size(39, 28);
            this.lblAPerimeter.TabIndex = 7;
            this.lblAPerimeter.Text = "???";
            // 
            // lblAArea
            // 
            this.lblAArea.AutoSize = true;
            this.lblAArea.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblAArea.Location = new System.Drawing.Point(489, 377);
            this.lblAArea.Name = "lblAArea";
            this.lblAArea.Size = new System.Drawing.Size(39, 28);
            this.lblAArea.TabIndex = 8;
            this.lblAArea.Text = "???";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(125, 193);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(100, 28);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "Width (m)";
            // 
            // frmAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblAArea);
            this.Controls.Add(this.lblAPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAreaPer";
            this.Text = "Area and Perimeter of a Rectangle by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAPerimeter;
        private System.Windows.Forms.Label lblAArea;
        private System.Windows.Forms.Label lblWidth;
    }
}

