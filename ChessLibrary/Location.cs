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
        public Location(int row , BoardL col)
        {
            X = row;
            Y = col;
        }
    }
}
