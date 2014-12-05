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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonGreate_Click(object sender, EventArgs e)
        {
            int input = 0;
            if (textBoxk.Text.Length > 0 && Int32.TryParse(textBoxk.Text, out input))
            {
                double ;
            }
        }

    }
}
