using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        delegate void MyDelegate(int i);

        private void EineMethode(int i)
        {
            textBox1.Text += "EineMethode wurde aufgerufen: " + i;
            textBox1.Text += Environment.NewLine;
        }
        private void EineAndereMethode(int i)
        {
            textBox1.Text += "EineAndereMethode wurde aufgerufen: " + i;
            textBox1.Text += Environment.NewLine;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MyDelegate verweisAufEineMethode = EineMethode;
            verweisAufEineMethode(5);
            verweisAufEineMethode = EineAndereMethode;
            verweisAufEineMethode(5);
        }
    }
}
