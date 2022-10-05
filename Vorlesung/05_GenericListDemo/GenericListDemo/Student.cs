using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    class Student
    {
        public Student(string name, int jahrgang, int matrikelNr)
        {
            _name = name;
            _jahrgang = jahrgang;
            _matrikelNr = matrikelNr;
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public int Jahrgang
        {
            get { return _jahrgang; }
        }

        public int MatrikelNr
        {
            get { return _matrikelNr; }
        }

        // Attribute
        private string _name;
        private int _jahrgang;
        private int _matrikelNr;
    }
}
