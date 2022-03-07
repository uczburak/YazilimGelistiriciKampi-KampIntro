using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();

            customer1.Id = 1;
            customer1.CustomerNumber = "123445";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.NationalityId = "2345435";

            CorporateCustomer customer2 = new CorporateCustomer();

            customer2.Id = 2;
            customer2.CustomerNumber = "1645445";
            customer2.CompanyName = "BurakLTDSTI";
            customer2.TaxNo = "14435435656234";

            //Gerçek kişi -- Tüzel Kişi
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
