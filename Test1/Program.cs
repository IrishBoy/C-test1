using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to see most activ users foreach network (y-for yes)? P.S. I don't have any info, so.....");
            string ans = Console.ReadLine();
            if (ans != "y")
            {
                Console.ReadKey();
            }
            else
            {
                Dictionary<string, int> most = Manager.Most_activ();
                foreach(string name in most.Keys)
                {
                    Console.WriteLine("For {name} is {most[name]}", name, most[name]);
                }
            }
                
        }
    }
}
