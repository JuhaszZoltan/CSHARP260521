string[] vegetables = [
    "potato",
    "paprika",
    "carrot",
    "tomato",
    "conflict?",
    ];

string name = "Zoltan";

Console.WriteLine($"Hello {name}, my favofir veggie is {vegetables[Random.Shared.Next(vegetables.Length)]}");