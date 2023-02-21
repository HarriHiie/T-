using System.Collections.Generic;
using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var schools = new Dictionary<string, string>();

            schools.Add("TTHK", "");
            schools.Add("TKG", "");
            schools.Add("POLÜ", "");
            

            foreach (var school in schools)
            {
                Console.WriteLine($"{school.Key}");
            }
           

        }
    }
}