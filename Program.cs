using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( " welcome to c#");
            // Console.ReadKey();
            //Datatype variablename
            //string firstName;
            //string lastName;
            //Console.WriteLine(  "enter firstname");
            //firstName = Console.ReadLine();
            //Console.WriteLine(  "enter lastname");
            //lastName = Console.ReadLine();
            //Console.WriteLine(  " welcome mr.\\ms." +firstName+" "+lastName);
            //Console.ReadKey();
            //example 3
            //DataType.Parse();
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter grade");
            grade= char.Parse(Console.ReadLine());
            Console.WriteLine("enter doj");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("name: \t" +name + "\n age: "+age +"\n Grade: \t" 
                +grade + "\n Salary: \t" +salary
                +"\n data of joining: \t " + doj);
            Console.ReadKey();


        }
    }
}
