namespace Tyuiu.BocharovaES.Sprint7.Project.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfoAbout_BES = new Label();
            pictureBoxAbout_BES = new PictureBox();
            buttonOk_BES = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_BES).BeginInit();
            SuspendLayout();
            // 
            // labelInfoAbout_BES
            // 
            labelInfoAbout_BES.AutoSize = true;
            labelInfoAbout_BES.Location = new Point(260, 44);
            labelInfoAbout_BES.Name = "labelInfoAbout_BES";
            labelInfoAbout_BES.Size = new Size(387, 200);
            labelInfoAbout_BES.TabIndex = 0;
            labelInfoAbout_BES.Text = resources.GetString("labelInfoAbout_BES.Text");
            // 
            // pictureBoxAbout_BES
            // 
            pictureBoxAbout_BES.Image = Properties.Resources.IMG_20240712_202711__2_;
            pictureBoxAbout_BES.Location = new Point(40, 44);
            pictureBoxAbout_BES.Name = "pictureBoxAbout_BES";
            pictureBoxAbout_BES.Size = new Size(147, 197);
            pictureBoxAbout_BES.TabIndex = 1;
            pictureBoxAbout_BES.TabStop = false;
            // 
            // buttonOk_BES
            // 
            buttonOk_BES.Location = new Point(527, 257);
            buttonOk_BES.Name = "buttonOk_BES";
            buttonOk_BES.Size = new Size(120, 39);
            buttonOk_BES.TabIndex = 2;
            buttonOk_BES.Text = "Ok";
            buttonOk_BES.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 308);
            Controls.Add(buttonOk_BES);
            Controls.Add(pictureBoxAbout_BES);
            Controls.Add(labelInfoAbout_BES);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_BES).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfoAbout_BES;
        private PictureBox pictureBoxAbout_BES;
        private Button buttonOk_BES;
    }
}