using System.Text;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Tyuiu.PolyakovaAB.Sprint6.Task5.V28.Lib;
namespace Tyuiu.PolyakovaAB.Sprint6.Task5.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Арина\source\repos\Tyuiu.PolyakovaAB.Sprint6\Tyuiu.PolyakovaAB.Sprint6.Task5.V28\bin\Debug\net8.0-windows\InPutFileTask5V28.txt";


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 70;
            this.chart1.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
            chart1.Series[0].Points.Clear();
            double[] numM = new double[ds.len];
            numM = ds.LoadFromDataFile(path);
            for (int i = 0; i < numM.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numM[i]));
                chart1.Series[0].Points.AddXY(i, numM[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sprint6 Task4 V8 выполнила студентка ИИПб-26-1 Полякова Арина Вячеславовна");
        }
    }
}
