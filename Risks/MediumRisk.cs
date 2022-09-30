using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class MediumRisk : CategoryRule 
    {
        public override EnumCategories Categorize(Trade trade, ConfigurationDTO configuration)
        {
            double valueClientPublico = 1000000;
            return (ClientSector.Public == trade.ClientSector && valueClientPublico < trade.Value)
                ? EnumCategories.MedimRisk
                : EnumCategories.WithoutRisk;
        }
    }
}
