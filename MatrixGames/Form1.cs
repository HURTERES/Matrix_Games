using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvMatrix.Columns[0].Visible = true;
            DgvMatrix.Columns[1].Visible = true;
            DgvMatrix.Columns[2].Visible = true;
            DgvMatrix.Rows.Add();
            DgvMatrix.Rows.Add();
            DgvMatrix.Rows[0].Cells[0].Value = "A1";
            DgvMatrix.Rows[1].Cells[0].Value = "A2";
            DgvMatrix.Rows[0].Cells[1].Value = 0;
            DgvMatrix.Rows[0].Cells[2].Value = 0;
            DgvMatrix.Rows[1].Cells[1].Value = 0;
            DgvMatrix.Rows[1].Cells[2].Value = 0;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Выполнить расчет смешанным типом
            FormAnswer Frm = new FormAnswer();   
            Frm.Lblq1.Visible = true;
            Frm.Lblq2.Visible = true;
            Frm.LblV.Location = new Point(12, 167);
            double a11 = 0, a12 = 0, a21 = 0, a22 = 0, p1, p2, q1, q2, V;
            a11 = double.Parse(DgvMatrix.Rows[0].Cells[1].Value.ToString());
            a12 = double.Parse(DgvMatrix.Rows[0].Cells[2].Value.ToString());
            a21 = double.Parse(DgvMatrix.Rows[1].Cells[1].Value.ToString());
            a22 = double.Parse(DgvMatrix.Rows[1].Cells[2].Value.ToString());
            p1 = (a22 - a21) / (a11 + a22 - a21 - a12);
            Frm.Lblp1.Text = "p1 = " + Math.Round(p1,3).ToString();
            p2 = 1 - p1;
            Frm.Lblp2.Text= "p2 = " + Math.Round(p2,3).ToString();
            q1 = (a22-a12) / (a11+a22-a21-a12);
            Frm.Lblq1.Text = "q1 = "+ Math.Round(q1, 3).ToString();
            q2 = 1 - q1;
            Frm.Lblq2.Text= "q2 = "+ Math.Round(q2, 3).ToString();
            V = (a11 * a22 - a12 * a21) / (a11+a22-a21-a12);
            Frm.LblV.Text = "V = " + Math.Round(V, 3).ToString();
            Frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Выполнить расчет чистым типом
            FormAnswer Frm = new FormAnswer();
            List<double> LstH = new List<double>();
            List<double> LstV = new List<double>();
            double a11 = 0, a12 = 0, a21 = 0, a22 = 0,MaxMin=0,MinMax=0;
            a11 = double.Parse(DgvMatrix.Rows[0].Cells[1].Value.ToString());
            a12 = double.Parse(DgvMatrix.Rows[0].Cells[2].Value.ToString());
            a21 = double.Parse(DgvMatrix.Rows[1].Cells[1].Value.ToString());
            a22 = double.Parse(DgvMatrix.Rows[1].Cells[2].Value.ToString());

            LstH.Add(Math.Min(a11,a12));
            LstH.Add(Math.Min(a21,a22));
            LstV.Add(Math.Max(a11, a21));
            LstV.Add(Math.Max(a12, a22));

            MaxMin = Math.Min(LstV[0], LstV[1]);
            MinMax = Math.Max(LstH[0], LstH[1]);

            Frm.Lblp1.Text = "MinMax = " + MinMax;
            Frm.Lblp2.Text = "MaxMin = " + MaxMin;
            Frm.Lblq1.Visible = false;
            Frm.Lblq2.Visible = false;
            Frm.LblV.Location = new Point(12, 89);

            if (MaxMin == MinMax && MaxMin != 0)
            {
                Frm.LblV.Text = "V = " + MaxMin;
                Frm.ShowDialog();
            }
            else
            {
                Frm.LblV.Text = "V = 0";
                MessageBox.Show("Игра не решается в чистых стратегиях");
            }

        }

        private void DgvMatrix_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress -= TextBox_KeyPress;
                textBox.KeyPress += TextBox_KeyPress;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
