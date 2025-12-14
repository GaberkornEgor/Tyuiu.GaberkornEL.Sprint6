using System.Diagnostics;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string str, string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"File not found: {path}");

            StringBuilder result = new StringBuilder();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ' },
                                                  StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length > 1)
                        {
                            if (result.Length > 0)
                                result.Append(" ");

                            result.Append(words[1]);
                        }
                    }
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error processing file: {ex.Message}", ex);
            }
        }
    }
}