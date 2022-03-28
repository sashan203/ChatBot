namespace Курсовая_Работа
{
    partial class AddForm
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
            this.CB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbL = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB);
            this.groupBox1.Controls.Add(this.AddB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbP);
            this.groupBox1.Controls.Add(this.tbL);
            this.groupBox1.Controls.Add(this.tbS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CB
            // 
            this.CB.Location = new System.Drawing.Point(90, 118);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(75, 23);
            this.CB.TabIndex = 6;
            this.CB.Text = "Закрыть";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(9, 118);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(75, 23);
            this.AddB.TabIndex = 5;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сервис";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(56, 92);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(100, 20);
            this.tbP.TabIndex = 2;
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(56, 60);
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(100, 20);
            this.tbL.TabIndex = 1;
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(56, 27);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 20);
            this.tbS.TabIndex = 0;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 176);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.TextBox tbS;
    }
}