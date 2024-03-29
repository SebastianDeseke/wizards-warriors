﻿// See https://aka.ms/new-console-template for more information
namespace CsharpSandbox;

public class Sandbox
{

    static void Main(String[] args)
    {
        Battlefield myBattlefield = new Battlefield();
        var newRender = new GUI.Renderer ();
        Player Player1 = new Player();
        Player Player2 = new Player();
        
        Console.WriteLine("The battlefield is " + myBattlefield.FieldGenerator());
        Console.WriteLine("Spawn at: " + "\n" + myBattlefield.Spawnpoint());
        //myBattlefield.Fight();
        //newRender.GenerateField();
        newRender.TestFieldCode();
    }
}
