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
        public bool IsMovePossible(Location start, Location target)
        {
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
        public Pawn(Color x, Location y)
        {
            bool isNum = false;
            if (x == Color.White)
            {
                if (y.X <= 6)
                    location = y;
                else
                    while (isNum == false)
                    {
                        isNum = int.TryParse(Console.ReadLine(), out y.X);
                        if (y.X <= 6)
                        {
                            location = y;
                            isNum = true;
                        }
                    }
            }
            if (x == Color.Black)
            {
                if (y.X >= 1)
                    location = y;
            }
        }

    }
}