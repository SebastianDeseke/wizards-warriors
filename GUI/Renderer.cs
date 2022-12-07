namespace CsharpSandbox.GUI;

public class Renderer
{

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
            Console.WriteLine();
        }
    }

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

}