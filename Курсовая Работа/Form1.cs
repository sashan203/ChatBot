using System;
using System.Data;
using System.Windows.Forms;

namespace Курсовая_Работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            FirstString = "";
            StrAdd = "";
            log = "";
            Answer = "";
            f1 = false;

        }
        public static Form1 Instance;
        public string FirstString;
        public string StrAdd;
        public string log;
        public string Answer;
        public bool f1;
        static void bot_GetStr (string obj)
        {
            if (obj == String.Empty)
            {
                DialogResult dr = MessageBox.Show("Пустое сообщение бот не поймёт", "Ошибка");
            }
            if (obj == "Trening")
            {
                Form1.Instance.FirstString = obj;
            }
            else
            {
                if (obj != String.Empty)
                {
                    Form1.Instance.StrAdd = obj;
                }
            }
            if (obj == "AddPass")
            {
                Form1.Instance.log = obj;
            }
            if (obj == "FindPass")
            {
                Form1.Instance.log = obj;
            }
        }
        public static class Data
        {
            public static string Value { get; set; }
        }

        public void button1_Click(object sender, EventArgs e)
        {

            ChatBot bot = new ChatBot(@"bd.txt");
            bot.GetStr += bot_GetStr;
            string q = tb.Text;
            string qwU = tb.Text;
            int losR;
            var f = new Form1();

            tb.Text = "";

            bot.Ans(q);
            var c = new ChatBot(@"bd.txt");
            if (Form1.Instance.log == "AddPass")
            {

                button3_Click(sender, e);
                SB_Click(sender, e);
            }
            if (Form1.Instance.log == "FindPass")
            {
                button4_Click(sender, e);
                SB_Click(sender, e);
            }

            if (Form1.Instance.FirstString == "Trening")
            {
                if (Form1.Instance.log == "")
                {
                    tBqw.Text = Form1.Instance.StrAdd;
                    p1.Enabled = true;
                    p1.Visible = true;
                    label1.Text = "";
                }

            }
            else
            {
                lab8.Text = lab6.Text;
                lab7.Text = lab5.Text;
                lab6.Text = lab4.Text;
                lab5.Text = lab3.Text;
                lab4.Text = label2.Text;
                lab3.Text = label1.Text;
                label2.Text = Form1.Instance.StrAdd;
                label1.Text = qwU;
                if (label1.Text != "")
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    lab11.Visible = true;
                    lab22.Visible = true;
                }
                if (lab3.Text != "")
                {
                    lab3.Visible = true;
                    lab4.Visible = true;
                    lab33.Visible = true;
                    lab44.Visible = true;
                }

                if (lab5.Text != "")
                {
                    lab5.Visible = true;
                    lab6.Visible = true;
                    lab55.Visible = true;
                    lab66.Visible = true;
                }

                if (lab7.Text != "")
                {
                    lab7.Visible = true;
                    lab8.Visible = true;
                    lab77.Visible = true;
                    lab88.Visible = true;
                }




                /*lab8.Location = new System.Drawing.Point(15,  + 30);

                losR = lab7.Location.X + lab7.Size.Width - p2.Size.Width + 30;
                lab7.Location = new System.Drawing.Point(lab7.Location.X - losR, lab8.Location.Y + lab8.Size.Height + 30);

                lab6.Location = new System.Drawing.Point(15, lab7.Location.Y + lab7.Size.Height + 30);

                losR = lab5.Location.X + lab5.Size.Width - p2.Size.Width + 30;
                lab5.Location = new System.Drawing.Point(lab5.Location.X - losR, lab6.Location.Y + lab6.Size.Height + 30);

                lab4.Location = new System.Drawing.Point(15, lab5.Location.Y + lab5.Size.Height + 30);

                losR = lab3.Location.X + lab3.Size.Width - p2.Size.Width + 30;
                lab3.Location = new System.Drawing.Point(lab3.Location.X - losR, lab4.Location.Y + lab4.Size.Height + 30);

                label2.Location = new System.Drawing.Point(15, lab3.Location.Y + lab3.Size.Height + 30);

                losR = label1.Location.X + label1.Size.Width - p2.Size.Width + 30;
                label1.Location = new System.Drawing.Point(label1.Location.X - losR, label2.Location.Y+ label2.Size.Height + 30);*/

                losR = lab7.Location.X + lab7.Size.Width - p2.Size.Width + 30;
                lab7.Location = new System.Drawing.Point(lab7.Location.X - losR, 30);
                lab77.Location = new System.Drawing.Point(lab7.Location.X + lab7.Width - lab77.Width, lab7.Location.Y - lab77.Size.Height);

                lab8.Location = new System.Drawing.Point(15, lab7.Location.Y + lab7.Size.Height + 30);
                lab88.Location = new System.Drawing.Point(8, lab8.Location.Y - lab88.Size.Height);

                losR = lab5.Location.X + lab5.Size.Width - p2.Size.Width + 30;
                lab5.Location = new System.Drawing.Point(lab5.Location.X - losR, lab8.Location.Y + lab8.Size.Height + 30);
                lab55.Location = new System.Drawing.Point(lab5.Location.X + lab5.Width - lab55.Width, lab5.Location.Y - lab55.Size.Height);

                lab6.Location = new System.Drawing.Point(15, lab5.Location.Y + lab5.Size.Height + 30);
                lab66.Location = new System.Drawing.Point(8, lab6.Location.Y - lab66.Size.Height);

                losR = lab3.Location.X + lab3.Size.Width - p2.Size.Width + 30;
                lab3.Location = new System.Drawing.Point(lab3.Location.X - losR, lab6.Location.Y + lab6.Size.Height + 30);
                lab33.Location = new System.Drawing.Point(lab3.Location.X + lab3.Width - lab33.Width, lab3.Location.Y - lab33.Size.Height);

                lab4.Location = new System.Drawing.Point(15, lab3.Location.Y + lab3.Size.Height + 30);
                lab44.Location = new System.Drawing.Point(8, lab4.Location.Y - lab44.Size.Height);

                losR = label1.Location.X + label1.Size.Width - p2.Size.Width + 30;
                label1.Location = new System.Drawing.Point(label1.Location.X - losR, lab4.Location.Y + lab4.Size.Height + 30);
                lab11.Location = new System.Drawing.Point(label1.Location.X + label1.Width - lab11.Width, label1.Location.Y - lab11.Size.Height);

                label2.Location = new System.Drawing.Point(15, label1.Location.Y + label1.Size.Height + 30);
                lab22.Location = new System.Drawing.Point(8, label2.Location.Y - lab11.Size.Height);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var c = new ChatBot(@"bd.txt");
            c.Teach(tBqw.Text, tBans.Text);
            p1.Enabled = false;
            p1.Visible = false;
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.usersTableAdapter.Fill(this.dBDataSet.Users);

            this.logPassTableAdapter.Fill(this.dBDataSet.LogPass);
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
       
            this.logPassTableAdapter.Fill(this.dBDataSet.LogPass);
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
        
            this.logPassTableAdapter.Fill(this.dBDataSet.LogPass);
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
           
            this.logPassTableAdapter.Fill(this.dBDataSet.LogPass);
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
            this.logPassTableAdapter.Fill(this.dBDataSet.LogPass);
            this.logPassTableAdapter.Fill(this.dBDataSet.LogPass);
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
            this.logPassTableAdapter.Fill(this.dBDataSet.LogPass);
            if (RegUser.Password != "" & RegUser.Login != "" &  RegUser.Find == false)
            {
                int p;
                p = 1;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j + 1 < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString() == RegUser.Login & dataGridView2.Rows[i].Cells[j + 1].Value.ToString() == RegUser.Password)
                            {
                                DialogResult dr = MessageBox.Show("Такой логин уже используется", "Ошибка");
                                RegUser.RegFormClose = false;
                                this.Close();
                                p = 0;
                            }
                        }

                    }
                }
                if (p == 1)
                {
                    DataRow nRow = dBDataSet.Tables[1].NewRow();
                    nRow[0] = RegUser.Login;
                    nRow[1] = RegUser.Password;
                    dBDataSet.Tables[1].Rows.Add(nRow);
                    usersTableAdapter.Update(dBDataSet.Users);
                    dBDataSet.Tables[1].AcceptChanges();
                    dataGridView2.Refresh();
                    RegUser.Password = "";
                    RegUser.Login = "";
                    usersTableAdapter.Update(dBDataSet);
                    dataGridView1.Refresh();
                    this.reportViewer1.RefreshReport();
                }
            }
            if (RegUser.Find)
            {
                int p;
                p = 1;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {

                    dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j + 1 < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString() == RegUser.Login & dataGridView2.Rows[i].Cells[j+1].Value.ToString() == RegUser.Password)
                            {
                                RegUser.Find = false;
                                RegUser.IdUser = RegUser.Login;
                                p = 0;
                                break;
                            }
                        }

                    }
                    if (p == 0)
                    {
                        RegForm af = new RegForm();
                        af.Hide();
                        break;
                    }
                }
                if (p == 1)
                {
                    DialogResult dr = MessageBox.Show("Логин или пароль не правильный, или аккаунт не зарегестрирован", "Ошибка");
                    RegUser.Find = false;
                    RegUser.RegFormClose = false;
                    RegForm af = new RegForm();
                    this.Close();
                }
                if (p == 0)
                {
                    RegForm af = new RegForm();
                    this.reportViewer1.RefreshReport();
                    reportViewer1.Update();
                    af.Visible = false;
                }
            }
            lab77.Text = "User " + RegUser.IdUser;
            lab55.Text = "User " + RegUser.IdUser;
            lab33.Text = "User " + RegUser.IdUser;
            lab11.Text = "User " + RegUser.IdUser;
        }

        private void SB_Click(object sender, EventArgs e)
        {
            logPassTableAdapter.Update(dBDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        public void button5_Click(object sender, EventArgs e)
        {

                label2.Text = Data.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(dBDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = !reportViewer1.Visible;
            RegUser.RegFormClose = false;
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegUser.RegFormClose = false;
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j+1 < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Selected == true)
                        {
                            if (j==0)
                            {
                            RegUser.FindStr = RegUser.FindStr +"Сервис: "+ dataGridView1.Rows[i].Cells[0].Value;
                            }
                            if (j == 1)
                            {
                            RegUser.FindStr = RegUser.FindStr + " Логин: " + dataGridView1.Rows[i].Cells[1].Value;
                            }
                            if (j == 2)
                            {
                            RegUser.FindStr = RegUser.FindStr + " Пароль: " + dataGridView1.Rows[i].Cells[2].Value+"\n";
                            }
                        }
                dataGridView1.Rows[i].Selected = false;
            }
            if (Form1.Instance.log == "FindPass")
            {

                label1.Visible = true;
                label2.Visible = true;
                lab11.Visible = true;
                lab22.Visible = true;
                label1.Text = "Найди данные";
                label2.Text = "";
                label2.Text = RegUser.FindStr + "\n";
                int losR;
                losR = label1.Location.X + label1.Size.Width - p2.Size.Width + 30;
                label1.Location = new System.Drawing.Point(label1.Location.X - losR, lab4.Location.Y + lab4.Size.Height + 30);
                lab11.Location = new System.Drawing.Point(label1.Location.X + label1.Width - lab11.Width, label1.Location.Y - lab11.Size.Height);

                label2.Location = new System.Drawing.Point(15, label1.Location.Y + label1.Size.Height + 30);
                lab22.Location = new System.Drawing.Point(8, label2.Location.Y - lab11.Size.Height);

            }
        }
        private void FormReport1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reportViewer1.Update();
            reportViewer1.Visible = !reportViewer1.Visible;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p4.Visible = !p4.Visible;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            p1.Enabled = false;
            p1.Visible = false;
        }
    }
}
