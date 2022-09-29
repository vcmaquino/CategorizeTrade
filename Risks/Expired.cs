using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks

{
    public class Expired : Categories
    {

        public override EnumCategories Categorize(Trade trade, ConfiguracaoDto configuracao)
        {
            var expirationDate = configuracao.ReferenceDate.AddDays(-30);
            if (expirationDate > trade.NextPaymentDate)
                return EnumCategories.EXPIRED;
            else
                return successor.Categorize(trade, configuracao);
        }
    }
}
