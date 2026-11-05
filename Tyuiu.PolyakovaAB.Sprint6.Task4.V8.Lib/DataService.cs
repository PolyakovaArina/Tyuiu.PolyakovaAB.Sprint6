using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue-startValue+1];
            int x = startValue;
            for (int i = 0; i < res.Length; i++)
            {
                if (x != 2)
                {
                    res[i] = Math.Round(Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x, 2);
                    x++;
                }
                else
                {
                    res[i] = 0;
                    x++;
                }
            }
            return res;
        }
    }
}
