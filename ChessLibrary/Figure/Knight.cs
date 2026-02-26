namespace ChessLibrary
{
    public class Knight
    {
        public Color color;
        public Location location;
        public Knight()
        { }
        public Knight(Color color)
        { this.color = color; }
        public Knight(Location location)
        { this.location = location; }
        public Knight(Color color, Location location)
        {
            this.color = color;
            this.location = location;
        }
        public Knight(Knight knight)
        {
            color = knight.color;
            location = knight.location;
        }
        public bool IsMovePossible(Location start, Location target)
        {
            if (Math.Abs(start.X - target.X) == 2 && Math.Abs(start.Y - target.Y) == 1)
                return true;
            else if(Math.Abs(start.X - target.X) == 1 && Math.Abs(start.Y - target.Y) == 2)
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
