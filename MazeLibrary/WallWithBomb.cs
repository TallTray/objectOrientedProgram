using RadilovProject;


namespace MazeProj
{
    public class WallWithBomb : Wall
    {
        public bool Destroyed { get; internal set; }
        public override void Enter()
        {
            if (Destroyed)
            {
                Console.WriteLine("Стена разрушена");
            }
            else
            {
                base.Enter();
            }
        }
        public override IMapSite Clone()
        {
            return new WallWithBomb();
        }
    }
}
