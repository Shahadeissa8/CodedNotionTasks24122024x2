using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedNotionTasks22122024x2.models
{
    internal class Class1
    {
        public int Num1;
        public int Num2;
        public int Num3;
        public int Add(int numb1, int numb2)
        {
            int sum = numb1 + numb2;
            return sum;
        }
        public int Add(int numb1, int numb2, int numb3)
        {
            int sum = numb1 + numb2 + numb3;
            return sum;
        }
        public double Add(int numb1, int numb2, double numb3)
        {
            double sum = numb1 + numb2 + numb3;
            return sum;
        }
        public double salary(double Salary, int workHours)
        {
            int hourRate = 10;
            double thisSalary = Salary + (workHours * hourRate);
            return thisSalary;
        }
        /* //doing this just in case it is required as the question is confusing "(Salary+( Work hour * hour rate)=10 KD)"
        public double sal(double Sal, int workHrs, double hrRate)
        {
            double salary2 = Sal+ (workHrs*hrRate); //doing this just in case it is required as the question is confusing "(Salary+( Work hour * hour rate)=10 KD)"
            return salary2;
        }
        */
    }


}
