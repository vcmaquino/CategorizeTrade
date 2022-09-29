using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Risks;
using System.Collections.Generic;

namespace CategorizeTrades.Rule
{
    public static class EvaluateRisk
    {
        public static IEnumerable<EnumCategories> EvaluateRiskClient(List<Trade> tradeList, ConfiguracaoDto configuration)
        {
            CategoryRule expired = new Expired();
            CategoryRule highRisk = new HighRisk();
            CategoryRule mediumRisk = new MediumRisk();
            expired.SetSuccessor(highRisk);
            highRisk.SetSuccessor(mediumRisk);

            foreach (var item in tradeList)
            {
                yield return expired.Categorize(item, configuration);
            }
        }
    }
}
