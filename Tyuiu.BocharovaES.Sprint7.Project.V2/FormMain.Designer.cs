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
            tabControl_BES = new TabControl();
            tabPageBase_BES = new TabPage();
            buttonOpen_BES = new Button();
            panelName_BES = new Panel();
            textBoxName_BES = new TextBox();
            dataGridViewBase_BES = new DataGridView();
            menuStrip_BES = new MenuStrip();
            toolStripMenuItem_BES = new ToolStripMenuItem();
            toolStripMenuItemInfo_BES = new ToolStripMenuItem();
            toolStripMenuItemAbout_BES = new ToolStripMenuItem();
            toolStripMenuItemHelp_BES = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage1 = new TabPage();
            openFileDialogProject_BES = new OpenFileDialog();
            tabControl_BES.SuspendLayout();
            tabPageBase_BES.SuspendLayout();
            panelName_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BES).BeginInit();
            menuStrip_BES.SuspendLayout();
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
            buttonOpen_BES.Location = new Point(42, 53);
            buttonOpen_BES.Name = "buttonOpen_BES";
            buttonOpen_BES.Size = new Size(149, 80);
            buttonOpen_BES.TabIndex = 4;
            buttonOpen_BES.UseVisualStyleBackColor = true;
            buttonOpen_BES.Click += buttonOpen_BES_Click;
            // 
            // panelName_BES
            // 
            panelName_BES.BackColor = Color.Thistle;
            panelName_BES.Controls.Add(textBoxName_BES);
            panelName_BES.Location = new Point(260, 36);
            panelName_BES.Name = "panelName_BES";
            panelName_BES.Size = new Size(1037, 100);
            panelName_BES.TabIndex = 3;
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
            dataGridViewBase_BES.BackgroundColor = SystemColors.Window;
            dataGridViewBase_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_BES.Location = new Point(260, 142);
            dataGridViewBase_BES.Name = "dataGridViewBase_BES";
            dataGridViewBase_BES.RowHeadersWidth = 51;
            dataGridViewBase_BES.Size = new Size(1037, 393);
            dataGridViewBase_BES.TabIndex = 1;
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
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1300, 729);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Диаграмма ";
            tabPage2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BES).EndInit();
            menuStrip_BES.ResumeLayout(false);
            menuStrip_BES.PerformLayout();
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
    }
}
