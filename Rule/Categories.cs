using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Interface;

namespace CategorizeTrades.Rule
{
    public abstract class CategoryRule : IClassifiable
    {
        protected CategoryRule Successor;
        public void SetSuccessor(CategoryRule _successor)
        {
            Successor = _successor;
        }
        public abstract EnumCategories Categorize(Trade trade, ConfiguracaoDto configuration);
    }
}
