using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int r = matrix.GetUpperBound(0)+1;
            int c = matrix.Length / r;
            int[] v = new int[r];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j == 4)
                    {
                        v[i] = matrix[i, j];
                    }
                }
            }
            Array.Sort(v);
            for (int i = 0; i < r; i++)
            {
                matrix[i, 4] = v[i];
            }
            return matrix;
        }
    }
}
