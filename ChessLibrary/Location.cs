using ChessLibrary.Enums;

namespace ChessLibrary
{
    public struct Location
    {
        public BoardN X;
        public BoardL Y;
        public Location(string coord)
        {
            X = (BoardN)7 - (coord[1] - '1');
            Y = (BoardL)(coord[0] - 'A');
        }
        public Location(BoardN row, BoardL col)
        { X = row; Y = col; }
    }
}
