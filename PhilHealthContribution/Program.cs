//Welcome message
Console.WriteLine("PhilHealth Contribution 2022");
Console.WriteLine("-----------------------");
Console.WriteLine();

//Get user input
Console.Write("Enter your Monthly Basic Salary: ");
double.TryParse(Console.ReadLine(), out double monthlyBasicSalary);
double philHealthContribution = double.NaN;

//Show result
Console.WriteLine();
switch (monthlyBasicSalary)
{
	case 10000:
		philHealthContribution = 400;
        break;
	case >= 10000.01 and <= 79999.99:
        philHealthContribution = monthlyBasicSalary * 0.04;
		break;
	case >= 80000:
		philHealthContribution = 3200;
        break;
	default:
		Console.WriteLine("You are not qualified to have PhilHealth Contribution");
		break;
}

if (double.IsNaN(philHealthContribution) == false)
{
	Console.WriteLine("Your Monthly PhilHealth Contribution is as follows:");
	Console.WriteLine($"Employer Share     : {philHealthContribution / 2}");
	Console.WriteLine($"Employee Share     : {philHealthContribution / 2}");
	Console.WriteLine($"Total Contribution : {philHealthContribution}");
}

Console.ReadLine();