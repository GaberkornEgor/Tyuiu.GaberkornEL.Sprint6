using Tyuiu.GaberkornEL.Sprint6.Task5.V29.Lib;
namespace Tyuiu.GaberkornEL.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\konev\source\repos\Tyuiu.GaberkornEL.Sprint6\Tyuiu.GaberkornEL.Sprint6.Task5.V29\bin\Debug\net8.0-windows\InPutDataFileTask5V29.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 12, 12.89, 35, 13.83, 12.76 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}