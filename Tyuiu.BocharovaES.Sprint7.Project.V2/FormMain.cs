using System.IO;
using Tyuiu.BocharovaES.Sprint7.Project.V2.Lib;
namespace Tyuiu.BocharovaES.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogProject_BES.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rowss;
        static int columns;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string openFilePath;
        DataService ds = new DataService();
        int cols, rows;

        private void toolStripMenuItemAbout_BES_Click_1(object sender, EventArgs e)
        {
            FormAbout formInstruction = new FormAbout();
            formInstruction.ShowDialog();
        }

        private void dataGridViewBase_BES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index).ToString();
            object header = this.dataGridViewBase_BES.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewBase_BES.Rows[index].HeaderCell.Value = indexStr;
        }

        private void buttonOpen_BES_Click(object sender, EventArgs e)
        {
            openFileDialogProject_BES.ShowDialog();
            openFilePath = openFileDialogProject_BES.FileName;
            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewBase_BES.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewBase_BES.RowCount = rows = arrayValues.GetLength(0);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewBase_BES.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
        }

        private void buttonOpenDio_BES_Click(object sender, EventArgs e)
        {
            string openFilePath;
            DataService ds = new DataService();
            int cols, rows;
            openFileDialogProject_BES.ShowDialog();
            openFilePath = openFileDialogProject_BES.FileName;
            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewChart_BES.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewChart_BES.RowCount = rows = arrayValues.GetLength(0);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewChart_BES.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonDio_BES.Enabled = true;
        }

        private void buttonDio_BES_Click(object sender, EventArgs e)
        {
            chartDio_BES.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Прибыли");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Только эта строка изменена

            foreach (DataGridViewRow row in this.dataGridViewChart_BES.Rows)
            {
                if (!row.IsNewRow && row.Cells[1] != null && row.Cells[1].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[1].Value);
                    series.Points.AddXY(label, hours);
                }
            }

            this.chartDio_BES.Series.Add(series);
        }

        private void buttonSum_BES_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < dataGridViewChart_BES.Rows.Count; i++)
                {
                    if (dataGridViewChart_BES.Rows[i].Visible)
                    {
                        count++;
                    }
                }

                if (count > 0)
                {
                    int[] values = new int[count];
                    int index = 0;

                    for (int i = 0; i < dataGridViewChart_BES.Rows.Count; i++)
                    {
                        if (dataGridViewChart_BES.Rows[i].Visible)
                        {
                            string val = dataGridViewChart_BES.Rows[i].Cells[1].Value?.ToString() ?? "0";
                            values[index] = int.Parse(val);
                            index++;
                        }
                    }
                    textBoxSum_BES.Text = ds.SumValue(values).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Введены неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMax_BES_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < dataGridViewChart_BES.Rows.Count; i++)
                {
                    if (dataGridViewChart_BES.Rows[i].Visible)
                    {
                        count++;
                    }
                }

                if (count > 0)
                {
                    int[] values = new int[count];
                    int index = 0;

                    for (int i = 0; i < dataGridViewChart_BES.Rows.Count; i++)
                    {
                        if (dataGridViewChart_BES.Rows[i].Visible)
                        {
                            string val = dataGridViewChart_BES.Rows[i].Cells[1].Value?.ToString() ?? "0";
                            values[index] = int.Parse(val);
                            index++;
                        }
                    }
                    textBoxMax_BES.Text = ds.MaxValue(values).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Введены неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_BES_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BES.ClearSelection();
            for (int i = 0; i <= dataGridViewBase_BES.Rows.Count - 1; i++)
                for (int j = 0; j <= dataGridViewBase_BES.ColumnCount - 1; j++)
                    if (dataGridViewBase_BES.Rows[i].Cells[j].Value != null && dataGridViewBase_BES.Rows[i].Cells[j].Value.ToString() == textBoxSearch_BES.Text)
                        dataGridViewBase_BES.Rows[i].Selected = true;
        }

        private void textBoxSearch_BES_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBoxSearch_BES.Text;
            foreach (DataGridViewRow row in dataGridViewBase_BES.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(currentText) && cell.Value.ToString().ToUpper().Contains(currentText.ToUpper()))
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void buttonIncreasing_BES_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadFromFileData(openFilePath);

            if (mx.GetLength(1) <= 5)
            {
                MessageBox.Show("Ошибка: недостаточно столбцов для сортировки по 6-му столбцу");
                return;
            }

            string[,] mxsort = ds.SortVozrastImproved(mx, 5);

            int rows = mxsort.GetLength(0);
            int columns = mxsort.GetLength(1);

            dataGridViewBase_BES.Rows.Clear();

            for (int i = 0; i < rows - 1; i++)
            {
                dataGridViewBase_BES.Rows.Add();
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_BES.Rows[i - 1].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void buttonDecreasing_BES_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadFromFileData(openFilePath);

            if (mx.GetLength(1) <= 5)
            {
                MessageBox.Show("Ошибка: недостаточно столбцов для сортировки по 6-му столбцу");
                return;
            }

            string[,] mxsort = ds.SortUbyvImproved(mx, 5);

            int rows = mxsort.GetLength(0);
            int columns = mxsort.GetLength(1);

            dataGridViewBase_BES.Rows.Clear();

            for (int i = 0; i < rows - 1; i++)
            {
                dataGridViewBase_BES.Rows.Add();
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_BES.Rows[i - 1].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void buttonFilter_BES_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewBase_BES.Rows)
            {
                if ((r.Cells[comboBoxCity_BES.SelectedIndex].Value?.ToString() ?? "").ToUpper().Contains(textBoxFilter_BES.Text.ToUpper()))
                {
                    dataGridViewBase_BES.Rows[r.Index].Visible = true;
                    dataGridViewBase_BES.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewBase_BES.CurrentCell = null;
                    dataGridViewBase_BES.Rows[r.Index].Visible = false;
                }
            }
        }

        private void comboBoxCity_BES_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCity_BES.SelectedIndex >= 0)
            {
                textBoxFilter_BES.Enabled = true;
            }
            else
            {
                textBoxFilter_BES.Enabled = false;
            }
        }
    }
}
