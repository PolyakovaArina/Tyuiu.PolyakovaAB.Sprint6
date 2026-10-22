using System.Drawing.Text;
using Tyuiu.PolyakovaAB.Sprint6.Task0.V19.Lib;

namespace Tyuiu.PolyakovaAB.Sprint6.Task0.V19
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
                textBox2.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1.Text)));
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
        private void textBoxKeyPress_PAV(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonBoxClick2_PAV(object sender, EventArgs e)
        {
            MessageBox.Show("Sprint6 Task0 V19 выполнила студентка ИИПб-26-1 Полякова Арина Вячеславовна");
        }
    }
}
