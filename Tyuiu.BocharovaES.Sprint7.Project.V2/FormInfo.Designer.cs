namespace Tyuiu.BocharovaES.Sprint7.Project.V2
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            textBoxInfo_BES = new TextBox();
            buttonInfo_BES = new Button();
            SuspendLayout();
            // 
            // textBoxInfo_BES
            // 
            textBoxInfo_BES.Location = new Point(3, 2);
            textBoxInfo_BES.Multiline = true;
            textBoxInfo_BES.Name = "textBoxInfo_BES";
            textBoxInfo_BES.Size = new Size(815, 438);
            textBoxInfo_BES.TabIndex = 0;
            textBoxInfo_BES.Text = resources.GetString("textBoxInfo_BES.Text");
            // 
            // buttonInfo_BES
            // 
            buttonInfo_BES.BackColor = Color.Thistle;
            buttonInfo_BES.Location = new Point(649, 458);
            buttonInfo_BES.Name = "buttonInfo_BES";
            buttonInfo_BES.Size = new Size(137, 60);
            buttonInfo_BES.TabIndex = 1;
            buttonInfo_BES.Text = "Ok";
            buttonInfo_BES.UseVisualStyleBackColor = false;
            buttonInfo_BES.Click += buttonInfo_BES_Click;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 530);
            Controls.Add(buttonInfo_BES);
            Controls.Add(textBoxInfo_BES);
            Name = "FormInfo";
            Text = "Руководство пользователя ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_BES;
        private Button buttonInfo_BES;
    }
}