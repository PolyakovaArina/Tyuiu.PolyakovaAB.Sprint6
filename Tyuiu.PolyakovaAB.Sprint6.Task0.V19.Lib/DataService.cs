using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task0.V19.Lib
{
    public class DataService : ISprint6Task0V19
    {
        public double Calculate(int x)
        {
            double y = -0.25 * (Math.Pow(x,3) - 3 * Math.Pow(x,2) + 4);
            return (y);
        }
    }
}
