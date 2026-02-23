namespace ChessLibrary
{
    public class Pawn
    {
        public byte point;
        public byte count;
        public bool isMoved;
        public bool isUnderAttack;
        public bool moveBlock;
        public Location location;
        public Color color;
        public bool IsMovePossible(string value1, string value2)
        {
            Location start = new Location(value1);
            Location target = new Location(value2);
            if (color == Color.White)
            {
                if (target.X - start.X == 0 && target.Y - start.Y == 1)
                    return true;
                if (target.X - start.X == 0 && target.Y - start.Y == 2 && !isMoved)
                    return true;
                if (Math.Abs(target.X - start.X) == 1 && target.Y - start.Y == 1)
                    return true;
            }
            if (color == Color.Black)
            {
                if (target.X - start.X == 0 && target.Y - start.Y == -1)
                    return true;
                if (target.X - start.X == 0 && target.Y - start.Y == -2 && !isMoved)
                    return true;
                if (Math.Abs(target.X - start.X) == 1 && target.Y - start.Y == -1)
                    return true;
            }
            return false;
        }
    }
}
