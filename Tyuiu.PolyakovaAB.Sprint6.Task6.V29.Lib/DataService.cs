using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAB.Sprint6.Task6.V29.Lib;

public class DataService : ISprint6Task6V29
{
    public string CollectTextFromFile(string path)
    {

        string res = "";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(" ");
                foreach (string word in words)
                {
                    if (word.Contains("i"))
                    {
                        res = res + word + " ";
                    }
                }
            }
        }
        return res;
    }
}




