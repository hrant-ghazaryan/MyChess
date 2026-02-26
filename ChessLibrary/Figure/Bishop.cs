namespace ChessLibrary
{
    public class Bishop
    {
        public Color color;
        public Location location;
        public Bishop()
        { }
        public Bishop(Color color)
        { this.color = color; }
        public Bishop(Location location)
        { this.location = location; }
        public Bishop(Color color, Location location)
        {
            this.color = color;
            this.location = location;
        }
        public Bishop(Bishop bishop)
        {
            color = bishop.color;  
            location = bishop.location;
        }
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
