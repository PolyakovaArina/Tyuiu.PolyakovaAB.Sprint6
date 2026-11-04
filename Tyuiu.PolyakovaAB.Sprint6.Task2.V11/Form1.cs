using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using Tyuiu.PolyakovaAB.Sprint6.Task2.V11.Lib;
namespace Tyuiu.PolyakovaAB.Sprint6.Task2.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBoxClick_PAV(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int star = Convert.ToInt32(textBox1.Text);
                int stop = Convert.ToInt32(textBox2.Text);
                double[] v = new double[stop - star + 1];
                v = (ds.GetMassFunction(star, stop));
                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < v.Length; i++)
                {
                    int cX = star + i;
                    string Starl = String.Format("|{0,5:d}      |     {1,10:f2}   |", cX, v[i]);
                    textBox3.AppendText(Starl + Environment.NewLine);
                    this.chart1.Series[0].Points.AddXY(cX, v[i]);
                    
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonBoxClick2_PAV(object sender, EventArgs e)
        {
            MessageBox.Show("Sprint6 Task2 V11 выполнила студентка ИИПб-26-1 Полякова Арина Вячеславовна");
        }

        
    }
}
