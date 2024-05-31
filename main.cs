using System.Security.Cryptography;

namespace Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pay> P_list = new List<Pay>
            {
                new Pay("Agent1", 100000),
                new Pay("Agent1", 210002),
                new Pay("Agent1", 99870),
                new Pay("Agent2", 1500),
                new Pay("Agent4", 9455),
            };
            Console.WriteLine("Введите имя контрагента: ");
            var contr = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(contr))
            {
                throw new ArgumentException("Укажите имя.");
            }
            else
            {
                var LINQ = from pay in P_list
                    where pay.Name == contr
                    select pay.Paysum;
                var totalSum = LINQ.Sum();
                
                Console.WriteLine(totalSum);
            }
        }
    }
}