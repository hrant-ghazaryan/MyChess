using ChessLibrary;

Queen queen = new Queen();
Rook rook = new Rook();
Bishop bishop = new Bishop();
King king = new Bishop();
Knight knight = new Knight();
Pawn pawn = new Pawn();
bool b = queen.IsMovePossible("A1", "A8");
Console.WriteLine(b);
