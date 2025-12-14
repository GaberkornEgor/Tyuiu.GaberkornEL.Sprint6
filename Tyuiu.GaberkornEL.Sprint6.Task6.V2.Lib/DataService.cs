using System.Diagnostics;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {

        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (words.Length > 1)
                    {
                        resStr = resStr + " " + words[1];
                    }
                }
            }

            return resStr.Trim();
        }
    }
}