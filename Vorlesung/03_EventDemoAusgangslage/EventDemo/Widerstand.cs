using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Widerstand
    {
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
            }
        }

        private string _desc;
    }
}
