using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TomilovDA.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            string resString = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(" ");
                    if (words.Length > 1)
                    {
                        resString += words[1] + " ";
                    }
                }
            }
            return resString.TrimEnd();
        }
    }
}
