/*Benji Stansfield, 8-25-25, Lab 1 "Vigenere Cipher"*/
using System.Diagnostics;

Console.Clear();

/*Tests*/
Debug.Assert(IsLowercaseLetter('a') == true);
Debug.Assert(!IsLowercaseLetter(' ') == true);
Debug.Assert(IsLowercaseLetter('A') == false, "All letters must be lowercase");
Debug.Assert(IsLowercaseLetter('*') == false, "Symbols should not be used");

Debug.Assert(IsValidString("howdy") == true);
Debug.Assert(!IsValidString("Howdy") == true);
Debug.Assert(IsValidString("howDy") == false, "String cannot contain any uppercase letters");
Debug.Assert(IsValidString("51") == false, "String cannot contain numbers");

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

/*Checks to make sure input has only lowercase letters*/
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

/*Checks if the string is valid*/
static bool IsValidString(string input)
{
    return false;
}