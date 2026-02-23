namespace ChessLibrary
{
    public class King
    {
        public Color color;
        public Location location;
        public bool IsMovePossible(Location start , Location target)
        {
            if (Math.Abs(start.X - target.X) == 1 || Math.Abs(start.Y - target.Y) == 1 ||
                Math.Abs(start.X - target.X) + Math.Abs(start.Y - target.Y) == 2)
                return true;
            return false;
        }
    }
}
