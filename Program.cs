string[] vegetables = [
    "potato",
    "paprika",
    "carrot",
    "tomato",
    "conflict?",
    "kukacos töpörtyű"
    ];

string name = "Zoltan";

Console.WriteLine($"Hello {name}, my favofir veggie is {vegetables[Random.Shared.Next(vegetables.Length)]}");