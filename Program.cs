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


//> BitMiller:
for (int i = 0; i < vegetables.Count(); i++)
{
    Console.WriteLine($"Vedzsi {Math.Floor(Convert.ToDouble(i/10))}{i%10}.: {vegetables[i]}");
}

string newName = "Norbert";
Console.WriteLine(newName);
Console.WriteLine($"Hello {name}, my favofir veggie is {vegetables[Random.Shared.Next(vegetables.Length)]}");

