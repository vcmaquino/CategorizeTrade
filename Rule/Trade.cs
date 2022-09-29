using CategorizeTrades.Enum;
using CategorizeTrades.Interface;
using System;

namespace CategorizeTrades.Rule
{
    public class Trade : ITrade
    {
        private double _value;
        private ClientSector _clientSector;
        private DateTime _nextPaymentDate;

       
        public double Value 
        { 
            get => _value;
            set => _value = value; 
        }
        public ClientSector ClientSector 
        { 
            get => _clientSector;
            set => _clientSector = value; 
        }
        public DateTime NextPaymentDate 
        {  
            get => _nextPaymentDate; 
            set => _nextPaymentDate = value; 
        }
    }
}
