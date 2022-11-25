//Welcome message
Console.WriteLine("Year Level");
Console.WriteLine("----------");
Console.WriteLine();

//Get user input
Console.Write("Hi! What is your name? ");
string? name = Console.ReadLine();

Console.Write("What year level are your currently in at your school? ");
string? yearLevel = Console.ReadLine();

//Show results
switch (yearLevel?.ToLower())
{
    case "first" or "1st":
        Console.WriteLine($"Hi Freshman {name}! Wishing you good luck.");
        break;
    case "second" or "2nd":
        Console.WriteLine($"Hope you are doing well Sophomore {name}!");
        break;
    case "third" or "3rd":
        Console.WriteLine($"Okay Junior {name}, so far so good!");
        break;
    case "fourth" or "4th":
        Console.WriteLine($"What a journey Senior {name}! The stage is coming soon.");
        break;
    default:
        Console.WriteLine($"Hold on there {name}, you will make it!");
        break;
}