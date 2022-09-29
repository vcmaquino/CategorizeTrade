using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class MediumRisk : CategoryRule 
    {
        public override EnumCategories Categorize(Trade trade, ConfiguracaoDto configuration)
        {
            double valorClientPublico = 1000000;
            return (ClientSector.Public == trade.ClientSector && valorClientPublico < trade.Value)
                ? EnumCategories.MedimRisk
                : EnumCategories.WithOutRisk;
        }
    }
}
