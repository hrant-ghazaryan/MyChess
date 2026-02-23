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
        public Pawn(Color x , Location y)
        {
            bool isNum = false;
            if (x == Color.White)
            {
                if (y.X <= 6)
                    location = y;
                else
                    while(isNum == false)
                    {
                        isNum = int.TryParse(Console.ReadLine(),out y.X);
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

        public bool WhiteIsMovePossible(Location start, Location target)
        {
            bool canMove = false;
            if (color == Color.White && start.X == 6)
            {
                if (start.X - target.X == 1 && start.Y == target.Y)
                    canMove = true;
                else if (start.X - target.X == 1 && Math.Abs(start.Y - target.Y) == 1)
                    canMove = true;
                else if (start.X - target.X == 2 && start.Y == target.Y)
                    canMove = true;
            }
            else if (color == 0 && start.X != 6)
            {
                if (start.X - target.X == 1 && start.Y == target.Y)
                    canMove = true;
                else if (start.X - target.X == 1 && Math.Abs(start.Y - target.Y) == 1)
                    canMove = true;
            }
            return canMove;
        }
        public bool BlackIsMovePossible(Location start, Location target)
        {
            bool canMove = false; ;
            if (color == Color.Black && start.X == 1)
            {
                if (target.X - start.X == 1 && start.Y == target.Y)
                    canMove = true;
                else if (target.X - start.X == 1 && Math.Abs(start.Y - target.Y) == 1)
                    canMove = true;
                else if (target.X - start.X == 2 && start.Y == target.Y)
                    canMove = true;
            }
            else if (color == Color.Black && start.X != 1)
            {
                if (target.X - start.X == 1 && start.Y == target.Y)
                    canMove = true;
                else if (target.X - start.X == 1 && Math.Abs(start.Y - target.Y) == 1)
                    canMove = true;
            }
            return canMove;
        }
    }
}