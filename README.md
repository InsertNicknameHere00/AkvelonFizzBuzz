# AkvelonFizzBuzz
This is an algorithm that replaces every third word in the string to Fizz, and every fifth word in the string to Buzz.
utilizes class FizzBuzzDetector and method getOverlappings that has input string and provides result as an object that contains output string with replaced words and number of coincidences of Fizz, Buzz and FizzBuzz words within the output string.

# Requirements:
- Input string must be between 7 and 100 characters long.
 
- .NET 6.0 or newer (tested with .NET 8.0).

- No additional dependencies or external libraries are required.

- The program compiles and runs as a standard C# Console Application.

# How to run:
- Build the solution.

- Run the console project (AkvelonFizzBuzz).

The program will then:
- Print the modified example string with FizzBuzz replacements.
- Run 5 manual tests and print PASS/FAIL results.

 # Manual tests are included in the Tests class.
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

# Prompts used (AI Assistance):
- “Is the regex built-in utility?”
- “How to use this regex, it’s missing some symbols and messing up the logic”
- “I haven’t worked on unit tests before, what can I do?”
- “How to do this test manually?”
- “Give me an idea for a final test.”
- "Short Documentation ideas?"

# Ideas / Help gathered from:
https://stackoverflow.com/questions/11764539/writing-fizzbuzz
https://stackoverflow.com/questions/43894982/trouble-matching-alpha-and-alphanumeric-words-in-string
