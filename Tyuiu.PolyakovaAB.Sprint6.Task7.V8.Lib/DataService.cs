using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int row = matrix.GetUpperBound(0);
            int column = matrix.Length / row;

            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= column; j++)
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
    }
}
