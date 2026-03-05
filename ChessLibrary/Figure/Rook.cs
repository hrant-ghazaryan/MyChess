using ChessLibrary.Figure;

namespace ChessLibrary
{
    public class Rook : Figuree
    {
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
                return true;
            }
            else if (IsMovePossible(start, target))
                return true;
            return false;
        }
    }
}
