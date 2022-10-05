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
            _widerstand.DescriptionChanged += DescChanged;
        }

        private void DescChanged(Widerstand widerstand)
        {
            currDesc.Text = _widerstand.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _widerstand.Description = newDesc.Text;
        }

        private Widerstand _widerstand;
    }
}
