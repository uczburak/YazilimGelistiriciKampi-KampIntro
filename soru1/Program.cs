using System;

namespace soru1
{
    class Program
    {
        public static string searchingChallenge(string str)
        {
            int numCount = 0;
            int numSum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(int.TryParse(str.Substring(i,1)))
                {
                    numCount += 1;
                    numSum += (int)str.Substring(i, 1);
                }
            }
            numSum = numSum / str.Length - numCount;
            return numSum.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
