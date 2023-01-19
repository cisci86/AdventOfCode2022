using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class StartOfMessage
    {
        public int GetStartOfMessage(string input)
        {
            Queue<char> som = new Queue<char>();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                som.Enqueue(input[i]);
                for (int j = i+1; j < i+14; j++)
                {
                    if (!som.Contains(input[j]))
                    {
                        som.Enqueue(input[j]);
                    }
                    else
                    {
                        som.Clear();
                        break;
                    }
                }
                if(som.Count == 14)
                {
                    break;
                }
            }
            foreach (var item in som)
            {
                output += item;
            }

            return input.IndexOf(output)+14;
        }
    }
}
