using Tyuiu.PolyakovaAB.Sprint6.Task1.V30.Lib;
namespace Tyuiu.PolyakovaAB.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
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
                v = (ds.GetMassFunction(star,stop));
                for (int i = 0; i < v.Length; i++)
                {
                    string Starl = String.Format("|{0,5:d}      |     {1,10:f2}   |", star, v[i]);
                    textBox3.AppendText(Starl+Environment.NewLine);
                    star++;
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
        
        private void buttonBoxClick2_PAV(object sender, EventArgs e)
        {
            MessageBox.Show("Sprint6 Task1 V30 выполнила студентка ИИПб-26-1 Полякова Арина Вячеславовна");
        }
    }
}
