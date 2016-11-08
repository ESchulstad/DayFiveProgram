using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFiveProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] daysWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine(daysWeek[1]);
            

            int[] studentAges = new int[18];
            Console.WriteLine("Enter your age.");
            studentAges[0] = int.Parse(Console.ReadLine());
            

            int[] studentAges = new int[3];
            studentAges[0] = 22;
            Console.WriteLine(studentAges[0]);
            

            char[] lastName = { 's', 'c', 'h', 'u', 'l', 's', 't', 'a', 'd' };
            Console.WriteLine(lastName.Length);
            

            string[] random = { "no", "idea", "what", "to", "write" };
            Console.WriteLine(random[random.Length - 2]);
            

            String[] names = { "Erica", "Sara", "Dave" };
            Console.WriteLine(Array.IndexOf(names, "Erica")); 
            

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.WriteLine(alphabet[0]);
            Array.Reverse(alphabet);
            Console.WriteLine(alphabet[0]);
            */

            string[] names = { "Erica", "Dave", "Sara", "Greg" };
            Array.Sort(names);
            Console.WriteLine(names[0]);
            Console.WriteLine(names[3]);



        }
    }
}
