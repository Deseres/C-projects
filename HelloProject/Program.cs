using HelloLibrary;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

HelloClass hello = new HelloClass();

LordOfTheRing bilbo = new LordOfTheRing();
bilbo.ShowYourself();

//Console.WriteLine("Hello");
//string name = "Vlad";
//Console.WriteLine(name);
//Console.WriteLine($"Hello, {name}!");

//string name2 = Console.ReadLine(); 
//Console.WriteLine($"Hello, {name2}!");  

//double radius = double.Parse(Console.ReadLine());
//double area = Math.PI * Math.Pow(radius, 2);
//double circymference = 2 * Math.PI * radius;
//Console.WriteLine(area);
//Console.WriteLine(circymference);


//double height = double.Parse(Console.ReadLine());
//double baseLength = double.Parse(Console.ReadLine());
//double areaTriangle = (baseLength * height) / 2;
//Console.WriteLine(areaTriangle);


//double sideA = double.Parse(Console.ReadLine());
//double sideB = double.Parse(Console.ReadLine());
//double sideC = double.Parse(Console.ReadLine());

//double perimeter = sideA + sideB + sideC;
//double halfPerimeter = perimeter / 2;
//double areaTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
//Console.WriteLine(areaTriangle);
//Console.WriteLine(perimeter);


//double Celsius = double.Parse(Console.ReadLine());
//double Fahrenheit = (Celsius * 9 / 5) + 32;
//double Kelvin = Celsius + 273.15;
//Console.WriteLine(Fahrenheit);
//Console.WriteLine(Kelvin);

//10 a
//double number1 = double.Parse(Console.ReadLine());
//double number2 = double.Parse(Console.ReadLine());
//double number3 = double.Parse(Console.ReadLine());
//double average = (number1 + number2 + number3) / 3;
//double sum = number1 + number2 + number3;
//Console.WriteLine(average);
//Console.WriteLine(sum);
// 10 b
//double[] numbers = { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };
//double average = numbers.Average();
//double sum = numbers.Sum();
//Console.WriteLine(average);
//Console.WriteLine(sum);
// 10 c
//List<double> numbers = new List<double>();
//numbers.Add(double.Parse(Console.ReadLine()));
//numbers.Add(double.Parse(Console.ReadLine()));
//numbers.Add(double.Parse(Console.ReadLine()));
//double average = numbers.Average();
//double sum = numbers.Sum();
//Console.WriteLine(average);
//Console.WriteLine(sum);


//11 a
//int numberOfNumbers = int.Parse(Console.ReadLine());

//int[] numbers = new int[numberOfNumbers];

//for (int i = 0; i < numberOfNumbers; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//double average = numbers.Average();
//double sum = numbers.Sum();
//Console.WriteLine(average);
//Console.WriteLine(sum);

// 11 b
//int numberOfNumbers = int.Parse(Console.ReadLine());
//List<int> numbers = new List<int>();
//for (int i = 0; i < numberOfNumbers; i++)
//{
//    numbers.Add(int.Parse(Console.ReadLine()));
//}

//double average = numbers.Average();
//double sum = numbers.Sum();
//Console.WriteLine(average);
//Console.WriteLine(sum);

//12 b
//List<int> numbers = new List<int>();

//while (true)
//{
//    string input = Console.ReadLine();
//    if (string.IsNullOrEmpty(input))
//    {
//        break;
//    }
//    numbers.Add(int.Parse(input));
//}

//double min = numbers.Min();
//double max = numbers.Max();
//double count = numbers.Count();
//double average = numbers.Average();
//double sum = numbers.Sum();
//Console.WriteLine(min);
//Console.WriteLine(max);
//Console.WriteLine(count);
//Console.WriteLine(average);
//Console.WriteLine(sum);

//12 a
//double sum = 0;
//double count = 0;
//double minimum = 0;
//double maximum = 0;
//bool firstInput = true;

//while (true)
//{
//    string input = Console.ReadLine();
//    if (string.IsNullOrEmpty(input))
//    {
//        break;
//    }
//    double number = double.Parse(input);

//    if (number < minimum)
//    {         
//        minimum = number;
//    }

//    if (number > maximum)
//    {
//        maximum = number;
//    }

//    if (firstInput)
//    {
//        minimum = number;
//        maximum = number;
//        firstInput = false;
//    }

//    sum += number;
//    count++;

//}

//double average = sum / count;
//Console.WriteLine(sum);
//Console.WriteLine(count);
//Console.WriteLine(average);
//Console.WriteLine(minimum);
//Console.WriteLine(maximum);



//13, 14, 15 

//int numberOfPlayers = int.Parse(Console.ReadLine());
//int[] score = new int[numberOfPlayers];
//int attempts = 0;
//int gameNumber = 0;

