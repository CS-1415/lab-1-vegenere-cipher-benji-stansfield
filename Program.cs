/*Benji Stansfield, 8-25-25, Lab 1 "Vigenere Cipher"*/
using System.Diagnostics;

Console.Clear();

/*Tests*/
Debug.Assert(IsLowercaseLetter('a'));
Debug.Assert(!IsLowercaseLetter(' '));
Debug.Assert(IsLowercaseLetter('A') == false, "All letters must be lowercase");
Debug.Assert(IsLowercaseLetter('*') == false, "Symbols should not be used");

int validMessageInput = 0;
string message = " ";

Console.Clear();

/*Instructions screen*/
Console.WriteLine("This program encrypts the characters of a message using the viginere cipher method.");
do
{
    Console.Write("Please enter the message: ");
    message = Console.ReadLine();
    foreach (char letter in message)
    {
        Console.WriteLine($"Valid letters: {validMessageInput}/{message.Length}"); //just a test, remove later
        if (IsLowercaseLetter(letter))
            validMessageInput += 1;
        else
        {
            validMessageInput = 0;
            break;
        }
    }

} while (validMessageInput != message.Length);
Console.Write("Please enter an encryption key: ");
string encryptionKey = Console.ReadLine();

static bool IsLowercaseLetter(char c)
{
    if (c != char.ToLower(c) || c == ' ' || !char.IsLetter(c)) //tests if the character is lowercase, not a space, or a letter
    {
        Console.WriteLine("Only lowercase letters are allowed.");
        return false;
    }
    else
        return true;
}