namespace CsharpSandbox.GUI;

public class Renderer
{
    Battlefield battlefield = new Battlefield();
    int lenght = 6;
    int width = 8;

    public void GenerateField()
    {

        var Field = new char[][] {
new char [] { '+', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '+'},
new char [] { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
new char [] { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
new char [] { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
new char [] { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
new char [] { '+', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '+'},
};

        for (int x = 0; x < Field.Length; x++)
        {
            for (int y = 0; y < Field[x].Length; y++)
            {
                Console.Write(Field[x][y]);
            }

            Console.WriteLine();

        };

    }

    //public object Brushes { get; private set; }

    public void StoyanExample()
    {
        Console.Clear();

        var world = new char[][]
{
    new char[] { '+', '-', '-', '-', '+' },
    new char[] { '|', '#', ' ', ' ', '|' },
    new char[] { '|', ' ', ' ', ' ', '|' },
    new char[] { '+', ' ', '-', '-', '+' },
};

        for (int x = 0; x < world.Length; x++)
        {
            for (int y = 0; y < world[x].Length; y++)
            {
                Console.Write(world[x][y]);
            }
            System.Console.WriteLine();
        }

    }

    public void TestFieldCode()
    {
        int sqaureWidth = 100;
        int sqaureHeight = 100;
        const int rowCount = 16;
        const int columnCount = 16;

        Console.Clear();

        var world = new char[rowCount][];

        for (int x = 0; x < rowCount; x++)
        //{
        {
            world[x] = new char[columnCount];
            for (int y = 0; y < columnCount; y++)
            {
                if (y == 0 || y == rowCount - 1)
                {
                    world[x][y] = '|';
                }
                else if (x == 0 || x == columnCount - 1)
                {
                    world[x][y] = '-';
                } 
                else 
                {
                    world [x][y] = ' ';
                }



                if ((x == 0 && y == 0) || (x == 0 && y == rowCount - 1))
                {
                    world [x][y] = '+';
                }
                else if ((x == rowCount - 1 && y == 0) || (x == rowCount - 1 && y == columnCount -1)) 
                {
                    world [x][y] = '+';
                }
                //world [x][y] = 'k';
            }
        }


        //Console.Clear();
        for (int x = 0; x < world.Length; x++)
        {
            for (int y = 0; y < world[x].Length; y++)
            {
                Console.Write(world[x][y]);
            }
            Console.WriteLine();
        }
    }
}