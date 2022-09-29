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

        public ConfiguracaoDto CreateConfiguration()
        {
            Console.WriteLine("Creating the portfolio, follow with the data of how many portfolios and the reference date");
            var configuracao = new ConfiguracaoDto();
            configuracao.NumberOfPortifolio = _validateOperations.ValidateNumberOfPortfolio();
            configuracao.ReferenceDate = _validateOperations.ValidateReferenceDate();
            return configuracao;
        }

        public List<Trade> CreateObjectNegotiation(ConfiguracaoDto configuracao)
        {
            var tradeList = new List<Trade>();

            Console.WriteLine("========================");
            for (int i = 0; i < configuracao.NumberOfPortifolio; i++)
            {
                var trade = new Trade();
                Console.WriteLine("Enter the value");
                var valor = Console.ReadLine();
                trade.ClientSector = _validateOperations.CompleteClientSector();
                trade.NextPaymentDate = _validateOperations.ValidateReferenceDate();
                trade.Value = _validateOperations.ValidateValor(valor);
                tradeList.Add(trade);
                Console.WriteLine("========================");
            }
            return tradeList;
        }

    }
}
