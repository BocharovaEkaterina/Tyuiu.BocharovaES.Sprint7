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
        public string[,] SortUbyvImproved(string[,] data, int sortColumn)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            var valueRowPairs = new List<(int Value, int RowIndex)>();

            for (int i = 1; i < rows; i++)
            {
                if (int.TryParse(data[i, sortColumn], out int value))
                {
                    valueRowPairs.Add((value, i));
                }
            }

            valueRowPairs.Sort((x, y) => y.Value.CompareTo(x.Value));

            string[,] sortedData = new string[rows, cols];

            for (int j = 0; j < cols; j++)
            {
                sortedData[0, j] = data[0, j];
            }

            for (int i = 0; i < valueRowPairs.Count; i++)
            {
                int sourceRow = valueRowPairs[i].RowIndex;
                int targetRow = i + 1;

                for (int j = 0; j < cols; j++)
                {
                    sortedData[targetRow, j] = data[sourceRow, j];
                }
            }

            return sortedData;
        }
        public string[,] SortVozrastImproved(string[,] data, int sortColumn)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            var valueRowPairs = new List<(int Value, int RowIndex)>();

            for (int i = 1; i < rows; i++)
            {
                if (int.TryParse(data[i, sortColumn], out int value))
                {
                    valueRowPairs.Add((value, i));
                }
            }

            valueRowPairs.Sort((x, y) => x.Value.CompareTo(y.Value));

            string[,] sortedData = new string[rows, cols];

            for (int j = 0; j < cols; j++)
            {
                sortedData[0, j] = data[0, j];
            }

            for (int i = 0; i < valueRowPairs.Count; i++)
            {
                int sourceRow = valueRowPairs[i].RowIndex;
                int targetRow = i + 1;

                for (int j = 0; j < cols; j++)
                {
                    sortedData[targetRow, j] = data[sourceRow, j];
                }
            }

            return sortedData;
        }
        public double MinValue(int[] values)
        {
            double min = 10000000000000000;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            return min;
        }
        public double SrValue(int[] value)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sum += value[i];
                count++;
            }
            double y = sum / count;
            return y;
        }

    }
}
