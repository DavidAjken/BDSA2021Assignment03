using System;
using System.Linq;

namespace BDSA2020.Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            var wizards = Wizard.Wizards;
            var carectors = from w in wizards.Value
                            where w.Creator.Contains("Rowling")
                            select w.Name;
            foreach (var w in carectors)
            {
                Console.WriteLine(w);
            }
        }
    }
}
