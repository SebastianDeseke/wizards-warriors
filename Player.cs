namespace CsharpSandbox;

public class Player
{

    int health = 100;
    int mana;
    int strength;
    int damageoutput;
    int damageinput;
    int level;
    int experience;
    int distance;

    public Player()
    {

    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int healthnow)
    {
        health = healthnow;
    }
    public void determinExp()
    {
        //A system where the player gives up something to gain exp, and then he can level up if he has enpugh exp
        //should be implimented later, since then there will be moves only available at a certain level
    }
    public void Wizard(int chosenAttack)
    {
        mana = 200;
        strength = 50;

        switch (chosenAttack)
        {
            case 1:
                Console.WriteLine("You have used Fireslash");
                //covers the 3 blocks infront of the player
                damageoutput = 50;
                distance = 2;
                break;
            case 2:
                Console.WriteLine("You have used Ice bullet");
                distance = 10;
                damageoutput = 60;
                //loses damage over distance
                break;
            case 3:
                Console.WriteLine("You have used Enhance");
                //enhances your next turns damage output
                damageoutput = damageoutput * 2;
                break;
            case 4:
                Console.WriteLine("You have used Powershield");
                damageinput = 0;
                //denies you as player 1 turn
                break;

        }
    }

    public void Warrior(int chosenAttack)
    {
        mana = 50;
        strength = 200;

        switch (chosenAttack)
        {
            case 1:
                Console.WriteLine("You have used Slash attack");
                //covers the 3 blocks infront of the character
                damageoutput = 50;
                distance = 2;
                break;
            case 2:
                Console.WriteLine("You have used Tornado slash");
                //covers all blocks around the player
                damageoutput = 30;
                break;
            case 3:
                Console.WriteLine("You have used Powerstance");
                //enhances your next turns damage output
                //maube later also block a fraction of the incoming attack
                damageoutput = damageoutput * 2;
                break;
            case 4:
                Console.WriteLine("You have used Powerblock");
                damageinput = damageinput / 0;
                //denies you as player 1 turn
                break;
        }
    }

}