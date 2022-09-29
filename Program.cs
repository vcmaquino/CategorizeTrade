using CategorizeTrades.Rule;
using System;

namespace CategorizeTrades
{
    class Program
    {
        static void Main(string[] args)
        {

            var validateOperations = new ValidateOperations();
            var createOperation = new CreateOperation(validateOperations);

            var configuration = createOperation.CreateConfiguration();
            var negotiationList = createOperation.CreateObjectNegotiation(configuration);

            var list = EvaluateRisk.EvaluateRiskClient(negotiationList, configuration);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
