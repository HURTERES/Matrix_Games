namespace MatrixGames
{
    partial class FormAnswer
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
            this.LblV = new System.Windows.Forms.Label();
            this.Lblq2 = new System.Windows.Forms.Label();
            this.Lblq1 = new System.Windows.Forms.Label();
            this.Lblp2 = new System.Windows.Forms.Label();
            this.Lblp1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblV
            // 
            this.LblV.AutoSize = true;
            this.LblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblV.Location = new System.Drawing.Point(12, 167);
            this.LblV.Name = "LblV";
            this.LblV.Size = new System.Drawing.Size(23, 24);
            this.LblV.TabIndex = 127;
            this.LblV.Text = "V";
            // 
            // Lblq2
            // 
            this.Lblq2.AutoSize = true;
            this.Lblq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblq2.Location = new System.Drawing.Point(12, 126);
            this.Lblq2.Name = "Lblq2";
            this.Lblq2.Size = new System.Drawing.Size(31, 24);
            this.Lblq2.TabIndex = 126;
            this.Lblq2.Text = "q2";
            // 
            // Lblq1
            // 
            this.Lblq1.AutoSize = true;
            this.Lblq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblq1.Location = new System.Drawing.Point(12, 89);
            this.Lblq1.Name = "Lblq1";
            this.Lblq1.Size = new System.Drawing.Size(31, 24);
            this.Lblq1.TabIndex = 125;
            this.Lblq1.Text = "q1";
            // 
            // Lblp2
            // 
            this.Lblp2.AutoSize = true;
            this.Lblp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblp2.Location = new System.Drawing.Point(12, 51);
            this.Lblp2.Name = "Lblp2";
            this.Lblp2.Size = new System.Drawing.Size(31, 24);
            this.Lblp2.TabIndex = 124;
            this.Lblp2.Text = "p2";
            // 
            // Lblp1
            // 
            this.Lblp1.AutoSize = true;
            this.Lblp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblp1.Location = new System.Drawing.Point(12, 12);
            this.Lblp1.Name = "Lblp1";
            this.Lblp1.Size = new System.Drawing.Size(31, 24);
            this.Lblp1.TabIndex = 123;
            this.Lblp1.Text = "p1";
            // 
            // FormAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(183, 194);
            this.Controls.Add(this.LblV);
            this.Controls.Add(this.Lblq2);
            this.Controls.Add(this.Lblq1);
            this.Controls.Add(this.Lblp2);
            this.Controls.Add(this.Lblp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblV;
        public System.Windows.Forms.Label Lblq2;
        public System.Windows.Forms.Label Lblq1;
        public System.Windows.Forms.Label Lblp2;
        public System.Windows.Forms.Label Lblp1;
    }
}