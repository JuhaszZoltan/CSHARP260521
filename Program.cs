string[] vegetables = [
    "potato",
    "paprika",
    "carrot",
    "tomato",
    "conflict?",
    "kukacos töpörtyű",
    "salad",
    "eggplant"
    ];

string name = "Peter";

Console.WriteLine($"Hello {name}, my favofir veggie is {vegetables[Random.Shared.Next(vegetables.Length)]}");

for (int i = 0; i < 100; i++)
{
    Console.SetCursorPosition(
        Random.Shared.Next(Console.WindowWidth - 6),
        Random.Shared.Next(Console.WindowHeight - 1));
    Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
    Console.WriteLine("._@/\"");
}

while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;