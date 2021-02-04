using System;

namespace EmpWageUsingClassMethod
{
	class Program
	{
		const int isFullTime = 1;
		const int isPartTime = 2;
		static void ComputeWage()
		{

			int empRatePerHr = 20;
			int empDailyHr = 0;
			int perDaySalary = 0;
			int mothWorkingDay = 20;
			int monthlySalary = 0;
			int monthlyHrs = 0;
			for (int i = 1; i <= mothWorkingDay; i++)
			{
				Random randomNumber = new Random();
				int empCheck = randomNumber.Next(0, 3);
				//Console.WriteLine(empCheck);
				switch ((int)empCheck)
				{
					case isFullTime:
						empDailyHr = 8;
						break;

					case isPartTime:
						empDailyHr = 4;
						break;

					default:
						empDailyHr = 0;
						break;

				}//switch

				monthlyHrs = monthlyHrs + empDailyHr;
				Console.WriteLine("Working days : " + i);
				Console.WriteLine("MonthlyHrsWise : " + monthlyHrs);
				perDaySalary = empRatePerHr * empDailyHr;
				Console.WriteLine(perDaySalary);
				monthlySalary = perDaySalary + monthlySalary;

			}
			Console.WriteLine("Monthly salary: " + monthlySalary);


		}
		public static void Main(String[] args)
		{
			Console.WriteLine("Welcome to Employee wage computation: ");
			ComputeWage();
		}
	}
}
