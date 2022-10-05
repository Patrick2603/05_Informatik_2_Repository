using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericListDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> list = new List<Student>();

            // Objekte einfügen
            Student student = new Student("Hans Dampf", 1990, 4711);
            list.Add(student);
            list.Add(new Student("Erwin Igel", 1991, 1234));
            list.Add(new Student("Emil Grünkern", 1990, 815));

            // Alle Objekte anzeigen
            string ausgabe = "";
            foreach (Student s in list)
            {
                // Die Referenzen haben schon den passenden Typen
                ausgabe += s.Name;
                ausgabe += Environment.NewLine;
            }

            textBox1.Text = ausgabe;

        }
    }
}
