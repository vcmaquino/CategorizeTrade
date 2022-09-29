using CategorizeTrades.Enum;
using System;

namespace CategorizeTrades.Interface
{
    public interface IValidateOperations
    {
        int ValidateNumberOfPortfolio();
        DateTime ValidateReferenceDate();
        double ValidateValor(string valor);
        ClientSector CompleteClientSector();
        ClientSector ValidateClientSector(string clientSector);
    }
}
