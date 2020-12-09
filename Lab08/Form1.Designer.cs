namespace Lab08
{
    partial class fMain
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
            this.tbPlanetsinfo = new System.Windows.Forms.TextBox();
            this.btnAddPlanet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPlanetsinfo
            // 
            this.tbPlanetsinfo.Location = new System.Drawing.Point(30, 21);
            this.tbPlanetsinfo.Multiline = true;
            this.tbPlanetsinfo.Name = "tbPlanetsinfo";
            this.tbPlanetsinfo.ReadOnly = true;
            this.tbPlanetsinfo.Size = new System.Drawing.Size(538, 280);
            this.tbPlanetsinfo.TabIndex = 0;
            this.tbPlanetsinfo.TextChanged += new System.EventHandler(this.tbPlanetsinfo_TextChanged);
            // 
            // btnAddPlanet
            // 
            this.btnAddPlanet.Location = new System.Drawing.Point(595, 21);
            this.btnAddPlanet.Name = "btnAddPlanet";
            this.btnAddPlanet.Size = new System.Drawing.Size(109, 25);
            this.btnAddPlanet.TabIndex = 1;
            this.btnAddPlanet.Text = "Додати планету";
            this.btnAddPlanet.UseVisualStyleBackColor = true;
            this.btnAddPlanet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(605, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 313);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPlanet);
            this.Controls.Add(this.tbPlanetsinfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №8";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlanetsinfo;
        private System.Windows.Forms.Button btnAddPlanet;
        private System.Windows.Forms.Button btnClose;
    }
}

