//Welcome message
Console.WriteLine("Is It Undertime");
Console.WriteLine("---------------");
Console.WriteLine();

//Get user input
Console.WriteLine("Your work schedule is 8:00 AM to 5:00 PM");
Console.WriteLine();
Console.Write("Considering your Time In is 8:00 AM, enter your Time Out: ");
TimeOnly.TryParse(Console.ReadLine(), out TimeOnly timeOut);

//Set values
const double acceptableOvertime = 30;
TimeOnly endTime = new TimeOnly(17, 0);
TimeSpan undertimeCount = endTime - timeOut;
double dayInMinutes = 1440;
const double nineHours = 540;
double undertimeMinute = double.NaN;

if (undertimeCount.TotalMinutes <= nineHours)
{
	undertimeMinute = undertimeCount.TotalMinutes;
}
else
{
	undertimeMinute = undertimeCount.TotalMinutes - dayInMinutes;
}

//Show results
switch (undertimeMinute)
{
	case <= -acceptableOvertime:
		Console.WriteLine($"Hmm, you're working overtime for {-undertimeMinute} minute(s).");
		break;
	case <= 0 and > -acceptableOvertime:
		Console.WriteLine("Nice, Until next working day!");
		break;
	case > 0:
		Console.WriteLine($"You're {undertimeMinute} minute(s) undertime.");
		break;
	default:
		Console.WriteLine("Your given Time Out seems unacceptable.");
		break;
}