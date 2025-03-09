using System;

// protected 
public class Game
{
    public  int answer;
    public Random random = new Random();

    public void GenerateRandomNumber()
    {
        answer = random.Next(1,101);
        // int answer = Random.Next(1,101);
        // return answer;
    }

    public int GetUserInput()
    {
        Console.Write("数字を入力してください");
        string input = Console.ReadLine();
        return int.Parse(input);
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);
        // return number;
    }

    public void ShowMessage(int number)
    {
        if(answer == number)
        {
            Console.WriteLine("おめでとう! 正解です");            
        }
        else if(answer > number)
        {
            Console.WriteLine("もっと大きい数字を入力してください。");
        }
        else
        {
            Console.WriteLine("もっと小さい数字を入力してください。");
        }
    }
    public int GetAnswer()
    {
        return answer;
    }

}