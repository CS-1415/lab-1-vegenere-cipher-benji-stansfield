/*Benji Stansfield, 8-25-25, Lab 1 "Vigenere Cipher"*/
using System.Diagnostics;

Console.Clear();

/*Tests*/
Debug.Assert(IsLowercaseLetter('a'));
Debug.Assert(!IsLowercaseLetter(' '));
Debug.Assert(IsLowercaseLetter('A') == false, "All letters must be lowercase");
Debug.Assert(IsLowercaseLetter('*') == false, "Symbols should not be used");

/*Instructions screen*/
Console.WriteLine("This program encrypts the characters of a message using the viginere cipher method.");
Console.Write("Please enter the message: ");
string message = Console.ReadLine();
char[] letters = message.ToCharArray(); //converts the string into a group of chars
Console.Write("Please enter an encryption key: ");
string encryptionKey = Console.ReadLine();

static bool IsLowercaseLetter(char c) 
{
    return false;
}