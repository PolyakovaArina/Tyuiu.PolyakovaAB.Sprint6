using Tyuiu.PolyakovaAB.Sprint6.Task4.V8.Lib;
using System.Windows.Forms;
namespace Tyuiu.PolyakovaAB.Sprint6.Task4.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string Starl =  Convert.ToString(v[i]);
                    textBox3.AppendText(Starl + Environment.NewLine);
                    this.chart1.Series[0].Points.AddXY(cX, v[i]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sprint6 Task4 V8 выполнила студентка ИИПб-26-1 Полякова Арина Вячеславовна");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V8.txt";
                File.WriteAllText(path, textBox3.Text);
                DialogResult dr = MessageBox.Show("Файл" + path + "сохранен успешно \n Открыть его в блокноте?","файл", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
