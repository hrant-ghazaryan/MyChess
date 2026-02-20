using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLibrary
{
    public struct Location
    {
        public int X;
        public BoardL Y;
        public Location(string coord)
        {
            X = 7 - (coord[1] - '1');
            Y = (BoardL)(coord[0] - 'A');
        }
    }
}
