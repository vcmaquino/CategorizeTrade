using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class HighRisk : Categories
    {
        public override EnumCategories Categorize(NegotiationDto negotiation, ConfiguracaoDto configuracao)
        {
            double valorClientPrivate = 1000000;
            if (ClientSector.PRIVATE == negotiation.ClientSector && valorClientPrivate < negotiation.Value)
                return EnumCategories.HIGHRISK;
            else
                return successor.Categorize(negotiation, configuracao);
        }
    }
}
