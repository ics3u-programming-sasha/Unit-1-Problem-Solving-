namespace PizzaCostSasha
{
    partial class frmPizzaCost
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
            this.lblEnterDiameter = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblASubtotal = new System.Windows.Forms.Label();
            this.lblATotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterDiameter
            // 
            this.lblEnterDiameter.AutoSize = true;
            this.lblEnterDiameter.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDiameter.Location = new System.Drawing.Point(72, 79);
            this.lblEnterDiameter.Name = "lblEnterDiameter";
            this.lblEnterDiameter.Size = new System.Drawing.Size(415, 37);
            this.lblEnterDiameter.TabIndex = 0;
            this.lblEnterDiameter.Text = "Enter the diameter of the pizza (in inches): ";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(568, 84);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(313, 199);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 43);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Myanmar Text", 14.25F);
            this.lblSubtotal.Location = new System.Drawing.Point(269, 308);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(116, 34);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal ($):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Myanmar Text", 14.25F);
            this.lblTotal.Location = new System.Drawing.Point(269, 373);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 34);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total ($):";
            // 
            // lblASubtotal
            // 
            this.lblASubtotal.AutoSize = true;
            this.lblASubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASubtotal.Location = new System.Drawing.Point(447, 309);
            this.lblASubtotal.Name = "lblASubtotal";
            this.lblASubtotal.Size = new System.Drawing.Size(40, 24);
            this.lblASubtotal.TabIndex = 5;
            this.lblASubtotal.Text = "???";
            // 
            // lblATotal
            // 
            this.lblATotal.AutoSize = true;
            this.lblATotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATotal.Location = new System.Drawing.Point(447, 374);
            this.lblATotal.Name = "lblATotal";
            this.lblATotal.Size = new System.Drawing.Size(40, 24);
            this.lblATotal.TabIndex = 6;
            this.lblATotal.Text = "???";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblATotal);
            this.Controls.Add(this.lblASubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblEnterDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDiameter;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblASubtotal;
        private System.Windows.Forms.Label lblATotal;
    }
}

