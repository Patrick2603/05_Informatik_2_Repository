using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormShowDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ZweitesFormular f = new ZweitesFormular();
            f.Show();
        }

        private void showModalButton_Click(object sender, EventArgs e)
        {
            ZweitesFormular f = new ZweitesFormular();
            f.ShowDialog();
        }

        private void showModalButton_MouseEnter(object sender, EventArgs e)
        {
            int i = 0;
        }
    }
}
