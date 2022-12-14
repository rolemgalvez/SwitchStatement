//Welcome message
Console.WriteLine("Are You Late");
Console.WriteLine("------------");
Console.WriteLine();

//Get user input
Console.WriteLine("Your work schedule is 8:00 AM to 5:00 PM");
Console.WriteLine();

Console.Write("Now, enter your Time In: ");
bool isTimeIn = TimeOnly.TryParse(Console.ReadLine(), out TimeOnly timeIn);

//Set values
TimeOnly startTime = new TimeOnly(8, 0);
TimeSpan lateCount = timeIn - startTime;
double minuteLate = double.NaN;
double dayInMinutes = 1440;
const double fourHours = 240;
const double sevenHours = 420;
const double nineHours = 540;

if (lateCount.TotalMinutes <= nineHours)
{
    minuteLate = lateCount.TotalMinutes;
}
else if (lateCount.TotalMinutes > nineHours && isTimeIn)
{
    minuteLate = lateCount.TotalMinutes - dayInMinutes;
}

//Process input
switch (minuteLate)
{
    case < 0:
        Console.WriteLine("Your earlier today!");
        break;
    case 0:
        Console.WriteLine("On time it is!");
        break;
    case > 0 and <= 15:
        Console.WriteLine("Within the 15 minute grace period, save by the bell!");
        break;
    case > 15 and < fourHours:
        Console.WriteLine("Snap! You are late my friend.");
        break;
    case >= fourHours and <= sevenHours:
        Console.WriteLine("Your work now is considered half day.");
        break;
    case > sevenHours and < nineHours:
        Console.WriteLine("Why you still go to work at this time?");
        break;
    case 540:
        Console.WriteLine("You are not late for tomorrow!");
        break;
    default:
        Console.WriteLine("Your given Time In value is out of this world!");
        break;
}

Console.ReadLine();