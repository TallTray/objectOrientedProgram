
namespace Lab9_Decorator_
{
    public class Latte : Coffe
    {
        public override int Price()
        {
            return 4;
        }
        public override void Print()
        {
            Console.WriteLine("Латте");
        }
    }
}
