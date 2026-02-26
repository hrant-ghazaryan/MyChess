namespace ChessLibrary
{
    public class Rook
    {
        public Color color;
        public Location location;
        public Rook()
        { }
        public Rook(Color color)
        { this.color = color; }
        public Rook(Location location)
        { this.location = location; }
        public Rook(Color color, Location location)
        {
            this.color = color;
            this.location = location;
        }
        public Rook(Rook rook)
        {
            color = rook.color;
            location = rook.location;
        }
        public bool IsMovePossible(Location start, Location target)
        {
            if (start.X == target.X || start.Y == target.Y)
                return true;
            return false;
        }
        public bool IsInside(Location loc)
        {
            if (loc.X >= 0 && loc.X < 8 &&
                (int)loc.Y >= 0 && (int)loc.Y < 8)
                return true;
            return false;
        }
    }
}
