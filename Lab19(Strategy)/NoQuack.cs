namespace Lab19_Strategy_
{
    public class NoQuack : IQuack
    {
        public void Execute()
        {
            Console.WriteLine("Не крякает");
        }
    }
}