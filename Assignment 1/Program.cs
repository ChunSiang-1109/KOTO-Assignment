// Question 1: String Concatenation and Arithmetic Operations
// Task: Write a program that asks the user to enter their first name, last name, and age.
// Concatenate the first and last name to display the full name. Then, calculate how many
// years are left until the user turns 100 and display a message.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter your first name: ");
//         string firstName = Console.ReadLine();

//         Console.Write("Enter your last name: ");
//         string lastName = Console.ReadLine();

//         Console.Write("Enter your age: ");
//         int age = int.Parse(Console.ReadLine());

//         string fullName = firstName + " " + lastName;

//         int yearsTo100 = 100 - age;

//         Console.WriteLine($"Hello, {fullName}. You will turn 100 in {yearsTo100} years.");
//     }
// }

// Output:
// Enter your first name: John
// Enter your last name: Doe
// Enter your age: 25
// Hello, John Doe. You will turn 100 in 75 years.
//---------------------------------------------------------------------------------------------

// Question 2: String Length and Looping
// Task: Create a program that asks the user to enter a word. Display each character of the
// word on a new line, along with the position of the character.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a word: ");
//         string word = Console.ReadLine();

//         for (int i = 0; i < word.Length; i++)
//         {
//             Console.WriteLine($"Character {i + 1}: {word[i]}");
//         }
//     }
// }

// Enter a word: hello
// Character 1: h
// Character 2: e
// Character 3: l
// Character 4: l
// Character 5: o
//---------------------------------------------------------------------------------------------

// Question 3: String Comparison and Conditional Statements
// Task: Write a program that compares two strings entered by the user. Check if they are
// equal, ignoring case, and display an appropriate message.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the first string: ");
//         string firstString = Console.ReadLine();

//         Console.Write("Enter the second string: ");
//         string secondString = Console.ReadLine();

//         if (string.Equals(firstString, secondString, StringComparison.OrdinalIgnoreCase))
//         {
//             Console.WriteLine("The strings are equal.");
//         }
//         else
//         {
//             Console.WriteLine("The strings are not equal.");
//         }
//     }
// }

// Enter the first string: apple
// Enter the second string: Apple
// The strings are equal.

// Enter the first string: CAR
// Enter the second string: CA
// The strings are not equal.
//---------------------------------------------------------------------------------------------

// Question 4: String Interpolation and Mathematical Calculations
// Task: Create a program that asks the user for a radius and then calculates and displays
// the area and circumference of a circle using string interpolation.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the radius of the circle: ");
//         double radius = double.Parse(Console.ReadLine());

//         double area = Math.PI * Math.Pow(radius, 2);

//         double circumference = 2 * Math.PI * radius;

//         Console.WriteLine($"For a circle with radius {radius}, Area: {area:F2}, Circumference: {circumference:F2}");
//     }
// }

// Enter the radius of the circle: 6
// For a circle with radius 6, Area: 113.10, Circumference: 37.70
//---------------------------------------------------------------------------------------------

// Question 5: Substring and Vowel Counting
// Task: Write a program that asks the user to enter a sentence. Extract the first word of
// the sentence and count the number of vowels in that word.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         string firstWord = sentence.Split(' ')[0];

//         int vowelCount = 0;

//         string vowels = "aeiouAEIOU";

//         foreach (char letter in firstWord)
//         {
//             if (vowels.Contains(letter))
//             {
//                 vowelCount++;
//             }
//         }

//         Console.WriteLine($"The first word is '{firstWord}', which contains {vowelCount} vowels.");
//     }
// }

// Enter a sentence: HELLO WORLD
// The first word is 'HELLO', which contains 2 vowels.
//---------------------------------------------------------------------------------------------

// Question 6: String Reversal and Palindrome Check
// Task: Create a program that reverses a string entered by the user and checks if it is a
// palindrome. Display the reversed string and whether it is a palindrome

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();

//         string reversedString = ReverseString(input);

//         bool isPalindrome = string.Equals(input, reversedString, StringComparison.OrdinalIgnoreCase);

//         Console.WriteLine($"Reversed String: {reversedString}");
//         Console.WriteLine(isPalindrome ? "The string is a palindrome" : "The string is not a palindrome");
//     }

