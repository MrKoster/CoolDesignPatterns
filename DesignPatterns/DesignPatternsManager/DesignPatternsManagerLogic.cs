using AdapterDesignPattern;
using DesignPatternsCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsManager
{
    public class DesignPatternsManagerLogic
    {
        public static List<string> CoveredPatterns = new List<string>()
        {
            "Bridge",
            "Singleton (thread unsafe)",
            "Singleton (thread safe)",
            "Adapter",
            "(others comming soon...)"
        };


        static void Main(string[] args)
        {
            Console.WriteLine("Hello in design patterns demo!");
            Console.WriteLine();
            Console.WriteLine("You can find various design patterns with commentary inside this solution.");
            Console.WriteLine("Each design pattern has its own project.");
            Console.WriteLine();
            Console.WriteLine("List of currently covered design patterns:");
            foreach (var pattern in CoveredPatterns)
            {
                Console.WriteLine($">{pattern}");
            }

            Console.ReadLine();
        }
    }
}
