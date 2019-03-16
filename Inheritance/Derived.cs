using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Derived:Base
    {
        public Derived()
        {
            publicfield = "Derived publicfield";
            protectedfield = "Derived protectedfield";

        }

        public void CallField()
        {
            Console.WriteLine(protectedfield);
        }
        
    }
}
