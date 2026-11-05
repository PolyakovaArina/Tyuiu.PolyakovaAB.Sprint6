using Tyuiu.PolyakovaAB.Sprint6.Task3.V9.Lib;
namespace Tyuiu.PolyakovaAB.Sprint6.Task3.V9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] m = new int[5, 5] { { -14, 25, 26, 18, 17 },
            { 28, 10, 6, -2, 4 },
            { 30, 25, -3, 11, -10 },
            { 11, 32, -5, -20, 25 },
            { 2, -18, 11, 8, -20 } };

        private void Form1_Load(object sender, EventArgs e)
        {
            int r = m.GetUpperBound(0) + 1;
            int c = m.Length / r;

            dataGridView1.ColumnCount = c;
            dataGridView1.RowCount = r;

            for (int i = 0; i < c; i++)
            {
                dataGridView1.Columns[i].Width = 35;
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(m[i, j]);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила студентка группы ИИПб-26-1 Полякова Арина Вячеславовна");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] v = ds.Calculate(m);

            int ro = v.GetUpperBound(0) + 1;
            int co = v.Length / ro;

            dataGridView2.ColumnCount = co;
            dataGridView2.RowCount = ro;

            for (int i = 0; i < co; i++)
            {
                dataGridView2.Columns[i].Width = 35;
            }
            for (int i = 0; i < ro; i++)
            {
                for (int j = 0; j < co; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(v[i, j]);
                }
            }
        }
    }
}
