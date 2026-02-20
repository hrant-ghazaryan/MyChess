namespace ChessLibrary
{
    public class King
    {
        public byte point;
        public byte count;
        public bool isMoved;
        public bool isChecked;
        public bool moveBlock;
        public Location location;
        public Color color;

        public bool IsMovePossible(Location start , Location target)
        {
            if (Math.Abs(start.X - target.X) == 1 || Math.Abs(start.Y - target.Y) == 1 ||
                Math.Abs(start.X - target.X) + Math.Abs(start.Y - target.Y) == 2)
                return true;
            return false;
        }
    }
}
