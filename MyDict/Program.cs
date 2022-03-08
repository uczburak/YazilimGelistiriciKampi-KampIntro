using System;

namespace MyDict
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDict<int, string> myDict = new MyDict<int, string>();

            myDict.Add(1, "osman");
            myDict.Add(2, "burak");
            myDict.Add(1, "Burak");
            myDict.Add(4, "berkan");
            myDict.Add(5, "emir");
            myDict.Print();
            myDict.Delete(4);
            Console.WriteLine(myDict.Count);
            myDict.Print();
            
        }

    }
}
