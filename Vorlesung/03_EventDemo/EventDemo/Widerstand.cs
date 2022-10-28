using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Widerstand
    {
        private string _desc;
        /* Schritt 1: Delegatendtyp für den Evenet Handler deklarieren, bei Übertragung der Events wird immer das Objekt mitgegeeben, wie ID zu verstehen */
        public delegate void DescriptionChangedHandler(Widerstand w);
        /* Schritt 2: Event in der auszulösenden Klasse definieren, Name des Events DescriptionChanged */ 
        public event DescriptionChangedHandler DescriptionChanged;

        /* Konstrukor */ 
        public Widerstand(string desc)
        {
            _desc = desc;
        }

        public string Description
        {
            get 
            { 
                return _desc; 
            }

            set
            {
                _desc = value;
                /* 3.Schritt: Event wird ausgelöst */
                OnDescriptionChanged();
            }
        }
        /* Schritt 3: Es wird immer am Afang geprüft ob dsa Event null ist, Grund dafür kein Handler am Event angemeldet, 
            Form1 möchte wissen welches Widerstand Objekt hat es ausgelöst bekommt deshalb Referenz des Objekts -> this Referenz  
            Form1 kann nur drauf zu greifen wenn es die ID des Objekts hat */ 
        private void OnDescriptionChanged()
        {
            if (DescriptionChanged != null)
            {
                DescriptionChanged(this);
            }
        }
    }
}
