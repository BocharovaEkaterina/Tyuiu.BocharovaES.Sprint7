namespace Tyuiu.BocharovaES.Sprint7.Project.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl_BES = new TabControl();
            tabPageBase_BES = new TabPage();
            buttonOpen_BES = new Button();
            panelName_BES = new Panel();
            pictureBoxName_BES = new PictureBox();
            textBoxName_BES = new TextBox();
            dataGridViewBase_BES = new DataGridView();
            menuStrip_BES = new MenuStrip();
            toolStripMenuItem_BES = new ToolStripMenuItem();
            toolStripMenuItemInfo_BES = new ToolStripMenuItem();
            toolStripMenuItemAbout_BES = new ToolStripMenuItem();
            toolStripMenuItemHelp_BES = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            groupBoxDioButton_BES = new GroupBox();
            buttonMax_BES = new Button();
            textBoxMax_BES = new TextBox();
            textBoxLabelMax_BES = new TextBox();
            buttonSum_BES = new Button();
            textBoxSum_BES = new TextBox();
            labelSum_BES = new TextBox();
            groupBoxDio_BES = new GroupBox();
            chartDio_BES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxChart_BES = new GroupBox();
            buttonDio_BES = new Button();
            buttonOpenDio_BES = new Button();
            dataGridViewChart_BES = new DataGridView();
            panelChart_BES = new Panel();
            textBoxChart_BES = new TextBox();
            tabPage3 = new TabPage();
            tabPage1 = new TabPage();
            openFileDialogProject_BES = new OpenFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            labelSearch_BES = new Label();
            textBoxSearch_BES = new TextBox();
            buttonSearch_BES = new Button();
            pictureBoxSearch_BES = new PictureBox();
            tabControl_BES.SuspendLayout();
            tabPageBase_BES.SuspendLayout();
            panelName_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName_BES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BES).BeginInit();
            menuStrip_BES.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxDioButton_BES.SuspendLayout();
            groupBoxDio_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDio_BES).BeginInit();
            groupBoxChart_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_BES).BeginInit();
            panelChart_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_BES).BeginInit();
            SuspendLayout();
            // 
            // tabControl_BES
            // 
            tabControl_BES.Controls.Add(tabPageBase_BES);
            tabControl_BES.Controls.Add(tabPage2);
            tabControl_BES.Controls.Add(tabPage3);
            tabControl_BES.Controls.Add(tabPage1);
            tabControl_BES.Dock = DockStyle.Fill;
            tabControl_BES.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            tabControl_BES.Location = new Point(0, 0);
            tabControl_BES.Name = "tabControl_BES";
            tabControl_BES.SelectedIndex = 0;
            tabControl_BES.Size = new Size(1308, 764);
            tabControl_BES.TabIndex = 1;
            tabControl_BES.Tag = "";
            // 
            // tabPageBase_BES
            // 
            tabPageBase_BES.Controls.Add(pictureBoxSearch_BES);
            tabPageBase_BES.Controls.Add(buttonSearch_BES);
            tabPageBase_BES.Controls.Add(textBoxSearch_BES);
            tabPageBase_BES.Controls.Add(labelSearch_BES);
            tabPageBase_BES.Controls.Add(buttonOpen_BES);
            tabPageBase_BES.Controls.Add(panelName_BES);
            tabPageBase_BES.Controls.Add(dataGridViewBase_BES);
            tabPageBase_BES.Controls.Add(menuStrip_BES);
            tabPageBase_BES.Location = new Point(4, 31);
            tabPageBase_BES.Name = "tabPageBase_BES";
            tabPageBase_BES.Padding = new Padding(3);
            tabPageBase_BES.Size = new Size(1300, 729);
            tabPageBase_BES.TabIndex = 0;
            tabPageBase_BES.Text = "База данных";
            tabPageBase_BES.UseVisualStyleBackColor = true;
            // 
            // buttonOpen_BES
            // 
            buttonOpen_BES.Image = Properties.Resources.folder_page_white;
            buttonOpen_BES.Location = new Point(38, 46);
            buttonOpen_BES.Name = "buttonOpen_BES";
            buttonOpen_BES.Size = new Size(149, 80);
            buttonOpen_BES.TabIndex = 4;
            buttonOpen_BES.UseVisualStyleBackColor = true;
            buttonOpen_BES.Click += buttonOpen_BES_Click;
            // 
            // panelName_BES
            // 
            panelName_BES.BackColor = Color.Thistle;
            panelName_BES.Controls.Add(pictureBoxName_BES);
            panelName_BES.Controls.Add(textBoxName_BES);
            panelName_BES.Location = new Point(260, 36);
            panelName_BES.Name = "panelName_BES";
            panelName_BES.Size = new Size(1037, 100);
            panelName_BES.TabIndex = 3;
            // 
            // pictureBoxName_BES
            // 
            pictureBoxName_BES.BackColor = Color.Transparent;
            pictureBoxName_BES.Image = (Image)resources.GetObject("pictureBoxName_BES.Image");
            pictureBoxName_BES.Location = new Point(922, 3);
            pictureBoxName_BES.Name = "pictureBoxName_BES";
            pictureBoxName_BES.Size = new Size(101, 94);
            pictureBoxName_BES.TabIndex = 5;
            pictureBoxName_BES.TabStop = false;
            // 
            // textBoxName_BES
            // 
            textBoxName_BES.BackColor = Color.Thistle;
            textBoxName_BES.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxName_BES.Location = new Point(317, 20);
            textBoxName_BES.Multiline = true;
            textBoxName_BES.Name = "textBoxName_BES";
            textBoxName_BES.Size = new Size(383, 59);
            textBoxName_BES.TabIndex = 2;
            textBoxName_BES.Text = "Сеть магазинов ";
            // 
            // dataGridViewBase_BES
            // 
            dataGridViewBase_BES.AllowUserToAddRows = false;
            dataGridViewBase_BES.BackgroundColor = SystemColors.Window;
            dataGridViewBase_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_BES.Location = new Point(260, 180);
            dataGridViewBase_BES.Name = "dataGridViewBase_BES";
            dataGridViewBase_BES.RowHeadersVisible = false;
            dataGridViewBase_BES.RowHeadersWidth = 51;
            dataGridViewBase_BES.Size = new Size(1037, 355);
            dataGridViewBase_BES.TabIndex = 0;
            dataGridViewBase_BES.CellContentClick += dataGridViewBase_BES_CellContentClick;
            // 
            // menuStrip_BES
            // 
            menuStrip_BES.ImageScalingSize = new Size(20, 20);
            menuStrip_BES.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_BES });
            menuStrip_BES.Location = new Point(3, 3);
            menuStrip_BES.Name = "menuStrip_BES";
            menuStrip_BES.Size = new Size(1294, 30);
            menuStrip_BES.TabIndex = 0;
            menuStrip_BES.Text = "menuStrip1";
            // 
            // toolStripMenuItem_BES
            // 
            toolStripMenuItem_BES.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInfo_BES, toolStripMenuItemAbout_BES, toolStripMenuItemHelp_BES });
            toolStripMenuItem_BES.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripMenuItem_BES.Name = "toolStripMenuItem_BES";
            toolStripMenuItem_BES.Size = new Size(109, 26);
            toolStripMenuItem_BES.Text = "Справка";
            // 
            // toolStripMenuItemInfo_BES
            // 
            toolStripMenuItemInfo_BES.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripMenuItemInfo_BES.Name = "toolStripMenuItemInfo_BES";
            toolStripMenuItemInfo_BES.Size = new Size(325, 26);
            toolStripMenuItemInfo_BES.Text = "Руководство пользователя";
            // 
            // toolStripMenuItemAbout_BES
            // 
            toolStripMenuItemAbout_BES.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            toolStripMenuItemAbout_BES.Name = "toolStripMenuItemAbout_BES";
            toolStripMenuItemAbout_BES.Size = new Size(325, 26);
            toolStripMenuItemAbout_BES.Text = "О разработчике";
            toolStripMenuItemAbout_BES.Click += toolStripMenuItemAbout_BES_Click_1;
            // 
            // toolStripMenuItemHelp_BES
            // 
            toolStripMenuItemHelp_BES.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            toolStripMenuItemHelp_BES.Name = "toolStripMenuItemHelp_BES";
            toolStripMenuItemHelp_BES.Size = new Size(325, 26);
            toolStripMenuItemHelp_BES.Text = "Поддержка";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBoxDioButton_BES);
            tabPage2.Controls.Add(groupBoxDio_BES);
            tabPage2.Controls.Add(groupBoxChart_BES);
            tabPage2.Controls.Add(panelChart_BES);
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1300, 729);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Диаграмма ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxDioButton_BES
            // 
            groupBoxDioButton_BES.Controls.Add(buttonMax_BES);
            groupBoxDioButton_BES.Controls.Add(textBoxMax_BES);
            groupBoxDioButton_BES.Controls.Add(textBoxLabelMax_BES);
            groupBoxDioButton_BES.Controls.Add(buttonSum_BES);
            groupBoxDioButton_BES.Controls.Add(textBoxSum_BES);
            groupBoxDioButton_BES.Controls.Add(labelSum_BES);
            groupBoxDioButton_BES.Location = new Point(349, 584);
            groupBoxDioButton_BES.Name = "groupBoxDioButton_BES";
            groupBoxDioButton_BES.Size = new Size(943, 136);
            groupBoxDioButton_BES.TabIndex = 5;
            groupBoxDioButton_BES.TabStop = false;
            groupBoxDioButton_BES.Text = "Статистика:";
            // 
            // buttonMax_BES
            // 
            buttonMax_BES.BackColor = Color.Thistle;
            buttonMax_BES.Location = new Point(756, 28);
            buttonMax_BES.Name = "buttonMax_BES";
            buttonMax_BES.Size = new Size(150, 83);
            buttonMax_BES.TabIndex = 5;
            buttonMax_BES.Text = "Отобразить";
            buttonMax_BES.UseVisualStyleBackColor = false;
            buttonMax_BES.Click += buttonMax_BES_Click;
            // 
            // textBoxMax_BES
            // 
            textBoxMax_BES.Location = new Point(480, 66);
            textBoxMax_BES.Multiline = true;
            textBoxMax_BES.Name = "textBoxMax_BES";
            textBoxMax_BES.Size = new Size(254, 34);
            textBoxMax_BES.TabIndex = 4;
            // 
            // textBoxLabelMax_BES
            // 
            textBoxLabelMax_BES.BackColor = Color.MistyRose;
            textBoxLabelMax_BES.Location = new Point(468, 28);
            textBoxLabelMax_BES.Multiline = true;
            textBoxLabelMax_BES.Name = "textBoxLabelMax_BES";
            textBoxLabelMax_BES.Size = new Size(282, 83);
            textBoxLabelMax_BES.TabIndex = 3;
            textBoxLabelMax_BES.Text = "Max выручка филиала:";
            // 
            // buttonSum_BES
            // 
            buttonSum_BES.BackColor = Color.Thistle;
            buttonSum_BES.Location = new Point(305, 28);
            buttonSum_BES.Name = "buttonSum_BES";
            buttonSum_BES.Size = new Size(158, 83);
            buttonSum_BES.TabIndex = 2;
            buttonSum_BES.Text = "Рассчитать ";
            buttonSum_BES.UseVisualStyleBackColor = false;
            buttonSum_BES.Click += buttonSum_BES_Click;
            // 
            // textBoxSum_BES
            // 
            textBoxSum_BES.Location = new Point(30, 66);
            textBoxSum_BES.Multiline = true;
            textBoxSum_BES.Name = "textBoxSum_BES";
            textBoxSum_BES.Size = new Size(257, 34);
            textBoxSum_BES.TabIndex = 1;
            // 
            // labelSum_BES
            // 
            labelSum_BES.BackColor = Color.MistyRose;
            labelSum_BES.Location = new Point(18, 28);
            labelSum_BES.Multiline = true;
            labelSum_BES.Name = "labelSum_BES";
            labelSum_BES.Size = new Size(281, 83);
            labelSum_BES.TabIndex = 0;
            labelSum_BES.Text = "Общая прибыль за месяц:";
            // 
            // groupBoxDio_BES
            // 
            groupBoxDio_BES.Controls.Add(chartDio_BES);
            groupBoxDio_BES.Location = new Point(343, 146);
            groupBoxDio_BES.Name = "groupBoxDio_BES";
            groupBoxDio_BES.Size = new Size(933, 418);
            groupBoxDio_BES.TabIndex = 4;
            groupBoxDio_BES.TabStop = false;
            groupBoxDio_BES.Text = "Диограммма:";
            // 
            // chartDio_BES
            // 
            chartArea1.Name = "ChartArea1";
            chartDio_BES.ChartAreas.Add(chartArea1);
            chartDio_BES.Dock = DockStyle.Fill;
            chartDio_BES.Location = new Point(3, 25);
            chartDio_BES.Name = "chartDio_BES";
            chartDio_BES.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            chartDio_BES.Series.Add(series1);
            chartDio_BES.Size = new Size(927, 390);
            chartDio_BES.TabIndex = 3;
            chartDio_BES.Text = "chart1";
            // 
            // groupBoxChart_BES
            // 
            groupBoxChart_BES.Controls.Add(buttonDio_BES);
            groupBoxChart_BES.Controls.Add(buttonOpenDio_BES);
            groupBoxChart_BES.Controls.Add(dataGridViewChart_BES);
            groupBoxChart_BES.Location = new Point(6, 134);
            groupBoxChart_BES.Name = "groupBoxChart_BES";
            groupBoxChart_BES.Size = new Size(308, 589);
            groupBoxChart_BES.TabIndex = 2;
            groupBoxChart_BES.TabStop = false;
            groupBoxChart_BES.Text = "Данные:";
            // 
            // buttonDio_BES
            // 
            buttonDio_BES.Enabled = false;
            buttonDio_BES.Image = (Image)resources.GetObject("buttonDio_BES.Image");
            buttonDio_BES.Location = new Point(162, 28);
            buttonDio_BES.Name = "buttonDio_BES";
            buttonDio_BES.Size = new Size(102, 64);
            buttonDio_BES.TabIndex = 2;
            buttonDio_BES.UseVisualStyleBackColor = true;
            buttonDio_BES.Click += buttonDio_BES_Click;
            // 
            // buttonOpenDio_BES
            // 
            buttonOpenDio_BES.Image = Properties.Resources.folder_add;
            buttonOpenDio_BES.Location = new Point(17, 28);
            buttonOpenDio_BES.Name = "buttonOpenDio_BES";
            buttonOpenDio_BES.Size = new Size(102, 64);
            buttonOpenDio_BES.TabIndex = 1;
            buttonOpenDio_BES.UseVisualStyleBackColor = true;
            buttonOpenDio_BES.Click += buttonOpenDio_BES_Click;
            // 
            // dataGridViewChart_BES
            // 
            dataGridViewChart_BES.BackgroundColor = Color.White;
            dataGridViewChart_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChart_BES.Location = new Point(3, 98);
            dataGridViewChart_BES.Name = "dataGridViewChart_BES";
            dataGridViewChart_BES.RowHeadersVisible = false;
            dataGridViewChart_BES.RowHeadersWidth = 51;
            dataGridViewChart_BES.Size = new Size(302, 488);
            dataGridViewChart_BES.TabIndex = 0;
            // 
            // panelChart_BES
            // 
            panelChart_BES.BackColor = Color.Thistle;
            panelChart_BES.Controls.Add(textBoxChart_BES);
            panelChart_BES.Dock = DockStyle.Top;
            panelChart_BES.Location = new Point(3, 3);
            panelChart_BES.Name = "panelChart_BES";
            panelChart_BES.Size = new Size(1294, 125);
            panelChart_BES.TabIndex = 1;
            // 
            // textBoxChart_BES
            // 
            textBoxChart_BES.BackColor = Color.Thistle;
            textBoxChart_BES.Font = new Font("Bookman Old Style", 20F, FontStyle.Italic);
            textBoxChart_BES.Location = new Point(421, 30);
            textBoxChart_BES.Multiline = true;
            textBoxChart_BES.Name = "textBoxChart_BES";
            textBoxChart_BES.Size = new Size(349, 53);
            textBoxChart_BES.TabIndex = 0;
            textBoxChart_BES.Text = "Прибыль филиалов";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1300, 729);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "График";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1300, 729);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Добавление/удаление филиала ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // openFileDialogProject_BES
            // 
            openFileDialogProject_BES.FileName = "openFileDialog1";
            // 
            // labelSearch_BES
            // 
            labelSearch_BES.AutoSize = true;
            labelSearch_BES.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearch_BES.Location = new Point(525, 146);
            labelSearch_BES.Name = "labelSearch_BES";
            labelSearch_BES.Size = new Size(89, 28);
            labelSearch_BES.TabIndex = 5;
            labelSearch_BES.Text = "Поиск";
            // 
            // textBoxSearch_BES
            // 
            textBoxSearch_BES.Location = new Point(620, 145);
            textBoxSearch_BES.Name = "textBoxSearch_BES";
            textBoxSearch_BES.Size = new Size(299, 29);
            textBoxSearch_BES.TabIndex = 6;
            // 
            // buttonSearch_BES
            // 
            buttonSearch_BES.BackColor = Color.Gainsboro;
            buttonSearch_BES.Font = new Font("Bookman Old Style", 12.8F, FontStyle.Bold);
            buttonSearch_BES.Location = new Point(925, 145);
            buttonSearch_BES.Name = "buttonSearch_BES";
            buttonSearch_BES.Size = new Size(126, 29);
            buttonSearch_BES.TabIndex = 7;
            buttonSearch_BES.Text = "Искать";
            buttonSearch_BES.UseVisualStyleBackColor = false;
            buttonSearch_BES.Click += buttonSearch_BES_Click;
            // 
            // pictureBoxSearch_BES
            // 
            pictureBoxSearch_BES.Image = Properties.Resources.zoom;
            pictureBoxSearch_BES.Location = new Point(479, 139);
            pictureBoxSearch_BES.Name = "pictureBoxSearch_BES";
            pictureBoxSearch_BES.Size = new Size(39, 38);
            pictureBoxSearch_BES.TabIndex = 8;
            pictureBoxSearch_BES.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 764);
            Controls.Add(tabControl_BES);
            MainMenuStrip = menuStrip_BES;
            Name = "FormMain";
            Text = "Сеть магазитов | Бочарова Е.С.";
            Load += Form1_Load;
            tabControl_BES.ResumeLayout(false);
            tabPageBase_BES.ResumeLayout(false);
            tabPageBase_BES.PerformLayout();
            panelName_BES.ResumeLayout(false);
            panelName_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName_BES).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BES).EndInit();
            menuStrip_BES.ResumeLayout(false);
            menuStrip_BES.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBoxDioButton_BES.ResumeLayout(false);
            groupBoxDioButton_BES.PerformLayout();
            groupBoxDio_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDio_BES).EndInit();
            groupBoxChart_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_BES).EndInit();
            panelChart_BES.ResumeLayout(false);
            panelChart_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl_BES;
        private TabPage tabPageBase_BES;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private MenuStrip menuStrip_BES;
        private ToolStripMenuItem toolStripMenuItem_BES;
        private ToolStripMenuItem toolStripMenuItemInfo_BES;
        private ToolStripMenuItem toolStripMenuItemAbout_BES;
        private ToolStripMenuItem toolStripMenuItemHelp_BES;
        private TextBox textBoxName_BES;
        private Panel panelName_BES;
        private DataGridView dataGridViewBase_BES;
        private Button buttonOpen_BES;
        private OpenFileDialog openFileDialogProject_BES;
        private Panel panelChart_BES;
        private TextBox textBoxChart_BES;
        private PictureBox pictureBoxName_BES;
        private GroupBox groupBoxChart_BES;
        private DataGridView dataGridViewChart_BES;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDio_BES;
        private GroupBox groupBoxDio_BES;
        private Button buttonOpenDio_BES;
        private Button buttonDio_BES;
        private GroupBox groupBoxDioButton_BES;
        private TextBox textBoxSum_BES;
        private TextBox labelSum_BES;
        private Button buttonMax_BES;
        private TextBox textBoxMax_BES;
        private TextBox textBoxLabelMax_BES;
        private Button buttonSum_BES;
        private Label labelSearch_BES;
        private Button buttonSearch_BES;
        private TextBox textBoxSearch_BES;
        private PictureBox pictureBoxSearch_BES;
    }
}
