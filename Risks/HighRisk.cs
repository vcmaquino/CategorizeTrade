using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class HighRisk : CategoryRule 
    {
        public override EnumCategories Categorize(Trade trade , ConfigurationDTO configiration)
        {
            double valueClientPrivate = 1000000;
            return ClientSector.Private == trade.ClientSector && valueClientPrivate < trade.Value
                ? EnumCategories.HighRisk
                : Successor.Categorize(trade, configiration);
        }
    }
}
