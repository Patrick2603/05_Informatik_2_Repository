using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO; 

namespace Aufgabe_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _datei = @"D:\tmp1\Adressen.txt";
        private List<Kontakt> _list = new List<Kontakt>();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /* a.) */
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* open the file */
            using (StreamReader sr = new StreamReader(_datei))
            {
                /* read it line for line, as long there is something to read */
                while((_zeile = reader.ReadLine()) != null)
                {
                    /* _list is from type Kontakt so we can only add values with type Kontakt so a new object has to be generated */
                    Kontakt adresse = new Kontakt(zeile);
                    _list.Add(adresse);
                }
            }
        }
    }
}
