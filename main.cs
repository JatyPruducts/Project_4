using System.Security.Cryptography;

namespace Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pay> P_list = new List<Pay>
            {
                new Pay("Client1", 1212),
                new Pay("Client2", 21004),
                new Pay("Client3", 45789),
                new Pay("Client4", 13004),
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
