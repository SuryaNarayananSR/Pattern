namespace Patern
{
    partial class Forage_data
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forage_data));
            this.srcPath = new System.Windows.Forms.TextBox();
            this.srcLab = new System.Windows.Forms.Label();
            this.desLab = new System.Windows.Forms.Label();
            this.desPath = new System.Windows.Forms.TextBox();
            this.frgData = new System.Windows.Forms.Button();
            this.srcTip = new System.Windows.Forms.ToolTip(this.components);
            this.desTip = new System.Windows.Forms.ToolTip(this.components);
            this.about = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srcPath
            // 
            this.srcPath.Location = new System.Drawing.Point(383, 108);
            this.srcPath.Name = "srcPath";
            this.srcPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.srcPath.Size = new System.Drawing.Size(298, 20);
            this.srcPath.TabIndex = 0;
            this.srcTip.SetToolTip(this.srcPath, "Enter the Source File Path.\r\n");
            this.srcPath.TextChanged += new System.EventHandler(this.srcPath_TextChanged);
            // 
            // srcLab
            // 
            this.srcLab.AutoSize = true;
            this.srcLab.Location = new System.Drawing.Point(84, 111);
            this.srcLab.Name = "srcLab";
            this.srcLab.Size = new System.Drawing.Size(150, 13);
            this.srcLab.TabIndex = 1;
            this.srcLab.Text = "Enter Complete Source Path :-";
            this.srcTip.SetToolTip(this.srcLab, "Sample : C:\\math.xml");
            // 
            // desLab
            // 
            this.desLab.AutoSize = true;
            this.desLab.Location = new System.Drawing.Point(84, 185);
            this.desLab.Name = "desLab";
            this.desLab.Size = new System.Drawing.Size(169, 13);
            this.desLab.TabIndex = 2;
            this.desLab.Text = "Enter Complete Destination Path :-";
            this.desTip.SetToolTip(this.desLab, "Sample : C:\\output.txt");
            // 
            // desPath
            // 
            this.desPath.Location = new System.Drawing.Point(383, 185);
            this.desPath.Name = "desPath";
            this.desPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.desPath.Size = new System.Drawing.Size(298, 20);
            this.desPath.TabIndex = 3;
            this.desTip.SetToolTip(this.desPath, "Enter the Destination File Path");
            this.desPath.TextChanged += new System.EventHandler(this.desPath_TextChanged);
            // 
            // frgData
            // 
            this.frgData.Location = new System.Drawing.Point(296, 299);
            this.frgData.Name = "frgData";
            this.frgData.Size = new System.Drawing.Size(75, 23);
            this.frgData.TabIndex = 4;
            this.frgData.Text = "Go";
            this.frgData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.frgData.UseVisualStyleBackColor = true;
            this.frgData.Click += new System.EventHandler(this.frgData_Click);
            // 
            // srcTip
            // 
            this.srcTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.srcTip.ToolTipTitle = "Source Path - Math.xml file";
            // 
            // desTip
            // 
            this.desTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.desTip.ToolTipTitle = "Destination Path - Text File";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Cursor = System.Windows.Forms.Cursors.Help;
            this.about.Location = new System.Drawing.Point(12, 496);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(35, 13);
            this.about.TabIndex = 5;
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Forage_data
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 518);
            this.Controls.Add(this.about);
            this.Controls.Add(this.frgData);
            this.Controls.Add(this.desPath);
            this.Controls.Add(this.desLab);
            this.Controls.Add(this.srcLab);
            this.Controls.Add(this.srcPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Forage_data";
            this.Text = "Math Data-Extracter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcPath;
        private System.Windows.Forms.Label srcLab;
        private System.Windows.Forms.Label desLab;
        private System.Windows.Forms.TextBox desPath;
        private System.Windows.Forms.Button frgData;
        private System.Windows.Forms.ToolTip srcTip;
        private System.Windows.Forms.ToolTip desTip;
        private System.Windows.Forms.Label about;
    }
}