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

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() };

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            creditApplicationManager.AppealCredit(consumerCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager, vehicleCreditManager, housingCreditManager };

            //creditApplicationManager.CreditPreliminaryInformation(credits);

            //creditApplicationManager.AppealCredit(new BussinesCreditManager(), loggers);
            //creditApplicationManager.AppealCredit(new BussinesCreditManager(), loggers);
        }
    }
}
