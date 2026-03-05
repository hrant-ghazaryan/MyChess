namespace ChessLibrary.Figure
{
    public abstract class Figuree
    {
        public Color color { get; set; }
        public Location location { get; set; }
        public bool IsInside(Location loc)
        {
            if ((int)loc.X >= 0 && (int)loc.X < 8 &&
                (int)loc.Y >= 0 && (int)loc.Y < 8)
                return true;
            return false;
        }
    }
}
