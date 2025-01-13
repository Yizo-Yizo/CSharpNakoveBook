using System.Collections;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using C_;
using CreatingAndUsingObjects;
public class Program
{
    public static void Main()
    {
        //Sequence();
        /*Console.WriteLine((int)'H');

        int height = 7; // Height of the triangle
        char symbol = '\u00A9'; // Copyright symbol

        for (int i = 1; i <= height; i++)
        {
            int spaces = height - i;

            // Print spaces before the symbol
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            // Print the symbol
            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine(); // Move to the next line
        }

        byte a = 3, b = 5;

        Console.WriteLine(a | b);
        int num = 70;
        string oddOrEven = num % 2 == 0 ? "Even" : "Odd";
        string divisibleBy5And7 = (num % 5 == 0) && (num % 7 == 0) ? "Divisible by 5 and 7" : "Not Divisible by 5 and 7";
        string numberIsSeven = (num / 100) % 10 == 7 ? "number is 7" : "number is not 7";
        Console.WriteLine(divisibleBy5And7);
        Console.WriteLine(DivisibleBy5And7(350));
        Console.WriteLine(Thirdbit(7));*/
        //Console.WriteLine(FourDigit(2011));
        //sumThreeInt();
        //Circle();
        //VirtualColumns();
        //SwitchStatement();
        //double total = 100;
        //Console.WriteLine("Gate way fee " + (3 * total) / 100 + "\nService fee " + (3 * total) / 100);
        //ArrayExample();
        //MultiArrays();
        //ReadMultiArrays();
        //long bestSum = int.MinValue;
        //Console.WriteLine(bestSum);
        //MaxPlatform2x2();
        //int[][,] myjaggedArray = new int[2][,];
        //myjaggedArray[0] = new int[,] { { 1, 2}, { 3,4} };
        //PascalTriangle();
        //Console.WriteLine("This is <b>Bold</b> this is not <b>bold</b>.");
        //TwentyElements();

        /*int[] array1 = { 1, 2, 3 };
        int[] array2 = { 1, 2, 3 };

        bool result = ArraysAreEqual(array1, array2);
        Console.WriteLine($"Are the arrays equal? {result}");*/

        /*Char 7 No. 3
        char[] array1 = { 'a', 'b', 'c' };
        char[] array2 = { 'a', 'c', 'b' };
        LexicographicallyEqual(array1, array2);*/

        //Ch 7 4
        /*int[] array1 = { 1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6, 7 };
        int[] array2 = { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 4 };
        int[] array3 = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, 12 };
        MaximumSequenceSameDigits(array1);*/

        //Ch 7 No. 5
        /*int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] array2 = { 5, 3, 2, 8, 4, 6, 7, 9, 10, 11, 12, 13, 14 };
        int[] array3 = { 9, 3, 7, 2, 8, 6, 1 };

        MaximumSequence(array2);*/

        //Ch 7 No. 6
        /*int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
        List<int> result = RandomConsecutiveNumbers(array);

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();*/

        /*List<int> ints = new List<int>();
        ints.Add(1);

        Console.WriteLine(ints[0]);

        List<string> strings = new List<string>();
        strings.Add("Me");

        Console.WriteLine(strings[0]);

        Console.WriteLine(strings.Remove("Me"));

        List<string> names = new List<string>() { "John", "Mark", "Cage", "Brain" };

        Console.WriteLine(string.Join(", ", names));
        names.Remove("Cage");
        Console.WriteLine(string.Join(", ", names));

        List<double> doubles = new List<double>() { 1, 1.5, 2, 2.5 };

        Console.WriteLine(doubles.Count());

        Console.WriteLine("Me" + " Myself");

        string name = "nigga called me";

        Console.WriteLine(name.ToUpper());

        Console.WriteLine(name.Length);

        StreamReader read = new StreamReader("Sample.txt");

        var lineNumber = 0;
        var line = read.ReadLine();

        string[] lines = new string[4];

        while(line != null)
        {
            lineNumber++;
            line = read.ReadLine();
            //Console.WriteLine("{0}, {1}",lineNumber, line);
            
            if (line != null)
            {
                lines[lineNumber] = line;
            }
            
        }

        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        StreamWriter writer = new StreamWriter("Sample.txt", false, Encoding.UTF8);

        writer.WriteLine("New line written");

        if(File.Exists("Sample.txt"))
        {
            Console.WriteLine("File exists.");
        }
        else
        {
            Console.WriteLine("File do not exist");
        

        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs["First"] = 1;
        keyValuePairs["Second"] = 2;
        keyValuePairs["Third"] = 3;

        foreach (var pair in keyValuePairs)
        {
            Console.WriteLine("{0} {1}", pair.Key, pair.Value);
        }

        Dictionary<string, bool> boolean = new Dictionary<string, bool>() { { "True", true }, { "False", false } };

    Console.WriteLine(boolean.ContainsKey("True"));
        Console.WriteLine(boolean.ContainsKey("me"));}*/

        /*if (keyValuePairs["Me"] != null)
        {
            Console.WriteLine("The key exist.");
        }
        else
        {
            Console.WriteLine("The key does not exist.");
        }

        Hashtable myHashTable = new Hashtable();
        myHashTable.Add("First", 1);
        myHashTable.Add("Second", 2);
        myHashTable.Add("Third", 3);

        Console.WriteLine(myHashTable["First"]);
        foreach (DictionaryEntry item  in myHashTable)
        {
            string key = (string)item.Key;
            object value = (object)item.Value;
            Console.WriteLine("{0} {1}", key, value);
        }

        Console.WriteLine(myHashTable.ContainsKey("First"));

        HashSet<string> strings = new HashSet<string>() { "Me", "Myself", "and", "I" };

        foreach (string key in strings)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine(strings.Contains("I"));

        List<string> names = new List<string>() { "Me", "Myself", "And", "I" };

        names.Sort();

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine(names.IndexOf("Myself"));

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        numbers.RemoveAll(x => x % 2 == 0); // Removes all even numbers

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        string statement = "The man came to the nigga yesterday";

        var words = statement.Split(' ');

        foreach( var word in words)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine(statement.Replace("man", "mojo"));

        Console.WriteLine(statement.Contains("nigga"));

        File.AppendAllText("Sample.txt", "Appended Line" + Environment.NewLine);

        StreamReader reader = new StreamReader("Sample.txt");
        Console.WriteLine(reader.ReadToEnd());

        var file = "Sample.txt";
        var lines = File.ReadLines(file).Count();
        Console.WriteLine(lines);

        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs["First"] = 1;
        keyValuePairs["Second"] = 2;
        keyValuePairs["Third"] = 3;

        foreach (var pair in keyValuePairs)
        {
            Console.WriteLine("{0} {1}", pair.Key, pair.Value);
        }

        keyValuePairs.Remove("First");

        Console.WriteLine(keyValuePairs.ContainsKey("First"));

        Dictionary<int, double> myDictionary = new Dictionary<int, double>()
        {
            {1, 1.1},
            {2, 2.2},
            {3, 3.3}
        };

        // Get a list of keys
        List<int> keys = myDictionary.Keys.ToList();

        // Print the keys
        Console.WriteLine(String.Join(", ", keys));

        Hashtable hashTable = new Hashtable() { { 1, 1.5 }, { 2, 2.5 }, { 3, 3.5 } };

        hashTable.Remove(1);

        List<int> ints = hashTable.Keys.Cast<int>().ToList();

        Console.WriteLine(String.Join(", ", ints));

        HashSet<int> set1 = new HashSet<int>() {  1, 2, 3, 4 };
        HashSet<int> set2 = new HashSet<int>() { 4, 5, 6 };

        //set1.UnionWith(set2);
        set1.IntersectWith(set2);
        Console.WriteLine(set1.IsSubsetOf(set2));

        Console.WriteLine(String.Join(", ", set1));

        // Ch 7 No. 7
        MaximumSum();


        // Ch 7 No. 8
        double[] doubles = { 32, 453, 2, 3, 56, 1, 7, 34, 9 };

        SelectionSort(doubles);

        // Ch 7 No. 9
        int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        MaximumSumSequence(array);

        // Ch 7 No. 10
        int[] arrays = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1 , 2, 4, 9, 3};
        FrequentlyOccurance(arrays);
        int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };

        SumOfNumberS(array, 11);

        // Ch 7 No. 12
        CreateSqureMatrices(4);

        // Ch 7 No. 13

        // Englighten Design
        int[] array = new int[] { 7, 15, 10, 8 };

        Console.WriteLine(Moves(array));

        // ENGLIGHTEN DESIGN PREP 

        // C# Easy questions No. 1
        PrintHello();

        // C# Easy questions No. 2
        SwapTwoNumbers();

        // C# Easy questions No. 3
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        EvenOddNumbers(num);

        // C# Easy questions No. 4
        LargestNumber();

        // C# Easy questions No. 5
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial is {0}",Factorial(number));

        // C# Easy questions No. 6
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Reversed string: {0}", ReverseString(str));

        // C# Easy questions No. 7
        Console.WriteLine("Enter a string: ");
    9
        string str = Console.ReadLine();
        Palindrome(str);

        // C# Easy questions No. 8
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        FibonacciSequence(number);

        // C# Easy questions No. 5
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of digits of the number is: {0}", SumOfDigits(number));

        // C# Easy questions No. 10
        Console.WriteLine("Enter string:");
        string str = Console.ReadLine();

        Console.WriteLine("Length of string is {0}", LengthOfString(str));

        // C# Easy questions No. 11
        Console.WriteLine("Enter celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} Fahrenheit", CelsiusToFahrenheit(celsius));

        // C# Easy questions No. 12
        Console.WriteLine("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Area: {0}", AreaCircle(radius));

        // C# Easy questions No. 13
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        LeapYear(year);

        // C# Easy questions No. 14
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        Console.WriteLine("There are {0} vowels in this word.", CountVowels(word));

        Console.Write("Enter start range: ");
        int numb1 = int.Parse(Console.ReadLine());

        Console.Write("Enter end range: ");
        int numb2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Random number: {0}", RandomWithinRange(numb1, numb2));

        // C# Easy questions No. 16
        Console.Write("Enter your first number: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter your second number: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: {0}", GCD(x, y));

        // C# Easy questions No. 18
        int[] array = new int[] { 10, 23, 4, 72, 54, 9, 18, 23 };
        MaximumMinimum(array);

        // C# Easy questions No. 19
        BubbleSort(array);

        // C# Easy questions No. 20
        SumArray(array);
        Console.WriteLine("\nSum: {0}",SumArray(array));

        // C# Easy questions No. 21
        int[] array2 = new int[] { 1, 43, 564, 654, 7685, 5675 };

        MergeArrays(array2, array);

        // C# Easy questions No. 23
        DecimalToBinary(148);

        // C# Easy questions No. 24
        Console.Write("Enter number: ");
        double number = double.Parse(Console.ReadLine());

        Console.Write("Enter power: ");
        double power = double.Parse(Console.ReadLine());

        Console.WriteLine("Result: {0}", Power(number, power));

        // C# Easy questions No. 25
        double[] array = new double[] { 10, 23, 4, 72, 54, 9, 18, 23 };

        Console.WriteLine("Second Largets: {0}", SecondLargest(array));

        // C# Easy questions No. 26

        Console.WriteLine("Write a sentence: ");
        string sentence = Console.ReadLine();

        Console.WriteLine("There are {0} words in the sentence.", CountWords(sentence));

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Reversed Number: ");
        ReverseNumber(number);

        // C# Easy questions No. 28
        Console.Write("Enter first word: ");
        string word1 = Console.ReadLine();

        Console.Write("Enter second word: ");
        string word2 = Console.ReadLine();

        Console.WriteLine("These two words are angrams: {0}", Anagram(word1, word2));

        int[] set1Array1 = { 1, 3, 5, 7 };
        int[] set1Array2 = { 2, 4, 7, 8 };

        IntersectionArray(set1Array1 , set1Array2);

        // Ch 7 No 13

        Console.Write("Enter rows you need: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter columns you need: ");
        int columns = int.Parse(Console.ReadLine());

        MaximumSumMatrix(rows, columns);

        // Ch 7 No. 14
        string[,] matrix = {
            {"a", "b", "b", "a"},
            {"b", "a", "a", "b"},
            {"b", "b", "a", "a"},
            {"a", "b", "a", "a"}
        };

        (string element, int length) longestSequence = FindLongestSequence(matrix);
        Console.WriteLine($"Longest sequence: {longestSequence.element}, Length: {longestSequence.length}");

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        foreach(int index in WordIndecies(word))
        {
            Console.Write(index + " ");
        }

        // Ch 7 No. 16
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        int target = 9;
        Console.WriteLine(BinarySearch(numbers, target));

        // Ch 7 No. 17
        int[] numbers = { 12, 11, 13, 5, 6, 7 };
        int n = numbers.Length;

        Console.WriteLine("Given array: ");
        PrintArray(numbers);

        MergeSort(numbers, n);

        Console.WriteLine("\nSorted array:");
        PrintArray(numbers);

        // Ch No. 19
        Prime();

        // Ch 7 No. 21
        int[] array = { 3, 1, 2, 4, 9, 6 };
        int S = 14;
        int K = 3;

        // Find subset
        bool found = FindSubsetSum(array, S, K);
        if (found)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        Console.WriteLine("Enter integers seperated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(input, int.Parse);

        foreach (int number in MinimalIncreasing(array))
        {
            Console.Write(number + " ");
        }

        // Ch 8 No. 4
        DecimalToBinary(178);

        // Ch 8 No. 5
        Console.WriteLine("Enter binary: ");
        string binary = Console.ReadLine();

        double[] numbers = BinaryToDecimal(binary);

        double sum = 0;

        foreach (double number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Decimal: {0}", sum);

        // Ch 8 No. 6
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        string hexValue = DecimalToHexadecimal(number);
        Console.WriteLine($"Hexadecimal: {hexValue}");

        // Ch 8 No. 7
        Console.WriteLine("Enter a hexadecimal number: ");
        string hexValue = Console.ReadLine();
        double decimalValue = HexadecimalToDecimal(hexValue);
        Console.WriteLine("Decimal: {0}", decimalValue);

        // Ch 8 No. 10
        Console.WriteLine("Enter a binary number: ");
        string binaryValue = Console.ReadLine();
        int decimalValue = BinaryToDecimalHornerScheme(binaryValue);
        Console.WriteLine("Decimal: {0}", decimalValue);

        // Ch 8 No. 11
        Console.WriteLine("Enter a Roman numeral: ");
        string romanNumber = Console.ReadLine();
        int decimalValue = RomanToArabicNumerals(romanNumber);
        Console.WriteLine("Decimal: {0}", decimalValue);

        // Ch 9 No. 1
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine(Greeting(name));

        // Ch 9 No. 2
        Console.Write("Enter three integers seperated by space: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        Console.WriteLine("The maximum number is: {0}", GetMaxOfThreeNumbers(int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]));

        // Ch 9 No. 3
        Console.Write("Enter an integer: ");
        string number = Console.ReadLine();
        string nameOfLastDigit = NameOfLastDigit(number);

        Console.WriteLine("Name of last digit: {0}", nameOfLastDigit);

        // Ch 9 No. 4
        Console.Write("Enter numbers seperated by space: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        Console.Write("Enter your target number: ");
        int targetNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Target number: {0} \nCount: {1}", targetNumber, CountOfNumber(numbers, targetNumber));

        // Run Test
        CountOfNumberTest();

        // Ch 9 No. 5
        Console.Write("Enter integers seperated by space: ");
        string input = Console.ReadLine();
        int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

        Console.Write("Enter position of number: ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Number is greater than its neighbors: {0}", GreaterThanNeighbors(numbers, index));

        GreaterThanNeighborsTest();

        // Ch No. 6
        Console.WriteLine("Enter integers seperated by space: ");
        string input = Console.ReadLine();
        int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

        int firstOccuredNumber = FirstOccuranceGreaterThanNeighbors(numbers);

        Console.WriteLine("Number occured first: {0}", firstOccuredNumber);

        Console.Write("Enter a number: ");
        string number = Console.ReadLine();

        ReverseNumber(number);
        int N = 2;
        int K = 3;
        for (int i = 1; i < K; i++ )
        {
            for (int j = 1; j < N; j++ )
            {
                Console.Write("{0} {1}", i, j);

            }
        }

        // Ch 10 No. 1

        Console.Write("Enter number of loops: ");
        int n = int.Parse(Console.ReadLine());
        int[] loops = new int[n];

        NestedLoopSimulation(n, 0, loops);

        // Ch 10 No. 3

        Console.Write("Enter number of elements in each combination (k): ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter total number of elements in the set (n): ");
        int n = int.Parse(Console.ReadLine());

        int[] combination = new int[k];

        //GenerateCombinationsRecursive(k, n, 0, 1, combination);
        GenerateCombinationsIterative(n, k);

        // Ch 10 No. 2
         Console.Write("Enter the total number of elements (n): ");
         int n = int.Parse(Console.ReadLine());

         Console.Write("Enter the number of elements in each variation (k): ");
         int k = int.Parse(Console.ReadLine());

         int[] variation = new int[k];

         //GenerateVariationsRecursive(n, k, 0, variation);
         GenerateVariationIterative(n, k);

        // Ch 10 No. 4
        Console.Write("Enter the number of elements in each combination (k): ");
         int k = int.Parse(Console.ReadLine());

         Console.Write("Enter words of your set seperated by space: ");
         string input = Console.ReadLine();
         string[] words = input.Split(" ");

         int n = words.Length;

         string[] combination = new string[k];

        GenerateSubsetsIterative(words, k);
        GenereateStringCombinationsRecursive(k, n, 0, 0, combination, words);
        

        // Ch 10 No. 5
        Console.Write("Enter words of your set seperated by space: ");
        string input = Console.ReadLine();
        string[] words = input.Split(" ");

        //GenerateSubsetsRecursive(words, new string[0], 0);
        GenerateSubsetsIterative(words);

        // Ch 10 No. 6
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Original array: " + string.Join(", ", array));

        MergeSortRecursive(array, 0, array.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", array));

        // Ch 10 No. 7
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        int[] permutation = new int[n];
        bool[] used = new bool[n + 1];

        GeneratePermutationsRecursive(permutation, used, 0, n);

        // Ch 10 No. 8
        int[] array = { 2, 3, 1, -1 };
        int targetSum = 4;
        List<int> subset = new List<int>();

        AllSubsetOfSum(array, targetSum, 0, subset, 0);

        // Fibonacci From YouTube 

        Console.WriteLine(FibonacciFromYouTube(9));

        // Ch 11 No. 1
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} is a leap year: {1}", year, CheckLeapYear(year));

        // Ch 11 No. 2
        RandomNumbersInARange();

        // Ch 11 No. 3
        Console.WriteLine(DayToday());

        // Ch 11 No. 4
        UpTime();

        // Ch 11 No. 5
        Console.Write("Enter length of side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter length of side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        double hypotenuse = Hypotenuse(side1, side2);
        Console.WriteLine("Hypotenus: {0}", hypotenuse);

        // Ch 11 No. 6
        Console.Write("Enter three sides separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        double[] sides = Array.ConvertAll(input, double.Parse);

        Console.Write("Enter a side and altitude separated by space: ");
        string[] input1 = Console.ReadLine().Split(' ');
        double[] sideAndAltitude = Array.ConvertAll(input1, double.Parse);

        Console.Write("Enter two sides and an angle between them separated by space: ");
        string[] input2 = Console.ReadLine().Split(' ');
        double[] sidesAndAngle = Array.ConvertAll(input2, double.Parse);

        double area = TriangleArea(sides[0], sides[1], sides[2]);
        Console.WriteLine("Area (Heron's formula): {0}", area);

        double area1 = TriangleArea(sideAndAltitude[0], sideAndAltitude[1]);
        Console.WriteLine("Area (side and altitude): {0}", area1);

        double area2 = TriangleArea(sidesAndAngle[0], sidesAndAngle[1], (int)sidesAndAngle[2]);
        Console.WriteLine("Area (two sides and angle): {0}", area2);

        // Ch 11 No. 7
        int sequence = CreatingAndUsingObjects.Sequence.NextValue();
        Console.WriteLine("Sequence: {0}", sequence);

        CreatingAndUsingObjects.Cat cat = new CreatingAndUsingObjects.Cat("nigga", "blue");
        Console.WriteLine( cat);

        // Ch 11 No. 8
        // Check CreatingAndUsingObjects namespace

        // Ch 11 No. 9
        // Define a list of public holidays
        List<DateTime> publicHolidays = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 1, 1),  // New Year's Day
                new DateTime(DateTime.Now.Year, 12, 25), // Christmas Day
                // Add other holidays as needed
            };

        // Define a list of working Saturdays
        List<DateTime> workingSaturdays = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 5, 15),  // Example of a working Saturday
                // Add other working Saturdays as needed
            };

        // Get the target date from the user
        Console.Write("Enter the target date (yyyy-mm-dd): ");
        DateTime targetDate = DateTime.Parse(Console.ReadLine());

        // Calculate the count of workdays
        int workdaysCount = CalculateWorkdays(DateTime.Now, targetDate, publicHolidays, workingSaturdays);

        Console.WriteLine($"The number of workdays between today and {targetDate.ToShortDateString()} is: {workdaysCount}");

        // Ch 11 No. 10
        Console.Write("Enter positive integers separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(input, int.Parse);

        int sum = SumOfNumbers(numbers);
        Console.WriteLine("Sum: {0}",sum);

        // Ch 11 No. 11
        RandomAdvertisingMessage();

        // Ch 12 No. 7
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Sqr(number);

        // Ch 12 No. 8
        try
        {
            int[] numbers = new int[10];
            int start = 1;
            int end = 100;
            Console.WriteLine("Enter 10 numbers such that 1 < a1 < a2 < ... < a10 < 100:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = ReadNumber(start, end);
                start = numbers[i]; // Update start to the last read number to ensure increasing order
            }

            Console.WriteLine("You entered valid numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

        // Ch 13 No. 2
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        string reversedText = ReverseString(text);
        Console.WriteLine("Reversed text: {0}",reversedText);

        // Ch 13 No. 3
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();
        
        Console.WriteLine("Parentheses placed correctly: {0}", ParenthesesCorrect(expression));

        // Ch 13 No. 5
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter substring to search: ");
        string substring = Console.ReadLine();

        int count = CountSubstringOccurrences(text, substring);
        Console.WriteLine("The substring '{0}' appears {1} times in the text.", substring, count);

        // Ch 13 No. 7
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.WriteLine("New Text: {0}", ComplementString(text));

        // Ch 13 No. 8
        Console.Write("Enter a text: ");
        string input = Console.ReadLine();

        string result = ConvertToUnicodeEscape(input);
        Console.WriteLine("Unicode escape sequence: {0}", result);

        // Ch 13 No. 9
        Console.Write("Enter the source text: ");
        string sourceText = Console.ReadLine();

        Console.Write("Enter the cipher code: ");
        string cipherCode = Console.ReadLine();

        string encryptedText = EncryptText(sourceText, cipherCode);
        Console.WriteLine("Encrypted text: {0}", encryptedText);

        // Ch 13 No. 10
        Console.WriteLine("Enter the text:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter the word to search for:");
        string word = Console.ReadLine();

        List<string> sentences = ExtractSentencesContainingWord(text, word);

        Console.WriteLine("\nSentences containing the word '{0}':", word);
        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence.Trim());
        }

        // Ch 13 No. 11
        Console.Write("Enter forbidden words separated by commas: ");
        string forbiddenWordsInput = Console.ReadLine();
        string[] forbiddenWords = forbiddenWordsInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("Enter the text: ");
        string text = Console.ReadLine();

        string result = ReplaceForbiddenWords(text, forbiddenWords);

        Console.WriteLine("Processed text: ");
        Console.WriteLine(result);

        // Ch 13 No. 12
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            // Decimal number
            Console.WriteLine("{0,15:F2}", number);

            // Hexadecimal number (for integers)
            if (number % 1 == 0) // check if number is an integer
            {
                int intNumber = (int)number;
                Console.WriteLine("{0,15:X}", intNumber);
            }
            else
            {
                Console.WriteLine("{0,15}", "N/A");
            }

            // Percentage
            Console.WriteLine("{0,15:P2}", number);

            // Currency
            Console.WriteLine("{0,15:C}", number);

            // Exponential (scientific) notation
            Console.WriteLine("{0,15:E}", number);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }

        // Ch 13 No. 13
        Console.Write("Enter URL: ");
        string url = Console.ReadLine();

        try
        {
            ParseURL(url, out string protocol, out string server, out string resource);
            Console.WriteLine("[protocol]=\"{0}\"", protocol);
            Console.WriteLine("[server]=\"{0}\"", server);
            Console.WriteLine("[resource]=\"{0}\"", resource);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Ch 13 No. 14
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string reversedSentence = ReverseWords(sentence);
        Console.WriteLine("Reversed sentence: {0}", reversedSentence);

        // Ch 13 No. 15
        // Define the dictionary text
        string dictionaryText = @".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";

        // Parse the dictionary
        Dictionary<string, string> dictionary = ParseDictionary(dictionaryText);

        // Loop to read words from the console
        while (true)
        {
            Console.Write("Enter a word (or 'exit' to quit): ");
            string word = Console.ReadLine().Trim();

            if (word.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine($"{word} – {dictionary[word]}");
            }
            else
            {
                Console.WriteLine("The word is not in the dictionary.");
            }
        }

        // Ch 13 No. 16
        // Sample HTML text with links
        string htmlText = @"<p>Please visit <a href=""http://softuni.org"">our site</a> to choose a training course. 
                           Also visit <a href= ""http://forum.softuni.org"">our forum</a> to discuss the courses.</p>";

        // Replace <a> tag hyperlinks with [URL] format
        string result = ReplaceHtmlLinks(htmlText);

        Console.WriteLine("Transformed HTML:");
        Console.WriteLine(result);

        // Ch 13 No. 17
        Console.WriteLine(NumberOfDays("03.08.2024", "06.08.2024"));

        // Ch 13 No. 18
        Console.WriteLine(DateTimeAdded("03.08.2024"));

        // Ch 13 No. 19
        string text = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";

        // Define the regular expression pattern for email addresses
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

        // Find all matches of the pattern in the text
        MatchCollection matches = Regex.Matches(text, pattern);

        // Print all extracted email addresses
        Console.WriteLine("Extracted email addresses from the sample text:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        // Ch 13 No. 20
        string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

        // Define the regex pattern to match dates in the format DD.MM.YYYY
        string pattern = @"\b\d{1,2}\.\d{1,2}\.\d{4}\b";

        // Find all matches in the text
        MatchCollection matches = Regex.Matches(text, pattern);

        // List to store extracted dates
        List<string> extractedDates = new List<string>();

        // Loop through each match
        foreach (Match match in matches)
        {
            // Parse the matched date
            string date = match.Value;

            // Split the date into day, month, and year
            string[] dateParts = date.Split('.');

            int day = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int year = int.Parse(dateParts[2]);

            // Create a DateTime object
            DateTime dateTime = new DateTime(year, month, day);

            // Convert to the Canadian date format (YYYY-MM-DD)
            string formattedDate = dateTime.ToString("yyyy-MM-dd");

            // Add to the list of extracted dates
            extractedDates.Add(formattedDate);
        }

        // Print the extracted dates
        foreach (string formattedDate in extractedDates)
        {
            Console.WriteLine(formattedDate);
        }

        //Ch 13 No. 21
        string text = "ABBA, lamal, exe. Some words are not palindromes like hello, world, and example.";

        // Extract words using regular expression
        string pattern = @"\b\w+\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        // List to store palindrome words
        List<string> palindromes = new List<string>();

        // Loop through each match
        foreach (Match match in matches)
        {
            string word = match.Value;
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        // Print the extracted palindrome words
        Console.WriteLine("Palindromes found in the text:");
        foreach (string palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
        }
        
        // Ch 13 No. 22
        // Read the input string from the console
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Dictionary to store the count of each letter
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        // Count the occurrences of each letter
        foreach (char c in input)
        {
            if (char.IsLetter(c)) // Consider only letters
            {
                char lowerC = char.ToLower(c); // Convert to lowercase for case-insensitivity
                if (letterCounts.ContainsKey(lowerC))
                {
                    letterCounts[lowerC]++;
                }
                else
                {
                    letterCounts[lowerC] = 1;
                }
            }
        }

        // Sort the letters in alphabetical order
        var sortedLetters = letterCounts.Keys.OrderBy(c => c);

        // Print each letter and its count
        Console.WriteLine("Letter counts in alphabetical order:");
        foreach (char letter in sortedLetters)
        {
            Console.WriteLine($"{letter}: {letterCounts[letter]}");
        }

        // Ch 13 No. 24
        // Read the input string from the console
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Call the method to remove consecutive duplicate characters
        string result = RemoveConsecutiveDuplicates(input);

        // Print the resulting string
        Console.WriteLine("Result: " + result);

        // Ch 13 No. 25
        // Prompt the user to enter words separated by commas
        Console.Write("Enter words separated by commas: ");
        string[] input = Console.ReadLine().Split(',');

        // Trim spaces around each word
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = input[i].Trim();
        }

        // Sort the words alphabetically
        string[] words = AlphabeticalOrder(input);

        // Print the sorted words
        Console.WriteLine("Sorted words:");
        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }

        // Ch 13 No. 26
        // Sample HTML input
        string htmlText = @"
<html>
<head><title>News</title></head>
<body><p><a href=""http://softuni.org"">Software
University</a> aims to provide free real-world practical
training for young people who want to turn into
skillful software engineers.</p></body>
</html>";

        // Extract and print the text content without tags
        string textContent = ExtractTextFromHtml(htmlText);
        Console.WriteLine(textContent);
    }

    // Ch 13 No. 26
    // Method to extract text content from HTML
    public static string ExtractTextFromHtml(string html)
    {
        // Replace tags with spaces
        string textOnly = Regex.Replace(html, "<.*?>", " ");
        // Replace multiple spaces with a single space
        textOnly = Regex.Replace(textOnly, @"\s+", " ");
        // Trim leading and trailing spaces
        textOnly = textOnly.Trim();

        return textOnly;
    }

    // Ch 13 No. 25
    // Method to sort the words alphabetically
    public static string[] AlphabeticalOrder(string[] input)
    {
        return input.OrderBy(c => c).ToArray();
    }

    // Ch 13 No. 24
    static string RemoveConsecutiveDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        // Use StringBuilder for efficient string manipulation
        System.Text.StringBuilder result = new System.Text.StringBuilder();

        // Add the first character to the result
        result.Append(input[0]);

        // Iterate through the input string starting from the second character
        for (int i = 1; i < input.Length; i++)
        {
            // If the current character is different from the previous one, add it to the result
            if (input[i] != input[i - 1])
            {
                result.Append(input[i]);
            }
        }

        // Convert the StringBuilder to a string and return it
        return result.ToString();

        // Ch 14 No. 1 Refer to Student class
        // Ch 14 No. 2 Refer to Student class
        // Ch 14 No. 3 Refer to Student class

        // Ch 14 No. 4 
        Student student = new Student("Thapelo");

        student.PrintStudentInfo();

        // Ch 14 No. 6 refer to TestStudent class

        // Ch 14 No. 7 
        TestStudent.CreateStudents();
        TestStudent.DisplayStudentsInfo();

        // Ch 14 No. 14
        GSMTest test = new GSMTest();
        test.PrintMobilePhones();

        // Optionally, you can call:
        MobilePhone.DisplayNokiaN95Info();

        // Ch 14. No. 20 Refer to class library and class book

        // Ch 14 No. 21
        LibraryBookTest libraryTest = new LibraryBookTest();
        libraryTest.Test();

        // Ch 14 No. 23
        // Create a list of integers with a capacity of 5
        GenericList<int> intList = new GenericList<int>(5);

        // Add elements to the list
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);

        // Access an element by index
        Console.WriteLine("Element at index 1: " + intList[1]);

        // Insert an element at index 1
        intList.InsertAt(1, 15);

        // Display the list
        Console.WriteLine("List after insertion: " + intList);

        // Remove the element at index 2
        intList.RemoveAt(2);

        // Display the list
        Console.WriteLine("List after removal: " + intList);

        // Search for an item
        int index = intList.IndexOf(20);
        Console.WriteLine("Index of 20: " + index);

        // Clear the list
        intList.Clear();
        Console.WriteLine("List after clearing: " + intList);

        // Ch 14 No. 25 refer to class Fraction
        // Ch 14 No. 26
        FractionTest fractionTest = new FractionTest();
        fractionTest.TestFractions();

        // Ch 15 No. 1

        try
        {

            string[] lines = File.ReadAllLines("OddLines.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error .WriteLine($"Error: {e.Message}");
        }

        // Ch 14 No. 2
        try
        {
            string[] oddLines = File.ReadAllLines("OddLines.txt");
            string[] justLines = File.ReadAllLines("JustLines.txt");

            File.WriteAllLines("Empty.txt", oddLines);
            File.AppendAllLines("Empty.txt", justLines);

            string[] emptyText = File.ReadAllLines("Empty.txt");

            for (int i = 0; i < emptyText.Length; i++)
            {
                Console.WriteLine(emptyText[i]);
            }
        }
        catch(FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch(DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch(IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 14 No. 3
        try
        {
            // Step 1: Read all lines from the file
            string[] lines = File.ReadAllLines("Empty.txt");

            // Step 2: Add line numbers to each line
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"{i + 1}: {lines[i]}";
            }

            // Step 3: Write the modified lines back to the file
            File.WriteAllLines("Empty.txt", lines);

            Console.WriteLine("File updated successfully with line numbers.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 14 No. 4
        int equal = 0;
        int nonEqual = 0;
        try
        {
            string[] firstTextFile = File.ReadAllLines("Empty.txt");
            string[] secondTextFile = File.ReadAllLines("Empty.txt");

            if (firstTextFile.Length != secondTextFile.Length)
            {
                throw new InvalidOperationException("Files have different number of lines.");
            }

            for ( int i = 0; i < firstTextFile.Length;i++)
            {
                if (firstTextFile[i] == secondTextFile[i])
                {
                    equal++;
                }
                else
                {
                    nonEqual++;
                }
            }

            Console.WriteLine($"Equal rows: {equal}");
            Console.WriteLine($"Non equal rows: {nonEqual}");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 14 No. 5

        try
        {
            string[] matrixTextFile = File.ReadAllLines("matrix.txt");

            int size = int.Parse(matrixTextFile[0]);

            int[,] matrix = new int[size, size];

            for (int i = 1; i < size;i++)
            {
                int[] digits = Array.ConvertAll(matrixTextFile[i].Split(' '), int.Parse);

                for (int j = 0; j < digits.Length; j++)
                {
                    matrix[i, j] = digits[j];
                }
            }

            int maximalSum = MaximalSum(matrix);

            Console.WriteLine($"Sample output: {maximalSum}");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine ($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 15 No. 6

        try
        {
            // Read all lines from the input file
            string[] names = File.ReadAllLines("names.txt");

            // Sort the names alphabetically
            Array.Sort(names);

            // Write the sorted names to the output file
            File.WriteAllLines("sorted_names.txt", names);

            Console.WriteLine("Names have been sorted and written to 'sorted_names.txt'.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 15 No. 7
        try
        {
            // Read the contents of the file
            string content = File.ReadAllText("input.txt");

            // Replace every occurrence of "start" with "finish"
            string updatedContent = content.Replace("start", "finish");

            // Write the updated content back to the file or to a new file
            File.WriteAllText("output.txt", updatedContent);

            Console.WriteLine("Replacement complete. Check 'output.txt' for the result.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 15 No. 8
        try
        {
            // Read the contents of the file
            string content = File.ReadAllText("input.txt");

            // Use a regex to replace only whole words
            string updatedContent = Regex.Replace(content, @"\bstart\b", "finish");

            // Write the updated content back to the file or to a new file
            File.WriteAllText("output.txt", updatedContent);

            Console.WriteLine("Replacement complete. Check 'output.txt' for the result.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 15 No. 9

        try
        {
            string[] lines = File.ReadAllLines("OddLines.txt");
            List<string> evenLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    evenLines.Add(lines[i]);
                }
            }

            // Write the remaining lines back to the file
            File.WriteAllLines("OddLines.txt", evenLines.ToArray());

            Console.WriteLine("Odd lines removed successfully.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 15 No. 10
        try
        {
            // Load the XML document
            XmlDocument doc = new XmlDocument();
            doc.Load("input.xml");

            // Extract the text content
            ExtractText(doc.DocumentElement);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 15 No. 11
        try
        {
            // Read the content of the input file
            string inputFile = "input.txt";
            string outputFile = "output.txt";
            string content = File.ReadAllText(inputFile);

            // Regular expression pattern to match words that start with "test"
            string pattern = @"\btest\w*\b";

            // Replace the matching words with an empty string
            string result = Regex.Replace(content, pattern, "", RegexOptions.IgnoreCase);

            // Write the modified content to the output file
            File.WriteAllText(outputFile, result);

            Console.WriteLine("Words starting with 'test' have been removed.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
        }

        // Ch 15 No. 12
        try
        {
            // Read the list of words to be removed from words.txt
            string[] wordsToRemove = File.ReadAllLines("words.txt");

            // Read the content of text.txt
            string textContent = File.ReadAllText("text.txt");

            // Create a regular expression pattern to match each word to remove
            foreach (string word in wordsToRemove)
            {
                string pattern = $@"\b{Regex.Escape(word)}\b";
                textContent = Regex.Replace(textContent, pattern, "", RegexOptions.IgnoreCase);
            }

            // Optionally, you can clean up extra spaces left from removed words
            textContent = Regex.Replace(textContent, @"\s+", " ").Trim();

            // Write the modified content back to text.txt
            File.WriteAllText("text.txt", textContent);

            Console.WriteLine("Words from 'words.txt' have been removed from 'text.txt'.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"File not found: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Directory not found: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"IO Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"An unexpected error occurred: {e.Message}");
        }

        // Ch 15 No. 13
        try
        {
            // Read the list of words to count from words.txt
            string[] words = File.ReadAllLines("words.txt");

            // Create a dictionary to store the word counts
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            // Initialize the dictionary with the words from words.txt
            foreach (string word in words)
            {
                wordCounts[word] = 0;
            }

            // Read the content of text.txt
            string textContent = File.ReadAllText("text.txt").ToLower();

            // Count the occurrences of each word in text.txt
            foreach (string word in words)
            {
                int count = CountOccurrences(textContent, word.ToLower());
                wordCounts[word] = count;
            }

            // Sort the dictionary by the number of occurrences in descending order
            var sortedWordCounts = wordCounts.OrderByDescending(kv => kv.Value);

            // Write the sorted results to result.txt
            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                foreach (var kv in sortedWordCounts)
                {
                    writer.WriteLine($"{kv.Key}: {kv.Value}");
                }
            }

            Console.WriteLine("Word count results have been written to result.txt.");
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine($"File not found: {e.Message}");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine($"Directory not found: {e.Message}");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine($"IO Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"An unexpected error occurred: {e.Message}");
        }

        // Ch 16 No. 1

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter positive integer numbers (press Enter on an empty line to finish):");

        while (true)
        {
            string input = Console.ReadLine();

            // Stop reading input when an empty line is entered
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            // Try to parse the input into an integer
            if (int.TryParse(input, out int number) && number > 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }

        if (numbers.Count > 0)
        {
            (double sum, double average) = SumAndAverage(numbers);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

        Stack<int> stackedNumbers = new Stack<int>();

        Console.Write("Enter numbers separated by space (press enter when you are done): ");
        string[] numbers = Console.ReadLine().Split(' ');

        Console.WriteLine("Before:");
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int parsedNumber))
            {
                Console.Write($"{number} ");
                stackedNumbers.Push(parsedNumber);
            }
            else
            {
                Console.WriteLine($"'{number}' is not a valid number.");
            }
        }
        Console.WriteLine();

        Console.WriteLine("After:");
        while (stackedNumbers.Count > 0)
        {
            int number = stackedNumbers.Pop();
            Console.Write($"{number} ");
        }

        // Ch 16 No. 3
        List<int> intergers = new List<int>();

        Console.WriteLine("Enter positive numbers (press enter for entry)");
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            if (int.TryParse(input, out int number) && number > 0)
            {
                intergers.Add(number);
            }
            else
            {
                Console.WriteLine("Entered invalid integer, please try again!");
            }
        }

        intergers.Sort();

        foreach (int interger in intergers)
        {
            Console.Write($"{interger} ");
        }

        // Ch 16 No.4
        List<int> numbers = new List<int> { 1, 2, 2, 2, 3, 4, 4, 4, 4, 5 };

        List<int> longestSubsequence = FindLongestSubsequence(numbers);

        Console.WriteLine("Longest subsequence of equal numbers:");
        foreach (int number in longestSubsequence)
        {
            Console.Write($"{number} ");
        }

        // Ch 16 No. 5
        List<int> numbers = new List<int> { 19, -10, 12, -6, -3, 34, -2, 5 };

        List<int> nonNegativeNumbers = RemoveNegativeNumbers(numbers);

        foreach (int number in nonNegativeNumbers)
        {
            Console.Write($"{number} ");
        }

        // Ch 16 No. 6
        List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

        List<int> result = RemoveOddCountNumbers(numbers);

        Console.WriteLine("Result: " + string.Join(", ", result));

        // Ch 16 No. 7
        int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        Dictionary<int, int> countOcurrances = OccuranceOfNumbers(numbers);

        foreach(KeyValuePair<int, int> occrance in countOcurrances)
        {
            Console.WriteLine($"{occrance.Key} -> {occrance.Value}");
        }

        // Ch 16 No. 8
        List<int> numbers = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

        int majorant = Majorant(numbers);

        if (majorant == int.MinValue)
        {
            Console.WriteLine("The majorant does not exist!");
        }
        else
        {
            Console.WriteLine($"The majorant is: {majorant}");
        }

        int N = 2;

        Queue<int> sequence =sequenceQueue(N);

        foreach (int number in sequence)
        {
            Console.Write($"{number} ");
        }

        // Ch 16 No. 10
        int N = 5, M = 16;
        Queue<int> sequence = SubSequence(N, M);

        foreach (int i in sequence)
        {
            Console.Write(i + " ");
        }

        // Ch 16 No. 15
        var linkedListSorting = new LinkedListSorting();

        linkedListSorting.Add(4);
        linkedListSorting.Add(2);
        linkedListSorting.Add(1);
        linkedListSorting.Add(3);

        linkedListSorting.SortNumbers();

        for (int i = 0; i < linkedListSorting.Count; i++)
        {
            Console.Write(linkedListSorting[i]+" ");
        }

        // Ch 16 No. 16
        string directoryPath = @"C:\Users\panth";
        AllDirectoriesDFS(directoryPath);

        // Ch 16 No. 18
        int[,] matrix =
        {
            { 0, 0, 0, -1, 0, -1 },
            { 0, -1, 0, -1, 0, -1 },
            { 0, 2, -1, 0, -1, 0 },
            { 0, -1, 0, 0, 0, 0 },
            { 0, 0, 0, -1, -1, 0 },
            { 0, 0, 0, -1, 0, -1 }
        };

        var labyrinth = Labyrinth(matrix);

        for (int row = 0; row < labyrinth.GetLength(0); row++)
        {
            for (int col = 0; col < labyrinth.GetLength(1); col++)
            {
                Console.Write(labyrinth[row, col] + " ");
            }
            Console.WriteLine();
        }

        // Ch 17 No. 1

        BinaryTree tree = new BinaryTree(5,
            new BinaryTree(3,
                new BinaryTree(3),
                new BinaryTree(4)),
            new BinaryTree(7,
                new BinaryTree(5),
                null));

        int target = 5;
        int count = tree.CountOccurrences(target);
        Console.WriteLine($"Number {target} occurs {count} time(s) in the tree.");

        // Ch 17 No. 2
        Tree<int> tree =
           new Tree<int>(7,
            new Tree<int>(19,
             new Tree<int>(1),
             new Tree<int>(12),
             new Tree<int>(31)),
            new Tree<int>(21),
            new Tree<int>(14,
             new Tree<int>(23),
             new Tree<int>(6))
           );

        tree.RootsWithKSubTrees(2);

        // Ch 17 No. 3
        Tree<int> tree =
   new Tree<int>(7,
       new Tree<int>(19,
           new Tree<int>(1),
           new Tree<int>(12,
               new Tree<int>(31)
           )
       ),
       new Tree<int>(21), // Leaf node with no children
       new Tree<int>(14,
           new Tree<int>(23),
           new Tree<int>(6)
       )
   );

        Console.WriteLine(tree.NumberOfLeaves());

        // Ch 17 No. 4
        BinaryTreee<int> binaryTree =
                new BinaryTreee<int>(14,
                    new BinaryTreee<int>(19,
                        new BinaryTreee<int>(23),
                        new BinaryTreee<int>(6,
                            new BinaryTreee<int>(10),
                            new BinaryTreee<int>(21))),
                    new BinaryTreee<int>(15,
                        new BinaryTreee<int>(3), null));

        var levelSums = GetLevelSums(binaryTree);

        Console.WriteLine("Sum of vertices at each level:");
        for (int i = 0; i < levelSums.Count; i++)
        {
            Console.WriteLine($"Level {i}: {levelSums[i]}");
        }*/

        // Ch 17 No. 5
        BinaryTreee<int> binaryTree =
                new BinaryTreee<int>(14,
                    new BinaryTreee<int>(19,
                        new BinaryTreee<int>(23),
                        new BinaryTreee<int>(6,
                            new BinaryTreee<int>(10),
                            new BinaryTreee<int>(21))),
                    new BinaryTreee<int>(15,
                        new BinaryTreee<int>(3), null));

        binaryTree.PrintVerticeWithLeaveSuccessors();
    }
    // Ch 17 No.4
    public static List<int> GetLevelSums(BinaryTreee<int> root)
    {
        var result = new List<int>();
        if (root == null)
        {
            return result;
        }

        var queue = new Queue<(BinaryTreee<int> Node, int Level)>();
        queue.Enqueue((root, 0));

        while (queue.Count > 0)
        {
            var (currentNode, level) = queue.Dequeue();

            // Ensure the list has a spot for the current level
            if (result.Count <= level)
            {
                result.Add(0);
            }

            // Add the current node's value to the corresponding level
            result[level] += currentNode.Value;

            // Enqueue left and right children
            if (currentNode.LeftChild != null)
            {
                queue.Enqueue((currentNode.LeftChild, level + 1));
            }

            if (currentNode.RightChild != null)
            {
                queue.Enqueue((currentNode.RightChild, level + 1));
            }
        }

        return result;
    }

