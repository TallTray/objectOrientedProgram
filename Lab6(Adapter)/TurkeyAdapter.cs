

namespace Lab6_Adapter_
{
    public class TurkeyAdapter : Duck
    {
        private Turkey _turkey;
        public TurkeyAdapter(Turkey turkey) 
        {
            _turkey = turkey ?? throw new ArgumentNullException(nameof(turkey));
        }
        public override void Quack()
        {
            _turkey.Cackle();
        }
        public override void Fly()
        {
            _turkey.Walk();
        }
    }
}
