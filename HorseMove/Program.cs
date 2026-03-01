using ChessLibrary;
using ChessLibrary.Enums;

Console.Write("Start Location: ");
Location Start = LocValuation();
int[,] desk1 = new int[8, 8];
InitialArray(desk1); StepCount(Start, desk1, 0);
PrintArray(desk1);

Console.WriteLine("---------");

Console.Write("Target  Location: ");
Location Target = LocValuation();
int[,] desk2 = new int[8, 8];
InitialArray(desk2); StepCount(Target, desk2, 0);
PrintArray(desk2);

int min = int.MaxValue;
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if (min > desk1[i, j] + desk2[i, j])
            min = desk1[i, j] + desk2[i, j];
    }
}
Console.WriteLine($"Min Steps: {min}");
static void StepCount(Location loc, int[,] board, int step = 0)
{
    int[] dx = { -2, -2, -1, -1, 1, 1, 2, 2 };
    int[] dy = { -1, 1, -2, 2, -2, 2, -1, 1 };

    bool foundNew = false;

    if (step == 0)
        loc[board] = 0;

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (board[i, j] == step)
            {
                for (int k = 0; k < 8; k++)
                {
                    Location Move;
                    Move.X = (BoardN)i + dx[k];
                    Move.Y = (BoardL)j + dy[k];

                    if (isInside(Move) &&
                        (int)Move[board] == -1)
                    {
                        board[(int)Move.X, (int)Move.Y] = step + 1;
                        foundNew = true;
                    }
                }
            }
        }
    }
    if (foundNew)
        StepCount(loc, board, step + 1);
}
static void InitialArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = -1;
        }
    }
}
static Location LocValuation()
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
static bool isInside(Location loc)
{
    if (loc.X >= 0 && loc.X < (BoardN)8 && loc.Y >= 0 && loc.Y < (BoardL)8)
        return true;
    return false;
}
static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}