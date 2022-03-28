
namespace Курсовая_Работа
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logPassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Курсовая_Работа.DBDataSet();
            this.tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBans = new System.Windows.Forms.TextBox();
            this.tBqw = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.lab11 = new System.Windows.Forms.Label();
            this.lab33 = new System.Windows.Forms.Label();
            this.lab55 = new System.Windows.Forms.Label();
            this.lab77 = new System.Windows.Forms.Label();
            this.lab44 = new System.Windows.Forms.Label();
            this.lab66 = new System.Windows.Forms.Label();
            this.lab88 = new System.Windows.Forms.Label();
            this.lab8 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab22 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.SB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.logPassTableAdapter = new Курсовая_Работа.DBDataSetTableAdapters.LogPassTableAdapter();
            this.usersTableAdapter = new Курсовая_Работа.DBDataSetTableAdapters.UsersTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.p4.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPassBindingSource
            // 
            this.logPassBindingSource.DataMember = "LogPass";
            this.logPassBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 383);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(488, 20);
            this.tb.TabIndex = 0;
            this.tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(238, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Обучение";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.button10);
            this.p1.Controls.Add(this.label5);
            this.p1.Controls.Add(this.label3);
            this.p1.Controls.Add(this.label4);
            this.p1.Controls.Add(this.tBans);
            this.p1.Controls.Add(this.tBqw);
            this.p1.Controls.Add(this.button2);
            this.p1.Enabled = false;
            this.p1.Location = new System.Drawing.Point(12, 23);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(572, 381);
            this.p1.TabIndex = 5;
            this.p1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ответ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вопрос";
            // 
            // tBans
            // 
            this.tBans.Location = new System.Drawing.Point(102, 213);
            this.tBans.Name = "tBans";
            this.tBans.Size = new System.Drawing.Size(414, 20);
            this.tBans.TabIndex = 2;
            // 
            // tBqw
            // 
            this.tBqw.Location = new System.Drawing.Point(102, 148);
            this.tBqw.Name = "tBqw";
            this.tBqw.Size = new System.Drawing.Size(414, 20);
            this.tBqw.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Добавить в базу данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 317);
            this.label1.MaximumSize = new System.Drawing.Size(360, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 250);
            this.label2.MaximumSize = new System.Drawing.Size(360, 0);
            this.label2.MinimumSize = new System.Drawing.Size(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            this.label2.Visible = false;
            // 
            // p2
            // 
            this.p2.AutoScroll = true;
            this.p2.BackColor = System.Drawing.SystemColors.Menu;
            this.p2.Controls.Add(this.lab11);
            this.p2.Controls.Add(this.lab33);
            this.p2.Controls.Add(this.lab55);
            this.p2.Controls.Add(this.lab77);
            this.p2.Controls.Add(this.lab44);
            this.p2.Controls.Add(this.lab66);
            this.p2.Controls.Add(this.lab88);
            this.p2.Controls.Add(this.lab8);
            this.p2.Controls.Add(this.lab7);
            this.p2.Controls.Add(this.lab6);
            this.p2.Controls.Add(this.lab22);
            this.p2.Controls.Add(this.lab5);
            this.p2.Controls.Add(this.lab4);
            this.p2.Controls.Add(this.lab3);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.label1);
            this.p2.Cursor = System.Windows.Forms.Cursors.Default;
            this.p2.Location = new System.Drawing.Point(12, 23);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(572, 349);
            this.p2.TabIndex = 6;
            // 
            // lab11
            // 
            this.lab11.AutoSize = true;
            this.lab11.Location = new System.Drawing.Point(525, 304);
            this.lab11.Name = "lab11";
            this.lab11.Size = new System.Drawing.Size(35, 13);
            this.lab11.TabIndex = 10;
            this.lab11.Text = "User1";
            this.lab11.Visible = false;
            // 
            // lab33
            // 
            this.lab33.AutoSize = true;
            this.lab33.Location = new System.Drawing.Point(525, 209);
            this.lab33.Name = "lab33";
            this.lab33.Size = new System.Drawing.Size(35, 13);
            this.lab33.TabIndex = 10;
            this.lab33.Text = "User3";
            this.lab33.Visible = false;
            // 
            // lab55
            // 
            this.lab55.AutoSize = true;
            this.lab55.Location = new System.Drawing.Point(525, 127);
            this.lab55.Name = "lab55";
            this.lab55.Size = new System.Drawing.Size(35, 13);
            this.lab55.TabIndex = 10;
            this.lab55.Text = "User5";
            this.lab55.Visible = false;
            // 
            // lab77
            // 
            this.lab77.AutoSize = true;
            this.lab77.Location = new System.Drawing.Point(525, 47);
            this.lab77.Name = "lab77";
            this.lab77.Size = new System.Drawing.Size(35, 13);
            this.lab77.TabIndex = 10;
            this.lab77.Text = "User7";
            this.lab77.Visible = false;
            // 
            // lab44
            // 
            this.lab44.AutoSize = true;
            this.lab44.Location = new System.Drawing.Point(8, 160);
            this.lab44.Name = "lab44";
            this.lab44.Size = new System.Drawing.Size(25, 13);
            this.lab44.TabIndex = 10;
            this.lab44.Text = "Бот";
            this.lab44.Visible = false;
            // 
            // lab66
            // 
            this.lab66.AutoSize = true;
            this.lab66.Location = new System.Drawing.Point(8, 80);
            this.lab66.Name = "lab66";
            this.lab66.Size = new System.Drawing.Size(25, 13);
            this.lab66.TabIndex = 10;
            this.lab66.Text = "Бот";
            this.lab66.Visible = false;
            // 
            // lab88
            // 
            this.lab88.AutoSize = true;
            this.lab88.Location = new System.Drawing.Point(8, 17);
            this.lab88.Name = "lab88";
            this.lab88.Size = new System.Drawing.Size(25, 13);
            this.lab88.TabIndex = 10;
            this.lab88.Text = "Бот";
            this.lab88.Visible = false;
            // 
            // lab8
            // 
            this.lab8.AutoSize = true;
            this.lab8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lab8.Location = new System.Drawing.Point(15, 30);
            this.lab8.MaximumSize = new System.Drawing.Size(360, 0);
            this.lab8.MinimumSize = new System.Drawing.Size(0, 15);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(0, 15);
            this.lab8.TabIndex = 9;
            this.lab8.Visible = false;
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(520, 60);
            this.lab7.MaximumSize = new System.Drawing.Size(360, 0);
            this.lab7.MinimumSize = new System.Drawing.Size(0, 15);
            this.lab7.Name = "lab7";
            this.lab7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab7.Size = new System.Drawing.Size(0, 15);
            this.lab7.TabIndex = 8;
            this.lab7.Visible = false;
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(15, 90);
            this.lab6.MaximumSize = new System.Drawing.Size(360, 0);
            this.lab6.MinimumSize = new System.Drawing.Size(0, 15);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(0, 15);
            this.lab6.TabIndex = 7;
            this.lab6.Visible = false;
            // 
            // lab22
            // 
            this.lab22.AutoSize = true;
            this.lab22.Location = new System.Drawing.Point(6, 237);
            this.lab22.Name = "lab22";
            this.lab22.Size = new System.Drawing.Size(25, 13);
            this.lab22.TabIndex = 10;
            this.lab22.Text = "Бот";
            this.lab22.Visible = false;
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(520, 140);
            this.lab5.MaximumSize = new System.Drawing.Size(360, 0);
            this.lab5.MinimumSize = new System.Drawing.Size(0, 15);
            this.lab5.Name = "lab5";
            this.lab5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab5.Size = new System.Drawing.Size(0, 15);
            this.lab5.TabIndex = 6;
            this.lab5.Visible = false;
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(15, 178);
            this.lab4.MaximumSize = new System.Drawing.Size(360, 0);
            this.lab4.MinimumSize = new System.Drawing.Size(0, 15);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(0, 15);
            this.lab4.TabIndex = 5;
            this.lab4.Visible = false;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(520, 227);
            this.lab3.MaximumSize = new System.Drawing.Size(360, 0);
            this.lab3.MinimumSize = new System.Drawing.Size(0, 15);
            this.lab3.Name = "lab3";
            this.lab3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab3.Size = new System.Drawing.Size(0, 15);
            this.lab3.TabIndex = 4;
            this.lab3.Visible = false;
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(599, 468);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(75, 23);
            this.SB.TabIndex = 8;
            this.SB.Text = "Сохранить";
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.SB_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(599, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(599, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(599, 574);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 576);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(701, 468);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Сохранение пользователя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.userDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logPassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 86);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Service";
            this.dataGridViewTextBoxColumn1.HeaderText = "Service";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.usersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(23, 510);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(536, 60);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoginUser";
            this.dataGridViewTextBoxColumn4.HeaderText = "LoginUser";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PasswordUser";
            this.dataGridViewTextBoxColumn5.HeaderText = "PasswordUser";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dBDataSet;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(418, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Войти в другой аккаунт";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // logPassTableAdapter
            // 
            this.logPassTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.logPassBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Курсовая_Работа.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(573, 381);
            this.reportViewer1.TabIndex = 18;
            this.reportViewer1.Visible = false;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(363, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "Отчёт";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(255, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "О программе";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p4.Controls.Add(this.label8);
            this.p4.Controls.Add(this.label10);
            this.p4.Controls.Add(this.label9);
            this.p4.Controls.Add(this.label11);
            this.p4.Controls.Add(this.label7);
            this.p4.Controls.Add(this.label6);
            this.p4.Location = new System.Drawing.Point(145, 23);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(321, 380);
            this.p4.TabIndex = 21;
            this.p4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(57, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Программа ChatBot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(136, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "2022";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 84);
            this.label9.TabIndex = 0;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "Если бот не знает ответа на ваш вопрос, \r\nон попросит вас помочь ему с ответом на" +
    " этот вопрос\r\nчтобы ответить на него в будущем.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 56);
            this.label7.TabIndex = 0;
            this.label7.Text = "Чтобы найти данные от аккаунта, который вы добавили\r\nнапишите боту \"найти пароль\"" +
    " или \"найти логин\",\r\nв поиске можете указать,\r\nлибо логин, либо пароль, либо сер" +
    "вис";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Чтобы добавить данные от сервиса напиши боту\r\n\"добавить пароль\" или \"добавить лог" +
    "ин\"";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(210, 307);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(151, 23);
            this.button10.TabIndex = 5;
            this.button10.Text = "Пропустить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 415);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чат-бот";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tb;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tBans;
        public System.Windows.Forms.TextBox tBqw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Button SB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        public DBDataSet dBDataSet;
        public System.Windows.Forms.BindingSource logPassBindingSource;
        public DBDataSetTableAdapters.LogPassTableAdapter logPassTableAdapter;
        public System.Windows.Forms.BindingSource usersBindingSource;
        public DBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lab88;
        private System.Windows.Forms.Label lab66;
        private System.Windows.Forms.Label lab44;
        private System.Windows.Forms.Label lab11;
        private System.Windows.Forms.Label lab22;
        private System.Windows.Forms.Label lab77;
        private System.Windows.Forms.Label lab55;
        private System.Windows.Forms.Label lab33;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
    }
}

