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
    }
}
