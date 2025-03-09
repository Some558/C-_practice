// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Game game = new Game();
        game.GenerateRandomNumber();

        while(true)
        {
            int number = game.GetUserInput();
            game.ShowMessage(number);

            if(number == game.GetAnswer())
            {
                break;
            }
        }
    // Game.Random();
    // Game.userInput();
    // Game.Message(number);

    }

}
