using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, Student> studenten = new Dictionary<int, Student>();

            // Studierende mit Matrikelnummer als Hash-Key abspeichern.
            Student student = new Student("Hans Dampf", 1990, 4711);
            studenten[4711] = student;
            studenten[1234] = new Student("Erwin Igel", 1991, 1234);
            studenten[815] = new Student("Emil Grünkern", 1990, 815);

            textBox1.Text = studenten[4711].Name;
        }
    }
}
