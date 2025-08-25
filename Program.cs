/*Benji Stansfield, 8-25-25, Lab 1 "Vigenere Cipher"*/
Console.Clear();

Console.WriteLine("This program encrypts the characters of a message using the viginere cipher method.");
Console.Write("Please enter the message: ");
string originalMessage = Console.ReadLine();
Console.Write("Please enter an encryption key: ");
string encryptionKey = Console.ReadLine();