//for (int i = 0; i < numberOfPlayers; i++)
//{
//    Random rnd = new Random();
//    int randomNumber = rnd.Next(1, 11);
//    attempts = 0;
//    while (true)
//    {
//        attempts++;
//        Console.WriteLine("Guess a number between 1 and 10:");
//        int userGuess = int.Parse(Console.ReadLine());
//        if (userGuess < randomNumber)
//        {
//            Console.WriteLine("Too low!");
//        }
//        else if (userGuess > randomNumber)
//        {
//            Console.WriteLine("Too high!");
//        }
//        else if (userGuess == randomNumber)
//        {
//            Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} in {attempts} attempts.");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
//        }
//    }
//    score[gameNumber] = attempts;
//    attempts++;
//    gameNumber++;
//}

//for (int i = 0; i < score.Length; i++)
//{
//    Console.WriteLine($"Player {i + 1} guessed the number in {score[i]} attempts.");
//    int winnerIndex = Array.IndexOf(score, score.Min());
//    Console.WriteLine($"The winer is player number:{winnerIndex+1}");
//}

//StringMethods
//string input = Console.ReadLine();
//string input2 = Console.ReadLine();
//int vowelCount = StringUtils.CountVowels(input);
//int letterCount = StringUtils.CountLatters(input);
//int uniqueLetterCount = StringUtils.UniqueLetters(input);
//string correctedCase = StringUtils.CorrectCase(input);
//string longestWord = StringUtils.LongestWord(input);
//string cleanedCopy = StringUtils.CleanedCopy(input2);

//int[] Array = new int[] { 1, 3, 3 };
//ArrayUtils.Reverse1(Array);
//int[] Array2 = new int[] { 4, 5, 5 };
//int treshold = 5;
//int[] reversedArray = ArrayUtils.Reverse2(Array2);
//Console.WriteLine(string.Join(",", Array));
//Console.WriteLine(string.Join(",", reversedArray));
//int[] Array3 = new int[] { 1, 8, 14 };
//int[] positiveArray = ArrayUtils.PickPositive(Array3);
//Console.WriteLine(string.Join(",", positiveArray));
//double[] Array4 = new double[] { 2.4, 4.5, 3.1, 8.9 };
//double[] roundedArray = ArrayUtils.Round(Array4);
//Console.WriteLine(string.Join(",", roundedArray));
//int[] aboveTreshhold = ArrayUtils.PickAboveTreshold(Array2, treshold);
//Console.WriteLine(string.Join(",", aboveTreshhold));
//int[] acumulateArray = ArrayUtils.Acumulate(Array2);
//Console.WriteLine(string.Join(",", acumulateArray));
//int[] ArrayMay = new int[] { 2, 4, 6 };
//int[] ArrayJun = new int[] { 1, 3, 5 };
//int[] zippedArray = ArrayUtils.Zip(ArrayMay, ArrayJun);
//Console.WriteLine(string.Join(",", zippedArray));
//int[,] grid = new int[,]
//{
//    { 1, 2, 3 },  // Row 0
//    { 4, 5, 6 },  // Row 1
//    { 8, 9, 10 } // Row 2
//};
//int[] mainDiagonal = ArrayUtils.Diagonal1(grid);
//Console.WriteLine(string.Join(",", mainDiagonal));
//int[] mainDiagonal2 = ArrayUtils.Diagonal2(new int[,]
//{
//    { 7, 2, 3, 4 },  // Row 0
//    { 5, 8, 6, 7 },  // Row 1
//    { 1, 9, 10,11 },  // Row 2 
//    { 4, 5, 7, 8 }    // Row 3
//});
//int[,] grid2 = new int[,]
//{
//    { 7, 2, 3, 4 },  // Row 0
//    { 5, 8, 6, 7 },  // Row 1
//    { 1, 9, 10,11 },  // Row 2 
//    { 4, 5, 7, 8 }    // Row 3
//};
//Console.WriteLine(string.Join(",", mainDiagonal2));
//ArrayUtils.Triangularize(grid2);
//ArrayUtils.PrintGrid(grid2);
//int[] flattenedList = ArrayUtils.Flatten(grid2);

//int a = 12;
//int b = 8;
//MiscUtils.GcdLcm(a, b, out int gcd, out int lcm);
//Console.WriteLine($"GCD: {gcd}, LCM: {lcm}");
//int[] numbers = new int[] { 6, 54, 10 };
//gcd = MiscUtils.GcdForMany(numbers);
//Console.WriteLine($"GCD for many numbers: {gcd}");


Point point1 = new Point(3.5, 4.2);
Point point2 = new Point(6.1, 8.3);
Console.WriteLine($"Distance to origin: {point1.DistanceToOrigin()}");
Console.WriteLine($"Distance between points: {point1.DistanceTo(point2)}");
var distStatic = Point.Distance(point1, point2);
Console.WriteLine(distStatic);

Point z = new Point(5,6);
z.Reflect(Point.ReflectionType.Y);
var pointString = Point.ToString(z);
Console.WriteLine(pointString);
