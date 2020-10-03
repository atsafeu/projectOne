using System;

namespace StudioCountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
      
            string test = "Hello World";
            Dictionary<char,int>counts = new Dictionary<char,int>();
            foreach (char c in test)
            {
               if (!counts.Keys.Contains(c))
                {
                    counts.Add(c,1);
                 }
               else
                {
                    counts[c]++;
                }
               foreach(KeyValuePair<chair,int> count in counts)
                {
                    Console.WriteLine(count.Key + ":" + count.Value);
                }
                Console.ReadLine();
            }
        }
    }
}
