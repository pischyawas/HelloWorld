using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = new string[3];
            string[] lastname = new string[3];
            double[] salary = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("          No. "+(i + 1)+"                |");
                Console.WriteLine("_______________________________|");
                Console.WriteLine("Please filter the name.        |");
                name[i] = Console.ReadLine();
         
                Console.WriteLine("Please filter the lastname.    |");
                lastname[i] = Console.ReadLine();
            
                Console.WriteLine("Please filter the Salary.      |");
                salary[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("_______________________________|");
                Console.WriteLine(" ");




            }

            Console.WriteLine("     *** Data Process ***      |");
            Console.WriteLine("_______________________________|");
            Console.WriteLine("No." + "| Name " +" "+  "| LastName"+" "+ "| Salary |");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" "+(i + 1)+"." + "   "+ name[i]+"      "+lastname[i]+"       "+salary[i]+"    ");
                


            }
            Console.WriteLine("_______________________________|");
            Console.WriteLine("END.");



            Console.ReadLine();

        }
    }
}
