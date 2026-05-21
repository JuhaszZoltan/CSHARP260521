string[] vegetables = [
    "potato",
    "paprika",
    "carrot",
    "tomato",
    "conflict?",
    "salad",
    "eggplant",
    ];

string name = "Norbi";

Console.WriteLine($"Hello {name}, my favofir veggie is {vegetables[Random.Shared.Next(vegetables.Length)]}");

string newName = "Norbert";
Console.WriteLine(newName);