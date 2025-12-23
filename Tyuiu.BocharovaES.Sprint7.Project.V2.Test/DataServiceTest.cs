using Tyuiu.BocharovaES.Sprint7.Project.V2.Lib;
namespace Tyuiu.BocharovaES.Sprint7.Project.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFileData()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BocharovaES.Sprint7\База данных.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckedMaxValue()
        {
            DataService ds = new DataService();
            int[] maxValueTest = { 3, 8, 5, 4, 10 };
            double wait = 10;
            double res = ds.MaxValue(maxValueTest);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedSumValue()
        {
            DataService ds = new DataService();
            int[] sumValueTest = { 3, 8, 5, 4, 10 };
            double wait = 30;
            double res = ds.SumValue(sumValueTest);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedSortUbyvImprove()
        {
            DataService ds = new DataService();
            string[,] basa = {
                                { "ID", "Название",    "Длительность"},
                                { "1",   "Примерный видеоклип", "240"},
                                { "2",   "Забавный момент", "180"},
                                { "3",   "Энергичный ритм", "300"}
                             };
            int column = 0;

            string[,] sortedbasa = { { "ID", "Название",    "Длительность"},
                                     { "3", "Энергичный ритм", "300" },
                                     { "2",   "Забавный момент", "180"},
                                     { "1",   "Примерный видеоклип", "240"}
                                   };

            string[,] result = ds.SortUbyvImproved(basa, column);
            CollectionAssert.AreEqual(result, sortedbasa);
        }
        [TestMethod]
        public void SortVozrastImproved()
        {
            DataService ds = new DataService();

            string[,] basa = {
                                { "ID", "Название",    "Длительность"},
                                { "1",   "Примерный видеоклип", "240"},
                                { "2",   "Забавный момент", "180"},
                                { "3",   "Энергичный ритм", "300"}
                             };
            int column = 2;
            string[,] sortedbasa = { { "ID", "Название", "Длительность" },
                                     { "2",   "Забавный момент", "180"},
                                     { "1",   "Примерный видеоклип", "240"},
                                     { "3",   "Энергичный ритм", "300"}
                                   };

            string[,] result = ds.SortVozrastImproved(basa, column);
            CollectionAssert.AreEqual(sortedbasa, result);
        }
    }
}
