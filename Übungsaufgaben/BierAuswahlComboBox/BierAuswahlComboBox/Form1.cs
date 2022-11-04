using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BierAuswahlComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = ""; 

            foreach(string s in this.listBox1.SelectedItems)
            {
                t += "\n- " + s; 
            }
            MessageBox.Show("Sie haben folgende Biere ausgewählt: " + t);
        }
    }
}
