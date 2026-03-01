namespace ChessLibrary
{
    public class Queen
    {
        public Color color;
        public Location location;
        public Queen()
        { }
        public Queen(Color color)
        { this.color = color; }
        public Queen(Location location)
        { this.location = location; }
        public Queen(Color color, Location location)
        {
            this.color = color;
            this.location = location;
        }
        public Queen(Queen queen)
        {
            color = queen.color;
            location = queen.location;
        }
        public bool IsMovePossible(Location start, Location target)
        {
            if (start.X == target.X || start.Y == target.Y ||
                Math.Abs(start.X - target.X) == Math.Abs(start.Y - target.Y))
                return true;
            return false;
        }
        public bool IsMovePossible3(Location start, Location target, Location third)
        {
            if (IsMovePossible(start, target)
               && IsMovePossible(start, third) && IsMovePossible(third, target))
            {
                if ((Math.Abs(start.X - third.X) <= Math.Abs(start.X - target.X))
                    && (Math.Abs(start.Y - third.Y) <= Math.Abs(start.Y - target.Y))
                    && (Math.Abs(target.X - third.X) <= Math.Abs(start.X - target.X))
                    && Math.Abs(target.Y - third.Y) <= Math.Abs(start.Y - target.Y))
                    return false;
                else if ((Math.Abs(start.X - third.X) < Math.Abs(start.X - target.X))
                    && Math.Abs(target.X - third.X) < Math.Abs(start.X - target.X))
                    return false;
                return true;
            }
            else if (IsMovePossible(start, target))
                return true;
            return false;
        }
        public bool IsInside(Location loc)
        {
            if ((int)loc.X >= 0 && (int)loc.X < 8 &&
                (int)loc.Y >= 0 && (int)loc.Y < 8)
                return true;
            return false;
        }
    }
}
