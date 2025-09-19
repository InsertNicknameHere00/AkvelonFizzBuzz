# AkvelonFizzBuzz
This is an algorithm that replaces every third word in the string to Fizz, and every fifth word in the string to Buzz.
utilizes class FizzBuzzDetector and method getOverlappings that has input string and provides result as an object that contains output string with replaced words and number of coincidences of Fizz, Buzz and FizzBuzz words within the output string.

#Requirements:
- .NET 6.0 or newer (tested with .NET 8.0).

- No additional dependencies or external libraries are required.

- The program compiles and runs as a standard C# Console Application.

#How to run:
- Build the solution.

- Run the console project (AkvelonFizzBuzz).

The program will then:
- Print the modified example string with FizzBuzz replacements.
- Run 5 manual tests and print PASS/FAIL results.

 #Manual tests are included in the Tests class.
They cover 5 scenarios:
Test 1
Official example from the task → count = 9

Test 2
Input too short → should throw exception

Test 3
Input with punctuation → replacements still correct, punctuation preserved

Test 4
Input with only 2 words → no replacements

Test 5
Input with 15 words → the 15th becomes "FizzBuzz"

Running the program will show both the example output and PASS/FAIL results of the tests.
