using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp2
{
    class Worker
    {


        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double SalaryDay { get; set; }
        public bool Officially { get; set; }

      
        public double official
        {
            get
            {
                if (Officially = true)
                {
                   return SalaryDay = SalaryDay - (19.5 * 100);
                }
                else
                {
                    return SalaryDay;
                }
            }

        }

        public bool pension
        {
            get
            {
                if (Age >= 80)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return $" {Name} { Surname}  for age { Age}  SalaryDay: { SalaryDay}  Officially: { Officially}";
        }



        public Worker(string name, string surname, int age, double salaryDay, bool officially)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SalaryDay = salaryDay;
            Officially = officially;
        }



    }

    
}
