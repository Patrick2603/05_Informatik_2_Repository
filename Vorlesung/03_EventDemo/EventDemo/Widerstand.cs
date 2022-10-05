using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Widerstand
    {
        public delegate void DescriptionChangedHandler(Widerstand w);
        public event DescriptionChangedHandler DescriptionChanged;

        public Widerstand(string desc)
        {
            _desc = desc;
        }

        public string Description
        {
            get { return _desc; }

            set
            {
                _desc = value;
                OnDescriptionChanged();
            }
        }

        private void OnDescriptionChanged()
        {
            if (DescriptionChanged != null)
            {
                DescriptionChanged(this);
            }
        }

        private string _desc;
    }
}
