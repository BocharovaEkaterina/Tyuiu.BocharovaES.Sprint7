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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl_BES = new TabControl();
            tabPageBase_BES = new TabPage();
            groupBoxFilter_BES = new GroupBox();
            textBoxFilter_BES = new TextBox();
            buttonFilter_BES = new Button();
            comboBoxCity_BES = new ComboBox();
            groupBoxSort_BES = new GroupBox();
            buttonDecreasing_BES = new Button();
            buttonIncreasing_BES = new Button();
            labelDecreasing_BES = new Label();
            labelIncreasing_BES = new Label();
            pictureBoxSearch_BES = new PictureBox();
            buttonSearch_BES = new Button();
            textBoxSearch_BES = new TextBox();
            labelSearch_BES = new Label();
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
            tabPageDio_BES = new TabPage();
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
            tabPageNew_BES = new TabPage();
            openFileDialogProject_BES = new OpenFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBoxNameFilter_BES = new TextBox();
            textBoxNameKay_BES = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridViewBaseNew_BES = new DataGridView();
            buttonOpenNew_BES = new Button();
            buttonSave_BES = new Button();
            buttonDelete_BES = new Button();
            buttonHelpNew_BES = new Button();
            tabControl_BES.SuspendLayout();
            tabPageBase_BES.SuspendLayout();
            groupBoxFilter_BES.SuspendLayout();
            groupBoxSort_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_BES).BeginInit();
            panelName_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName_BES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BES).BeginInit();
            menuStrip_BES.SuspendLayout();
            tabPageDio_BES.SuspendLayout();
            groupBoxDioButton_BES.SuspendLayout();
            groupBoxDio_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDio_BES).BeginInit();
            groupBoxChart_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_BES).BeginInit();
            panelChart_BES.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPageNew_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaseNew_BES).BeginInit();
            SuspendLayout();
            // 
            // tabControl_BES
            // 
            tabControl_BES.Controls.Add(tabPageBase_BES);
            tabControl_BES.Controls.Add(tabPageDio_BES);
            tabControl_BES.Controls.Add(tabPage3);
            tabControl_BES.Controls.Add(tabPageNew_BES);
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
            tabPageBase_BES.Controls.Add(groupBoxFilter_BES);
            tabPageBase_BES.Controls.Add(pictureBoxSearch_BES);
            tabPageBase_BES.Controls.Add(groupBoxSort_BES);
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
            // groupBoxFilter_BES
            // 
            groupBoxFilter_BES.Controls.Add(textBoxNameKay_BES);
            groupBoxFilter_BES.Controls.Add(textBoxNameFilter_BES);
            groupBoxFilter_BES.Controls.Add(textBoxFilter_BES);
            groupBoxFilter_BES.Controls.Add(buttonFilter_BES);
            groupBoxFilter_BES.Controls.Add(comboBoxCity_BES);
            groupBoxFilter_BES.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFilter_BES.Location = new Point(4, 180);
            groupBoxFilter_BES.Name = "groupBoxFilter_BES";
            groupBoxFilter_BES.Size = new Size(250, 358);
            groupBoxFilter_BES.TabIndex = 9;
            groupBoxFilter_BES.TabStop = false;
            groupBoxFilter_BES.Text = "Фмльтрация и сортировка:";
            // 
            // textBoxFilter_BES
            // 
            textBoxFilter_BES.Location = new Point(6, 243);
            textBoxFilter_BES.Name = "textBoxFilter_BES";
            textBoxFilter_BES.Size = new Size(215, 29);
            textBoxFilter_BES.TabIndex = 11;
            // 
            // buttonFilter_BES
            // 
            buttonFilter_BES.BackColor = Color.Gainsboro;
            buttonFilter_BES.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFilter_BES.Location = new Point(8, 303);
            buttonFilter_BES.Name = "buttonFilter_BES";
            buttonFilter_BES.Size = new Size(197, 36);
            buttonFilter_BES.TabIndex = 10;
            buttonFilter_BES.Text = "Отобразить";
            buttonFilter_BES.UseVisualStyleBackColor = false;
            buttonFilter_BES.Click += buttonFilter_BES_Click;
            // 
            // comboBoxCity_BES
            // 
            comboBoxCity_BES.FormattingEnabled = true;
            comboBoxCity_BES.Items.AddRange(new object[] { "номер", "ФИО", "город", "улица,дом", "телефон", "капитал владельца", "фамилия поставщика", "прибыль месяц", "проходимость" });
            comboBoxCity_BES.Location = new Point(8, 112);
            comboBoxCity_BES.Name = "comboBoxCity_BES";
            comboBoxCity_BES.Size = new Size(213, 29);
            comboBoxCity_BES.TabIndex = 1;
            comboBoxCity_BES.SelectedIndexChanged += comboBoxCity_BES_SelectedIndexChanged;
            // 
            // groupBoxSort_BES
            // 
            groupBoxSort_BES.Controls.Add(buttonDecreasing_BES);
            groupBoxSort_BES.Controls.Add(buttonIncreasing_BES);
            groupBoxSort_BES.Controls.Add(labelIncreasing_BES);
            groupBoxSort_BES.Controls.Add(labelDecreasing_BES);
            groupBoxSort_BES.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxSort_BES.Location = new Point(12, 554);
            groupBoxSort_BES.Name = "groupBoxSort_BES";
            groupBoxSort_BES.Size = new Size(631, 158);
            groupBoxSort_BES.TabIndex = 5;
            groupBoxSort_BES.TabStop = false;
            groupBoxSort_BES.Text = "Сортировка по капиталу владельца:";
            // 
            // buttonDecreasing_BES
            // 
            buttonDecreasing_BES.BackColor = Color.Gainsboro;
            buttonDecreasing_BES.Location = new Point(383, 94);
            buttonDecreasing_BES.Name = "buttonDecreasing_BES";
            buttonDecreasing_BES.Size = new Size(207, 46);
            buttonDecreasing_BES.TabIndex = 3;
            buttonDecreasing_BES.Text = "Отфильтровать";
            buttonDecreasing_BES.UseVisualStyleBackColor = false;
            buttonDecreasing_BES.Click += buttonDecreasing_BES_Click;
            // 
            // buttonIncreasing_BES
            // 
            buttonIncreasing_BES.BackColor = Color.Gainsboro;
            buttonIncreasing_BES.Location = new Point(45, 94);
            buttonIncreasing_BES.Name = "buttonIncreasing_BES";
            buttonIncreasing_BES.Size = new Size(207, 46);
            buttonIncreasing_BES.TabIndex = 2;
            buttonIncreasing_BES.Text = "Отфильтровать ";
            buttonIncreasing_BES.UseVisualStyleBackColor = false;
            buttonIncreasing_BES.Click += buttonIncreasing_BES_Click;
            // 
            // labelDecreasing_BES
            // 
            labelDecreasing_BES.AutoSize = true;
            labelDecreasing_BES.BackColor = Color.MistyRose;
            labelDecreasing_BES.Location = new Point(358, 49);
            labelDecreasing_BES.Name = "labelDecreasing_BES";
            labelDecreasing_BES.Size = new Size(145, 20);
            labelDecreasing_BES.TabIndex = 1;
            labelDecreasing_BES.Text = "-по убыванию ";
            // 
            // labelIncreasing_BES
            // 
            labelIncreasing_BES.AutoSize = true;
            labelIncreasing_BES.BackColor = Color.MistyRose;
            labelIncreasing_BES.Location = new Point(24, 49);
            labelIncreasing_BES.Name = "labelIncreasing_BES";
            labelIncreasing_BES.Size = new Size(163, 20);
            labelIncreasing_BES.TabIndex = 0;
            labelIncreasing_BES.Text = "-по возрастанию";
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
            // textBoxSearch_BES
            // 
            textBoxSearch_BES.Location = new Point(620, 145);
            textBoxSearch_BES.Name = "textBoxSearch_BES";
            textBoxSearch_BES.Size = new Size(299, 29);
            textBoxSearch_BES.TabIndex = 6;
            textBoxSearch_BES.TextChanged += textBoxSearch_BES_TextChanged;
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
            dataGridViewBase_BES.Size = new Size(1037, 358);
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
            // tabPageDio_BES
            // 
            tabPageDio_BES.Controls.Add(groupBoxDioButton_BES);
            tabPageDio_BES.Controls.Add(groupBoxDio_BES);
            tabPageDio_BES.Controls.Add(groupBoxChart_BES);
            tabPageDio_BES.Controls.Add(panelChart_BES);
            tabPageDio_BES.Location = new Point(4, 31);
            tabPageDio_BES.Name = "tabPageDio_BES";
            tabPageDio_BES.Padding = new Padding(3);
            tabPageDio_BES.Size = new Size(1300, 729);
            tabPageDio_BES.TabIndex = 1;
            tabPageDio_BES.Text = "Диаграмма ";
            tabPageDio_BES.UseVisualStyleBackColor = true;
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
            chartArea3.Name = "ChartArea1";
            chartDio_BES.ChartAreas.Add(chartArea3);
            chartDio_BES.Dock = DockStyle.Fill;
            chartDio_BES.Location = new Point(3, 25);
            chartDio_BES.Name = "chartDio_BES";
            chartDio_BES.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Name = "Series1";
            chartDio_BES.Series.Add(series3);
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
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1300, 729);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "График";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageNew_BES
            // 
            tabPageNew_BES.Controls.Add(buttonHelpNew_BES);
            tabPageNew_BES.Controls.Add(buttonDelete_BES);
            tabPageNew_BES.Controls.Add(buttonSave_BES);
            tabPageNew_BES.Controls.Add(buttonOpenNew_BES);
            tabPageNew_BES.Controls.Add(dataGridViewBaseNew_BES);
            tabPageNew_BES.Location = new Point(4, 31);
            tabPageNew_BES.Name = "tabPageNew_BES";
            tabPageNew_BES.Padding = new Padding(3);
            tabPageNew_BES.Size = new Size(1300, 729);
            tabPageNew_BES.TabIndex = 3;
            tabPageNew_BES.Text = "Добавление/удаление филиала ";
            tabPageNew_BES.UseVisualStyleBackColor = true;
            // 
            // openFileDialogProject_BES
            // 
            openFileDialogProject_BES.FileName = "openFileDialog1";
            // 
            // textBoxNameFilter_BES
            // 
            textBoxNameFilter_BES.BackColor = SystemColors.InactiveBorder;
            textBoxNameFilter_BES.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxNameFilter_BES.Location = new Point(8, 57);
            textBoxNameFilter_BES.Multiline = true;
            textBoxNameFilter_BES.Name = "textBoxNameFilter_BES";
            textBoxNameFilter_BES.Size = new Size(213, 34);
            textBoxNameFilter_BES.TabIndex = 12;
            textBoxNameFilter_BES.Text = "Выберете столбец:";
            // 
            // textBoxNameKay_BES
            // 
            textBoxNameKay_BES.BackColor = SystemColors.InactiveBorder;
            textBoxNameKay_BES.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxNameKay_BES.Location = new Point(8, 163);
            textBoxNameKay_BES.Multiline = true;
            textBoxNameKay_BES.Name = "textBoxNameKay_BES";
            textBoxNameKay_BES.Size = new Size(213, 52);
            textBoxNameKay_BES.TabIndex = 13;
            textBoxNameKay_BES.Text = "Ключ для фильтрации";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(623, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(669, 498);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewBaseNew_BES
            // 
            dataGridViewBaseNew_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaseNew_BES.Location = new Point(569, 108);
            dataGridViewBaseNew_BES.Name = "dataGridViewBaseNew_BES";
            dataGridViewBaseNew_BES.RowHeadersWidth = 51;
            dataGridViewBaseNew_BES.Size = new Size(728, 613);
            dataGridViewBaseNew_BES.TabIndex = 0;
            // 
            // buttonOpenNew_BES
            // 
            buttonOpenNew_BES.Image = Properties.Resources.folder_page_white1;
            buttonOpenNew_BES.Location = new Point(638, 6);
            buttonOpenNew_BES.Name = "buttonOpenNew_BES";
            buttonOpenNew_BES.Size = new Size(146, 96);
            buttonOpenNew_BES.TabIndex = 1;
            buttonOpenNew_BES.UseVisualStyleBackColor = true;
            // 
            // buttonSave_BES
            // 
            buttonSave_BES.Image = Properties.Resources.folder_add1;
            buttonSave_BES.Location = new Point(810, 6);
            buttonSave_BES.Name = "buttonSave_BES";
            buttonSave_BES.Size = new Size(146, 96);
            buttonSave_BES.TabIndex = 2;
            buttonSave_BES.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_BES
            // 
            buttonDelete_BES.Image = Properties.Resources.folder_delete;
            buttonDelete_BES.Location = new Point(974, 6);
            buttonDelete_BES.Name = "buttonDelete_BES";
            buttonDelete_BES.Size = new Size(146, 96);
            buttonDelete_BES.TabIndex = 3;
            buttonDelete_BES.UseVisualStyleBackColor = true;
            // 
            // buttonHelpNew_BES
            // 
            buttonHelpNew_BES.Location = new Point(1138, 6);
            buttonHelpNew_BES.Name = "buttonHelpNew_BES";
            buttonHelpNew_BES.Size = new Size(146, 96);
            buttonHelpNew_BES.TabIndex = 4;
            buttonHelpNew_BES.UseVisualStyleBackColor = true;
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
            groupBoxFilter_BES.ResumeLayout(false);
            groupBoxFilter_BES.PerformLayout();
            groupBoxSort_BES.ResumeLayout(false);
            groupBoxSort_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_BES).EndInit();
            panelName_BES.ResumeLayout(false);
            panelName_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName_BES).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BES).EndInit();
            menuStrip_BES.ResumeLayout(false);
            menuStrip_BES.PerformLayout();
            tabPageDio_BES.ResumeLayout(false);
            groupBoxDioButton_BES.ResumeLayout(false);
            groupBoxDioButton_BES.PerformLayout();
            groupBoxDio_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDio_BES).EndInit();
            groupBoxChart_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_BES).EndInit();
            panelChart_BES.ResumeLayout(false);
            panelChart_BES.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPageNew_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaseNew_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl_BES;
        private TabPage tabPageBase_BES;
        private TabPage tabPageDio_BES;
        private TabPage tabPage3;
        private TabPage tabPageNew_BES;
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
        private GroupBox groupBoxFilter_BES;
        private GroupBox groupBoxSort_BES;
        private Label labelIncreasing_BES;
        private ComboBox comboBoxCity_BES;
        private Label labelDecreasing_BES;
        private Button buttonDecreasing_BES;
        private Button buttonIncreasing_BES;
        private Button buttonFilter_BES;
        private TextBox textBoxFilter_BES;
        private TextBox textBoxNameFilter_BES;
        private TextBox textBoxNameKay_BES;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewBaseNew_BES;
        private Button buttonDelete_BES;
        private Button buttonSave_BES;
        private Button buttonOpenNew_BES;
        private Button buttonHelpNew_BES;
    }
}
