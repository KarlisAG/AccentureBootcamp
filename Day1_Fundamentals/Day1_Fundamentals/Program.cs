using System;
using System.Dynamic;
using System.Text;

namespace Day1_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //DegreesTask();   
            LoopTask();
        }

        public static void LoopTask()
        {
            Console.WriteLine("Enter the amount of lines you want in your triangle!");
            int lines = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= lines; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }

            string whiteSpace = "";
            for (int i = 0; i <= lines; i++)
            {
                for (int j = lines; j > i; j--)
                {
                    //string space = whiteSpace + " ";
                    //Console.Write(space); -- abi ir vienadi
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        public static void DegreesTask()
        {
            Console.WriteLine("Please enter degree amount!");
            if (Double.TryParse(Console.ReadLine(), out double degrees))
            {
                Console.WriteLine("Please enter degree unit!");
                string originalUnit = Console.ReadLine().ToLower();

                Console.WriteLine("To what degree unit you want to convert it to?");
                string convertUnit = Console.ReadLine().ToLower();

                double result;
                switch (originalUnit)
                {
                    case "c":
                        switch (convertUnit)
                        {
                            case "f":
                                result = degrees * 9 / 5 + 32;
                                PrintResult(result);
                                break;
                            case "k":
                                result = degrees + 273.15;
                                PrintResult(result);
                                break;
                            case "c":
                                PrintResult(degrees);//lai pie vienadiem abiem unitiem neatkartotot, var vnk if sakuma kur parbauda vai abi ir vienadi un ja ir tad vnk izdruka to rezultatau (ietaupa paris linijas)
                                break;
                            default:
                                WrongInput();
                                break;
                        }
                        break;
                    case "f":
                        switch (convertUnit)
                        {
                            case "c":
                                result = degrees - 32 * 5 / 9;
                                PrintResult(result);
                                break;
                            case "k":
                                result = (degrees + 459.67) * 5 / 9;
                                PrintResult(result);
                                break;
                            case "f":
                                PrintResult(degrees);
                                break;
                            default:
                                WrongInput();
                                break;
                        }
                        break;
                    case "k":
                        switch (convertUnit)
                        {
                            case "f":
                                result = degrees * 9 / 5 - 459.67;
                                PrintResult(result);
                                break;
                            case "c":
                                result = degrees - 273.15;
                                PrintResult(result);
                                break;
                            case "k":
                                PrintResult(degrees);
                                break;
                            default:
                                WrongInput();
                                break;
                        }
                        break;
                    default:
                        WrongInput();
                        break;
                        
                }
            }
            else
            {
                Console.WriteLine("You need to enter a number!");
                DegreesTask();
            }
            
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine($"After conversion: {result}");
        }

        private static void WrongInput()
        {
            Console.WriteLine("Wrong Input!");
        }



        private static void Notes()
        {
            int num = 45645;

            for (int i = 0; i < 5; i++)
            {
                num = num % 1000;
                Console.WriteLine(num);
            }

            StringBuilder sb = new StringBuilder();//ar so var savienot stringus, labaka ka str1+str2, jo tas var novest pie liela memory leak
            sb.Append("aa");
            sb.Append(" asd");
            Console.WriteLine(sb.ToString());//hz kpc vins toString izmantoja
            int age = 22;
            string formatedText = String.Format("I am {0} years old, my name is {2} {1}", age, "Kārlis", "papisines");
            Console.WriteLine(formatedText);
            //ar format var to store kada variable un tad izmnatot bet ar $ var tikai kad console writeline, jeb to nevar store un reuse


            string formatedText2 = $"I am {age} years old, my name is Kārlis papisines";
            Console.WriteLine(formatedText2);

            switch(age)
            {
                //var likt vairakus case un darit vienu darbibu ja tas ir kads no tiem
                case 10:
                case 15:
                case 2:
                    Console.WriteLine("Your'e under age!");
                    break;
                default:
                    break;
            }
            //loopos var but continue - lidzigi ka break, pec ta neko nelasa, vnk iet uz nakamo iteraciju
            //ja ir loop loopā, tad break apstadina tikai sev tuvako loop
        
        }
    }
}
