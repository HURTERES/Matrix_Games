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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.DgvMatrix = new System.Windows.Forms.DataGridView();
            this.Nothing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCalculate = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMatrix.ColumnHeadersHeight = 30;
            this.DgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nothing,
            this.B1,
            this.B2});
            this.DgvMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMatrix.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMatrix.EnableHeadersVisualStyles = false;
            this.DgvMatrix.GridColor = System.Drawing.Color.White;
            this.DgvMatrix.Location = new System.Drawing.Point(12, 51);
            this.DgvMatrix.Name = "DgvMatrix";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvMatrix.RowHeadersVisible = false;
            this.DgvMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
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
            this.BtnCalculate.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCalculate.ForeColor = System.Drawing.Color.Black;
            this.BtnCalculate.Location = new System.Drawing.Point(12, 149);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(178, 36);
            this.BtnCalculate.TabIndex = 117;
            this.BtnCalculate.Text = "Смешанный";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
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
            this.ClientSize = new System.Drawing.Size(401, 200);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

