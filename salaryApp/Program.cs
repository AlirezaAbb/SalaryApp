using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Threading.Tasks.Dataflow;

namespace SalaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /**
             * Create a salary App
             * Take a gross salary from the user
             * Also take EI, CPP and Income Tax from the user .
             * Also Receive Bonus and Allowances received as dollar.
             * If gender is female than please deduct the salary as 1% from the income tax.
             * Apply condition on dependent for deudction
             * 1. If 2 dependent then there is no changes in dedeuction.
             * 2. If dependent are 3 then please deduct 2% from the gross salary.
             * 3. If dependent are 4 then please deduct 3% from the gross salary.
             * then display the final salary after adding bonus and allowances.
             * */

            Console.WriteLine("");
            Console.WriteLine("Please enter Gross Salary::");
            double grossSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Employement Insurance:");
            double ei = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Cpp:");
            double cpp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter bonus");
            double bonus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter income tax:");
            double incomeTax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter allowances:");
            double allowances = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Please enter dependents:");
            int dependent = Convert.ToInt32(Console.ReadLine());
            double baseSalary = grossSalary + bonus + allowances;
            ei = (ei / 100) * grossSalary;
            cpp = (cpp / 100) * grossSalary;
            incomeTax = (incomeTax / 100) * grossSalary;

            if (isFemale(gender))

                switch (dependent)
                {

                    case 2:
                        incomeTax = incomeTax + ((1 / 100) * grossSalary);
                        break;
                    case 3:
                        incomeTax = incomeTax + ((2 / 100) * grossSalary);
                        break;
                    case 4:
                        incomeTax = incomeTax + ((3 / 100) * grossSalary);
                        break;
                    default:
                        Console.WriteLine("Please enter a different option for dependent::");
                        break;

                }
            else
                switch (dependent)
                {

                    case 2:
                        Console.WriteLine("There is no deduction in income tax ::");
                        break;
                    case 3:
                        incomeTax = incomeTax + ((2 / 100) * grossSalary);
                        break;
                    case 4:
                        incomeTax = incomeTax + ((3 / 100) * grossSalary);
                        break;
                    default:
                        Console.WriteLine("Please enter a different option for dependent::");
                        break;

                }

            double netSalary = baseSalary - (ei + incomeTax + cpp);
            Console.WriteLine("Net salary is::" + netSalary);
            Console.WriteLine("");

        }

        /**
         * check condition whether gender is female or not.
         **/
        static Boolean isFemale(string gender)
        {
            return (gender == "female");
        }

    }
}