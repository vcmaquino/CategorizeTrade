using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class HighRisk : CategoryRule 
    {
        public override EnumCategories Categorize(Trade trade , ConfiguracaoDto configiration)
        {
            double valorClientPrivate = 1000000;
            return ClientSector.Private == trade.ClientSector && valorClientPrivate < trade.Value
                ? EnumCategories.HighRisk
                : Successor.Categorize(trade, configiration);
        }
    }
}
