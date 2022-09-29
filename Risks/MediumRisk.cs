using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class MediumRisk : Categories
    {
        public override EnumCategories Categorize(Trade trade, ConfiguracaoDto configuracao)
        {
            double valorClientPublico = 1000000;
            if (ClientSector.PUBLIC == trade.ClientSector && valorClientPublico < trade.Value)
                return EnumCategories.MEDIUMRISK;
            return EnumCategories.WITHOUTRISK;
        }
    }
}
