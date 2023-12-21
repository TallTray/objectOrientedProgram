namespace Lab19_Strategy_
{
    public class NoFly : IFly
    {
        public void Execute()
        {
            Console.WriteLine("Не летает");
        }
    }
}