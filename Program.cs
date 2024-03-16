using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Reflection.Metadata;

namespace firstassig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<<<< Assignment C#1 >>>>>>>>>>>>");
            Console.WriteLine("1- Write a C# Sharp program to swap two numbers");
            int NumberOne;
            int NumberTwo;
            int swapValue;

            Console.WriteLine("Enter The First Number .....");
            NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number .....");

            NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Expected Result After Swapping >>>>>");
            swapValue = NumberOne;
            NumberOne = NumberTwo;
            NumberTwo = swapValue;
            Console.WriteLine($"The First Number {NumberOne}");
            Console.WriteLine($"The Second Number {NumberTwo}");



            Console.WriteLine("2- Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor");

            Console.WriteLine("Enter The First Number .......");
            int No1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Number .......");
            int No2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Third Number .......");
            int No3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The fourth Number .......");
            int No4 = Convert.ToInt32(Console.ReadLine());
            int Sum = (No1 + No2 + No3 + No4);
            int Avg = Sum / 4;
            Console.WriteLine("The Average of {0}", Avg);
              Console.WriteLine("#########################################");

               Console.WriteLine("3.  A C# program to find the longest word in a string.  ");
               String Sentence=Console.ReadLine();
               String[] SplitSentence = Sentence.Split(new[]{ " " }, StringSplitOptions.None);
               string LongestWord = " ";
               int word_length = 0;

               foreach (String s in SplitSentence)
               {
                   if (s.Length > word_length)
                   {
                       word_length = s.Length;
                       LongestWord=s;
                   }
               }
               Console.WriteLine(LongestWord);
               Console.WriteLine(word_length);
               Console.WriteLine("#########################################");

               Console.WriteLine("4- A C# program to check if an array contains an odd number");
               bool isodd = false;
               int[] array = new int[5] ;
            for(int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
               foreach (var item in array)
               {
                   if (item % 2 != 0)
                   {
                       isodd = true;
                   }


               }

               Console.WriteLine(isodd);
               Console.WriteLine("#########################################");

               Console.WriteLine("5- a C# Sharp program to calculate the factorial of a given number");
               int X =Convert.ToInt32( Console.ReadLine());
               int factorial=1 ;
               for (int i = 1; i <= X; i++)
               {
                   factorial = factorial * i;
               }
            Console.WriteLine(factorial);

            Console.WriteLine("#########################################");

            Console.WriteLine("6- a program in C# Sharp to display the pattern like right angle triangle using an asterisk");
            int No_Raw = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= No_Raw; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("#########################################");

            Console.WriteLine("7- a program in C# Sharp to make such a pattern like a pyramid with an asterisk. ");
            int Nraw=Convert.ToInt32(Console.ReadLine());
            int space = Nraw -1;
            for (int i = 1;i< Nraw; i++)
            {
                for (int j = space; j >= 1; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                space--;
            }

           /* Console.WriteLine("#########################################");

            Console.WriteLine("8- A C# Sharp program to display alphabet pattern like B with an asterisk. ");
            for(int row = 0;row<=6;row++) { 
            for(int column=0;column<=6;column++) {
                if()
                }

            }*/
            Console.WriteLine("#########################################");

            Console.WriteLine("9- A C# Sharp program to find the minimum value from two given two numbers, represented as string. ");
            string str1=Console.ReadLine();
            string str2=Console.ReadLine();
            if(Int32.Parse(str1) > Int32.Parse(str2))
            {
                Console.WriteLine(str2);
            }
            Console.WriteLine(str1);
            Console.WriteLine("#########################################");

            Console.WriteLine("10- A program in C# Sharp to read any day number in integer and display day name in the word.  ");
            Console.WriteLine("Please Enter the value Between 1-7 .......");
            int numberOFday=Convert.ToInt32(Console.ReadLine());
            if(numberOFday==1)
            {
                Console.WriteLine("Saturday");
            }if(numberOFday==2)
            {
                Console.WriteLine("Sunday");
            }if(numberOFday==3)
            {
                Console.WriteLine("Monday");
            }if( numberOFday==4)
            {
                Console.WriteLine("Tuesday");
            }
            if (numberOFday == 5)
            {
                Console.WriteLine("Wednesday");
            }if(numberOFday == 6)
            {
                Console.WriteLine("thursday");
            }
            if (numberOFday == 7)
            {
                Console.WriteLine("Friday");
            }

            Console.WriteLine("#########################################");

            Console.WriteLine("11- a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle  ");
            const float pi = 3.14F;
            double perimeter;
            double area;
            double radius=0;
            Console.WriteLine("Enter the radius........");
            radius =Convert.ToDouble (Console.ReadLine());
            perimeter = 2 * pi * radius;
            area = pi * radius*radius;
            Console.WriteLine("The perimeter is   {0}  \nand the area is   {1}",perimeter,area);
            
            Console.WriteLine("#########################################");

            Console.WriteLine("12- A C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd ");
            int input1;
            int input2;
           bool  isEven = false;
            Console.WriteLine("Enter input one ........");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input two ........");
            input2 = Convert.ToInt32(Console.ReadLine());
            if((input1 % 2 == 0&& input2 % 2 == 0 )||( input1 % 2 != 0 && input2 % 2 != 0)) {
                isEven = true;
                Console.WriteLine( isEven);

            }
            else
            {
                isEven = false;
                Console.WriteLine(isEven);
            }
            Console.WriteLine("#########################################");

            Console.WriteLine("13- A program in C# Sharp to create a function to input a string and count number of spaces are in the string. ");
            string stringInput;
            string stringInput1;
            String spacer = " ";
            int count = 0;
            Console.WriteLine("Enter the sentance .......... ");
            stringInput = Console.ReadLine();
             for(int i = 0;i< stringInput.Length; i++)
            {
                stringInput1=stringInput.Substring(i,1);
                if(stringInput1==" ")
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
            Console.WriteLine("#########################################");

            Console.WriteLine("14- A program in C# Sharp to find the length of a string without using library function ");
            string SStr;
            int Counter = 0;
            Console.WriteLine("Enter the sentance .......... ");
            SStr=Console.ReadLine();
            foreach (var item in SStr)
            {
                Counter++;
            }
            Console.WriteLine(Counter);


            Console.WriteLine("#########################################");

            Console.WriteLine("14- A c# Sharp program to remove duplicate characters from a given string");
        }

    }
    }
