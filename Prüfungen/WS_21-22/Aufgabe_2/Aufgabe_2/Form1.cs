using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* b.) */
        List<Ticket> _ticketList = new List<Ticket>();

        private void button1_Click(object sender, EventArgs e)
        {
            /* Button: hinzufügen */
            /* Check if there is something in the textBox */
            if(tBBeschreibung.Text.Length > 0)
            {
                int neueNummer = 0; 
                /* check if there is even something in the List */
                if(_ticketList.Count > 0)
                {
                    /* look at the highest Number of the ticket List, -1 is needed because of starting Index of 0, then create the new number which is +1 greater */
                    neueNummer = _ticketList[_ticketList.Count - 1].Nummer + 1; 
                }
                /* create the new ticket which should be added */
                Ticket t = new Ticket(neueNummer, tBBeschreibung.Text);
                /* add Ticket t to List */
                _ticketList.Add(t); 
            }

            tBBeschreibung.Clear();
            tBNummer.Clear();
            tBStatus.Clear(); 
        }

        /* c.) */
        private void button2_Click(object sender, EventArgs e)
        {
            /* Button: Status */
            int ticketnummer = Int32.Parse(tBNummer.Text);
            for(int i = 0; i < _ticketList.Count(); i++)
            {
                if (ticketnummer == _ticketList[i].Nummer)
                {
                    int ticketstatus = Int32.Parse(tBStatus.Text);

                    if(ticketstatus == 100)
                    {
                        _ticketList.RemoveAt(i);
                    }
                    else if((ticketstatus >= 0) && (ticketstatus < 100))
                    {
                        _ticketList[i].Status = ticketstatus; 
                    }
                }
            }
        }
    }
}
