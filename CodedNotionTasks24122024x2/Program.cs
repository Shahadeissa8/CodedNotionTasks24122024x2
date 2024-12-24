using CodedNotionTasks22122024x2.models;

Class1 thisIsAClass = new Class1();

Console.WriteLine("enter number 1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number 2: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sum 1 is: " + thisIsAClass.Add(numb1, numb2));

Console.WriteLine("enter number 3: ");
int numb3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sum 2 is: " + thisIsAClass.Add(numb1, numb2, numb3));

Console.WriteLine("enter number 3 as a double: ");
double numb4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("sum 3 is: " + thisIsAClass.Add(numb1, numb2, numb4));

Console.WriteLine("enter your salary: ");
double Salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter your work hours: ");
int workHours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(thisIsAClass.salary(Salary, workHours));
/* //doing this just in case it is required as the question is confusing "(Salary+( Work hour * hour rate)=10 KD)"
Console.WriteLine("enter your salary: ");
double Sal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter your work hours: ");
int workHrs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your hour rate: ");
double hrRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(thisIsAClass.sal(Sal,workHrs,hrRate));
*/