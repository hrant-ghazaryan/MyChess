namespace ChessLibrary
{
    public class King
    {
        public Color color;
        public Location location;
        public King()
        { }
        public King(Color color)
        { this.color = color; }
        public King(Location location)
        { this.location = location; }
        public King(Color color, Location location)
        {
            this.color = color;
            this.location = location;
        }
        public King(King king)
        {
            color = king.color;
            location = king.location;
        }
        public bool IsMovePossible(Location start , Location target)
        {
            if (Math.Abs(start.X - target.X) == 1 || Math.Abs(start.Y - target.Y) == 1 ||
                Math.Abs(start.X - target.X) + Math.Abs(start.Y - target.Y) == 2)
                return true;
            return false;
        }
    }
}
