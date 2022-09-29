using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Risks;
using System.Collections.Generic;

namespace CategorizeTrades.Rule
{
    public class EvaluateRisk
    {
        public List<EnumCategories> EvaluateRiskClient(List<Trade> tradeList, ConfiguracaoDto configuration)
        {
            var categories = new List<EnumCategories>();
            Categories expired = new Expired();
            Categories highRisk = new HighRisk();
            Categories mediumRisk = new MediumRisk();
            expired.SetSuccessor(highRisk);
            highRisk.SetSuccessor(mediumRisk);

            foreach (var item in tradeList)
            {
                categories.Add(expired.Categorize(item, configuration));
            }
            return categories;
        }
    }
}