//     static string ReverseString(string s)
//     {
//         char[] array = s.ToCharArray();

//         Array.Reverse(array);

//         return new string(array);
//     }
// }

// Enter a string: sis
// Reversed String: sis
// The string is a palindrome

// Enter a string: sir
// Reversed String: ris
// The string is not a palindrome
//---------------------------------------------------------------------------------------------

// Question 7: Character Frequency Counter
// Task: Write a program that counts the frequency of each character in a string entered by
// the user. Display the results.

// using System;
// using System.Collections.Generic;

//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter a string: ");
//             char input = Console.ReadLine()[0];

//             Dictionary<char, int> frequency = new Dictionary<char, int>();

//             foreach (char c in input)
//             {
//                 if (frequency.ContainsKey(c))
//                 {
//                     frequency[c]++;
//                 }
//                 else
//                 {
//                     frequency[c] = 1;
//                 }
//             }

//             Console.WriteLine("Character frequencies:");
//             foreach (var kvp in frequency)
//             {
//                 Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//             }
//         }
// }

// Character frequencies:
// a: 1
// s: 2
// i: 1
// g: 1
// n: 2
// m: 1
// e: 1
// t: 1
//---------------------------------------------------------------------------------------------

// Question 8: String Formatting and Date Calculation
// Task: Create a program that asks the user for their birthdate (in the format YYYY-MMDD) and calculates how many days they have lived. Display the result using string
// formatting.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter your birthdate (YYYY-MM-DD): ");
//         string input = Console.ReadLine();

//         DateTime birthdate;
//         if (DateTime.TryParseExact(input, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out birthdate))
//         {
//             TimeSpan ageSpan = DateTime.Now - birthdate;
//             int daysLived = (int)ageSpan.TotalDays;

//             Console.WriteLine($"You have lived {daysLived} days.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.");
//         }
//     }
// }

// Enter your birthdate (YYYY-MM-DD): 2000
// Invalid date format. Please use YYYY-MM-DD.

// Enter your birthdate (YYYY-MM-DD): 2000-11-09
// You have lived 8679 days.
//---------------------------------------------------------------------------------------------

// Question 9: Capitalization and Looping
// Task: Write a program that capitalizes the first letter of each word in a sentence entered
// by the user and displays the result.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         string capitalizedSentence = CapitalizeWords(sentence);

//         Console.WriteLine($"Capitalized Sentence: {capitalizedSentence}");
//     }

//     static string CapitalizeWords(string sentence)
//     {
//         string[] words = sentence.Split(' ');

//         for (int i = 0; i < words.Length; i++)
//         {
//             if (words[i].Length > 0)
//             {
//                 // Capitalize the first letter and concatenate with the rest of the word
//                 words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
//             }
//         }

//         return string.Join(" ", words);
//     }
// }

// Enter a sentence: hello world everyone
// Capitalized Sentence: Hello World Everyone
//---------------------------------------------------------------------------------------------

// Question 10: String Splitting and Word Count
// Task: Create a program that splits a sentence entered by the user into individual words.
// Display the number of words and each word on a new line.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//         Console.WriteLine($"Number of words: {words.Length}");

//         for (int i = 0; i < words.Length; i++)
//         {
//             Console.WriteLine($"Word {i + 1}: {words[i]}");
//         }
//     }
// }

// Enter a sentence: csharp is a powerful language
// Number of words: 5
// Word 1: csharp
// Word 2: is
// Word 3: a
// Word 4: powerful
// Word 5: language
//---------------------------------------------------------------------------------------------

// Question 11: Anagram Checker 
// Task: Write a program that checks if two strings entered by the user are anagrams
// (contain the same characters in a different order). Ignore case and spaces.

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the first string: ");
//         string firstString = Console.ReadLine();

//         Console.Write("Enter the second string: ");
//         string secondString = Console.ReadLine();

//         if (AreAnagrams(firstString, secondString))
//         {
//             Console.WriteLine("The strings are anagrams.");
//         }
//         else
//         {
//             Console.WriteLine("The strings are not anagrams.");
//         }
//     }

