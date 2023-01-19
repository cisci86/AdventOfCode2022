using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Rucksack
    {
        public void DivideCompartments(string[] sacks)
        {
            int sum = 0;
            foreach(var sack in sacks)
            {
                int compartmentSize = sack.Length/2;
                var compartment1 = sack.Substring(0, compartmentSize);
                char[] c1 = new char[compartmentSize];
                for(int i = 0; i < c1.Length; i++)
                {
                    c1[i] = compartment1[i];
                }
                var compartment2 = sack.Substring(compartmentSize);
                char[] c2 = new char[compartmentSize];
                for (int i = 0; i < c2.Length; i++)
                {
                    c2[i] = compartment2[i];
                }
                foreach (var item in c1)
                {
                    if(Array.Exists(c2, c2i => c2i == item))
                    {
                        sum += GetPriority(item);
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }

        public int GetPriority(char item)
        {
            if (Char.IsLower(item))
            {
                return (item - 96);
            }
            if (Char.IsUpper(item))
            {
                return (item - 38);
            }
            return 0;
        }
    }
}
