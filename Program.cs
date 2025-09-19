using System.IO;
using System.Text.RegularExpressions;
using static AkvelonFizzBuzz.Program;

namespace AkvelonFizzBuzz
{
    internal class Program
    {

        public class DetectorResult
        {
            public string OutputString { get; set; }
            public int Count { get; set; }
        }

        public class FizzBuzzDetector
        {
            public DetectorResult getOverlappings(string stringTemp)
            {
                int alphanumeric = 0;
                int totalReplaced = 0;
                if (stringTemp == null || stringTemp.Length < 7 || stringTemp.Length > 100)
                {
                    throw new ArgumentException("String must be between 7 and 100 characters long and not null");
                }

                var stringParts = Regex.Split(stringTemp, "([^A-Za-z0-9']+)");

                for (int i = 0; i < stringParts.Length; i++)
                {
                    if (Regex.IsMatch(stringParts[i], @"^[A-Za-z0-9']+$"))

                    {
                        alphanumeric++;

                        if (alphanumeric % 3 == 0 && alphanumeric % 5 == 0)
                        {
                            stringParts[i] = "FizzBuzz";
                            totalReplaced++;
                        }
                        else if (alphanumeric % 3 == 0)
                        {
                            stringParts[i] = "Fizz";
                            totalReplaced++;
                        }
                        else if (alphanumeric % 5 == 0)
                        {
                            stringParts[i] = "Buzz";
                            totalReplaced++;
                        }
                    }
                }

                return new DetectorResult
                {
                    OutputString = string.Join("", stringParts),
                    Count = totalReplaced
                };
            }
        }
            static void Main(string[] args)
            {
            string input = "Mary had a little lamb\n" +
                "Little lamb, little lamb\n" +
                "Mary had a little lamb\n" +
                "It's fleece was white as snow";

            FizzBuzzDetector detector = new FizzBuzzDetector();
            DetectorResult result = detector.getOverlappings(input);
            Console.WriteLine("Modified String:\n" + result.OutputString);
            Console.WriteLine("\nTotal Replacements: " + result.Count);
            Console.WriteLine();
            Tests.RunTests();
        }
        }

    internal class Tests {
        public static void RunTests()
        {
            string input = "Mary had a little lamb\n" +
             "Little lamb, little lamb\n" +
             "Mary had a little lamb\n" +
             "It's fleece was white as snow";

            FizzBuzzDetector detector = new FizzBuzzDetector();

            // Test 1 returns the counts for replaced words
            var testOne = detector.getOverlappings(input);
            Console.WriteLine("TEST 1");
            Console.WriteLine(testOne.Count == 9 ? "PASS" : "FAIL");

            Console.WriteLine();

            // Test 2 checks if exception works
            Console.WriteLine("TEST 2");
            try
            {
                detector.getOverlappings("test");
                Console.WriteLine("FAIL");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("PASS");
            }

            Console.WriteLine();

            // Test 3 checks punctuation
            var testThree = detector.getOverlappings("One, two three! Four five six.");
            Console.WriteLine("TEST 3");
            Console.WriteLine(testThree.Count == 3 ? "PASS" : "FAIL");

            Console.WriteLine();

            //Test 4 should not replace words
            var tempInput = "Hello World";
            var testFour = detector.getOverlappings(tempInput);
          
            Console.WriteLine("TEST 4");
            if (testFour.OutputString == "Hello World" && testFour.Count == 0)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
                Console.WriteLine("Got: " + testFour.OutputString + " | Count=" + testFour.Count);
            }

            Console.WriteLine();

            // Test 5 Fifteenth word should be FizzBuzz (word 3 is Fizz and word 5 is Buzz -> word 15 is FizzBuzz)
            Console.WriteLine("TEST 5");
            string tempInput2 = "one two three four five six seven eight nine ten eleven twelve thirteen fourteen fifteen";
            var testFive = detector.getOverlappings(tempInput2);

            if (testFive.OutputString.Contains("FizzBuzz") && testFive.Count >= 1)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
                Console.WriteLine("Got: " + testFive.OutputString);
            }


        }
    }
    }