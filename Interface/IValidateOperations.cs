using CategorizeTrades.Enum;
using System;

namespace CategorizeTrades.Interface
{
    public interface IValidateOperations
    {
        int ValidateNumberOfPortfolio();
        DateTime ValidateReferenceDate();
        double ValidateValue(string value);
        ClientSector CompleteClientSector();
        ClientSector ValidateClientSector(string clientSector);
    }
}
