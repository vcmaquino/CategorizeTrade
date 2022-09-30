using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks

{
    public class Expired : CategoryRule 
    {

        public override EnumCategories Categorize(Trade trade, ConfigurationDTO configuration)
        {
            var expirationDate = configuration.ReferenceDate.AddDays(-30);
            return expirationDate > trade.NextPaymentDate ? EnumCategories.Expired
             : Successor.Categorize(trade, configuration);
        }
    }
}
