using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("Name", listView1.Width / 4, HorizontalAlignment.Left);
            listView1.Columns.Add("Vorname", listView1.Width / 4, HorizontalAlignment.Left);
            listView1.Columns.Add("e-Mail", listView1.Width / 4, HorizontalAlignment.Left);

            listView1.View = View.Details;

            // Liste füllen
            listView1.BeginUpdate(); // Neuzeichnen derListe verhindern
            ListViewItem lvi = new ListViewItem("Banner");
            lvi.SubItems.Add("David");
            lvi.SubItems.Add("david.banner@navy.mil");
            lvi.ImageIndex = 0;
            listView1.Items.Add(lvi);

            lvi = new ListViewItem("Chaplin");
            lvi.SubItems.Add("Charlie");
            lvi.SubItems.Add("charlie@chaplin.de");
            lvi.ImageIndex = 1;
            listView1.Items.Add(lvi);
            listView1.EndUpdate();

            ImageList imageListLarge = new ImageList();
            imageListLarge.Images.Add(Bitmap.FromFile("hulk.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile("chaplin.jpg"));

            listView1.LargeImageList = imageListLarge;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.View == View.Details)
            {
                listView1.View = View.LargeIcon;
            }
            else 
            {
                listView1.View = View.Details;
            }
        }
    }
}
