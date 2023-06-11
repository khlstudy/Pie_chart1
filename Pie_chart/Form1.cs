using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pie_chart
{
    public partial class frmSector : Form
    {
        int m;
        double Sum;

        public frmSector()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (txtColvoEl.Text == "")
            { MessageBox.Show("Кількісь категорій витрат не введено!", "Помилка"); }
            else
            {
                m = Int32.Parse(txtColvoEl.Text);
                if (m > 10)
                { MessageBox.Show("Кількісь категорій витрат перебільшує число 10!", "Помилка"); }
                else
                {
                    dgvMass.ColumnCount = m;

                    for (int j = 0; j < m; j++)
                    {
                        dgvMass.Columns[j].Width = 110;
                        dgvMass.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvMass.Columns[j].HeaderText = "Витрати категорії " + (j + 1).ToString();
                    }
                }
            }

        }

        private void btCreateDiag_Click(object sender, EventArgs e)
        {
            Sum = 0;
            double[] A = new double[m];
            string[] B = new string[m];

            for (int j = 0; j < m; j++)
            {
                A[j] = Convert.ToDouble(dgvMass.Rows[0].Cells[j].Value);
                B[j] = "Витрати категорії " + (j + 1).ToString();
                Sum += A[j];
                if (A[j] <= 0)
                { MessageBox.Show("Серед введених елементів є мінусові або нульові!", "Помилка"); }
            }

            if (Sum != 100)
            { MessageBox.Show("Сума відсоткового утримання витрат повинна дорівнювати 100%! Перевірте дані!", "Помилка"); }
            else
            {
                chartSector.Series[0].Points.DataBindXY(B, A);
                chartSector.ChartAreas[0].Area3DStyle.Enable3D = true;
            }

        }
    }
}
