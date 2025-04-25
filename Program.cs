using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeAlgebraMetode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LoopWhileSmallerThan10(4);
            //LoopWhileBiggerThan0(7);
            //LoopingForeverWithOptionToStop(2);
            //InputGrades();
            //CountingCharactersInSentence("Hi, how are you??");

            //StringArrayToSentence(new string[] { "Good", "morning", "how", "are", "you" });
            //NumberOfCharArrayOccurencesInStringArray();
            //CheckCredentials();
            //FillAndPrintAttendanceList();
            // CalculateGradeAverage();

            //CompareAnimalArrays();
            //NumbersInPyramidPattern();
            //SortArrayAscending();
            //PrintOddNumbersInRange(56);
            //PrintNumbersFromInterval(2, 45);

        }

        // TURA #1


        // 1.Zadatak - Primjer konacne petlje koja ima uvjet ako je x manji od 10

        static void LoopWhileSmallerThan10(byte x = 1)
        {
            if (x < 10)
            {
                while (x < 10)
                {
                    x++;
                }
                Console.WriteLine($"Looping has finished, final value of x is: {x}");
            }
            else
            {
                Console.WriteLine("Number which have been passed into method is not smaller than 10");
            }   
        }
         
            
        // 2.Zadatak - Primjer konacne petlje koja ima uvjet ako je y veci od 0

        static void LoopWhileBiggerThan0(byte y = 20)
        {
            if (y > 0)
            {
                while (y > 0)
                {
                    y--;
                }
                Console.WriteLine($"Looping has finished, final value of y is: {y}");
            }
            else
            {
                Console.WriteLine("Number which have been passed into method is not bigger than 0");
            } 
        }
 

        // 3.Zadatak - Beskonacna petlja, ali uz pomoc naredbe break; je moguce izaci iz petlje

        static void LoopingForeverWithOptionToStop(byte z = 5)
        {
            if (z < 20)
            {
                while (z < 20)
                {
                    if (z == 19)
                    {
                        break;
                    }
                    z++;
                }
                Console.WriteLine("Loop has successfully ended");
            }
            else
            {
                Console.WriteLine("Number which have been passed into method is not smaller than 20");
            } 
        }
        

        // 4.Zadatak - Primjer while petlje za unos ocjena. Ocjene moraju biti brojevi izmedju 1 i 5

        static void InputGrades()
        {
            List<byte> grades = new List<byte>();

            while (grades.Count < 10)
            {
                Console.WriteLine("Type the grade (1 to 5):");
                string typedGrade = Console.ReadLine();
                bool marker = byte.TryParse(typedGrade, out byte result);

                if (marker && result > 0 && result < 6)
                {
                    grades.Add(result);
                }
                else
                {
                    Console.WriteLine("Your input is invalid.");
                }
            }

            foreach (byte grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
        

        // 5.Zadatak - Program za brojanje ukupnog broja slova, znamenki i posebnih znakova u nizu

        static void CountingCharactersInSentence(string sentence)
        {
            char[] characters = new char[sentence.Length];

            for (short x = 0; x < sentence.Length; x++)
            {
                characters[x] = sentence[x];
            }

            int numberOfCharacters = characters.Length;

            Console.WriteLine($"Number of characters in provided sentence is: {numberOfCharacters}");
        }


        // TURA #2


        // 1. Zadatak - Kopirajte jedan niz u drugi niz, uz unos pojedinih rijeci, sastavljanje recenice

        static void StringArrayToSentence(string[] arrayOfStrings)
        {
            string[] temporaryArray = new string[arrayOfStrings.Length];
            
            for (byte x = 0; x < arrayOfStrings.Length; x++)
            {
                temporaryArray[x] = arrayOfStrings[x];
            }

            string sentence = string.Join(" ", temporaryArray);

            Console.WriteLine(sentence);
        }


        // 2. Zadatak - Pronadjite broj pojavljivanja odredjenog niza u nizu rijeci

        static void NumberOfCharArrayOccurencesInStringArray()
        {
            string[] arrayOfStrings = { "wheel", "shifter", "roof", "transmission", "screw", "nut", "pump", "lights", "radio", "air-condition", "roll" };

            byte counter = 0;
            Console.WriteLine("Enter 2 characters array:");
            string input = Console.ReadLine();

            foreach (string word in arrayOfStrings)
            {
                if (word.Contains(input))
                {
                    counter++;
                }
            }

            Console.WriteLine($"Character array \"{input}\" have {counter} occurences in our array of strings.");
        }


        // 3. Zadatak - Provjerite korisnicko ime i lozinku, za unos imate 3 pokusaja

        static void CheckCredentials()
        {
            string[,] database = 
        {
            {"pero", "ante", "donald", "admin" },
            {"123456", "092343", "345278", "000000" }
        };

            string username = null;
            string password = null;

            for (int y = 3; y > 0; y--)
            {
                bool markerUser = true;

                while (markerUser)
                {
                    Console.WriteLine("Please enter you username:");
                    username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        continue;
                    }
                    else
                    {
                        markerUser = false;
                    }

                }

                bool markerPass = true;

                while (markerPass)
                {
                    Console.WriteLine("Please enter your password:");
                    password = Console.ReadLine();

                    if (string.IsNullOrEmpty(password))
                    {
                        continue;
                    }
                    else
                    {
                        markerPass = false;
                    }
                }

                bool login = false;

                for (int x = 0; x < (database.Length / 2); x++)
                {
                    if (database[0, x] == username && database[1, x] == password)
                    {
                        login = true;
                    }
                }

                if (login)
                {
                    Console.WriteLine("You have been logged in successfully!");
                    break;
                }
                else if (y == 1)
                {
                    Console.WriteLine("You have used all 3 login attempts without success.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect username or password, try again.\n{y - 1} attempts left.");
                }
            }
        }


        // 4. Zadatak - Ispisi polaznike seminara, od 1 do 17, evidencija polaznika po seminaru

        static void FillAndPrintAttendanceList()
        {
            string[] students = {"Agata Kordic", "Ana Markovic", "Denis Arambasic", "Dino Franceschi", "Fran Pepic", "Ivan Vidovic", "Ivica Jakelic",
            "Kristijan Pocta", "Nikola Dzida", "Vedran Horvat", "Fran Pepic", "Marko Vladova", "Kristina Somodi", "Jakov Bilac", "Vojislav Durackovic",
            "Kresimir Kovacevic", "Josip Bodruzic"};

            string[,] record = new string[students.Length, students.Length]; // 2D array which consist of students and attendance

            Console.WriteLine("Attendance record app.\nNames of students will be printed one by one. " +
                "If student is in attendance write \"y\", if not write \"n\".");
            Console.ReadKey();

            for (int x = 0; x < students.Length; x++)
            {
                record[0, x] = students[x];    // filling first dimension

                bool flag = true;

                while (flag)
                {
                    Console.WriteLine(record[0, x]);
                    string input = Console.ReadLine();

                    if (input != "y" && input != "n")
                    {
                        Console.WriteLine("Wrong input, please enter \"y\" ili \"n\"");
                    }
                    else if (input == "y")
                    {
                        record[1, x] = "PRESENT";
                        flag = false;
                    }
                    else if (input == "n")
                    {
                        record[1, x] = "NOT PRESENT";
                        flag = false;
                    }
                }
            }

            for (int x = 0; x < students.Length; x++)
            {
                Console.WriteLine($"Polaznik {record[0, x]} ---------- {record[1, x]}");  // Final printout
            }
        }


        // 5. Zadatak - Prosjek ocjena za uneseni broj predmeta

        static void CalculateGradeAverage()
        {
            Console.WriteLine("You need to input total of 5 grades per subject (range 1-5).\nPress ENTER to continue:");
            Console.ReadKey();

            int[] math = new int[5];
            int[] physics = new int[5];
            int[] chemistry = new int[5];

            for (int x = 0; x < 3; x++)
            {
                bool marker = true;
                Console.WriteLine("Select subject - math, physics or chemistry:");
                string subject = Console.ReadLine();

                while (marker)
                {
                    if (subject == "math" || subject == "chemistry" || subject == "physics")
                    {
                        marker = false;
                    }
                    else
                    {
                        Console.WriteLine("Select subject - math, physics or chemistry:");
                        subject = Console.ReadLine();
                    }
                }

                int[] temporary = new int[5];

                for (int y = 0; y < 5; y++)
                {
                    Console.WriteLine($"Grade no. {y + 1}:");
                    string input = Console.ReadLine();
                    temporary[y] = Int16.Parse(input);
                }

                switch (subject)
                {
                    case "math":
                        math = temporary;
                        break;
                    case "physics":
                        physics = temporary;
                        break;
                    default:
                        chemistry = temporary;
                        break;
                }
            }

            bool flag = true;

            while (flag)
            {
                double average;
                Console.WriteLine("For which subject you would like to see average:");
                string selectedSubject = Console.ReadLine();

                switch (selectedSubject)
                {
                    case "math":
                        average = math.Average();
                        break;
                    case "physics":
                        average = physics.Average();
                        break;
                    default:
                        average = chemistry.Average();
                        break;
                }

                Console.WriteLine($"Grades average for subject {selectedSubject} is {average}");
                Console.ReadKey();

                Console.WriteLine("Would you like to see grades average for other subjects? Input \"yes\" or \"no\"");
                string answer = Console.ReadLine();

                if (answer == "no")
                {
                    flag = false;
                }
                else if (answer == "yes")
                {
                    continue;
                }
            }
        }


        // TURA #3


        // 1. Zadatak - Petlja koja usporedjuje nizove zivotinja

        static void CompareAnimalArrays()
        {
            string[] birds = { "eagle", "falcon", "mackerel" };
            string[] cats = { "tiger", "lion", "jaguar" };
            string[] fishes = { "mackerel", "sardine", "cod" };


            foreach (string bird in birds)
            {
                if (fishes.Contains(bird) || cats.Contains(bird))
                {
                    Console.WriteLine($"There's an error in arrays, looks like {bird} ended up in wrong category.\nPlease check.");
                }
                else
                {
                    Console.WriteLine("All animals are listed in appropriate category.");
                }
            }
        }
        

        // 2. Zadatak (Fran Pepic) - Prikazite obrazac poput piramide s brojevima uvecanim za 1

        static void NumbersInPyramidPattern(byte first = 1, byte second = 5)
        {

            for (int x = 1; x <= second; x++)
            {

                for (int space = 0; space <= second - x; space++)
                {
                    Console.Write(" ");
                }


                for (int y = 1; y <= x; y++)
                {
                    Console.Write(first + " ");
                    first++;
                }

                Console.WriteLine();
            }
        }


        // 3. Zadatak - Poredaj uneseni niz u rastucem redoslijedu

        static void SortArrayAscending()
        {
            byte[] someArray = new byte[5];

            for (byte x = 0; x < someArray.Length; x++)
            {
                Console.WriteLine("Enter 2-digit number:");
                byte number = byte.Parse(Console.ReadLine());

                someArray[x] = number;
            }

            Array.Sort(someArray);
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();

            foreach (int num in someArray)
            {
                Console.WriteLine(num);
            }
        }


        // 4. Zadatak - Ispis neparnih brojeva koji su veci od 1, a manji od 20

        static void PrintOddNumbersInRange(int range = 20)
        {
            int[] numbers = new int[range];

            for (byte x = 1; x < range + 1; x++)
            {
                numbers[x - 1] = x;
            }

            foreach (int number in numbers)
            {
                if (number % 2 != 0 && number > 1 && number < range)
                {
                    Console.WriteLine($"Number {number} is odd number!");
                }

            }
        }


        // 5. Zadatak - Ispis brojeva iz intervala [1, 300] koji su djeljivi s 5

        static void PrintNumbersFromInterval(int first = 1, int second = 300)
        {
            int[] interval = { first, second };

            for (int x = interval[0]; x <= interval[1]; x++)
            {
                if (x % 5 == 0)
                {
                    Console.WriteLine($"Number {x} is divisible with number 5!");
                }
            }
        }

    }
}
