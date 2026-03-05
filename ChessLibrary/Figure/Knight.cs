using ChessLibrary.Figure;

namespace ChessLibrary
{
    public class Knight : Figuree
    {
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
    }
}
