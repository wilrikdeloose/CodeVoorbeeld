using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeVoorbeeld
{
    internal class School
    {
        private string name = "Fontys";
        private int maxStudents = 1000;
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public School(string name, int maxStudents)
        {
            this.name = name;
            this.maxStudents = maxStudents;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
