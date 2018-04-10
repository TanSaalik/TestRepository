using System;

namespace ConsoleApp1
{
    internal class Tervitaja
    {
        internal static void Tervita(string keda)
        {
            Console.WriteLine("Tere " + keda + "!");
        }

        internal static void Tervita(string[] v)
        {
            for(int i = 0; i < v.Length; i++)
            Console.WriteLine("Tere " + v[i] + "!");
        }
    }
}