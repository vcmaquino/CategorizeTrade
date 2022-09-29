using CategorizeTrades.Enum;
using System;
using System.Globalization;

namespace CategorizeTrades.Rule
{
    public class ValidateOperations
    {

        public int ValidateNumberOfPortifolio()
        {
            int number = 0;
            while (number <= 0)
            {
                Console.WriteLine("Enter the portfolio number");
                var numberOfPortifolio = Console.ReadLine();
                number = Convert.ToInt32(numberOfPortifolio);
                if (number <= 0)
                {
                    Console.WriteLine("Invalid number");
                }
            }
            return number;
        }
        public DateTime ValidateReferenceDate()
        {
            DateTime? date = null;
            while (date == null)
            {
                try
                {
                    Console.WriteLine("Enter a valid date");
                    var referenceDate = Console.ReadLine();
                    date = DateTime.ParseExact(referenceDate, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None);
                } catch (FormatException fe)
                {
                    Console.WriteLine("Invalid date");
                }
            }
            return date.Value;
        }

        public double ValidateValor(string valor)
        {
            var validateValor = double.Parse(valor);
            return validateValor;
        }

        public ClientSector CompleteClientSector()
        {
            ClientSector clientSector = ClientSector.INVALIDO;
            while (clientSector == ClientSector.INVALIDO)
            {
                Console.WriteLine("Enter client sector 1:PRIVATE E 2:PUBLIC");
                var sector = Console.ReadLine();
                clientSector = ValidateClientSector(sector);
            }
            return clientSector;
        }

        public ClientSector ValidateClientSector(string clientSector)
        {
            if (clientSector == "1")
            {
                return ClientSector.PRIVATE;
            }
            else if (clientSector == "2")
            {
                return ClientSector.PUBLIC;
            }
            return ClientSector.INVALIDO;
        }
    }
}
