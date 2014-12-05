using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPRKForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            int input = 0;
            if (textBoxInputx.Text.Length > 0 && Int32.TryParse(textBoxInputx.Text, out input))
            {
                Table table = new Table(input);
                List <TPRKForms2.Table.Row> rows = table.Rows;
                int n = 1;
                foreach(var row in rows)
                {
                    string[] tableRow = new string[] {n.ToString(), Table.Row.x.ToString(), row.Y.ToString(), row.Win.ToString() };
                    dataGridViewTable.Rows.Add(tableRow);
                    n++;
                }
                textBoxAverage.Text = table.Average.ToString();
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
