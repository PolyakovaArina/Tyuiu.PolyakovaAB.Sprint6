using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue-startValue+1];
            int x = startValue;
            for (int i = 0; i < res.Length; i++)
            {
                
                res[i] = Math.Round((((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6),2);
                x++;
            }
            return res;
        }
    }
}
