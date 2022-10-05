using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");
            MessageBox.Show("Text", "Überschrift");
            DialogResult r = MessageBox.Show("Text", "Überschrift", MessageBoxButtons.OKCancel);
            MessageBox.Show("Text", "Überschrift", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show("Text", "Überschrift", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            MessageBox.Show("Text", "Überschrift", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