    // Ch 16 No. 18
    public static int[,] Labyrinth(int[,] matrix)
    {
        // Finding the root/starting point
        for (int row = 0 ; row < matrix.GetLength(0); row++)
        {
            for (int col = 0 ; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 2)
                {
                    matrix[row, col] = 0;
                    BFSLabyrinth(matrix, row, col);
                    return matrix;
                }
            }
        }

        return matrix;
    }

    public static void BFSLabyrinth(int[,] matrix, int rootRow, int rootCol)
    {
        int matrixSize = matrix.GetLength(0) * matrix.GetLength(1);
        int moves = 0;
        int count = 1;

        while(moves <= matrixSize)
        {

            if ((rootRow + count <= matrix.GetLength(0)) && (rootRow - count >= 0) && (rootCol + count <= matrix.GetLength(1)) && (rootCol - count >= 0))
            {
                if (matrix[rootRow + count, rootCol] == 0)
                {
                    AddUpwards(matrix, rootRow, rootCol, count);
                    moves++;
                }
                else if (matrix[rootRow - count, rootCol] == 0)
                {
                    AddDownwards(matrix, (rootRow - count), rootCol, count);
                    moves++;
                }
                else if (matrix[rootRow, rootCol + count] == 0)
                {
                    AddToTheRight(matrix, rootRow, rootCol, count);
                    moves++;
                }
                else if (matrix[rootRow, rootCol - count] == 0)
                {
                    AddToTheLeft(matrix, rootRow, rootCol, count);
                    moves++;
                }
                else 
                {
                    moves++;
                }

            }

        }
    }

    public static void AddToTheLeft(int[,] matrix, int row, int col, int count)
    {
        while (true)
        {
            if ((col - count >= 0) && (matrix[row, col - count] != -1))
            {
                matrix[row, col - count] += matrix[row, col + (count + 1)];
                count++;
            }
            else
            {
                break;
            }
        }
    }

    public static void AddToTheRight(int[,] matrix, int row, int col, int count)
    {
        while (true)
        {
            if ((col + count <= matrix.GetLength(1)) && (matrix[row, col + count] != -1))
            {
                matrix[row, col + count] += matrix[row, col + (count - 1)];
                count++;
            }
            else
            {
                break;
            }
        }
    }

    public static void AddDownwards(int[,] matrix, int row, int col, int count)
    {
        while (true)
        {
            if ((row - count >= 0) && (matrix[row - count, col] != -1))
            {
                matrix[row - count, col] += matrix[row - (count + 1), col];
                count++;
            }
            else
            {
                break;
            }
        }
    }

    public static void AddUpwards(int[,] matrix,  int row, int col, int count)
    {
        while (true)
        {
            if ((row + count <= matrix.GetLength(0)) && (matrix[row + count, col] != -1))
            {
                matrix[row + count, col] += matrix[row + (count - 1), col];
                count++;
            }
            else
            {
                break;
            }
        }
    }
    // Ch 16 No. 17
    public static void AllDirectoriesDFS(string directoryPath)
    {
        Stack<string> directoriesVisited = new Stack<string>();

        // Start with the root directory
        directoriesVisited.Push(directoryPath);

        while (directoriesVisited.Count > 0)
        {
            var currentDirectory = directoriesVisited.Pop();

            Console.WriteLine(currentDirectory);

            try
            {
                var subDirectories = Directory.GetDirectories(currentDirectory);

                foreach ( var subDirectory in subDirectories)
                {
                    directoriesVisited.Push(subDirectory);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied to: {currentDirectory}. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while accessing: {currentDirectory}. {ex.Message}");
            }
        }
    }
    // Ch 16 No. 16
    public static void AllDirectoriesBFS(string directoryPath)
    {
        Queue<string> directoriesVisited = new Queue<string>();

        // Start with the root directory
        directoriesVisited.Enqueue(directoryPath);

        while (directoriesVisited.Count > 0)
        {
            // Dequeue the next directory to process
            string currentDirectory = directoriesVisited.Dequeue();

            // Print the current directory
            Console.WriteLine(currentDirectory);

            try
            {
                // Get subdirectories of the current directory
                string[] subdirectories = Directory.GetDirectories(currentDirectory);

                // Enqueue all subdirectories
                foreach (string subdir in subdirectories)
                {
                    directoriesVisited.Enqueue(subdir);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied to: {currentDirectory}. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while accessing: {currentDirectory}. {ex.Message}");
            }
        }
    }
    // Ch 16 No. 14
    // Refer to CircularQueue class

        // Ch 16 No. 13
        // Refere to DynamicDeque class

        // Ch 16 No. 12
        // Refer to DynamicStack class

        // Ch 16 No. 11
        // Refer to DynamicDoublyList class

        // Ch 16 No. 10
    public static Queue<int> SubSequence(int N, int M)
    {
        Queue<int> sequence = new Queue<int>();
        Queue<int> newSequence = new Queue<int>();

        sequence.Enqueue(N);
        int current = sequence.Dequeue();
        newSequence.Enqueue(current);

        while (current != M)
        {

            if (current * 2 <= M)
            {
                newSequence.Enqueue(current * 2);
                sequence.Enqueue(current * 2);
            }
            else if (current + 2 <= M)
            {
                newSequence.Enqueue(current + 2);
                sequence.Enqueue(current + 2);
            }
            else
            {
                newSequence.Enqueue(current + 1);
                sequence.Enqueue(current + 1);
            }

            current = sequence.Dequeue();
        }

        return newSequence;
    }


    // Ch 16 No. 9
    public static Queue<int> sequenceQueue(int N)
    {
        Queue<int> sequence = new Queue<int>();
        Queue<int> newSequence = new Queue<int>();  
        sequence.Enqueue(N);

        int count = 0;
        while (count < 50)
        {
            int current = sequence.Dequeue();
            newSequence.Enqueue(current);

            sequence.Enqueue(current + 1);
            sequence.Enqueue(2 * current + 1);
            sequence.Enqueue(current + 2);
            count++;
        }

        return newSequence;
    }
    // Ch 16 No. 8
    public static int Majorant(List<int> numbers)
    {
        int majorant = int.MinValue;
        int countOfNumbers = numbers.Count;
        Dictionary<int, int> numberOfOccurrences = OccuranceOfNumbers(numbers.ToArray());

        foreach (var pair in numberOfOccurrences)
        {
            if (pair.Value >= ((countOfNumbers / 2) + 1))
            {
                majorant = pair.Key;
                break;
            }
        }

        return majorant;
    }
    // Ch 16 No. 7
    public static Dictionary<int, int> OccuranceOfNumbers(int[] numbers)
    {

        Dictionary<int, int> countOcurrances = new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            if (countOcurrances.ContainsKey(number))
            {
                countOcurrances[number]++;
            }
            else
            {
                countOcurrances[number] = 1;
            }
        }

        return countOcurrances;
    }

    // Ch 16 No. 6
    static List<int> RemoveOddCountNumbers(List<int> numbers)
    {
        Dictionary<int, int> countDict = new Dictionary<int, int>();

        // Count occurrences of each number
        foreach (int number in numbers)
        {
            if (countDict.ContainsKey(number))
            {
                countDict[number]++;
            }
            else
            {
                countDict[number] = 1;
            }
        }

        // Filter out numbers that have an odd count
        List<int> result = new List<int>();

        foreach (int number in numbers)
        {
            if (countDict[number] % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }

    // Ch 16 No. 5
    public static List<int> RemoveNegativeNumbers(List<int> numbers)
    {
        List<int> nonNegativeNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (number >= 0)
            {
                nonNegativeNumbers.Add(number);
            }
        }

        return nonNegativeNumbers;
    }

    // Ch 16 No. 4
    public static List<int> FindLongestSubsequence(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            return new List<int>();

        int maxLength = 1;
        int currentLength = 1;
        int bestStartIndex = 0;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentLength++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestStartIndex = i - currentLength + 1;
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        return numbers.GetRange(bestStartIndex, maxLength);
    }

    // Ch 16 No. 1
    public static (double, double) SumAndAverage(List<int> numbers)
    {
        double sum = numbers.Sum();
        double average = numbers.Average();

        return (sum, average);
    }
    // Ch 15 No. 13
    static int CountOccurrences(string text, string word)
    {
        int count = 0;
        int index = text.IndexOf(word);

        while (index != -1)
        {
            count++;
            index = text.IndexOf(word, index + word.Length);
        }

        return count;
    }

    // Ch 15 No. 10
    static void ExtractText(XmlNode node)
    {
        // If the node is a text node, print the text
        if (node is XmlText)
        {
            Console.WriteLine(node.Value.Trim());
        }

        // Recursively process child nodes
        foreach (XmlNode child in node.ChildNodes)
        {
            ExtractText(child);
        }
    }

    // Ch 14 No. 5
    public static int MaximalSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] +
                          matrix[i + 1, j] + matrix[i + 1, j + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }

        return bestSum;
    }
    // Ch 13 No. 21
    // Helper method to check if a word is a palindrome
    static bool IsPalindrome(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    // Ch 13 No. 18
    public static DateTime DateTimeAdded(string date)
    {
        string format = "dd.MM.yyyy";
        DateTime newDateTime = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);

        return newDateTime.AddHours(6).AddMinutes(30);
    }
    // Ch 13 No. 17
    public static double NumberOfDays(string day1, string day2)
    {
        string format = "dd.MM.yyyy";
        DateTime formattedDay1 = DateTime.ParseExact(day1, format, CultureInfo.InvariantCulture);
        DateTime formattedDay2 = DateTime.ParseExact(day2, format, CultureInfo.InvariantCulture);

        double result = formattedDay2.Subtract(formattedDay1).Days;

        return result;
    }
    // Ch 13 No. 16
    public static string ReplaceHtmlLinks(string html)
    {
        // Regular expression pattern to match <a> tags with href attribute
        string pattern = @"<a\s+href\s*=\s*""([^""]+)""\s*>(.*?)</a>";

        // Replace <a> tags with [URL] tags using Regex.Replace method
        string transformedText = Regex.Replace(html, pattern, "[URL=$1]$2[/URL]");

        return transformedText;
    }

    // Ch 13 No. 15
    public static Dictionary<string, string> ParseDictionary(string text)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        // Split the text into lines based on newline characters
        string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        foreach (string line in lines)
        {
            // Split each line into parts based on the " – " separator
            // Using new[] { " – " } creates a string array with one element as the separator
            // StringSplitOptions.None means no special handling for empty elements
            string[] parts = line.Split(new[] { " – " }, StringSplitOptions.None);
            if (parts.Length == 2)
            {
                dictionary[parts[0].Trim()] = parts[1].Trim();
            }
        }

        return dictionary;
    }

    // Ch 13 No. 14
    static string ReverseWords(string sentence)
    {
        // Use regular expressions to split the sentence into words while preserving punctuation and spaces
        string[] words = Regex.Split(sentence, @"(\W+)");

        // Reverse the words array
        Array.Reverse(words);

        // Join the reversed words back into a single string
        return string.Join("", words);
    }


    // Ch 13 No. 13
    static void ParseURL(string url, out string protocol, out string server, out string resource)
    {
        if (string.IsNullOrEmpty(url))
        {
            throw new ArgumentException("URL cannot be null or empty.");
        }

        int protocolEndIndex = url.IndexOf("://");
        if (protocolEndIndex == -1)
        {
            throw new ArgumentException("Invalid URL format: Protocol not found.");
        }

        protocol = url.Substring(0, protocolEndIndex);
        int serverStartIndex = protocolEndIndex + 3;
        int resourceStartIndex = url.IndexOf('/', serverStartIndex);

        if (resourceStartIndex == -1)
        {
            server = url.Substring(serverStartIndex);
            resource = "/";
        }
        else
        {
            server = url.Substring(serverStartIndex, resourceStartIndex - serverStartIndex);
            resource = url.Substring(resourceStartIndex);
        }
    }

    // Ch 13 No. 11
    public static string ReplaceForbiddenWords(string text, string[] forbiddenWords)
    {
        foreach (string word in forbiddenWords)
        {
            string tremmedWord = word.Trim();
            if(!string.IsNullOrEmpty(tremmedWord))
            {
                string pattern = Regex.Escape(tremmedWord);
                string replacement = new string('*', tremmedWord.Length);
                text = Regex.Replace(text, pattern, replacement, RegexOptions.IgnoreCase);
            }
        }

        return text;
    }

    // Ch 13 No. 10
    static List<string> ExtractSentencesContainingWord(string text, string word)
    {
        List<string> result = new List<string>();
        string[] sentences = text.Split('.');

        foreach (string sentence in sentences)
        {
            string pattern = $@"\b{Regex.Escape(word)}\b";
            if (Regex.IsMatch(sentence, pattern, RegexOptions.IgnoreCase))
            {
                result.Add(sentence);
            }
        }

        return result;
    }

    // Ch 13 No. 8
    public static string ConvertToUnicodeEscape(string input)
    {
        char[] chars = input.ToCharArray();
        string[] unicodeEscapes = new string[chars.Length];

        for (int i = 0; i < chars.Length; i++)
        {
            unicodeEscapes[i] = $"\\u{(int)chars[i]:x4}";
        }

        return string.Join("", unicodeEscapes);
    }

    // Ch 13 No. 8
    public static string ComplementString(string text)
    {
        if (text == null)
        {
            return "Invalid string";
        }

        if (text.Length > 20)
        {
            return text.Substring(0, 20);
        }
        else
        {
            return text.PadRight(20, '*');
        }
    }

    // Ch 13 No. 6
    public static string ModifyCasing(string text)
    {
        // Regular expression to find <upcase>...</upcase> tags
        string pattern = @"<upcase>(.*?)<\upcase>";

        // Use Regex to replace the matched patterns
        string result = Regex.Replace(text, pattern, m => m.Groups[1].Value.ToUpper());

        return result;
    }
    // Ch 13 No. 5
    public static int CountSubstringOccurrences(string text, string subString)
    {
        if (string.IsNullOrEmpty(text)) return 0;

        int count = 0;
        int index = 0;

        while((index = text.IndexOf(subString,index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += subString.Length;
        }

        return count;
    }
    // Ch 13 No. 3
    public static bool ParenthesesCorrect(string expression)
    {
        int openParenthesesCount = 0;
        int closeParenthesesCount = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openParenthesesCount++;
            }
            else if (expression[i] == ')')
            {
                closeParenthesesCount++;
            }
            
        }

        if (openParenthesesCount == closeParenthesesCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Ch 13 No. 2
    public static string ReverseString(string text)
    {
        StringBuilder reversedText = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText.Append(text[i]);
        }

        return reversedText.ToString();
    }

    public static int ReadNumber(int start, int end)
    {
        Console.Write($"Enter a number in the range [{start + 1}...{end - 1}]: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            throw new FormatException("Invalid number format.");
        }

        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException($"The number must be in the range [{start + 1}...{end - 1}].");
        }

        return number;
    }

