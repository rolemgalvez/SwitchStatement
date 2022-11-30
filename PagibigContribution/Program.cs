//Welcome message
Console.WriteLine("Pag-IBIG Contribution");
Console.WriteLine("---------------------");
Console.WriteLine();

//Get user input
Console.Write("Enter your Basic Monthly Salary: ");
double.TryParse(Console.ReadLine(), out double basicMonthlySalary);
double employeeShare = double.NaN;
double companyShare = basicMonthlySalary * 0.02;

//Show results
Console.WriteLine();
switch (basicMonthlySalary)
{
	case > 0 and <= 1500:
		employeeShare = basicMonthlySalary * 0.01;
		break;
	case > 1500 and < 5000:
		employeeShare = basicMonthlySalary * 0.02;
		break;
	case >= 5000:
		employeeShare = 5000 * 0.02;
		companyShare = 5000 * 0.02;
		break;
	default:
		Console.WriteLine("You're not qualified to have a Pag-IBIG Contibution.");
		break;
}

if (double.IsNaN(employeeShare) == false)
{
	Console.WriteLine("Your Pag-IBIG Contribution is as follows:");
	Console.WriteLine($"EE (Employee Share): {employeeShare}");
	Console.WriteLine($"ER (Employer Share): {companyShare}");
	Console.WriteLine($"Total Share        : {employeeShare + companyShare}"); 
}
Console.ReadLine();