//     static bool AreAnagrams(string str1, string str2)
//     {
//         string processedStr1 = new string(str1.Where(c => !char.IsWhiteSpace(c)).Select(c => char.ToLower(c)).ToArray());
//         string processedStr2 = new string(str2.Where(c => !char.IsWhiteSpace(c)).Select(c => char.ToLower(c)).ToArray());

//         return processedStr1.OrderBy(c => c).SequenceEqual(processedStr2.OrderBy(c => c));
//     }
// }

// Enter the first string: silent
// Enter the second string: listen
// The strings are anagrams.
//---------------------------------------------------------------------------------------------

// Question 12: String Compression Algorithm [Can skip if can’t solve]
// Task: Create a program that compresses a string using the counts of repeated
// characters. For example, the string "aaabbc" becomes "a3b2c1". If the compressed
// string is not smaller, return the original string.

// using System;
// using System.Text;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();

//         // Compress the string
//         string compressedString = CompressString(input);

//         // Output
//         Console.WriteLine("Compressed String: " + compressedString);
//     }

//     static string CompressString(string str)
//     {
//         if (string.IsNullOrEmpty(str))
//             return str;

//         StringBuilder compressed = new StringBuilder();
//         int count = 1;

//         for (int i = 0; i < str.Length - 1; i++)
//         {
//             if (str[i] == str[i + 1])
//             {
//                 count++;
//             }
//             else
//             {
//                 compressed.Append(str[i]);
//                 compressed.Append(count);
//                 count = 1;  // Reset count for new character
//             }
//         }

//         compressed.Append(str[str.Length - 1]);
//         compressed.Append(count);

//         string compressedString = compressed.ToString();

//         return compressedString.Length < str.Length ? compressedString : str;
//     }
// }

// Enter a string: aaabbbcc
// Compressed String: a3b3c2
//---------------------------------------------------------------------------------------------

// Question 13: Caesar Cipher [Can skip if can’t solve]
// Task: Write a program that implements a Caesar cipher, which shifts each letter in a
// string by a given number of positions. The program should handle both encryption and
// decryption.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Example of encryption
//         Console.Write("Enter a string to encrypt: ");
//         string encryptInput = Console.ReadLine();
//         Console.Write("Enter shift amount: ");
//         int encryptShift = int.Parse(Console.ReadLine());

//         string encryptedString = CaesarCipher(encryptInput, encryptShift);
//         Console.WriteLine("Encrypted String: " + encryptedString);

//         // Example of decryption
//         Console.Write("Enter a string to decrypt: ");
//         string decryptInput = Console.ReadLine();
//         Console.Write("Enter shift amount: ");
//         int decryptShift = int.Parse(Console.ReadLine());

//         string decryptedString = CaesarCipher(decryptInput, -decryptShift);
//         Console.WriteLine("Decrypted String: " + decryptedString);
//     }

//     static string CaesarCipher(string input, int shift)
//     {
//         char[] buffer = input.ToCharArray();

//         for (int i = 0; i < buffer.Length; i++)
//         {
//             char c = buffer[i];
//             if (char.IsLetter(c))
//             {
//                 char d = (char)(c + shift);

//                 // Handle overflow for lowercase letters
//                 if (char.IsLower(c))
//                 {
//                     if (d > 'z')
//                         d = (char)(c - (26 - shift));
//                     else if (d < 'a')
//                         d = (char)(c + (26 + shift));
//                 }
//                 // Handle overflow for uppercase letters
//                 else if (char.IsUpper(c))
//                 {
//                     if (d > 'Z')
//                         d = (char)(c - (26 - shift));
//                     else if (d < 'A')
//                         d = (char)(c + (26 + shift));
//                 }

//                 buffer[i] = d;
//             }
//         }

//         return new string(buffer);
//     }
// }

// Enter a string to encrypt: khoor
// Enter shift amount: 3
// Encrypted String: nkrru
// Enter a string to decrypt: nkrru
// Enter shift amount: 3
// Decrypted String: khoor
//---------------------------------------------------------------------------------------------

