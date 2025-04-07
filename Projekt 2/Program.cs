List<int> levandeY = new List<int>();
List<int> levandeX = new List<int>();
// levandeX.Add(49, 50, 50, 50, 51);
int[] levandeArrayY = levandeY.ToArray();
int[] levandeArrayX = levandeX.ToArray();
int y = 0;
int x = 0;
main();


void main()
{
    start();
    while (true)
    {
        Console.Clear();
        dinKarta();
        Console.ReadLine();
    }
}

void start()
{
    levandeX.Add(49);
    levandeX.Add(50);
    levandeX.Add(50);
    levandeX.Add(50);
    levandeX.Add(51);
    levandeY.Add(50);
    levandeY.Add(49);
    levandeY.Add(50);
    levandeY.Add(51);
    levandeY.Add(51);
}

void dinKarta()
{
    int grid = 99;
    // System.Console.Write("   ");
    // for (int y = 0; y < grid + 1; y++)
    // {
    //     System.Console.Write(y);
    //     if (y < 10)
    //     {
    //         System.Console.Write(" ");
    //     }
    // }
    System.Console.WriteLine();
    for (int i = 0; i < grid; i++)
    {
        // System.Console.Write(i + 1 + " ");
        // if (i + 1 < 10)
        // {
        //     System.Console.Write(" ");
        // }
        for (int k = 0; k < grid; k++)
        {
            bool levande = Överlevnad(i,k,levandeArrayY[], levandeArrayX[]);
            System.Console.Write("0 ");
        }
        System.Console.WriteLine();
    }
}


static bool Överlevnad(int y, int x, int[] levandeArrayY, int[] levandeArrayX)
{ 
    int grannar = 0;
    bool överlevnadBool = false;
    bool levande = false;
    for (int i = 0; i<levandeArrayX.Count(); i++)
    {
        int xAxelTest = x-1;
        int yAxelTest = y-1;
        if (levandeArrayX[i] == x && levandeArrayY[i] == y)
        {
            levande = true;
        }
        for (int o = 0; o<3; o++)
        {
            for (int k = 0; k<3; k++)
            {
                if (levandeArrayX[i] == xAxelTest && levandeArrayY[i] == yAxelTest)
                {
                    grannar++;
                }
                xAxelTest++;
            }
            yAxelTest++;
        }
    }
    if (levande == true && grannar<2 && grannar>3)
    {
        överlevnadBool = false;
    }
    else if(levande == true &&  grannar == 2)
    {
        överlevnadBool = true;
    }
    else if(grannar == 2)
    {
        överlevnadBool = true;
    }
    return överlevnadBool;
}


// static (int, int) Test(int i, int k, int levandeArray[])
// {
//     return (100, 100);
// }