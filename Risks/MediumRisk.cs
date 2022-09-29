using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class MediumRisk : Categories
    {
        public override EnumCategories Categorize(NegotiationDto negotiation, ConfiguracaoDto configuracao)
        {
            double valorClientPublico = 1000000;
            if (ClientSector.PUBLIC == negotiation.ClientSector && valorClientPublico < negotiation.Value)
                return EnumCategories.MEDIUMRISK;
            return EnumCategories.WITHOUTRISK;
        }
    }
}
