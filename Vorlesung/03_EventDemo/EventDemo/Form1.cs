using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _widerstand = new Widerstand("Pull-Up");
            currDesc.Text = _widerstand.Description;
            /* Schritt 5: Anmelden des Handlers am Event als Beobachter */
            _widerstand.DescriptionChanged += DescChanged;
        }
        /* Schritt 4: Event Handler schreiben. Event Handler ist eine Methode mit einer Signatur die der Delegattyp fordert 
            mehr oder weniger der Briefkasten, Objekt muss auch vom Typ Widerstand sein dsa es so auch angelegt wurde */ 
        private void DescChanged(Widerstand widerstand)
        {
            /* Code der ausgeführt wird wenn Event eintritt */
            currDesc.Text = _widerstand.Description;
        }
        /* Event Handler */
        private void button1_Click(object sender, EventArgs e)
        {
            _widerstand.Description = newDesc.Text;
        }

        private Widerstand _widerstand;
    }
}
