namespace MatrixGames
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.DgvMatrix = new System.Windows.Forms.DataGridView();
            this.Nothing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.Lblp1 = new System.Windows.Forms.Label();
            this.Lblp2 = new System.Windows.Forms.Label();
            this.Lblq1 = new System.Windows.Forms.Label();
            this.Lblq2 = new System.Windows.Forms.Label();
            this.LblV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(100, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(193, 25);
            this.Label1.TabIndex = 84;
            this.Label1.Text = "Матричные игры";
            // 
            // DgvMatrix
            // 
            this.DgvMatrix.AllowUserToAddRows = false;
            this.DgvMatrix.AllowUserToDeleteRows = false;
            this.DgvMatrix.AllowUserToResizeColumns = false;
            this.DgvMatrix.AllowUserToResizeRows = false;
            this.DgvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMatrix.BackgroundColor = System.Drawing.Color.White;
            this.DgvMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvMatrix.ColumnHeadersHeight = 30;
            this.DgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nothing,
            this.B1,
            this.B2});
            this.DgvMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMatrix.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvMatrix.EnableHeadersVisualStyles = false;
            this.DgvMatrix.GridColor = System.Drawing.Color.White;
            this.DgvMatrix.Location = new System.Drawing.Point(12, 51);
            this.DgvMatrix.Name = "DgvMatrix";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvMatrix.RowHeadersVisible = false;
            this.DgvMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMatrix.Size = new System.Drawing.Size(377, 92);
            this.DgvMatrix.TabIndex = 85;
            this.DgvMatrix.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvMatrix_EditingControlShowing);
            // 
            // Nothing
            // 
            this.Nothing.HeaderText = "";
            this.Nothing.Name = "Nothing";
            this.Nothing.ReadOnly = true;
            this.Nothing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nothing.Visible = false;
            // 
            // B1
            // 
            this.B1.HeaderText = "B1";
            this.B1.Name = "B1";
            this.B1.Visible = false;
            // 
            // B2
            // 
            this.B2.HeaderText = "B2";
            this.B2.Name = "B2";
            this.B2.Visible = false;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.Brown;
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCalculate.ForeColor = System.Drawing.Color.White;
            this.BtnCalculate.Location = new System.Drawing.Point(12, 149);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(178, 36);
            this.BtnCalculate.TabIndex = 117;
            this.BtnCalculate.Text = "Смешанный";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Lblp1
            // 
            this.Lblp1.AutoSize = true;
            this.Lblp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblp1.Location = new System.Drawing.Point(21, 213);
            this.Lblp1.Name = "Lblp1";
            this.Lblp1.Size = new System.Drawing.Size(31, 24);
            this.Lblp1.TabIndex = 118;
            this.Lblp1.Text = "p1";
            // 
            // Lblp2
            // 
            this.Lblp2.AutoSize = true;
            this.Lblp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblp2.Location = new System.Drawing.Point(21, 252);
            this.Lblp2.Name = "Lblp2";
            this.Lblp2.Size = new System.Drawing.Size(31, 24);
            this.Lblp2.TabIndex = 119;
            this.Lblp2.Text = "p2";
            // 
            // Lblq1
            // 
            this.Lblq1.AutoSize = true;
            this.Lblq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblq1.Location = new System.Drawing.Point(21, 290);
            this.Lblq1.Name = "Lblq1";
            this.Lblq1.Size = new System.Drawing.Size(31, 24);
            this.Lblq1.TabIndex = 120;
            this.Lblq1.Text = "q1";
            // 
            // Lblq2
            // 
            this.Lblq2.AutoSize = true;
            this.Lblq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblq2.Location = new System.Drawing.Point(21, 327);
            this.Lblq2.Name = "Lblq2";
            this.Lblq2.Size = new System.Drawing.Size(31, 24);
            this.Lblq2.TabIndex = 121;
            this.Lblq2.Text = "q2";
            // 
            // LblV
            // 
            this.LblV.AutoSize = true;
            this.LblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblV.Location = new System.Drawing.Point(21, 368);
            this.LblV.Name = "LblV";
            this.LblV.Size = new System.Drawing.Size(23, 24);
            this.LblV.TabIndex = 122;
            this.LblV.Text = "V";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(211, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 36);
            this.button1.TabIndex = 123;
            this.button1.Text = "Чистый";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblV);
            this.Controls.Add(this.Lblq2);
            this.Controls.Add(this.Lblq1);
            this.Controls.Add(this.Lblp2);
            this.Controls.Add(this.Lblp1);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.DgvMatrix);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatrixGames";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        public System.Windows.Forms.DataGridView DgvMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nothing;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1;
        private System.Windows.Forms.DataGridViewTextBoxColumn B2;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label Lblp1;
        private System.Windows.Forms.Label Lblp2;
        private System.Windows.Forms.Label Lblq1;
        private System.Windows.Forms.Label Lblq2;
        private System.Windows.Forms.Label LblV;
        private System.Windows.Forms.Button button1;
    }
}

