﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Manager
    {
        List<Employee> employees = new List<Employee>();

        public Manager()
        {
            loadEmployeesListFromFile();

            Console.WriteLine("The average pay for all employees is: " + AveragePay());
            Console.WriteLine("The Wages employee with the highest pay is: " + HighestPayWagesEmployee());
            Console.WriteLine("The Salaried employee with the lowest pay is: " + LowestPaySalariedEmployee());
            Console.WriteLine("Percentage of Salaried employees is: " + PercentageOfSalaried() + "%");
            Console.WriteLine("Percentage of Wages employees is: " + PercentageOfWages() + "%");
            Console.WriteLine("Percentage of Part Time employees is: " + PercentageOfPartTime() + "%");
        }

        
        private void loadEmployeesListFromFile()
        {
            string[] lines = File.ReadAllLines("C://cprg211//InheritanceLab//res//Employees.txt");

            foreach (string line in lines)
            {
                string[] fields = line.Split(":");
                string s = fields[0];
                char firstChar = s[0];
                switch (firstChar)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                        employees.Add(new Salaried(fields[0], fields[1], fields[2], fields[3], long.Parse(fields[4]), fields[5],
                                                   fields[6], Double.Parse(fields[7])));
                        break;
                    case '5':
                    case '6':
                    case '7':
                        employees.Add(new Wages(fields[0], fields[1], fields[2], fields[3], long.Parse(fields[4]), fields[5],
                                   fields[6], Double.Parse(fields[7]), Double.Parse(fields[8])));
                        break;
                    case '8':
                    case '9':
                        employees.Add(new PartTime(fields[0], fields[1], fields[2], fields[3], long.Parse(fields[4]), fields[5],
                                   fields[6], Double.Parse(fields[7]), Double.Parse(fields[8])));
                        break;

                }
            }
        }


        private double AveragePay()
        {

            double totalPay = 0;
            foreach (Employee emp in employees)
            {
                if (emp is Salaried)
                {
                    totalPay += ((Salaried)emp).GetPay();
                }
                else if (emp is Wages)
                {
                    totalPay += ((Wages)emp).GetPay();
                }
                else if (emp is PartTime)
                {
                    totalPay += ((PartTime)emp).GetPay();
                }
            }
            return totalPay / employees.Count();
        }


        private Wages HighestPayWagesEmployee()
        {
            double highestPay = 0;
            Wages highestPayEmp = null;
            foreach (Employee emp in employees)
            {
                if (emp is Wages)
                {
                    Wages wageEmp = (Wages)emp;
                    if (wageEmp.GetPay() > highestPay)
                    {
                        highestPay = wageEmp.GetPay();
                        highestPayEmp = wageEmp;
                    }
                }
            }
            return highestPayEmp;
        }

        private Salaried LowestPaySalariedEmployee()
        {
            double lowestPay = 0;
            Salaried lowestPayEmp = null;
            bool found = false;
            for (int i = 0; !found && i < employees.Count(); i++)
            {
                Employee emp = employees[i];
                if (emp is Salaried)
                {
                    lowestPay = ((Salaried)emp).GetPay();
                    lowestPayEmp = (Salaried)emp;
                    found = true;
                }
            }
            for (int i = 0; i < employees.Count(); i++)
            {
                Employee emp = employees[i];
                if (emp is Salaried)
                {
                    Salaried salariedEmp = (Salaried)emp;
                    if (salariedEmp.GetPay() < lowestPay)
                    {
                        lowestPay = salariedEmp.GetPay();
                        lowestPayEmp = salariedEmp;
                    }
                }
            }
            return lowestPayEmp;
        }

        
        private double PercentageOfSalaried()
        {
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp is Salaried)
                {
                    count++;
                }
            }
            return (double)count / employees.Count() * 100;
        }

        
        private double PercentageOfWages()
        {
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp is Wages)
                {
                    count++;
                }
            }
            return (double)count / employees.Count() * 100;
        }

        private double PercentageOfPartTime()
        {
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp is PartTime)
                {
                    count++;
                }
            }
            return (double)count / employees.Count() * 100;
        }
    }

}

