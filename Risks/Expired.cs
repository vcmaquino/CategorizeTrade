using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks

{
    public class Expired : Categories
    {

        public override EnumCategories Categorize(NegotiationDto negotiation, ConfiguracaoDto configuracao)
        {
            var expirationDate = configuracao.ReferenceDate.AddDays(-30);
            if (expirationDate > negotiation.NextPaymentDate)
                return EnumCategories.EXPIRED;
            else
                return successor.Categorize(negotiation, configuracao);
        }
    }
}
