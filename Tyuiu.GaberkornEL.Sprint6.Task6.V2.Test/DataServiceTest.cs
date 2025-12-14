using Tyuiu.GaberkornEL.Sprint6.Task6.V2.Lib;
namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Users\Ymir\source\repos\Tyuiu.GaberkornEL.Sprint6\Tyuiu.StoyakinNM.Sprint6.Task6.V2\bin\Debug\InPutDataFileTask6V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}