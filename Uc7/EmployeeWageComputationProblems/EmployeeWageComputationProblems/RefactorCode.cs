using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationProblems
{
    public class RefactorCode
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HOURS_IN_MONTH = 10;
        public  int computeEmpWage()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmployeeHour = 0;
            while (empHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmployeeHour += empHrs;
                Console.WriteLine("Day=" + totalWorkingDays + " Emplyee hours=" + empHrs);
            }
            int totalEmpWages = totalEmployeeHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("total employee wage is=" + totalEmpWages);
            return totalEmpWages;
        }
    }
}
