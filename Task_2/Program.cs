using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            #region Task_1 Bounes
            /*
            Console.WriteLine("Hello World!");
            */
            #endregion

            #region problem_1
            /*
            // store var x
            int x = 10;
            // store var y
            int y = 20;
            int sum = x + y;
            // print sum
            Console.WriteLine(sum);
            */
            #endregion

            #region Q_1
            // ctrl + K + C/U
            #endregion

            #region problem 2
            /*
            // Error diffrent datatype 
            // solution "Parse"
            int x = int.Parse("10");
            // must Impelement Y
            int y = 1;
            Console.WriteLine(x + y);
            */
            #endregion


            #region Q_2
            /*
             Runtime Error as divide by zero 
            10/0


            try to access index at array that size is small than it 
            int a[100]={0}
            a[100]


            Logical Error
            Logic flaw, but valid syntax and runtime
            a[5]={0}
            int sum = 0;
            for(int i = 0; i < 4 ; i++){
                sum+=a[i];
            }  i from 0 >> 3 skip a[4]

             */
            #endregion


            #region problem 3
            /*
            // my name
            string Name;

            // age
            Int16 age;
            // Sallary 
            long Sallary;

            // is student

            bool Is_Student;
            */




            #endregion


            #region Q_3

            //Makes Maintenance Easier
            //Aligns with .NET Standards
            #endregion


            #region problem 4
            /*
            Num num1 = new Num();
            num1.value = 1;

            Num num2 = num1;
            num2.value = 2;
            Console.WriteLine(num1.value);
            Console.WriteLine(num2.value);
            */
            #endregion


            #region Q_4
            // Value types are stored in the stack, and copying them creates a new independent copy
            //Reference types are stored in the heap, and copying them makes both variables point to the same object
            #endregion



            #region Problem_5
            /*
            int x = 15;
            int y = 4;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(y * x);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
            */
            #endregion


            #region Q5

            //Question: What will be the output of the following code? Explain why:
            //int a = 2, b = 7;
            //Console.WriteLine(a % b);
            // Output will be 0 a>b;
            #endregion


            #region problem_6
            /*
            int num=int.Parse(Console.ReadLine());
            if (num%2==0&& num >10)
            {
                Console.WriteLine("Yes");
            }
            */
            #endregion

            #region Q6
            /*
            & used at bit manipulation  if a= 3 and b = 5
            binary representation 0010 and 0101 so a&b = 0000 =0

            && used at condition
            */
            #endregion



            #region problem 7
            /*
            Console.Write("Enter a decimal number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            int myInt = (int)num1;
            int num2 = 10;
            double Doub = num2;
            Console.WriteLine(Doub);
            Console.WriteLine(num1);
            */
            #endregion



            #region Q7
            // C# forces you to cast manually to make sure you're aware that precision may be lost.
            #endregion


            #region PROBLEM 8
            /*
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            int age = int.Parse(ageInput);

            if (age > 0)
            {
                Console.WriteLine("Valid age entered: " + age);
            }
            else
            {
                Console.WriteLine("Age must be greater than 0.");
            }
            */
            #endregion


            #region Q8
            //using search
            /*
            if (int.TryParse(input, out int age))
            {
                Console.WriteLine("Valid input.");
            }
            else
            {
                Console.WriteLine("Invalid number format.");
            }
            */
            #endregion

            #region Problem 9
            /*
            int x = 5;
            int a = ++x;

            Console.WriteLine("Prefix:");
            Console.WriteLine("x = " + x);
            Console.WriteLine("a = " + a);

            x = 5;
            int b = x++;

            Console.WriteLine("Postfix:");
            Console.WriteLine("x = " + x);
            Console.WriteLine("b = " + b);
            */
            #endregion


            #region Q9
            //int x = 5;
            //int y = ++x + x++;
            // output >> 12
         

            #endregion


        }
    }
}
