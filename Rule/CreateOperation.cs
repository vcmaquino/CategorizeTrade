using CategorizeTrades.DTO;
using System;
using System.Collections.Generic;

namespace CategorizeTrades.Rule
{
    public class CreateOperation
    {
        private readonly ValidateOperations _validateOperations;
        public CreateOperation(ValidateOperations validateOperations)
        {
            _validateOperations = validateOperations;
        }

        public ConfiguracaoDto CreateConfiguration()
        {
            Console.WriteLine("Creating the portfolio, follow with the data of how many portfolios and the reference date");
            var configuracao = new ConfiguracaoDto();
            configuracao.NumberOfPortifolio = _validateOperations.ValidateNumberOfPortifolio();
            configuracao.ReferenceDate = _validateOperations.ValidateReferenceDate();
            return configuracao;
        }

        public List<NegotiationDto> CreateObjectNegotiation(ConfiguracaoDto configuracao)
        {
            var negotiationList = new List<NegotiationDto>();

            Console.WriteLine("========================");
            for (int i = 0; i < configuracao.NumberOfPortifolio; i++)
            {
                var negotiation = new NegotiationDto();
                Console.WriteLine("Enter the value");
                var valor = Console.ReadLine();
                negotiation.ClientSector = _validateOperations.CompleteClientSector();
                negotiation.NextPaymentDate = _validateOperations.ValidateReferenceDate();
                negotiation.Value = _validateOperations.ValidateValor(valor);
                negotiationList.Add(negotiation);
                Console.WriteLine("========================");
            }
            return negotiationList;
        }

    }
}
