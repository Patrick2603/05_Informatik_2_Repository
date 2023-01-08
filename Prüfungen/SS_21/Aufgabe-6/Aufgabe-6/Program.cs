using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* initialize */
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            /* StreamReader needs the file path */
            using (StreamReader reader = new StreamReader(openFileDialog.FileName))
            {
                string text = reader.ReadToEnd();
            }

            /* Alternative */
            //StreamReader reader = new StreamReader(openFileDialog.FileName);
            //string text = reader.ReadToEnd();
            //reader.Dispose(); 

        }
    }
}
