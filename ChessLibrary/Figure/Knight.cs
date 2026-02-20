using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLibrary
{
    public class Knight
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
            bool[,] board = new bool[8, 8];
            int[] dx = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] dy = { -1, 1, -2, 2, -2, 2, -1, 1 };

            for (int k = 0; k < 8; k++)
            {
                Location Move;
                Move.X = start.X + dx[k];
                Move.Y = start.Y + dy[k];

                if (IsInside(Move))
                {
                    board[Move.X, (int)Move.Y] = true;
                }
            }
            if (board[target.X, (int)target.Y])
                return true;
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
