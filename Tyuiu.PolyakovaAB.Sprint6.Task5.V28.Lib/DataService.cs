using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numA = new double[len];
            int ind = 0;
            using (StreamReader r = new StreamReader(path))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    numA[ind] = Math.Round(Convert.ToDouble(line), 2);
                    ind++;
                }
            }
            numA = numA.Where(val => val < 10).ToArray();
            return numA;
        }
    }
}
