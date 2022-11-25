//Welcome message
Console.WriteLine("Are You Late");
Console.WriteLine("------------");
Console.WriteLine();

//Get user input
Console.Write("Enter work start time: ");
bool isWorkStart = TimeOnly.TryParse(Console.ReadLine(), out TimeOnly workStart);