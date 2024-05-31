namespace Project_4
{
    public class Pay
    {
        public string Name {get; protected set; }
        public int Paysum {get; protected set; }

        public Pay(string name, int sum)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Укажите имя");
            }
            else
            {
                Name = name;
                Paysum = sum;
            }
        }
    }
}