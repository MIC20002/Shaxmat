int[,] myMAtrix;
myMAtrix = new int[8, 8];
Console.WriteLine("D or N");
string DN = Console.ReadLine();


    Console.WriteLine("Type x");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Type y");
    int y = int.Parse(Console.ReadLine());
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            myMAtrix[i, j] = 0;

        }
    }
if (DN == "D")
{
    myMAtrix[x, y] = 1;
    myMAtrix[x + 2, y + 1] = 2;
    myMAtrix[x + 1, y + 2] = 3;
    myMAtrix[x - 1, y + 2] = 4;
    myMAtrix[x - 2, y - 1] = 5;
    myMAtrix[x - 2, y - 1] = 6;
    myMAtrix[x - 1, y - 2] = 7;
    myMAtrix[x + 1, y - 2] = 8;
    myMAtrix[x + 2, y - 1] = 9;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(myMAtrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
{ 
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            myMAtrix[i, j] = 0;

        }
        //myMAtrix[x, y] = 1;
        //myMAtrix[x + 2, y + 1] = 2;
        //myMAtrix[x + 1, y + 2] = 3;
        //myMAtrix[x - 1, y + 2] = 4;
        //myMAtrix[x - 2, y - 1] = 5;
        //myMAtrix[x - 2, y - 1] = 6;
        //myMAtrix[x - 1, y - 2] = 7;
        //myMAtrix[x + 1, y - 2] = 8;
        //myMAtrix[x + 2, y - 1] = 9;
    }
 }
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        Console.Write(myMAtrix[i, j] + " ");
    }
    Console.WriteLine();
}



