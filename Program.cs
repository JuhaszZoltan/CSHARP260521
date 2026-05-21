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

string newName = "Norbert";
Console.WriteLine(newName);
Console.WriteLine($"Hello {name}, my favofir veggie is {vegetables[Random.Shared.Next(vegetables.Length)]}");

