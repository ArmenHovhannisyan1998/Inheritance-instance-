using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived instance = new Derived();
            Console.WriteLine(instance.publicfield);
            Console.WriteLine(new string ('-',50));
            instance.CallField();
            Console.WriteLine(new string('-', 50));
            instance.Show();

            Console.ReadKey();
        }
    }
}
