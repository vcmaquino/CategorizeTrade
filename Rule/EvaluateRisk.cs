using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Risks;
using System.Collections.Generic;

namespace CategorizeTrades.Rule
{
    public class EvaluateRisk
    {
        public List<EnumCategories> EvaluateRiskClient(List<NegotiationDto> negotiation, ConfiguracaoDto configuracao)
        {
            var categorias = new List<EnumCategories>();
            Categories expired = new Expired();
            Categories highRisk = new HighRisk();
            Categories mediumRisk = new MediumRisk();
            expired.SetSuccessor(highRisk);
            highRisk.SetSuccessor(mediumRisk);

            foreach (var item in negotiation)
            {
                categorias.Add(expired.Categorize(item, configuracao));
            }
            return categorias;
        }
    }
}
