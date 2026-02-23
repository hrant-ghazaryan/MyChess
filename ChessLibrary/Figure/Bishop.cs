namespace ChessLibrary
{
    public class Bishop
    {
        public Color color;
        public Location location;
        public bool IsMovePossible(Location start, Location target)
        {
            if (Math.Abs(start.X - target.X) == Math.Abs(start.Y - target.Y))
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
