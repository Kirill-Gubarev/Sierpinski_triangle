class Program
{
    static void Main(string[] args)
    {
        byte.TryParse(Console.ReadLine(), out byte k);
        short n = (short)(Math.Pow(2, k));
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        short x = 0, y = 0;
        FFF(n, x, y);
        Console.ReadLine();
    }
    static void FFF(short n, short x, short y)
    {
        if (n == 0)//
        {
            Thread.Sleep(30);
            Cell(x, y);
        }
        else//making 3 copies
        {
            FFF((short)(n / 2), x, y);
            FFF((short)(n / 2), (short)(x + n), y);
            FFF((short)(n / 2), x, (short)(y + n));
        }
    }
    static void Cell(short x, short y)//cell rendering
    {
        Console.SetCursorPosition(x * 2, y);
        Console.Write('█');
        Console.SetCursorPosition(x * 2 + 1, y);
        Console.Write('█');
    }
}
