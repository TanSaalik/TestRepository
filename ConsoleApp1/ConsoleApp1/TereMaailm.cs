﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere maailm!");
            Console.WriteLine("Nyyd on 2kki push ka.");
            Tervitaja.Tervita("ASK");
            Tervitaja.Tervita(new string[] { "Maailm" , "Jaan", "Mati"});
            Console.ReadLine();
        }
    }
}
