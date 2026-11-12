using Tyuiu.PolyakovaAB.Sprint6.Task7.V8.Lib;
namespace Tyuiu.PolyakovaAB.Sprint6.Task7.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filepath)
        {
            string fileData = File.ReadAllText(filepath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arV = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < line_r.Length; c++)
                {
                    arV[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            int[,] arV = new int[rows, columns];

            arV = LoadFromFileData(openFilePath);

            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            dataGridView2.ColumnCount =  columns;
            dataGridView2.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 35;
                dataGridView2.Columns[i].Width = 35;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0;c < columns; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = arV[r, c];
                }
            }
            arV = ds.GetMatrix(LoadFromFileData(openFilePath));
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arV = new int[rows, columns];
            arV = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridView2.Rows[r].Cells[c].Value = arV[r, c];
                }
            }
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7V8";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridView2.RowCount;
            int columns = dataGridView2.ColumnCount;

            string str = "";

            for (int i = 0;  i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView2.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
