namespace Lab19_Strategy_
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFly(), new NoQuack(), new Swim()) { }
    }
}