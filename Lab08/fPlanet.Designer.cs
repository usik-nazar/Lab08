namespace Lab08
{
    partial class fPlanet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaxTemp = new System.Windows.Forms.TextBox();
            this.tbMinTemp = new System.Windows.Forms.TextBox();
            this.tbDayLenght = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasInhabited = new System.Windows.Forms.CheckBox();
            this.chbHasAtmosphere = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaxTemp);
            this.groupBox1.Controls.Add(this.tbMinTemp);
            this.groupBox1.Controls.Add(this.tbDayLenght);
            this.groupBox1.Controls.Add(this.tbRadius);
            this.groupBox1.Controls.Add(this.tbWeight);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbMaxTemp
            // 
            this.tbMaxTemp.Location = new System.Drawing.Point(164, 161);
            this.tbMaxTemp.Name = "tbMaxTemp";
            this.tbMaxTemp.Size = new System.Drawing.Size(131, 23);
            this.tbMaxTemp.TabIndex = 1;
            // 
            // tbMinTemp
            // 
            this.tbMinTemp.Location = new System.Drawing.Point(164, 132);
            this.tbMinTemp.Name = "tbMinTemp";
            this.tbMinTemp.Size = new System.Drawing.Size(131, 23);
            this.tbMinTemp.TabIndex = 1;
            // 
            // tbDayLenght
            // 
            this.tbDayLenght.Location = new System.Drawing.Point(164, 103);
            this.tbDayLenght.Name = "tbDayLenght";
            this.tbDayLenght.Size = new System.Drawing.Size(131, 23);
            this.tbDayLenght.TabIndex = 1;
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(164, 74);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(131, 23);
            this.tbRadius.TabIndex = 1;
            this.tbRadius.TextChanged += new System.EventHandler(this.tbRadius_TextChanged);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(164, 45);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(131, 23);
            this.tbWeight.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(164, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(131, 23);
            this.tbName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Макс температура";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Мін температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тривалість доби";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Радиус планети";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Маса планети";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва планети";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasInhabited);
            this.groupBox2.Controls.Add(this.chbHasAtmosphere);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Важливі дані";
            // 
            // chbHasInhabited
            // 
            this.chbHasInhabited.AutoSize = true;
            this.chbHasInhabited.Location = new System.Drawing.Point(20, 61);
            this.chbHasInhabited.Name = "chbHasInhabited";
            this.chbHasInhabited.Size = new System.Drawing.Size(124, 19);
            this.chbHasInhabited.TabIndex = 0;
            this.chbHasInhabited.Text = "Планета обітаєма";
            this.chbHasInhabited.UseVisualStyleBackColor = true;
            // 
            // chbHasAtmosphere
            // 
            this.chbHasAtmosphere.AutoSize = true;
            this.chbHasAtmosphere.Location = new System.Drawing.Point(20, 36);
            this.chbHasAtmosphere.Name = "chbHasAtmosphere";
            this.chbHasAtmosphere.Size = new System.Drawing.Size(160, 19);
            this.chbHasAtmosphere.TabIndex = 0;
            this.chbHasAtmosphere.Text = "Планета має атмосферу";
            this.chbHasAtmosphere.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(372, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fPlanet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про нову планету";
            this.Load += new System.EventHandler(this.fPlanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMaxTemp;
        private System.Windows.Forms.TextBox tbMinTemp;
        private System.Windows.Forms.TextBox tbDayLenght;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasInhabited;
        private System.Windows.Forms.CheckBox chbHasAtmosphere;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}