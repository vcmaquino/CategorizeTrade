using CategorizeTrades.Enum;
using CategorizeTrades.Interface;
using System;
using System.Globalization;

namespace CategorizeTrades.Rule
{
    public class ValidateOperations : IValidateOperations
    {

        public int ValidateNumberOfPortfolio()
        {
            int number = 0;
            while (number <= 0)
            {
                Console.WriteLine("Enter the number of portfolios");
                var numberOfPortfolio = Console.ReadLine();
                number = Convert.ToInt32(numberOfPortfolio);
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

        public double ValidateValue(string value)
        {
            var validateValue = double.Parse(value);
            return validateValue;
        }

        public ClientSector CompleteClientSector()
        {
            ClientSector clientSector = ClientSector.Invalid;
            while (clientSector == ClientSector.Invalid)
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
                return ClientSector.Private;
            }
            else if (clientSector == "2")
            {
                return ClientSector.Public;
            }
            return ClientSector.Invalid;
        }
    }
}
