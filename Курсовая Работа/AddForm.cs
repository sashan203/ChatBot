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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void CB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.dBDataSet.Tables[0].NewRow();
                if (tbS.Text != "" && tbL.Text != "" && tbP.Text != "")
                {
                    nRow[0] = tbS.Text;
                    nRow[1] = tbL.Text;
                    nRow[2] = tbP.Text;
                    nRow[3] = RegUser.IdUser;
                    main.dBDataSet.Tables[0].Rows.Add(nRow);
                    main.logPassTableAdapter.Update(main.dBDataSet.LogPass);
                    main.dBDataSet.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                    tbS.Text = "";
                    tbL.Text = "";
                    tbP.Text = "";
                    CB_Click(sender, e);

                }
                else
                {
                    DialogResult dr = MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
