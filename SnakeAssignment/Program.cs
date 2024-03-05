// See https://aka.ms/new-console-template for more information
using SnakeAssignment;
using System.Runtime;

Console.WriteLine("Hello, World!");


SnakeStateMachine snake = new SnakeStateMachine();

while (true)
{


    string snakeMap = "";

    for (int i = 0; i < 20; i++)
    {
        Console.WriteLine("\n");
        for (int j = 0; j < 20; j++)
        {
            if(snake.Move.X == j && snake.Move.Y == i)
            {
                snakeMap += "S";
            }
            else
            {
                snakeMap += "/";
            }
            
        }
        snakeMap += "\n";
    }
    Console.WriteLine(snakeMap);

    Console.WriteLine($"X: {snake.Move.X}.. " + $"Y: { snake.Move.Y}");
    char input = Console.ReadKey().KeyChar;
    snake.Update(input);
}


