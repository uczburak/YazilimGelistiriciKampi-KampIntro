using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BussinesCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The Bussines Credit payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
