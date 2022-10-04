using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennschnecken
{
    internal class Rennschnecken
    {
        public void Rennschnecke(Random rand)
        {
            _rand = rand;
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

        private int _strecke = 0;
        private Random _rand;

    }
}
