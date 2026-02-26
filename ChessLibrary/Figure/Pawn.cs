namespace ChessLibrary
{
    public class Pawn
    {
        public bool isMoved;
        public Color color;
        public Location location;
        public Pawn(Color x)
        {
            color = x;
        }
        public Pawn(Pawn pawn)
        {
            color = pawn.color;
            location = pawn.location;
        }
        public bool IsMovePossible(Location start , Location target)
        {
            if ((int)start.X == 6 || (int)start.X == 1) isMoved = false;
            if (color == Color.White)
            {
                if (start.X - target.X == 1 && start.Y == target.Y)
                    return true;
                else if (start.X - target.X == 2 && !isMoved && start.Y == target.Y)
                    return true;
            }
            if (color == Color.Black)
            {
                if (target.X - start.X == 1 && start.Y == target.Y)
                    return true;
                else if (target.X - start.X == 2 && !isMoved && start.Y == target.Y)
                    return true;
            }
            return false;
        }
    }
}
