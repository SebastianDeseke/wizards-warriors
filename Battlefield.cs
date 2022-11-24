namespace CsharpSandbox;

public class Battlefield
{

    int length = 6;
    int width = 8;
    int[] BattlefieldSize;
    int spawnpointplayer1;
    int spawnpointplayer2;
    Random rnd = new Random();
    Player myPlayers = new Player();

    public Battlefield()
    {
        BattlefieldSize = new int[length * width];
    }

    public int[] FieldGenerator()
    {
        int count = 1;

        //int player1Half = between 1 and length/2
        //int player2Half =  between length/2 and length.end
        for (int i = 0; i < length * width; i++)
        {
            BattlefieldSize[i] = count;
            count++;
        }

        return BattlefieldSize;
    }
    public string Spawnpoint()
    {
        int fieldsquares = length * width;
        int halfline = BattlefieldSize.Length / 2;
        spawnpointplayer1 = rnd.Next(BattlefieldSize[0], halfline);
        spawnpointplayer2 = rnd.Next(halfline + 1, BattlefieldSize[BattlefieldSize.Length - 1] + 1);
        return "Your spawn point is " + spawnpointplayer1 + "\t" + spawnpointplayer2;
    }

    public void Fight()
    {
        String choice;
        Console.WriteLine("Wizard or Warrior?");
        choice = Console.ReadLine();
        int Attackchoice;
        do
        {

            switch (choice)
            {
                case "Wizard":
                    Console.WriteLine("Choose your Attack: " + "\n" + "1 = Fireslash \n" + "2 = Ice Bullet \n");
                    Attackchoice = Console.Read();
                    myPlayers.Wizard(Attackchoice);
                    break;
                case "Warrior":
                    Console.WriteLine("Choose your Attack: ");
                    Attackchoice = Console.Read();
                    myPlayers.Warrior(Attackchoice);
                    break;
                default:
                    Console.WriteLine("You probably made a spelling mistake!");
                    break;
            }
        } while (myPlayers.GetHealth() > 0);

    }
}

