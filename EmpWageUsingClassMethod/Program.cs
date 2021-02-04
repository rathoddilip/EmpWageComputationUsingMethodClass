using System;

namespace EmpWageUsingClassMethod
{
	class Program
	{
		const int isFullTime = 1;
		const int isPartTime = 2;

		public static void EmpWageCompute(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
		{


			int totalWorkingHrs = 0;
			int workingDays = 0;
			int empDailyHr = 0;
			int totalEmpWage = 0;
			Random randomNumber = new Random();
			while (workingDays < numOfWorkingDays || totalWorkingHrs < maxHoursPerMonth)
			{


				int empCheck = randomNumber.Next(0, 3);
				switch (empCheck)
				{
					case isPartTime:
						empDailyHr = 4;
						workingDays += 1;
						break;

					case isFullTime:
						empDailyHr = 8;
						workingDays += 1;
						break;

					default:
						empDailyHr = 0;
						break;

				}//switch
				totalWorkingHrs += empDailyHr;
				Console.WriteLine("days: " + workingDays + "  " + "Emp Hrs : " + totalWorkingHrs);
				totalEmpWage += empRatePerHour * totalWorkingHrs;
			}//while
			Console.WriteLine("Total Emp Wage for company " + company +" "+ "is :" + totalEmpWage);

		}//method

		public static void Main(String[] args)
		{
			Console.WriteLine("Welcome to employee wage computation");
			EmpWageCompute("Persistent", 100, 20, 80);
			EmpWageCompute("Infosys", 150, 15, 60);
		}
	}
}
