using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            //consumerCreditManager.Calculate();

            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.Calculate();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            creditApplicationManager.AppealCredit(consumerCreditManager, databaseLoggerService);
            creditApplicationManager.AppealCredit(housingCreditManager, fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager, vehicleCreditManager, housingCreditManager };

            //creditApplicationManager.CreditPreliminaryInformation(credits);
        }
    }
}