// Question 14: Longest Word Finder
// Task: Create a program that finds the longest word in a sentence entered by the user. If
// there are multiple words of the same length, display all of them.

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         // Find the longest word(s)
//         var longestWords = FindLongestWords(sentence);

//         // Output
//         Console.WriteLine("Longest word(s): " + string.Join(", ", longestWords));
//     }

//     static List<string> FindLongestWords(string sentence)
//     {
//         // Split the sentence into words
//         string[] words = sentence.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        
//         // Find the length of the longest word
//         int maxLength = words.Max(word => word.Length);
        
//         // Find all words with the maximum length
//         List<string> longestWords = words
//             .Where(word => word.Length == maxLength)
//             .ToList();

//         return longestWords;
//     }
// }

// Enter a sentence: one two three oneto toone
// Longest word(s): three, oneto, toone
//---------------------------------------------------------------------------------------------

// Question 15: Advanced Palindrome Checker [Can skip if can’t solve]
// Task: Write a program that checks if a sentence is a palindrome, ignoring spaces,
// punctuation, and case.

// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         // Check if the sentence is a palindrome
//         bool isPalindrome = IsPalindrome(sentence);

//         // Output
//         if (isPalindrome)
//         {
//             Console.WriteLine("The sentence is a palindrome.");
//         }
//         else
//         {
//             Console.WriteLine("The sentence is not a palindrome.");
//         }
//     }

//     static bool IsPalindrome(string sentence)
//     {
//         // Remove all non-alphanumeric characters and convert to lowercase
//         string cleaned = Regex.Replace(sentence, @"[^a-zA-Z0-9]", "").ToLower();

//         // Check if the cleaned string is a palindrome
//         int left = 0;
//         int right = cleaned.Length - 1;

//         while (left < right)
//         {
//             if (cleaned[left] != cleaned[right])
//                 return false;

//             left++;
//             right--;
//         }

//         return true;
//     }
// }

// Enter a sentence: a plan a man canal panama
// The sentence is not a palindrome.

// Enter a sentence: A man a plan a canal panama
// The sentence is a palindrome.
//---------------------------------------------------------------------------------------------

// Question 16: String Permutations [Can skip if can’t solve]
// Task: Create a program that generates all permutations of a string entered by the user
// and displays them.

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();

//         // Generate and display permutations
//         var permutations = GeneratePermutations(input);
//         Console.WriteLine("Permutations:");
//         foreach (var perm in permutations)
//         {
//             Console.WriteLine(perm);
//         }
//     }

//     static List<string> GeneratePermutations(string str)
//     {
//         List<string> result = new List<string>();
//         Permute(str.ToCharArray(), 0, str.Length - 1, result);
//         return result;
//     }

//     static void Permute(char[] chars, int left, int right, List<string> result)
//     {
//         if (left == right)
//         {
//             result.Add(new string(chars));
//         }
//         else
//         {
//             for (int i = left; i <= right; i++)
//             {
//                 Swap(ref chars[left], ref chars[i]);
//                 Permute(chars, left + 1, right, result);
//                 Swap(ref chars[left], ref chars[i]); // backtrack
//             }
//         }
//     }

//     static void Swap(ref char x, ref char y)
//     {
//         char temp = x;
//         x = y;
//         y = temp;
//     }
// }

// Enter a string: 1sb
// Permutations:
// 1sb
// 1bs
// s1b
// sb1
// bs1
// b1s
//---------------------------------------------------------------------------------------------

// Question 17: Password Strength Checker [Can skip if can’t solve]
// Task: Write a program that checks the strength of a password entered by the user. The
// program should evaluate length, use of uppercase and lowercase letters, digits, and
// special characters, and provide feedback on the password’s strength.

// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter a password: ");
//         string password = Console.ReadLine();

//         // Check password strength
//         string strength = CheckPasswordStrength(password);

//         // Output
//         Console.WriteLine("Password Strength: " + strength);
//     }

//     static string CheckPasswordStrength(string password)
//     {
//         if (string.IsNullOrEmpty(password))
//             return "Weak";

