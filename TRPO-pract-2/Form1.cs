using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_pract_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GetAnswer_Click(object sender, EventArgs e)
        {
            double upI = 1;
            double downI = 1;
            double up = 1;
            double down = 1;

            double X = (double)nud_X.Value;

            for (int i = 0; i < 7; i++)
            {
                downI = upI * 2 - 1;
                upI = upI * 2;

                up *= X - upI;
                down *= X - downI;
            }

            tbx_AnswerS.Text = (up / down).ToString();
        }

        private void btn_GetAnswerN_Click(object sender, EventArgs e)
        {
            List<double> n = new List<double>();
            int nCounter = 2;
            double y0 = 0;
            double y1 = 0;
            double currentY = 0;
            try
            {
                y0 = Convert.ToDouble(tbx_Y0.Text);
                y1 = Convert.ToDouble(tbx_Y1.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный формат данных", "Ошибка");
            }
            n.Add(y0);
            n.Add(y1);
            while(Math.Abs(n[nCounter - 1] - n[nCounter - 2]) >= 2.71828182846)
            {
                currentY = 1 / Math.Pow((1 + Math.Pow(Math.Sin(n[nCounter - 1]), 2) + Math.Pow(Math.Sin(n[nCounter - 2]), 2)), (double)1/2);
                nCounter++;
                n.Add(currentY);
            }
            tbx_AnswerN.Text = currentY.ToString();            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №2, вариант 8, Филяк, ИСП-41", "О программе");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
