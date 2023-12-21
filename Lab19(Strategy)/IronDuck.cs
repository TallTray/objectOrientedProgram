namespace Lab19_Strategy_
{
    public class IronDuck : Duck
    {
        public IronDuck() : base(new NoFly(), new NoQuack(), new NoSwim()) { }
    }
}