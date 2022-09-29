using CategorizeTrades.DTO;
using CategorizeTrades.Enum;

namespace CategorizeTrades.Rule
{
    public abstract class Categories
    {
        protected Categories successor;
        public void SetSuccessor(Categories _successor)
        {
            successor = _successor;
        }
        public abstract EnumCategories Categorize(NegotiationDto negotiation, ConfiguracaoDto configuracao);
    }
}
