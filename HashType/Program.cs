using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashType
{
    class Program
    {
        static void Main(string[] args)
        {
            string _hash;
            Console.Write("Hash Enter =>");
            _hash = Console.ReadLine();
            Hash.WhichType(_hash);
            Console.ReadLine();
        }
    }
}