// Ch 12 No. 7
public static void Sqr(int number)
    {
        try
        {

            if (number < 0)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("Square Root: " + squareRoot);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid Number");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }

    }
    // Ch 11 No. 11
    public static void RandomAdvertisingMessage()
    {
        string[] laundatoryPhrases = new string[]
        {
            "The product is excellent.",
            "This is a great product.",
            "I use this product constantly.",
            "This is the best product from this category."
        };

        string[] laundatoryStories = new string[]
        {
            "Now I feel better.",
            "I managed to change.", "It made some miracle.",
            "I can’t believe it, but now I am feeling great.",
            "You should try it, too. I am very satisfied."
        };

        string[] authorFirstNames = new string[]
        {
            "Dayan", "Stella", "Hellen", "Kate"
        };

        string[] authorLastNames = new string[]
        {
            "Johnson", "Peterson", "Charls"
        };

        string[] authorCities = new string[]
        {
            "London", "Paris", "Berlin", "New York", "Madrid"
        };

        string randomLaudatoryPhrase = RandomText(laundatoryPhrases);
        string randomLaudatoryStory = RandomText(laundatoryStories);
        string randomAuthorFirstName = RandomText(authorFirstNames);
        string randomAuthorLastname = RandomText(authorLastNames);
        string randomAuthorCity = RandomText(authorCities);

        Console.WriteLine("{0} {1} -- {2} {3}, {4}", randomLaudatoryPhrase, randomLaudatoryStory, randomAuthorFirstName, randomAuthorLastname, randomAuthorCity);
    }

    public static string RandomText(string[] texts)
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(texts.Length);
        string randomText = texts[randomIndex];

        return randomText;
    }


    // Ch 11 No. 10
    public static int SumOfNumbers(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    // Ch 11 No. 9
    public static int CalculateWorkdays(DateTime startDate, DateTime endDate, List<DateTime> publicHolidays, List<DateTime> workingSaturdays)
    {
        int workdaysCount = 0;

        // Iterate through each day in the date range
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            // Skip public holidays that are not working Saturdays
            if (publicHolidays.Contains(date) && !workingSaturdays.Contains(date))
            {
                continue;
            }

            // Count Monday to Friday as workdays
            if (date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday)
            {
                workdaysCount++;
            }

            // Count working Saturdays as workdays
            if (date.DayOfWeek == DayOfWeek.Saturday && workingSaturdays.Contains(date))
            {
                workdaysCount++;
            }
        }

        return workdaysCount;
    }

    // Ch 11 No. 6
    public static double TriangleArea(double side1, double side2, double side3)
    {
        double semiPerimeter = (side1 + side2 + side3) / 2d;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        return area;
    }

    public static double TriangleArea(double side, double altitude)
    {
        double area = 0.5 * side * altitude;
        return area;
    }

    public static double TriangleArea(double side1, double side2, int angle)
    {
        double angleInRadians = angle * (Math.PI / 180); // Convert angle to radians
        double area = 0.5 * side1 * side2 * Math.Sin(angleInRadians);
        return area;
    }
    // Ch 11 No. 5
    public static double Hypotenuse(double side1,  double side2)
    {
        double hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
        return hypotenuse;
    }
    // Ch 11 No. 4
    public static void UpTime()
    {
        // Get the total uptime in milliseconds
        int uptimeMilliseconds = Environment.TickCount;

        // Convert the uptime to TimeSpan
        TimeSpan uptime = TimeSpan.FromMilliseconds(uptimeMilliseconds);

        // Extract days, hours, and minutes from the TimeSpan
        int days = uptime.Days;
        int hours = uptime.Hours;
        int minutes = uptime.Minutes;

        // Print the result
        Console.WriteLine("The computer has been running for:");
        Console.WriteLine("{0} days, {1} hours, and {2} minutes", days, hours, minutes);
    }
    // Ch 11 No. 3
    public static string DayToday()
    {
        string day = DateTime.Now.DayOfWeek.ToString();

        return day;
    }
    // Ch 11 No. 2
    public static void RandomNumbersInARange()
    {
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randomNumber = random.Next(100, 201);
            Console.Write(randomNumber + " ");
        }
        Console.WriteLine();
    }
    // Ch 11 No. 1
    public static bool CheckLeapYear(int year)
    {
        return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
    }
    // Fibonacci From YouTube (Fibonacci using memoization)
    public static int FibonacciFromYouTube(int number)
    {
        int[] fibonacciSequence = new int[number + 1];
        if (number <= 1)
        {
            return number;
        }

        if (fibonacciSequence[number] != 0)
        {
            return fibonacciSequence[number];
        }
        
        int nthNumber = FibonacciFromYouTube(number - 1) + FibonacciFromYouTube(number - 2);

        fibonacciSequence[number] = nthNumber;

        return nthNumber;
    }

    // Ch 10 No. 8
    public static void AllSubsetOfSum(int[] array, int targetSum, int index, List<int> subset, int currentSum)
    {
        if (currentSum == targetSum)
        {
            PrintSubset(subset);
            return;
        }

        if (index >= array.Length)
        {
            return;
        }

        // Include the current element in the subset
        subset.Add(array[index]);
        AllSubsetOfSum(array, targetSum, index + 1, subset, currentSum + array[index]);

        // Exclude the current element from the subset
        subset.RemoveAt(subset.Count - 1);
        AllSubsetOfSum(array, targetSum, index + 1, subset, currentSum);

    }

    static void PrintSubset(List<int> subset)
    {
        Console.WriteLine(string.Join(" + ", subset) + " = " + subset.Sum());
    }
    // Ch 10 No. 7
    public static void GeneratePermutationsRecursive(int[] permutation, bool[] used, int index, int n)
    {
        if (index == n)
        {
            PrintCombinations(permutation);
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                permutation[index] = i;
                GeneratePermutationsRecursive(permutation, used, index + 1, n);
                used[i] = false;
            }
        }
    }

    //Ch 10 No. 6
    public static void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            // Recursively sort the first and second halves
            MergeSortRecursive(array, left, middle);
            MergeSortRecursive(array, middle + 1, right);

            Merge(array, left, middle, right);
        }
    }

    // Ch 10 No. 5
    public static void GenerateSubsetsIterative(string[] set)
    {
        int n = set.Length;
        int totalSubsets = 1 << n; // 2 ^ n subsets

        for (int i = 0; i < totalSubsets; i++)
        {
            Console.Write("{");
            for (int j = 0; j < n; j++)
            {
                // Check if j-th bit in the i is set
                if ((i & (1 << j)) != 0)
                {
                    Console.Write(set[j] + " ");
                }
            }
            Console.WriteLine("}");
        }
    }
    public static void GenerateSubsetsRecursive(string[] set, string[] currentSubset, int index)
    {
        if (index == set.Length)
        {
            PrintSubset(currentSubset);
            return;
        }

        // Include the current element
        string[] newSubset = new string[currentSubset.Length + 1];  
        Array.Copy(currentSubset, newSubset, currentSubset.Length);
        newSubset[newSubset.Length - 1] = set[index];
        GenerateSubsetsRecursive(set, newSubset, index + 1);

        // Exclude the current element
        GenerateSubsetsRecursive(set, currentSubset, index + 1);
    }

    public static void PrintSubset(string[] subset)
    {
        Console.WriteLine("{" + string.Join(",", subset) + "}");
    }
    // Ch 10 No. 4
    public static void GenerateSubsetsIterative(string[] set, int k)
    {
        int n = set.Length;
        int totalSubsets = (int)Math.Pow(2, n);

        // Generate all subsets
        for (int i = 0; i < totalSubsets; i++)
        {
            List<string> subset = new List<string>();
            int bitmask = i;
            for (int j = 0; j < n; j++)
            {
                if ((bitmask & (1 << j)) != 0)
                {
                    subset.Add(set[j]);
                }
            }
            if (subset.Count == k)
            {
                PrintStringCombination(subset);
            }
        }
    }
    public static void PrintStringCombination(List<string> combinations)
    {
        Console.Write("(" + string.Join(" ", combinations) + "), " + " ");
    }

    public static void GenereateStringCombinationsRecursive(int k, int n, int index, int start, string[] combination, string[] setOfStrings)
    {
        if (k == index)
        {
            PrintStringCombination(combination);
            return;
        }

        for (int i = start; i < n;  i++)
        {
            combination[index] = setOfStrings[i];
            GenereateStringCombinationsRecursive(k, n, index + 1, i + 1, combination, setOfStrings);
        }
    }

    public static void PrintStringCombination(string[] combinations)
    {
        Console.Write("(" + string.Join(" ", combinations) + "), " + " ");
    }
    // Ch 10 No. 2
    public static void GenerateVariationIterative(int n, int k)
    {
        int[] variation = new int[k];

        for (int i = 0; i < k; i++)
        {
            variation[i] = 1; // Initialize each element to 1 instead of 0
        }

        while (true)
        {
            // Print current variation
            PrintCombinations(variation);

            // Find right most element that can be incremented
            int index = k - 1;

            while (index >= 0 && variation[index] == n)
            {
                index--;
            }

            if (index < 0)
            {
                break;
            }

            // Increment the element and set all following elements to 0
            variation[index]++;
            for (int i = index + 1; i < k; i++)
            {
                variation[i] = 1;
            }
        }
    }
    public static void GenerateVariationsRecursive(int k, int n, int index, int[] variation)
    {
        if (index == k)
        {
            PrintCombinations(variation);
            return;
        }    

        for (int i = 1; i < n; i++)
        {
            variation[index] = i;
            GenerateVariationsRecursive(i, k, index + 1, variation);
        }
    }
    // Ch 10 No. 3
    public static void GenerateCombinationsIterative(int n, int k)
    {
        int[] combination = new int[k];

        for (int i = 0; i < k; i ++)
        {
            combination[i] = 1;
        }

        while (true)
        {
            // Print the current combination
            Console.WriteLine(string.Join(" ", combination));

            int index = k - 1;
            while (index >= 0 && combination[index] == n)
            {
                index--;
            }

            if (index < 0)
            {
                break;
            }

            combination[index]++;
            for (int i = index + 1; i < k; i++)
            {
                combination[i] = combination[index];
            }
        }
    }
    public static void GenerateCombinationsRecursive(int k, int n, int index, int start, int[] combination)
    {
        if (index == k)
        {
            PrintCombinations(combination);
            return;
        }

        for (int i = start; i <= n; i++)
        {
            combination[index] = i;
            GenerateCombinationsRecursive(k, n, index + 1, i, combination);
        }
    }

    public static void PrintCombinations(int[] combinations)
    {
        Console.Write("(" + string.Join(" ", combinations) + "), " + " ");
    }

    // Ch 10 No. 1

    public static void NestedLoopSimulation(int n, int currentLoop, int[] loops)
    {
        if (n == currentLoop)
        {
            PrintLoops(loops);
            return;
        }
        
        for (int i = 1; i < n;  i++)
        {
            loops[currentLoop] = i;
            NestedLoopSimulation(n, currentLoop + 1, loops);
        }
    }

    public static void PrintLoops(int[] loops)
    {
        Console.WriteLine(string.Join(" ", loops));
    }

    // Ch 9 No. 7
    public static void ReverseNumber(string number)
    {
        for (int i = number.Length-1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
    }

    // Ch 9 No. 6
    public static int FirstOccuranceGreaterThanNeighbors(int[] numbers)
    {
        for (int i = 1; i < numbers.Length-2; i++)
        {
            if (numbers[i] > numbers[i-1] && numbers[i] > numbers[i+1])
            {
                return numbers[i];
            }
        }

        return -1;
    }

    // Ch 9 No. 5
    public static bool GreaterThanNeighbors(int[] numbers, int index)
    {
        bool result = false;

        if (index < 0 || index >= numbers.Length)
        {
            Console.WriteLine("Index out of bound");
            return false;
        }
        else if (index == 0 || index == numbers.Length - 1) 
        {
            return false;
        }
        else
        {
            result = numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1];
        }

        return result;
    }
    
    public static void GreaterThanNeighborsTest()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int index1 = -1;

        Console.WriteLine("Test 1: int[] array1 = { 1, 2, 3, 4, 5 }; int index1 = -1; " + (GreaterThanNeighbors(array1, index1) == false ? "Paased" : "Failed"));

        int[] array2 = { 42, 17, 93, 58, 29 };
        int index2 = 5;

        Console.WriteLine("Test 2: int[] array2 = { 42, 17, 93, 58, 29 }; int index2 = 5; " + (GreaterThanNeighbors(array2, index2) == false ? "Paased" : "Failed"));

        int[] array3 = { 7, 7, 7, 7, 7 };
        int index3 = 2;
        Console.WriteLine("Test 3: int[] array3 = { 7, 7, 7, 7, 7 }; int index3 = 2; " + (GreaterThanNeighbors(array3, index3) == false ? "Paased" : "Failed"));

        int[] array4 = { -5, -1, 0, 3, 8 };
        int index4 = 3;
        Console.WriteLine("Test 4: int[] array4 = { -5, -1, 0, 3, 8 }; int index4 = 3; " + (GreaterThanNeighbors(array4, index4) == false ? "Paased" : "Failed"));

        int[] array5 = { 4, 12, 7, 15, 9 };
        int index5 = 3;
        Console.WriteLine("Test 5: int[] array5 = { 4, 12, 7, 15, 9 }; int index5 = 3; " + (GreaterThanNeighbors(array5, index5) == true ? "Paased" : "Failed"));
    }
    // Ch 9 No. 4
    public static void CountOfNumberTest()
    {
        string[] numbers = new string[] { "1", "2", "3", "1", "2", "5", "6", "1" };
        int target = 1;


        Console.WriteLine("Test 1: string[] numbers = new string[] { \"1\", \"2\", \"3\", \"1\", \"2\", \"5\", \"6\", \"1\" }; int target = 1; \n" +
            "CountOfNumber(numbers, target) " + (CountOfNumber(numbers, target) == 3 ? "Passed" : "Failed"));
    }
    public static int CountOfNumber(string[] numbers, int target)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (int.Parse(numbers[i]) == target)
            {
                count++;
            }
        }

        return count;
    }

    // Ch 9 No. 3
    public static string NameOfLastDigit(string number)
    {
        char[] digits = number.ToCharArray();
        int length = digits.Length;
        string nameOfLastDigit = DigitToName(digits[length-1].ToString());

        return nameOfLastDigit;
    }

    public static string DigitToName(string digit)
    {
        Dictionary<int, string> numberToName = new Dictionary<int, string>()
        {
            [0] = "Zero",
            [1] = "One",
            [2] = "Two",
            [3] = "Three",
            [4] = "Four",
            [5] = "Five",
            [6] = "Six",
            [7] = "Seven",
            [8] = "Eight",
            [9] = "Nine"
        };

        int number = int.Parse(digit);
        string nameOfNumber = numberToName[number];

        return nameOfNumber;
    }
    // Ch 9 No. 2
    public static int GetMaxOfThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
    {
        if(GetMax(firstNumber, secondNumber) < thirdNumber)
        {
            return thirdNumber;
        }
        else
        {
            return GetMax(firstNumber, secondNumber);
        }
    }
    public static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber < secondNumber)
        {
            return secondNumber;
        }
        else
        {
            return firstNumber;
        }
    }

    // Ch 9 No. 1
    public static string Greeting(string name)
    {
        return "Hello, " + name;
    }
    // Ch 8 No. 11
    public static int RomanToArabicNumerals(string romanNumber)
    {
        int sum = 0;

        Dictionary<char, int> romanToDecimal = new Dictionary<char, int>()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };

        for (int i = 0; i < romanNumber.Length; i++)
        {
            // Get the value of the current Roman numeral
            int current = romanToDecimal[romanNumber[i]];

            // Check if the next Roman numeral exists and is larger
            if (i + 1 < romanNumber.Length && romanToDecimal[romanNumber[i + 1]] > current)
            {
                // If the next numeral is larger, subtract the current numeral value
                sum -= current;
            }
            else
            {
                // Otherwise, add the current numeral value
                sum += current;
            }
        }

        return sum;

    }
    // Ch 8 No. 10
    public static int BinaryToDecimalHornerScheme(string binaryValue)
    {
        int sum = 0;

        foreach (char digit in binaryValue)
        {
            // Convert the character 'digit' to its integer value (0 or 1)
            int binaryDigit = digit - '0';  // '0' -> 0, '1' -> 1

            // Apply Horner's Scheme
            sum = sum * 2 + binaryDigit;
        }

        return sum;

    }
    // Ch 8 No. 9
    public static void BinaryToHexadecimal(string binaryValue)
    {
        // Call BinaryToDecimal Method
        // Call DecimalToHexadecimal Method
    }

    // Ch 8 No. 8
    public static void HexadecimalToBinary(string hexValue)
    {
        // Call HexadecimalToDecimal method
        // Call DecimalToBinary method
    }

    // Ch 8 No. 7
    public static double HexadecimalToDecimal(string hexValue)
    {
        double sum = 0;
        char[] hexDigits = hexValue.ToCharArray();

        Dictionary<char, int> hexadecimalNumbers = new Dictionary<char, int>()
        {
            ['0'] = 0,
            ['1'] = 1,
            ['2'] = 2,
            ['3'] = 3,
            ['4'] = 4,
            ['5'] = 5,
            ['6'] = 6,
            ['7'] = 7,
            ['8'] = 8,
            ['9'] = 9,
            ['A'] = 10,
            ['B'] = 11,
            ['C'] = 12,
            ['D'] = 13,
            ['E'] = 14,
            ['F'] = 15
        };

        for (int i = 0; i < hexDigits.Length; i++)
        {
            sum += hexadecimalNumbers[hexDigits[i]] * Math.Pow(16, hexDigits.Length - 1 - i);
        }

        return sum;
    }
    // Ch 8 No. 6
    public static string DecimalToHexadecimal(int number)
    {
        if (number == 0)
        {
            return "0";
        }

        StringBuilder hexadecimal = new StringBuilder();

        Dictionary<int, string> hexadecimalNumbers = new Dictionary<int, string>()
        {
            [0] = "0",
            [1] = "1",
            [2] = "2",
            [3] = "3",
            [4] = "4",
            [5] = "5",
            [6] = "6",
            [7] = "7",
            [8] = "8",
            [9] = "9",
            [10] = "A",
            [11] = "B",
            [12] = "C",
            [13] = "D",
            [14] = "E",
            [15] = "F"
        };

        while (number > 0)
        {
            int remainder = number % 16;
            hexadecimal.Insert(0, hexadecimalNumbers[remainder]);
            number /= 16;
        }

        return hexadecimal.ToString();
    }
    // Ch 8 No. 5
    public static double[] BinaryToDecimal(string binary)
    {
        char[] zeroOrOne = binary.ToCharArray();
        double[] numbers = new double[zeroOrOne.Length];
        int count = 0;

        for (int i = zeroOrOne.Length - 1;  i >= 0 ; i--)
        {
            numbers[count] = (int.Parse(zeroOrOne[count].ToString())) * Math.Pow(2, i);
            count++;
        }
        
        return numbers;
    }
    // Ch 8 No. 4
    public static void DecimalToBinary(int number)
    {
        StringBuilder binary = new StringBuilder();

        int newNumber;
        int dividedNumber;
        int tempNumber = number;

        do
        {

            dividedNumber = tempNumber;
            newNumber = dividedNumber;

            if (newNumber / 2 < 1)
            {
                binary.Append('1');
                break;
            }
            else if (newNumber % 2 == 0)
            {
                binary.Append('0');
            }
            else
            {
                binary.Append('1');
            }
            tempNumber = newNumber / 2;

        } while (true);

        char[] binaryResult = binary.ToString().ToCharArray();

        for (int i = binaryResult.Length - 1; i >= 0; i--)
        {
            Console.Write(binaryResult[i] + " ");
        }
    }
    // Ch 7 No. 22
    public static int[] MinimalIncreasing(int[] array)
    {
        int n = array.Length;
        int[] lengths = new int[n];
        int[] previous = new int[n];

        for (int i = 0; i < n; i++)
        {
            lengths[i] = 1;
            previous[i] = -1;
        }

        int maxLength = 1;
        int maxIndex = 0;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] > array[j] && lengths[i] < lengths[j] + 1)
                {
                    lengths[i] = lengths[j] + 1;
                    previous[i] = j;
                }
            }
            if (lengths[i] > maxLength)
            {
                maxLength = lengths[i];
                maxIndex = i;
            }
        }

        int[] longestSubsequence = new int[maxLength];
        int k = maxLength - 1;

        while (maxIndex >= 0)
        {
            longestSubsequence[k] = array[maxIndex];
            k--;
            maxIndex = previous[maxIndex];
        }

        return longestSubsequence;
    }
    // Ch 7 No. 21
    public static bool FindSubsetSum(int[] array, int S, int K)
    {
        int n = array.Length;

        // Iterate through all combinations of K elements
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (K == 3) // Check if exactly 3 elements are needed
                    {
                        if (array[i] + array[j] + array[k] == S)
                        {
                            Console.WriteLine($"Combination found: {array[i]}, {array[j]}, {array[k]}");
                            return true;
                        }
                    }
                    else
                    {
                        // Extend the logic for K elements by adding more nested loops or another method
                    }
                }
            }
        }
        return false;
    }

    // Ch 7 No. 19
    public static void Prime()
    {
        for (int i = 1; i < 10000000; i++)
        {
            for (int j = 2; j <= 10000000; j++)
            {
                if (i % j == 0 && i != j)
                {
                    break;
                }
                else if(j == 10000000)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    // Ch7 No. 17
    // Iterative mergesort function to sort numbers[0...n-1]
    public static void MergeSort(int[] numbers, int n)
    {
        // For the current size of subarrays to be merged
        // subarray sizes start from 1 and double each time
        for (int currSize = 1; currSize <= n -1; currSize++)
        {
            for (int leftStart = 0; leftStart < n - 1; leftStart += 2 * currSize)
            {
                // Find ending point of the left subarray.
                // mid+1 is the starting point of the right subarray
                int mid = Math.Min(leftStart + currSize, n -1);

                int righEnd = Math.Min(leftStart + 2 * currSize - 1, n - 1);

                Merge(numbers, leftStart, mid, righEnd);
            }
        }
    }
    // Method to merge two subarrays of numbers[]
    public static void Merge(int[] array, int left, int middle, int right)
    {
        // Calculate the sizes of the two subarrays to be merged
        int leftArraySize = middle - left + 1;
        int rightArraySize = right - middle;

        // Create temporary arrays
        int[] leftArray = new int[leftArraySize];
        int[] rightArray = new int[rightArraySize];

        // Copy data to temporary arrays
        for (int i = 0; i < leftArraySize; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < rightArraySize; j++)
            rightArray[j] = array[middle + 1 + j];

        // Initial indices of the two subarrays
        int leftIndex = 0, rightIndex = 0;

        // Initial index of the merged subarray
        int mergedIndex = left;

        // Merge the temporary arrays back into the original array
        while (leftIndex < leftArraySize && rightIndex < rightArraySize)
        {
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        // Copy any remaining elements of the left array, if any
        while (leftIndex < leftArraySize)
        {
            array[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // Copy any remaining elements of the right array, if any
        while (rightIndex < rightArraySize)
        {
            array[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }
    // Utility function to print the array
    public static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
    // Ch 7 No. 16
    public static int BinarySearch(int[] numbers, int target)
    {
        int start = 0, end = numbers.Length - 1;

        while(start < end)
        {
            int middle = (start + end) / 2;

            if (numbers[middle] == target)
            {
                return middle;
            }
            else if (target < numbers[middle])
            {
                end = middle - 1;
            }
            else if (target > numbers[middle])
            {
                start = middle + 1;
            }
        }

        return -1;
    }

    // Ch 7 No. 15
    public static int[] WordIndecies(string word)
    {
        int count = 0;

        char[] alphabets = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        string lowerCaseWord = word.ToLower();
        char[] letters = lowerCaseWord.ToCharArray();

        int[] indecies = new int[letters.Length];

        foreach (char letter in letters)
        {
            for (int i = 0; i < alphabets.Length; i++)
            {
                if(letter == alphabets[i])
                {
                    indecies[count] = i;
                    count++;
                }
            }
        }

        return indecies;
    }

    // CH 7 No. 14
    public static (string element, int length) FindLongestSequence(string[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        (string element, int length) longestSequence = ("", 0);

        // Check Rows
        for (int i = 0; i < rows; i++)
        {
            (string element, int length) rowSequence = FindLongestInRow(matrix, i);
            if (rowSequence.length > longestSequence.length)
            {
                longestSequence = rowSequence;
            }
        }

        // Check columns
        for (int j = 0; j < cols; j++)
        {
            (string element, int length) colSequence = FindLongestInColumn(matrix, j);
            
            if (colSequence.length > longestSequence.length)
            {
                longestSequence = colSequence;
            }
        }

        // Check diagonals
        for (int i = 0; i < rows; i++)
        {
            (string element, int length) diagSequence = FindLongestInDiagonal(matrix, i, 0);
            
            if (diagSequence.length > longestSequence.length)
            {
                longestSequence = diagSequence;
            }

            diagSequence = FindLongestInDiagonal(matrix, i, cols - 1, false);

            if (diagSequence.length > longestSequence.length)
            {
                longestSequence = diagSequence;
            }
        }
        return longestSequence;
    }
    public static (string element, int length) FindLongestInDiagonal(string[,] matrix, int row, int col, bool topLeftToBottomRight = true)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        string current = matrix[row, col];
        int maxLength = 1;
        int currentLength = 1;

        while (row < rows -1 && col < cols - 1 && row >= 0 && col >= 0)
        {
            row += topLeftToBottomRight ? 1 : 1;
            col += topLeftToBottomRight ? 1 : -1;

            if (row >= rows || col >= cols || col > 0) break;

            if (matrix[row, col] == current)
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            else
            {
                current = matrix[row, col];
                currentLength = 1;
            }
        }

        return (current, maxLength);
    }
    public static (string element, int length) FindLongestInColumn(string[,] matrix, int col)
    {
        int rows = matrix.GetLength(0);
        string current = matrix[0, col];
        int maxLength = 1;
        int currentLength = 1;

        for (int i = 1; i < rows; i++)
        {
            if (matrix[i, col] == current)
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            else
            {
                current = matrix[i, col];
                currentLength = 1;
            }
        }

        return (current, maxLength);
    }

    public static (string element, int length) FindLongestInRow(string[,] matrix, int row)
    {
        int cols = matrix.GetLength(1);
        string current = matrix[row, 0];
        int maxLength = 1;
        int currentLength = 1;

        for (int j = 1; j < cols; j++)
        {
            if (matrix[row, j] == current)
            {
                currentLength++;
                if(currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            else
            {
                current = matrix[row, j];
                currentLength = 1;
            }
        }

        return (current, maxLength);
    }

    // Ch 7 No. 13
    public static void MaximumSumMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        int count = 1;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestColumn = 0;

        Console.WriteLine("Enter numbers of your matrix. After each number press enter: ");
         
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Row {0}", count);
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
            count++;
        }

        for (int i = 0; i < rows-2; i++)
        {
            for (int j = 0; j < columns-2; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + 
                    matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                    matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = i;
                    bestColumn = j;
                }
            }
        }
        Console.WriteLine("Best platform is: ");
        Console.WriteLine("{0} {1} {2}", matrix[0,0], matrix[0,1], matrix[0,2]);
        Console.WriteLine("{0} {1} {2}", matrix[1, 0], matrix[1, 1], matrix[1, 2]);
        Console.WriteLine("{0} {1} {2}", matrix[2,0], matrix[2,1], matrix[2,2]);
        Console.WriteLine("Best sum: {0}", bestSum);
    }

    /*// ENGLIGHTEN DESIGN PREP

    // C# Easy questions No. 30
    // I do not know how to soleve the Print the first N prime numbers problem

    // C# Easy questions No. 29
    public static void IntersectionArray(int[] array1, int[] array2)
    {
        List<int> intersection = new List<int>();


        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    intersection.Add(array1[i]);
                }
            }
        }

        foreach (int number in  intersection)
        {
            Console.Write(number + " ");
        }
    }

    // C# Easy questions No. 28
    public static bool Anagram(string word1, string word2)
    {
        bool isAngram = true;
        foreach (char letter in word1)
        {
            if (!(word2.Contains(letter)))
            {
                isAngram = false;
                break;
            }
        }

        return isAngram;
    }

    // C# Easy questions No. 27
    public static void ReverseNumber(int number)
    {
        char[] digits = number.ToString().ToCharArray();

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
    }

    // C# Easy questions No. 26
    public static int CountWords(string sentence)
    {
        string[] words = sentence.Split(' ');

        return words.Length;
    }

    // C# Easy questions No. 25
    public static double SecondLargest(double[] array)
    {
        int length = array.Length;
        int count = 0;
        double temp = 0;

        while (count != Math.Pow(length, 2))
        {

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            count++;
        }

        return array[1];
    }

    // C# Easy questions No. 24
    public static double Power(double number, double power)
    {
        double result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }

    // C# Easy questions No. 23
    public static void DecimalToBinary(int number)
    {
        StringBuilder binary = new StringBuilder();

        int newNumber;
        int dividedNumber;
        int tempNumber = number;

        do
        {
            
            dividedNumber = tempNumber;
            newNumber = dividedNumber;

            if (newNumber / 2 < 1)
            {
                binary.Append('1');
                break;
            }
            else if (newNumber % 2 == 0)
            {
                binary.Append('0');
            }
            else
            {
                binary.Append('1');
            }
            tempNumber = newNumber / 2;

        } while(true);

        char[] binaryResult = binary.ToString().ToCharArray();

        for (int i = binaryResult.Length - 1; i >= 0; i--)
        {
            Console.Write(binaryResult[i] + " ");
        }
    }

    // C# Easy questions No. 22 
    // I do not know how to solve remove duplicates in an array

    // C# Easy questions No. 21
    public static void MergeArrays(int[] array1, int[] array2)
    {
        int[] array3 = new int[array1.Length + array2.Length];

        for(int i = 0;  i < array1.Length; i++)
        {
            array3[i] = array1[i];
        }
        for (int i = 0; i < array2.Length; i++)
        {
            array3[i + array1.Length] = array2[i];
        }

        foreach(int i in array3)
        {
            Console.Write(i + " ");
        }
        
    }

    // C# Easy questions No. 20
    public static int SumArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    // C# Easy quetions No. 19
    public static void BubbleSort(int[] array)
    {
        int length = array.Length;
        int count = 0;
        int temp = 0;

        while (count != Math.Pow(length, 2))
        {
            
            for (int i = 0; i < length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            count++;
        }

        foreach(int i in array)
        {
            Console.Write(i + " ");
        }
        
        
    }

    // C# Easy questions No. 17
    // I do not know how to solve prime number problem 

    // C# Easy questions No. 18
    public static void MaximumMinimum(int[] array)
    {
        int minimum = array[0];
        int maximum = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (maximum > array[j])
                {
                    maximum = array[i]; 
                }
                if (minimum < array[j])
                {
                    minimum = array[i];
                }
            }
        }

        Console.WriteLine("Maximum value: {0} \nMinimum: {1}", maximum, minimum);
    }

    // C# Easy questions No. 16
    public static int GCD(int x, int y)
    {
        int greatestCommonDenominator = 1;
        int[] factorsOfx = new int[x];
        int[] factorsOfy = new int[y];

        int xcount = 0;
        int ycount = 0;

        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                factorsOfx[xcount] = i;
                xcount++;
            }
        }

        for (int i = 1; i <= y; i++)
        {
            if (x % i == 0)
            {
                factorsOfy[ycount] = i;
                ycount++;
            }
        }

        for(int i = 0; i < factorsOfx.Length; i++)
        {
            for (int j = 0; j < factorsOfy.Length; j++)
            {
                if (factorsOfx[i] == factorsOfy[j])
                {
                    greatestCommonDenominator = factorsOfx[i];
                    break;
                }
            }

            if (greatestCommonDenominator != 1) { break; }
        }

        return greatestCommonDenominator;
    }

    // C# Easy questions No. 15
    public static int RandomWithinRange(int numb1, int numb2)
    {
        Random randomNumber = new Random();

        return randomNumber.Next(numb1, numb2);
    }

    // C# Easy questions No. 14
    public static int CountVowels(string word)
    {
        int count = 0;
        char[] letters = word.ToCharArray();
        string vowels = "aeiou";

        foreach (char letter in letters)
        {
            if (vowels.Contains(letter))
            {
                count++;
            }
        }

        return count;
    }

    // C# Easy questions No. 13
    public static void LeapYear(int year)
    {
       if (year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine("This is a leap year.");
        }
       else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
        {
            Console.WriteLine("This is a leap year.");
        }
        else
        {
            Console.WriteLine("This year is not a leap year.");
        }

    }

    // C# Easy questions No. 12
    public static double AreaCircle(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);

        return Math.Round(area, 2);
    }

    // C# Easy questions No. 11
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = ((9 / 5) * celsius) + 32;

        return fahrenheit;
    }

    // C# Easy questions No. 10
    public static int LengthOfString(string str)
    {
        return str.Length;
    }

    // C# Easy questions No. 9
    public static int SumOfDigits(int number)
    {
        char[] charNumbers = number.ToString().ToCharArray();

        int sum = 0;

        foreach (char cha in charNumbers)
        {
            sum += int.Parse(cha.ToString());
        }

        return sum;
    }

    // C# Easy questions No. 8
    public static void FibonacciSequence(int num)
    {
        int count = 0, zero = 0, one = 1;
        int[] fibonacci = new int[num];
        int[] numbers = new int[num];

        fibonacci[0] = zero;
        fibonacci[1] = one;

        for (int i = 2; i < num; i++)
        {
            fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
        }

        foreach (int i in fibonacci)
        {
            Console.Write(i + " ");
        }
    }

    // C# Easy questions No. 7
    public static void Palindrome(string str)
    {
        char[] letters = str.ToCharArray();
        int length = letters.Length;

        for (int i = 0, j = length -1; i < length / 2; i++, j--)
        {
            if (letters[i] != letters[j])
            {
                Console.WriteLine("This is not a palindrome.");
                return;
            }
        }

        Console.WriteLine("This string is a palindrome.");
    }

    // C# Easy questions No. 6
    public static string ReverseString(string s)
    {
        char[] chars = s.ToCharArray();
        char[] newChars = new char[chars.Length];

        for (int i = chars.Length - 1;  i >= 0 ; i--)
        {
            int j = chars.Length - 1;
            newChars[j - i] = chars[i];
        }

        return new string(newChars);
    }

    // C# Easy questions No. 5
    public static int Factorial(int number)
    {
        int factorial = 1;
        

        while (number > 0)
        {
            factorial = factorial * number;
            number--;
        }

        return factorial;
    }

    // C# Easy questions No. 4
    public static void LargestNumber()
    {
        int index = 0;

        int[] numbers = new int[3];

        Console.WriteLine("Enter first number: ");
        numbers[0] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        numbers[1] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        numbers[2] = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[index])
            {
                index = i;
            }
        }

        Console.WriteLine("The largest number is: {0}", numbers[index]);
    }

    // C# Easy questions No. 3
    public static void EvenOddNumbers(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is Even.");
        }
        else
        {
            Console.WriteLine("Number is odd.");
        }
    }

    // C# Easy questions No. 2
    public static void SwapTwoNumbers()
    {
        Console.Write("Enter two digit number: ");

        int num = int.Parse(Console.ReadLine());

        while (num.ToString().Length != 2)
        {
            Console.WriteLine("Please enter number with two digits: ");
            num = int.Parse(Console.ReadLine());
        }

        var temp = num.ToString().ToCharArray();

        Console.WriteLine(temp[1] + "" + temp[0]);
    }

    // C# Easy questions No. 1
    public static void PrintHello()
    {
        Console.WriteLine("Hello World");
    }

    // Englighten Design
    public static int Moves(int[] array)
    {
        int N = array.Length;
        int target = 10;
        int arraySum = array.Sum();

        int excess = 0;
        int moves = 0;

        if (arraySum != target * N)
        {
            return -1;
        }

        for (int i = 0; i < N; i++)
        {
            excess += array[i] - target;
            moves += Math.Abs(excess);
        }

        return moves;
    }*/

    // Ch 7 No. 12
    public static void CreateSqureMatrices(int size)
    {
        int[,] matrix = new int[size, size];
        int number = 1;

        for (int sum = 0; sum <= 2 * (size - 1); sum++)
        {
            for (int row = 0; row < size; row++)
            {
                int col = sum - row;
                if (col >= 0 && col < size)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
        }

        int sizes = matrix.GetLength(0);

        for (int row = 0; row < sizes; row++)
        {
            for (int col = 0; col < sizes; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
        //int[,] matrix = new int[size,size];
        int[,] matrix2 = new int[size, size];
        int count = 0, count2 = 0, count3 = 0, count4 = 0;
        bool change = false;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                count++;
                matrix[j, i] = count;
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            if (!change)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    count2++;
                    matrix2[j, i] = count2;
                }
                change = true;
            }
            else
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    count2++;
                    matrix2[j, i] = count2 + (size - (j + 1));
                }
                change = false;
            }

        }

        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
     // Ch 7 No. 11
    public static void SumOfNumberS(int[] array, int S)
    {
        
        int currentSum = 0;
        int startIndex = 0;
        

        for (int endIndex = 0; endIndex < array.Length; endIndex++)
        {
            currentSum += array[endIndex];

            while (currentSum > S && startIndex < endIndex)
            {
                currentSum -= array[startIndex];
                startIndex++;
            }

            if (currentSum == S)
            {
                Console.WriteLine("Subsequence: ");
                for (int j = startIndex; j <= endIndex; j++)
                {
                    Console.Write(array[j] + " ");
                }
                return;
            }

        }

        Console.WriteLine("No sequence was found.");
    }

    // Ch 7 No. 10 
    public static void FrequentlyOccurance(int[] array)
    {
        int count = 0;
        int frequentNumber = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int currentCount = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    currentCount++;
                }
            }

            if (currentCount > count)
            {
                count = currentCount;
                frequentNumber = array[i];
            }
        }

        Console.Write("Frequent number: {0} ", frequentNumber);
        Console.WriteLine("Frequency: {0}", count);
    }

    // Ch 7 No. 9
    public static void MaximumSumSequence(int[] array)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int maxLength = 0;
        int tempIndex = 0;
        int currentLength = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            


            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
                startIndex = tempIndex;
            }

            if (currentSum < 0)
            {
                tempIndex = i + 1;
                currentSum = 0; 
            }
        }

        Console.WriteLine("Subsequence: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("The maximal sum is: {0} ", maxSum);
    }

    // Ch 7 No. 8
    public static void SelectionSort(double[] array)
    {
        

        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }    
            }

            double temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }

        Console.WriteLine("Here is the sorted array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    // Ch 7 No. 7
    public static void MaximumSum()
    {
        Console.Write("Enter number of elements for your array: ");
        var N = int.Parse(Console.ReadLine());

        Console.Write("Enter length of consecutive maximal sum less than {0}: ", N);
        var K = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers for you array: " , N);

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = int.MinValue;
        int startIndex = 0;

        for (int i = 0; i < N - K; i++)
        {
            int currentSum = 0;

            for (int j = 0; j < K; j++)
            {
                currentSum += array[i + j];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = i;
            }
        }


        Console.WriteLine("The the K consecutive elements with maximal sum are: ");

        for (int i = startIndex; i < startIndex + K; i++)
        {
            Console.Write(array[i] + ", ");
        }

        Console.WriteLine("The maximal sum is: " +  maxSum);
    }

    //Ch 7 No. 6
    public static List<int> RandomConsecutiveNumbers(int[] array)
    {
        int n = array.Length;
        //Initialize arrays to store the length and previous index of the maximum increasing sequence ending at each positin
        int[] maxLength = new int[n];
        int[] previousIndex = new int[n];

        //Initialize the length of the longest increasing subsequence to 1 for each element and the previous index to -1
        for (int i = 0; i < n; i++)
        {
            maxLength[i] = 1;
            previousIndex[i] = -1;
        }

        //Itereate through each element of the array
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                //Check if the current element is greater than the previous element
                if (array[i] > array[j])
                {
                    //If incerasing sequence ending at i is longer than that ending at j, update it
                    if (maxLength[i] < maxLength[j] + 1)
                    {
                        maxLength[i] = maxLength[j] + 1;
                        previousIndex[i] = j;
                    }
                }
            }
        }

        //Find the index of the longest increasing subsequence
        int maxLengthIndex = 0;
        for (int i = 0; i < n; i ++)
        {
            if (maxLength[i] > maxLength[maxLengthIndex])
            {
                maxLengthIndex = i;
            }
        }

        //Reconstruct the longest increasing subsequence using the previous index array
        List<int> sequence = new List<int>();
        while (maxLengthIndex != -1)
        {
            sequence.Add(array[maxLengthIndex]);
            maxLengthIndex = previousIndex[maxLengthIndex];
        }

        sequence.Reverse();

        return sequence;

    }

    //Ch 7 No. 5
    public static void MaximumSequence(int[] array)
    {
        int startIndex = 0;
        //int maxIndex = 1;
        int currentLength = 1; 
        int maxLength = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if ((array[i] > array[i-1]) && (array[i] == (array[i-1] + 1)))
            {
                currentLength++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    //maxIndex = startIndex;
                }
            }
            else
            {
                currentLength = 1;
                startIndex = i;
            }
        }

        if (currentLength > 1)
        {
            for (int i = startIndex; i < startIndex + maxLength; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }

    //Ch 7 4
    public static void MaximumSequenceSameDigits(int[] digits)
    {
        int[] duplicateInts = new int[digits.Length];
        int intsIndex = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            if (i != digits.Length - 1)
            {
                if (digits[i] == digits[i + 1])
                {
                    duplicateInts[intsIndex] = digits[i];
                    duplicateInts[intsIndex + 1] = digits[i];
                }
            }
        }

        if (duplicateInts.Length == 0)
        {
            Console.WriteLine("There are no consecutive numbers");
        }
        else
        {
            for (int i = 0; i < intsIndex; i++)
            {
                Console.Write(" " + duplicateInts[i]);
            }
        }
    }

    //Ch 7 No. 3
    public static void LexicographicallyEqual(char[] array1, char[] array2)
    {
        if (array1.Length != array2.Length)
        {
            Console.WriteLine("Arrays are not equal");
        }
        else
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if ((array1[i] < array2[i]))
                {
                    Console.WriteLine("Array1 is laxicographically greater than array2");
                    
                }
                else
                {
                    Console.WriteLine("Array2 is laxicographically greater than array1");
                }
                break;
            }
        }

        
    }
    public static bool ArraysAreEqual<T>(T[] array1, T[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1[i].Equals(array2[i]))
                {
                    return false;
                }
            }
        }

        return true;
    }
    public static void TwentyElements()
    {
        int[] twentyElements = new int[20];

        for (int i = 0; i < twentyElements.Length; i++)
        {
            twentyElements[i] = (i+1)*5;
        }

        for (int i = 0; i < twentyElements.Length; i++)
        {
            Console.Write(twentyElements[i] + " ");
        }
    }
    public static void PascalTriangle()
    {
        const int HEIGHT = 12;
        // Allocate the array in a triangle form
        long[][] triangle = new long[HEIGHT + 1][];
        for (int row = 0; row < HEIGHT; row++)
        {
            triangle[row] = new long[row + 1];
        }

        // Calculate the Pascal's triangle
        triangle[0][0] = 1;
        for (int row = 0; row < HEIGHT - 1; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                triangle[row + 1][col] += triangle[row][col];
                //triangle[row + 1][col] = triangle[row + 1][col] + triangle[row][col];
                triangle[row + 1][col + 1] += triangle[row][col];
            }
        }

        // Print the Pascal's triangle
        for (int row = 0; row < HEIGHT; row++)
        {
            Console.Write("".PadLeft((HEIGHT - row) * 2));
            for (int col = 0; col <= row; col++)
            {
                Console.Write("{0,3} ", triangle[row][col]);
            }
            Console.WriteLine();
        }
    }
    public static void MaxPlatform2x2()
    {
        int[,] matrix = {
            { 0, 2, 4, 0, 9, 5 },
            { 7, 1, 3, 3, 2, 1 },
            { 1, 3, 9, 8, 5, 6 },
            { 4, 6, 7, 9, 1, 0 }
            };
        // Find the maximal sum platform of size 2 x 2
        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                long sum = matrix[row, col] + matrix[row, col + 1] +
                matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the result
        Console.WriteLine("The best platform is:");
        Console.WriteLine(" {0} {1}",
        matrix[bestRow, bestCol],
        matrix[bestRow, bestCol + 1]);
        Console.WriteLine(" {0} {1}",
        matrix[bestRow + 1, bestCol],
        matrix[bestRow + 1, bestCol + 1]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
}
            public static void ReadMultiArrays()
    {
        Console.Write("Enter the number of the rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of the columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the cells of the matrix:");

        for (int row  = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row  < matrix.GetLength(0); rows++)
        {
            for (int col = 0; col <matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row, col]);
            }
            Console.WriteLine(); 
        }
    }
    public static void MultiArrays()
    {
        int[,] matrix =
        {
            {1,2,3,4},
            {5,6,7,8},
        };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    public static void ArrayExample()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the values of the array:");

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        bool symmetric = true;
        for (int i = 0; i < array.Length / 2; i++)
        {
            if (array[i] != array[n - i - 2])
            {
                symmetric = false;
                break;
            }
        }
        Console.WriteLine("Is symmetric ? {0}", symmetric);
    }

    public static void SwitchStatement()
    {
        Console.WriteLine("Enter a digit (0 - 9): ");

        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 0: Console.WriteLine("Zero");
                break;
            case 1: Console.WriteLine("One");
                break;
            case 2: Console.WriteLine("Two");
                break;
            case 3: Console.WriteLine("Three");
                break;
            case 4: Console.WriteLine("Four");
                break;
            case 5: Console.WriteLine("Five");
                break;
            case 6: Console.WriteLine("Six");
                break;
            case 7: Console.WriteLine("Seven");
                break;
            case 8: Console.WriteLine("Eight");
                break;
            case 9: Console.WriteLine("Nine");
                break;
            default: Console.WriteLine("You enter wrong number");
                break;
        }
    }

    public static void VirtualColumns()
    {
        int myInt = 2;
        string haxValue = myInt.ToString("X");
        double positiveFraction = 3.4;
        double negativeFraction = -0.75;
        
        Console.Write("{0,-10}", haxValue);
        Console.Write("{0,-10}", positiveFraction);
        Console.WriteLine("{0,-10}", negativeFraction);
    }

    public static void Circle()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        double circum = 2 * Math.PI * radius;

        Console.WriteLine("Radius = {0}, Area = {1}, Parameter = {2}", radius, area, circum);
    }

    public static void sumThreeInt()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int result = num1 + num2 + num3;

        Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2, num3, result);
    }

    public static string FourDigit(int num)
    {
        string strNum = num.ToString();

        if (strNum.Length == 4)
        {
            string convertedNum = strNum[3].ToString() + strNum[2].ToString() + strNum[1].ToString() + strNum[0];
            return convertedNum;
        }

        return "Enter Four Digit Number";
        
    }

    public static byte Thirdbit(byte num)
    {
        //string thirdByte = num.ToString();

        return num;
    }

    public static bool DivisibleBy5And7(int num)
    {

        if ((num % 5  == 0) && (num % 7 == 0))
        {
            return true;
        }
        return false;
    }

    public static double AreaOfTrapezoid(double a, double b, double h)
    {
        return (((a + b) / 2) * h);
    }
    public static string OddOrEven(int num)
    {
        if (num % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
    public static void Sequence()
    {
        int[] numbers = Enumerable.Range(0, 101).ToArray();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + "," + " ");
            }
            else { Console.Write("-"+number + "," + " ");}
        }
    }

}


