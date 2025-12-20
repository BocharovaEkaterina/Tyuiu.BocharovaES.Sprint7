using Tyuiu.BocharovaES.Sprint7.Project.V2.Lib;
namespace Tyuiu.BocharovaES.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
    }
}
