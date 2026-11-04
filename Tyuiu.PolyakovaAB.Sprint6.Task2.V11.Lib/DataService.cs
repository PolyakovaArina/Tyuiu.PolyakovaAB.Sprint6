using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task2.V11.Lib
{
    public class DataService : ISprint6Task2V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            double[] res = new double[stopValue-startValue+1];
            int x = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i + 1 !=0)
                {
                    res[x] = Math.Round((Math.Cos(i) / (i + 1)) - Math.Cos(i) * 1.3 + 3 * i,2);
                    x++;
                }
                else
                {
                    res[x] = 0.00;
                    x++;
                }
            }
            return res;
        }
    }
}
