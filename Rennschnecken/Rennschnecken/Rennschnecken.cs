using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennschnecken
{
    internal class Rennschnecken
    {
        private int _strecke;
        private Random _rand;

        public Rennschnecken(Random rand, Rennschnecken schnecke1)
        {
            _rand = rand;
            _strecke = 0; 
        }

        public void Krieche()
        {
            _strecke += _rand.Next(4);
        }

        public int Strecke
        {
            get
            {
                return _strecke;
            }
        }

        public string Visualisierung
        {
            get
            {
                string s = "";

                for (int i = 0; i < _strecke; i++)
                {
                    s += "_";
                }
                s += "@";

                return s;
            }
        }
    }
}
