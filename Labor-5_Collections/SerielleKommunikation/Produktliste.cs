using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerielleKommunikation
{
    public partial class Produktliste : Form
    {
        public Produktliste()
        {
            InitializeComponent();
        }

        public void ZeigeListe(Dictionary<int, int> productList)
        {
            ListBox.Columns.Add("ID", ListBox.Width / 2, HorizontalAlignment.Left);
            ListBox.Columns.Add("Wert", ListBox.Width / 2, HorizontalAlignment.Left);
            ListBox.View = View.Details;
            ListBox.BeginUpdate();

            foreach (KeyValuePair<int, int> zähler in productList)
            {
                ListViewItem Item = new ListViewItem(zähler.Key.ToString());
                Item.SubItems.Add(zähler.Value.ToString());
                ListBox.Items.Add(Item);
            }
            ListBox.EndUpdate();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
