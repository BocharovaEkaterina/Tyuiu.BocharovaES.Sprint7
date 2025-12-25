namespace Tyuiu.BocharovaES.Sprint7.Project.V2
{
    partial class FormHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHelp_BES = new Panel();
            textBoxHelp_BES = new TextBox();
            textBox1 = new TextBox();
            buttonHelp_BES = new Button();
            panelHelp_BES.SuspendLayout();
            SuspendLayout();
            // 
            // panelHelp_BES
            // 
            panelHelp_BES.BackColor = Color.Thistle;
            panelHelp_BES.Controls.Add(textBoxHelp_BES);
            panelHelp_BES.Dock = DockStyle.Top;
            panelHelp_BES.Location = new Point(0, 0);
            panelHelp_BES.Name = "panelHelp_BES";
            panelHelp_BES.Size = new Size(575, 125);
            panelHelp_BES.TabIndex = 0;
            // 
            // textBoxHelp_BES
            // 
            textBoxHelp_BES.BackColor = Color.Thistle;
            textBoxHelp_BES.Font = new Font("Segoe UI Semibold", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxHelp_BES.Location = new Point(141, 12);
            textBoxHelp_BES.Multiline = true;
            textBoxHelp_BES.Name = "textBoxHelp_BES";
            textBoxHelp_BES.Size = new Size(299, 79);
            textBoxHelp_BES.TabIndex = 0;
            textBoxHelp_BES.Text = "ПОДДЕРЖКА";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 131);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 120);
            textBox1.TabIndex = 1;
            textBox1.Text = "Если у вас возникли какие-то предложения или проблемы при работе с приложением, то Вы всегда можете написать написать разработчику:\r\n- по номеру телефона 89080861406\r\n- в тг @Kati2515\r\n";
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.BackColor = Color.Thistle;
            buttonHelp_BES.Location = new Point(426, 258);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(120, 39);
            buttonHelp_BES.TabIndex = 2;
            buttonHelp_BES.Text = "Закрыть";
            buttonHelp_BES.UseVisualStyleBackColor = false;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 309);
            Controls.Add(buttonHelp_BES);
            Controls.Add(textBox1);
            Controls.Add(panelHelp_BES);
            Name = "FormHelp";
            Text = "Поддержка";
            panelHelp_BES.ResumeLayout(false);
            panelHelp_BES.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHelp_BES;
        private TextBox textBoxHelp_BES;
        private TextBox textBox1;
        private Button buttonHelp_BES;
    }
}