namespace MinotaurLabyrinth
{
    /// <summary>
    /// Represents a Slimy gel monster in the game.
    /// </summary>
    public class GelatinousCube : Monster, IMovable
    {
        private Location _location;


        public GelatinousCube(Location Location){
            _location = Location;
        }

        public Location GetLocation() {
            return _location;
        }
        public override void Activate(Hero hero, Map map)
        {
            ConsoleHelper.WriteLine("exciting text", ConsoleColor.Red);
            hero.Kill("You got killed");
        }

        public void Move(Hero hero, Map map)
        {
            map.GetRoomAtLocation(_location).RemoveMonster():
            _location = new Location(_location.Row + 1, _location.Column);
            map.GetRoomAtLocation(_location).AddMonster(this);
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            return false;
        }

        public override DisplayDetails Display()
        {
            return new DisplayDetails("[C]", ConsoleColor.Green);
        }
    }
}