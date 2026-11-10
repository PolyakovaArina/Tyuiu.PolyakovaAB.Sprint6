using Tyuiu.PolyakovaAB.Sprint6.Task6.V29.Lib;
namespace Tyuiu.PolyakovaAB.Sprint6.Task6.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBox1.Text = File.ReadAllText(openFilePath);
            groupBox1.Text = groupBox1.Text + " " + openFileDialog1.FileName;
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string str = "i";
            textBox2.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
