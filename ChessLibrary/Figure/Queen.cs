using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLibrary
{
    public class Queen
    {
        public byte point;
        public byte count;
        public bool isUnderAttack;
        public bool moveBlock;
        public Location location;
        public Color color;
        public bool IsMovePossible(string value, string value2)
        {
            Location start = new Location(value);
            Location target = new Location(value2);
            if (IsInside(start) && IsInside(target))
            {
                bool[,] board = new bool[8, 8];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Math.Abs(start.X - i) <= 7 && (int)start.Y == j)
                        {
                            Location newLoc;
                            newLoc.X = i;
                            newLoc.Y = start.Y;
                            if (IsInside(newLoc))
                                board[i, j] = true;
                        }
                        if (start.X == i && Math.Abs((int)start.Y - j) <= 7)
                        {
                            Location newLoc;
                            newLoc.X = start.X;
                            newLoc.Y = (BoardL)j;
                            if (IsInside(newLoc))
                                board[i, j] = true;
                        }
                        if (Math.Abs(start.X - i) == Math.Abs((int)start.Y - j))
                            board[i, j] = true;
                    }
                }
                return board[target.X, (int)target.Y];
            }
            else
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
