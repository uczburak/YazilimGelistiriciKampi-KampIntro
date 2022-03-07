using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new();

            names.Add("Burak");

            Console.WriteLine(names.Count);

            names.Add("Osman");

            names.Add("Pidor");

            names.Add("Hakan");

            Console.WriteLine(names);


            foreach (string name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
