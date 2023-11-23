
namespace RadilovProject
{
    public class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы уткнулись в стену");
        }

        public virtual IMapSite Clone()
        {
            return new Wall();
        }
    }
}
