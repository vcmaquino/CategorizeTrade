using CategorizeTrades.DTO;
using CategorizeTrades.Interface;
using System;
using System.Collections.Generic;

namespace CategorizeTrades.Rule
{
    public class CreateOperation
    {
        private readonly IValidateOperations _validateOperations;
        public CreateOperation(IValidateOperations validateOperations)
        {
            _validateOperations = validateOperations;
        }

        public ConfigurationDTO CreateConfiguration()
        {
            Console.WriteLine("Creating the portfolio, follow with the data of how many portfolios and the reference date");
            var configuration = new ConfigurationDTO();
            configuration.ReferenceDate = _validateOperations.ValidateReferenceDate();
            configuration.NumberOfPortfolio = _validateOperations.ValidateNumberOfPortfolio();
            return configuration;
        }

        public List<Trade> CreateObjectNegotiation(ConfigurationDTO configuration)
        {
            var tradeList = new List<Trade>();

            Console.WriteLine("========================");
            for (int number = 0; number < configuration.NumberOfPortfolio; number++)
            {
                var trade = new Trade();
                Console.WriteLine("Enter the value");
                var value = Console.ReadLine();
                trade.ClientSector = _validateOperations.CompleteClientSector();
                trade.NextPaymentDate = _validateOperations.ValidateReferenceDate();
                trade.Value = _validateOperations.ValidateValue(value);
                tradeList.Add(trade);
                Console.WriteLine("========================");
            }
            return tradeList;
        }

    }
}
