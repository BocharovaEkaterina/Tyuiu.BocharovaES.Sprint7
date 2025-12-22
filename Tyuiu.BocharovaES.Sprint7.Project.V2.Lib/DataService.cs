namespace Tyuiu.BocharovaES.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows;
            int columns;
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] mtrx = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = Convert.ToString(line_r[j]);
                }
            }
            return mtrx;
        }
        public double MaxValue(int[] values)
        {
            double max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }
        public double SumValue(int[] value)
        {
            double sum = 0;
            for(int i = 0; i < value.Length;i++)
            {
                sum += value[i];
            }
            return sum;
        }
    }
}
