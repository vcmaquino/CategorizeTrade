using CategorizeTrades.Enum;
using System;

namespace CategorizeTrades.Interface
{
    public interface ITrade
    {
        double Value { get; set; }
        ClientSector ClientSector { get; set; }
        DateTime NextPaymentDate { get; set; }
    }
}
