using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        
        public int[,] GetMatrix(string path)
        {
            int[,] matrix = LoadFromFileData(path);
            int row = matrix.GetLength(0);
            int column = matrix.Length/row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j == 7)
                    {
                        if (matrix[i, j] != 5)
                        {
                            matrix[i, j] = -1;
                        }
                    }
                }
            }
            return matrix;
        }
        static int rows;
        static int columns;
        static string openFilePath;
        

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

    }
}
