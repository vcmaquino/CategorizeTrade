using CategorizeTrades.Enum;
using System;

namespace CategorizeTrades.DTO
{
    public class NegotiationDto
    {
        public double Value { get; set; }
        public ClientSector ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
    }
}