//         bool hasUppercase = Regex.IsMatch(password, @"[A-Z]");
//         bool hasLowercase = Regex.IsMatch(password, @"[a-z]");
//         bool hasDigit = Regex.IsMatch(password, @"\d");
//         bool hasSpecialChar = Regex.IsMatch(password, @"[\W_]");
//         bool isLongEnough = password.Length >= 8;

//         int score = 0;

//         if (hasUppercase) score++;
//         if (hasLowercase) score++;
//         if (hasDigit) score++;
//         if (hasSpecialChar) score++;
//         if (isLongEnough) score++;

//         switch (score)
//         {
//             case 5:
//                 return "Strong";
//             case 4:
//                 return "Moderate";
//             default:
//                 return "Weak";
//         }
//     }
// }

// Enter a password: 1@wors32PD
// Password Strength: Strong

// Enter a password: abd123
// Password Strength: Weak
//---------------------------------------------------------------------------------------------

// Question 18: Advanced Substring Search
// Task: Create a program that finds all occurrences of a substring within a string and
// replaces them with another substring provided by the user

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter the main string: ");
//         string mainString = Console.ReadLine();

//         Console.Write("Enter the substring to find: ");
//         string substringToFind = Console.ReadLine();

//         Console.Write("Enter the substring to replace it with: ");
//         string substringToReplace = Console.ReadLine();

//         // Replace occurrences of the substring
//         string resultString = ReplaceSubstring(mainString, substringToFind, substringToReplace);

//         // Output
//         Console.WriteLine("Resulting String: " + resultString);
//     }

//     static string ReplaceSubstring(string mainString, string substringToFind, string substringToReplace)
//     {
//         // Replace all occurrences of substringToFind with substringToReplace
//         return mainString.Replace(substringToFind, substringToReplace);
//     }
// }

// Enter the main string: the rain in spain stays mainly in the plain
// Enter the substring to find: in
// Enter the substring to replace it with: ot
// Resulting String: the raot ot spaot stays maotly ot the plaot
//---------------------------------------------------------------------------------------------

// Question 19: Sentence Reversal
// Task: Write a program that reverses the order of words in a sentence entered by the user
// while keeping the words themselves intact.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         // Reverse the order of words
//         string reversedSentence = ReverseWords(sentence);

//         // Output
//         Console.WriteLine("Reversed Sentence: " + reversedSentence);
//     }

//     static string ReverseWords(string sentence)
//     {
//         // Split the sentence into words
//         string[] words = sentence.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        
//         // Reverse the array of words
//         Array.Reverse(words);
        
//         // Join the reversed array back into a single string
//         return string.Join(" ", words);
//     }
// }

// Enter a sentence: csharp fun
// Reversed Sentence: fun csharp
//---------------------------------------------------------------------------------------------

// Question 20: Base Conversion
// Task: Create a program that converts a number from one base (e.g., binary, octal,
// hexadecimal) to another base. The user should input the number, its current base, and
// the desired base for conversion.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Input
//         Console.Write("Enter the number: ");
//         string number = Console.ReadLine();

//         Console.Write("Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): ");
//         int currentBase = int.Parse(Console.ReadLine());

//         Console.Write("Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): ");
//         int desiredBase = int.Parse(Console.ReadLine());

//         // Convert the number from the current base to the desired base
//         string convertedNumber = ConvertBase(number, currentBase, desiredBase);

//         // Output
//         Console.WriteLine("Converted Number: " + convertedNumber);
//     }

//     static string ConvertBase(string number, int currentBase, int desiredBase)
//     {
//         // Convert the number from the current base to decimal
//         int decimalNumber = Convert.ToInt32(number, currentBase);

//         // Convert the decimal number to the desired base
//         return ConvertToBase(decimalNumber, desiredBase);
//     }

//     static string ConvertToBase(int number, int baseToConvertTo)
//     {
//         if (number == 0)
//             return "0";

//         const string chars = "0123456789ABCDEF";
//         string result = "";
//         int tempNumber = number;

//         while (tempNumber > 0)
//         {
//             result = chars[tempNumber % baseToConvertTo] + result;
//             tempNumber /= baseToConvertTo;
//         }

//         return result;
//     }
// }

// Enter the number: 101010
// Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): 2
// Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): 10
// Converted Number: 42