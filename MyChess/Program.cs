using ChessLibrary;
using ChessLibrary.Enums;

Console.Write("Start Location: ");
Location start = LocValidation();
Console.Write("Target  Location: ");
Location target = LocValidation();
Console.Write("thirdF  Location: ");
Location thirdF = LocValidation();

Rook rook = new Rook(); Bishop bishop = new Bishop(); 
Pawn pawn = new Pawn((Color)1); Knight knight = new Knight(); 
Queen queen = new Queen(); King king = new King();
Console.WriteLine($"Bishop: {bishop.IsMovePossible3(start, target, thirdF)}");
Console.WriteLine($"Rook: {rook.IsMovePossible3(start, target, thirdF)}");
Console.WriteLine($"Queen: {queen.IsMovePossible3(start, target, thirdF)}");
Console.WriteLine("----------");
Console.WriteLine(Message(pawn, pawn.IsMovePossible(start, target)));
Console.WriteLine(Message(king, king.IsMovePossible(start, target)));
Console.WriteLine(Message(bishop, bishop.IsMovePossible(start, target)));
Console.WriteLine(Message(knight, knight.IsMovePossible(start, target)));
Console.WriteLine(Message(rook, rook.IsMovePossible(start, target)));
Console.WriteLine(Message(queen, queen.IsMovePossible(start, target)));

static Location LocValidation()
{
    string? value;
    do
    {
        value = Console.ReadLine()?.ToUpper();
    }
    while (value?.Length != 2 ||
           value[0] < 'A' || value[0] > 'H' ||
           value[1] < '1' || value[1] > '8');

    BoardN x = (BoardN)(7 - (value[1] - '1'));
    BoardL y = (BoardL)(value[0] - 'A');

    return new Location(x, y);
}
static string Message(Object obj, bool b)
{
    if (b)
        return $"{obj.GetType().Name} can be moved to the specified location";
    else
        return $"{obj.GetType().Name} can't move moved to the specified location";
}