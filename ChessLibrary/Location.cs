using ChessLibrary.Enums;

namespace ChessLibrary
{
    public struct Location
    {
        public BoardN X { get; set; }
        public BoardL Y { get; set; }
        public Location(string coord)
        {
            X = (BoardN)7 - (coord[1] - '1');
            Y = (BoardL)(coord[0] - 'A');
        }
        public Location(BoardN row, BoardL col)
        { X = row; Y = col; }
        public int this[int[,] board]
        {
            get => board[(int)X, (int)Y];
            set => board[(int)X, (int)Y] = value;
        }
    }
}
