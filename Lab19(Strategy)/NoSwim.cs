namespace Lab19_Strategy_
{
    public class NoSwim : ISwim
    {
        public void Execute()
        {
            Console.WriteLine("Не плавает");
        }
    }
}