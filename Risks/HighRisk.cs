using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Risks
{
    public class HighRisk : Categories
    {
        public override EnumCategories Categorize(Trade trade , ConfiguracaoDto configuracao)
        {
            double valorClientPrivate = 1000000;
            if (ClientSector.PRIVATE == trade.ClientSector && valorClientPrivate < trade.Value)
                return EnumCategories.HIGHRISK;
            else
                return successor.Categorize(trade, configuracao);
        }
    }
}
