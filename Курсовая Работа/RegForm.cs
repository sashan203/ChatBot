using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_Работа
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (tbl.Text != "" && tbp.Text != "")
            {
                RegUser.Login = tbl.Text;
                RegUser.Password = tbp.Text;
                RegUser.IdUser = tbl.Text;
                tbl.Text = "";
                tbp.Text = "";
                RegUser.RegFormClose = true;
                p.Visible = true;
                p.Enabled = true;
                Form1 af = new Form1();
                af.Show();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbl.Text != "" && tbp.Text != "")
            {
                RegUser.Find = true;
                RegUser.Login = tbl.Text;
                RegUser.Password = tbp.Text;
                tbl.Text = "";
                tbp.Text = "";
                RegUser.RegFormClose = true;
                p.Visible = true;
                p.Enabled = true;
                Form1 af = new Form1();
                af.Show();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void RegForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (RegUser.RegFormClose == false)
            {
                p.Visible = false;
                p.Enabled = false;
            }
        }
    }
}
