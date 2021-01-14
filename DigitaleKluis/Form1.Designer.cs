
namespace DigitaleKluis
{
    partial class Form1
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
            this.btnKluis = new System.Windows.Forms.Button();
            this.numKluis = new System.Windows.Forms.NumericUpDown();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblKluis = new System.Windows.Forms.Label();
            this.lblKluis2 = new System.Windows.Forms.Label();
            this.lblAttempts2 = new System.Windows.Forms.Label();
            this.numKluis2 = new System.Windows.Forms.NumericUpDown();
            this.btnKluis2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKluis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKluis2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKluis
            // 
            this.btnKluis.Location = new System.Drawing.Point(206, 39);
            this.btnKluis.Name = "btnKluis";
            this.btnKluis.Size = new System.Drawing.Size(75, 23);
            this.btnKluis.TabIndex = 1;
            this.btnKluis.Text = "Enter code";
            this.btnKluis.UseVisualStyleBackColor = true;
            this.btnKluis.Click += new System.EventHandler(this.btnKluis_Click);
            // 
            // numKluis
            // 
            this.numKluis.Location = new System.Drawing.Point(55, 39);
            this.numKluis.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numKluis.Name = "numKluis";
            this.numKluis.Size = new System.Drawing.Size(120, 20);
            this.numKluis.TabIndex = 2;
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(56, 62);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(54, 13);
            this.lblAttempts.TabIndex = 3;
            this.lblAttempts.Text = "Attempts: ";
            // 
            // lblKluis
            // 
            this.lblKluis.AutoSize = true;
            this.lblKluis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKluis.Location = new System.Drawing.Point(55, 20);
            this.lblKluis.Name = "lblKluis";
            this.lblKluis.Size = new System.Drawing.Size(55, 15);
            this.lblKluis.TabIndex = 4;
            this.lblKluis.Text = "Kluis 1:";
            // 
            // lblKluis2
            // 
            this.lblKluis2.AutoSize = true;
            this.lblKluis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKluis2.Location = new System.Drawing.Point(55, 96);
            this.lblKluis2.Name = "lblKluis2";
            this.lblKluis2.Size = new System.Drawing.Size(55, 15);
            this.lblKluis2.TabIndex = 8;
            this.lblKluis2.Text = "Kluis 2:";
            // 
            // lblAttempts2
            // 
            this.lblAttempts2.AutoSize = true;
            this.lblAttempts2.Location = new System.Drawing.Point(56, 138);
            this.lblAttempts2.Name = "lblAttempts2";
            this.lblAttempts2.Size = new System.Drawing.Size(54, 13);
            this.lblAttempts2.TabIndex = 7;
            this.lblAttempts2.Text = "Attempts: ";
            // 
            // numKluis2
            // 
            this.numKluis2.Location = new System.Drawing.Point(55, 115);
            this.numKluis2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numKluis2.Name = "numKluis2";
            this.numKluis2.Size = new System.Drawing.Size(120, 20);
            this.numKluis2.TabIndex = 6;
            // 
            // btnKluis2
            // 
            this.btnKluis2.Location = new System.Drawing.Point(206, 115);
            this.btnKluis2.Name = "btnKluis2";
            this.btnKluis2.Size = new System.Drawing.Size(75, 23);
            this.btnKluis2.TabIndex = 5;
            this.btnKluis2.Text = "Enter code";
            this.btnKluis2.UseVisualStyleBackColor = true;
            this.btnKluis2.Click += new System.EventHandler(this.btnKluis2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 178);
            this.Controls.Add(this.lblKluis2);
            this.Controls.Add(this.lblAttempts2);
            this.Controls.Add(this.numKluis2);
            this.Controls.Add(this.btnKluis2);
            this.Controls.Add(this.lblKluis);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.numKluis);
            this.Controls.Add(this.btnKluis);
            this.Name = "Form1";
            this.Text = "Digitale Kluis";
            ((System.ComponentModel.ISupportInitialize)(this.numKluis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKluis2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKluis;
        private System.Windows.Forms.NumericUpDown numKluis;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblKluis;
        private System.Windows.Forms.Label lblKluis2;
        private System.Windows.Forms.Label lblAttempts2;
        private System.Windows.Forms.NumericUpDown numKluis2;
        private System.Windows.Forms.Button btnKluis2;
    }
}

