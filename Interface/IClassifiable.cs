using CategorizeTrades.DTO;
using CategorizeTrades.Enum;
using CategorizeTrades.Rule;

namespace CategorizeTrades.Interface
{
    public interface IClassifiable
    {
        void SetSuccessor(CategoryRule successor);
        EnumCategories Categorize(Trade trade, ConfiguracaoDto configuration);
    }
}
