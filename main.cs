//Minecraft Text Generator
//Created: 05/07/2025
//Last Updated: 04/08/2025
//This app takes user input and converts it to the minecraft chat font.
//Made by: Ayan Adhikari
//Note: This project took a while because setting up c# took a while and I had other projects I was working on
/*---------------------------------------------------------------------*/
//Setup
using System;
using System.Data;
using System.Threading;
public class Program
{
    //Note: All lowercase letter get converted to capital letters.
    //Note: For now each charcter's row is just itself but in future the pixel art for each charcter will be added. (20/07/2025)
    
    //
    static string[] CapitalLetters1 = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };//Note: For each character it needs to print 1 line at a time (This is the top row)
    static string[] CapitalLetters2 = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };//Row 2 for letters
    static string[] CapitalLetters3 = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };//Row 3 for letters
    static string[] CapitalLetters4 = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };//Row 4 for letters
    static string[] CapitalLetters5 = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };//Row 5 for letters
                                   
    //Arrays for numbers
    static string[] Numbers1 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//Row 1 for numbers
    static string[] Numbers2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//Row 2 for numbers
    static string[] Numbers3 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//Row 3 for numbers
    static string[] Numbers4 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//Row 4 for numbers
    static string[] Numbers5 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//Row 5 for numbers
                                 
    //Arrays for symbols
    static string[] Symbols1 = { " ", ".", ",", ">", "<", "?", "/", "\"", "\'", ":", ";", "[", "]", "{", "}", "(", ")", "|", "!", "@", "#", "$", "%", "^", "&", "*", "_", "-", "+", "=", "`", "~", "\\" };//Row 1 for symbols
    static string[] Symbols2 = { " ", ".", ",", ">", "<", "?", "/", "\"", "\'", ":", ";", "[", "]", "{", "}", "(", ")", "|", "!", "@", "#", "$", "%", "^", "&", "*", "_", "-", "+", "=", "`", "~", "\\" };//Row 2 for symbols
    static string[] Symbols3 = { " ", ".", ",", ">", "<", "?", "/", "\"", "\'", ":", ";", "[", "]", "{", "}", "(", ")", "|", "!", "@", "#", "$", "%", "^", "&", "*", "_", "-", "+", "=", "`", "~", "\\" };//Row 3 for symbols
    static string[] Symbols4 = { " ", ".", ",", ">", "<", "?", "/", "\"", "\'", ":", ";", "[", "]", "{", "}", "(", ")", "|", "!", "@", "#", "$", "%", "^", "&", "*", "_", "-", "+", "=", "`", "~", "\\" };//Row 4 for symbols
    static string[] Symbols5 = { " ", ".", ",", ">", "<", "?", "/", "\"", "\'", ":", ";", "[", "]", "{", "}", "(", ")", "|", "!", "@", "#", "$", "%", "^", "&", "*", "_", "-", "+", "=", "`", "~", "\\" };//Row 5 for symbols
    
    //Variables that aren't arrays
    static bool run = true;
    static char character = 'x';
    static string input;
    static char[] input_array;
    static int Lines;
    static void Main()
    {
        /*---------------------------------------------------------------------*/
        //Basic intro
        Console.WriteLine("This is the minecraft text generator.");
        Thread.Sleep(1000);
        Console.WriteLine("It will generate minecraft-style text.");
        Console.WriteLine("Type what you want it to say then press enter.");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        Console.WriteLine($"");
        /*---------------------------------------------------------------------*/
        //Main loop
        while (run)
        {
            Console.Write("Enter text:");
            input = Console.ReadLine();
            char[] input_array = input.ToCharArray();
            Console.Clear();
            PrintText();

        }
        //Add ending
    }
    //Method for printing the minecraft text
    static void PrintText()
    {
        Console.WriteLine($"Here is your generated text");
        Console.WriteLine();
        //Row 1
        for (int i = 0; i < input.Length; i++)
        {
            character = input_array[i];
            if (character == 'A' || character == 'a')
            {
                Console.Write($"{CapitalLetters1[1]}");
            }
            else if (character == 'B' || character == 'b')
            {
                Console.Write($"{CapitalLetters1[2]}");
            }
            else if (character == 'C' || character == 'c')
            {
                Console.Write($"{CapitalLetters1[3]}");
            }
            else if (character == 'D' || character == 'd')
            {
                Console.Write($"{CapitalLetters1[4]}");
            }
            else if (character == 'E' || character == 'e')
            {
                Console.Write($"{CapitalLetters1[5]}");
            }
            else if (character == 'F' || character == 'f')
            {
                Console.Write($"{CapitalLetters1[6]}");
            }
            else if (character == 'G' || character == 'g')
            {
                Console.Write($"{CapitalLetters1[7]}");
            }
            else if (character == 'H' || character == 'h')
            {
                Console.Write($"{CapitalLetters1[8]}");
            }
            else if (character == 'I' || character == 'i')
            {
                Console.Write($"{CapitalLetters1[9]}");
            }
            else if (character == 'J' || character == 'j')
            {
                Console.Write($"{CapitalLetters1[10]}");
            }
            else if (character == 'K' || character == 'k')
            {
                Console.Write($"{CapitalLetters1[11]}");
            }
            else if (character == 'L' || character == 'l')
            {
                Console.Write($"{CapitalLetters1[12]}");
            }
            else if (character == 'M' || character == 'm')
            {
                Console.Write($"{CapitalLetters1[13]}");
            }
            else if (character == 'N' || character == 'n')
            {
                Console.Write($"{CapitalLetters1[14]}");
            }
            else if (character == 'O' || character == 'o')
            {
                Console.Write($"{CapitalLetters1[15]}");
            }
            else if (character == 'P' || character == 'p')
            {
                Console.Write($"{CapitalLetters1[16]}");
            }
            else if (character == 'Q' || character == 'q')
            {
                Console.Write($"{CapitalLetters1[17]}");
            }
            else if (character == 'R' || character == 'r')
            {
                Console.Write($"{CapitalLetters1[18]}");
            }
            else if (character == 'S' || character == 's')
            {
                Console.Write($"{CapitalLetters1[19]}");
            }
            else if (character == 'T' || character == 't')
            {
                Console.Write($"{CapitalLetters1[20]}");
            }
            else if (character == 'U' || character == 'u')
            {
                Console.Write($"{CapitalLetters1[21]}");
            }
            else if (character == 'V' || character == 'v')
            {
                Console.Write($"{CapitalLetters1[22]}");
            }
            else if (character == 'W' || character == 'w')
            {
                Console.Write($"{CapitalLetters1[23]}");
            }
            else if (character == 'X' || character == 'x')
            {
                Console.Write($"{CapitalLetters1[24]}");
            }
            else if (character == 'Y' || character == 'y')
            {
                Console.Write($"{CapitalLetters1[25]}");
            }
            else if (character == 'Z' || character == 'z')
            {
                Console.Write($"{CapitalLetters1[26]}");
            }
            else if (character == '0')
            {
                Console.Write($"{Numbers1[0]}");
            }
            else if (character == '1')
            {
                Console.Write($"{Numbers1[1]}");
            }
            else if (character == '2')
            {
                Console.Write($"{Numbers1[2]}");
            }
            else if (character == '3')
            {
                Console.Write($"{Numbers1[3]}");
            }
            else if (character == '4')
            {
                Console.Write($"{Numbers1[4]}");
            }
            else if (character == '5')
            {
                Console.Write($"{Numbers1[5]}");
            }
            else if (character == '6')
            {
                Console.Write($"{Numbers1[6]}");
            }
            else if (character == '7')
            {
                Console.Write($"{Numbers1[7]}");
            }
            else if (character == '8')
            {
                Console.Write($"{Numbers1[8]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers1[9]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers1[9]}");
            }
            else if (character == '.')
            {
                Console.Write($"{Symbols1[1]}");
            }
            else if (character == ',')
            {
                Console.Write($"{Symbols1[2]}");
            }
            else if (character == '>')
            {
                Console.Write($"{Symbols1[3]}");
            }
            else if (character == '<')
            {
                Console.Write($"{Symbols1[4]}");
            }
            else if (character == '?')
            {
                Console.Write($"{Symbols1[5]}");
            }
            else if (character == '/')
            {
                Console.Write($"{Symbols1[6]}");
            }
            else if (character == '"')
            {
                Console.Write($"{Symbols1[7]}");
            }
            else if (character == '\'')
            {
                Console.Write($"{Symbols1[8]}");
            }
            else if (character == ':')
            {
                Console.Write($"{Symbols1[9]}");
            }
            else if (character == ';')
            {
                Console.Write($"{Symbols1[10]}");
            }
            else if (character == '[')
            {
                Console.Write($"{Symbols1[11]}");
            }
            else if (character == ']')
            {
                Console.Write($"{Symbols1[12]}");
            }
            else if (character == '{')
            {
                Console.Write($"{Symbols1[13]}");
            }
            else if (character == '}')
            {
                Console.Write($"{Symbols1[14]}");
            }
            else if (character == '(')
            {
                Console.Write($"{Symbols1[15]}");
            }
            else if (character == ')')
            {
                Console.Write($"{Symbols1[16]}");
            }
            else if (character == '|')
            {
                Console.Write($"{Symbols1[17]}");
            }
            else if (character == '!')
            {
                Console.Write($"{Symbols1[18]}");
            }
            else if (character == '@')

            {
                Console.Write($"{Symbols1[19]}");
            }
            else if (character == '#')
            {
                Console.Write($"{Symbols1[20]}");
            }
            else if (character == '$')
            {
                Console.Write($"{Symbols1[21]}");
            }
            else if (character == '%')
            {
                Console.Write($"{Symbols1[22]}");
            }
            else if (character == '^')
            {
                Console.Write($"{Symbols1[23]}");
            }
            else if (character == '&')
            {
                Console.Write($"{Symbols1[24]}");
            }
            else if (character == '*')
            {
                Console.Write($"{Symbols1[25]}");
            }
            else if (character == '_')
            {
                Console.Write($"{Symbols1[26]}");
            }
            else if (character == '-')
            {
                Console.Write($"{Symbols1[27]}");
            }
            else if (character == '+')
            {
                Console.Write($"{Symbols1[28]}");
            }
            else if (character == '=')
            {
                Console.Write($"{Symbols1[29]}");
            }
            else if (character == '`')
            {
                Console.Write($"{Symbols1[30]}");
            }
            else if (character == '~')
            {
                Console.Write($"{Symbols1[31]}");
            }
            else if (character == '\\')
            {
                Console.Write($"{Symbols1[32]}");
            }
            else
            {
                Console.Write($"Error");
            }
        }
        /*---------------------------------------------------------------------*/
        //There will be 5 loops (1 for each row for the characters)
        //This is row 2
        //Each loop is the same except it prints what the pixel art from different arrays. 
        //This means that the loop for row 1 would print CapitalLetters1[insert]
        //and the loop for row 2 would print CapitalLetters2[insert] and so on.
        //A line is printed between rows to ensure that everything is on different lines.
        Console.WriteLine(); //Line
        for (int i = 0; i < input.Length; i++)
        {
            character = input_array[i];
            if (character == 'A' || character == 'a')
            {
                Console.Write($"{CapitalLetters2[1]}");
            }
            else if (character == 'B' || character == 'b')
            {
                Console.Write($"{CapitalLetters2[2]}");
            }
            else if (character == 'C' || character == 'c')
            {
                Console.Write($"{CapitalLetters2[3]}");
            }
            else if (character == 'D' || character == 'd')
            {
                Console.Write($"{CapitalLetters2[4]}");
            }
            else if (character == 'E' || character == 'e')
            {
                Console.Write($"{CapitalLetters2[5]}");
            }
            else if (character == 'F' || character == 'f')
            {
                Console.Write($"{CapitalLetters2[6]}");
            }
            else if (character == 'G' || character == 'g')
            {
                Console.Write($"{CapitalLetters2[7]}");
            }
            else if (character == 'H' || character == 'h')
            {
                Console.Write($"{CapitalLetters2[8]}");
            }
            else if (character == 'I' || character == 'i')
            {
                Console.Write($"{CapitalLetters2[9]}");
            }
            else if (character == 'J' || character == 'j')
            {
                Console.Write($"{CapitalLetters2[10]}");
            }
            else if (character == 'K' || character == 'k')
            {
                Console.Write($"{CapitalLetters2[11]}");
            }
            else if (character == 'L' || character == 'l')
            {
                Console.Write($"{CapitalLetters2[12]}");
            }
            else if (character == 'M' || character == 'm')
            {
                Console.Write($"{CapitalLetters2[13]}");
            }
            else if (character == 'N' || character == 'n')
            {
                Console.Write($"{CapitalLetters2[14]}");
            }
            else if (character == 'O' || character == 'o')
            {
                Console.Write($"{CapitalLetters2[15]}");
            }
            else if (character == 'P' || character == 'p')
            {
                Console.Write($"{CapitalLetters2[16]}");
            }
            else if (character == 'Q' || character == 'q')
            {
                Console.Write($"{CapitalLetters2[17]}");
            }
            else if (character == 'R' || character == 'r')
            {
                Console.Write($"{CapitalLetters2[18]}");
            }
            else if (character == 'S' || character == 's')
            {
                Console.Write($"{CapitalLetters2[19]}");
            }
            else if (character == 'T' || character == 't')
            {
                Console.Write($"{CapitalLetters2[20]}");
            }
            else if (character == 'U' || character == 'u')
            {
                Console.Write($"{CapitalLetters2[21]}");
            }
            else if (character == 'V' || character == 'v')
            {
                Console.Write($"{CapitalLetters2[22]}");
            }
            else if (character == 'W' || character == 'w')
            {
                Console.Write($"{CapitalLetters2[23]}");
            }
            else if (character == 'X' || character == 'x')
            {
                Console.Write($"{CapitalLetters2[24]}");
            }
            else if (character == 'Y' || character == 'y')
            {
                Console.Write($"{CapitalLetters2[25]}");
            }
            else if (character == 'Z' || character == 'z')
            {
                Console.Write($"{CapitalLetters2[26]}");
            }
            else if (character == '0')
            {
                Console.Write($"{Numbers2[0]}");
            }
            else if (character == '1')
            {
                Console.Write($"{Numbers2[1]}");
            }
            else if (character == '2')
            {
                Console.Write($"{Numbers2[2]}");
            }
            else if (character == '3')
            {
                Console.Write($"{Numbers2[3]}");
            }
            else if (character == '4')
            {
                Console.Write($"{Numbers2[4]}");
            }
            else if (character == '5')
            {
                Console.Write($"{Numbers2[5]}");
            }
            else if (character == '6')
            {
                Console.Write($"{Numbers2[6]}");
            }
            else if (character == '7')
            {
                Console.Write($"{Numbers2[7]}");
            }
            else if (character == '8')
            {
                Console.Write($"{Numbers2[8]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers2[9]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers2[9]}");
            }
            else if (character == '.')
            {
                Console.Write($"{Symbols2[1]}");
            }
            else if (character == ',')
            {
                Console.Write($"{Symbols2[2]}");
            }
            else if (character == '>')
            {
                Console.Write($"{Symbols2[3]}");
            }
            else if (character == '<')
            {
                Console.Write($"{Symbols2[4]}");
            }
            else if (character == '?')
            {
                Console.Write($"{Symbols2[5]}");
            }
            else if (character == '/')
            {
                Console.Write($"{Symbols2[6]}");
            }
            else if (character == '"')
            {
                Console.Write($"{Symbols2[7]}");
            }
            else if (character == '\'')
            {
                Console.Write($"{Symbols2[8]}");
            }
            else if (character == ':')
            {
                Console.Write($"{Symbols2[9]}");
            }
            else if (character == ';')
            {
                Console.Write($"{Symbols2[10]}");
            }
            else if (character == '[')
            {
                Console.Write($"{Symbols2[11]}");
            }
            else if (character == ']')
            {
                Console.Write($"{Symbols2[12]}");
            }
            else if (character == '{')
            {
                Console.Write($"{Symbols2[13]}");
            }
            else if (character == '}')
            {
                Console.Write($"{Symbols2[14]}");
            }
            else if (character == '(')
            {
                Console.Write($"{Symbols2[15]}");
            }
            else if (character == ')')
            {
                Console.Write($"{Symbols2[16]}");
            }
            else if (character == '|')
            {
                Console.Write($"{Symbols2[17]}");
            }
            else if (character == '!')
            {
                Console.Write($"{Symbols2[18]}");
            }
            else if (character == '@')

            {
                Console.Write($"{Symbols2[19]}");
            }
            else if (character == '#')
            {
                Console.Write($"{Symbols2[20]}");
            }
            else if (character == '$')
            {
                Console.Write($"{Symbols2[21]}");
            }
            else if (character == '%')
            {
                Console.Write($"{Symbols2[22]}");
            }
            else if (character == '^')
            {
                Console.Write($"{Symbols2[23]}");
            }
            else if (character == '&')
            {
                Console.Write($"{Symbols2[24]}");
            }
            else if (character == '*')
            {
                Console.Write($"{Symbols2[25]}");
            }
            else if (character == '_')
            {
                Console.Write($"{Symbols2[26]}");
            }
            else if (character == '-')
            {
                Console.Write($"{Symbols2[27]}");
            }
            else if (character == '+')
            {
                Console.Write($"{Symbols2[28]}");
            }
            else if (character == '=')
            {
                Console.Write($"{Symbols2[29]}");
            }
            else if (character == '`')
            {
                Console.Write($"{Symbols2[30]}");
            }
            else if (character == '~')
            {
                Console.Write($"{Symbols2[31]}");
            }
            else if (character == '\\')
            {
                Console.Write($"{Symbols2[32]}");
            }
            else
            {
                Console.Write($"Error");
            }
        }
        /*---------------------------------------------------------------------*/
        //This is row 3
        Console.WriteLine(); //Line
        for (int i = 0; i < input.Length; i++)
        {
            character = input_array[i];
            if (character == 'A' || character == 'a')
            {
                Console.Write($"{CapitalLetters3[1]}");
            }
            else if (character == 'B' || character == 'b')
            {
                Console.Write($"{CapitalLetters3[2]}");
            }
            else if (character == 'C' || character == 'c')
            {
                Console.Write($"{CapitalLetters3[3]}");
            }
            else if (character == 'D' || character == 'd')
            {
                Console.Write($"{CapitalLetters3[4]}");
            }
            else if (character == 'E' || character == 'e')
            {
                Console.Write($"{CapitalLetters3[5]}");
            }
            else if (character == 'F' || character == 'f')
            {
                Console.Write($"{CapitalLetters3[6]}");
            }
            else if (character == 'G' || character == 'g')
            {
                Console.Write($"{CapitalLetters3[7]}");
            }
            else if (character == 'H' || character == 'h')
            {
                Console.Write($"{CapitalLetters3[8]}");
            }
            else if (character == 'I' || character == 'i')
            {
                Console.Write($"{CapitalLetters3[9]}");
            }
            else if (character == 'J' || character == 'j')
            {
                Console.Write($"{CapitalLetters3[10]}");
            }
            else if (character == 'K' || character == 'k')
            {
                Console.Write($"{CapitalLetters3[11]}");
            }
            else if (character == 'L' || character == 'l')
            {
                Console.Write($"{CapitalLetters3[12]}");
            }
            else if (character == 'M' || character == 'm')
            {
                Console.Write($"{CapitalLetters3[13]}");
            }
            else if (character == 'N' || character == 'n')
            {
                Console.Write($"{CapitalLetters3[14]}");
            }
            else if (character == 'O' || character == 'o')
            {
                Console.Write($"{CapitalLetters3[15]}");
            }
            else if (character == 'P' || character == 'p')
            {
                Console.Write($"{CapitalLetters3[16]}");
            }
            else if (character == 'Q' || character == 'q')
            {
                Console.Write($"{CapitalLetters3[17]}");
            }
            else if (character == 'R' || character == 'r')
            {
                Console.Write($"{CapitalLetters3[18]}");
            }
            else if (character == 'S' || character == 's')
            {
                Console.Write($"{CapitalLetters3[19]}");
            }
            else if (character == 'T' || character == 't')
            {
                Console.Write($"{CapitalLetters3[20]}");
            }
            else if (character == 'U' || character == 'u')
            {
                Console.Write($"{CapitalLetters3[21]}");
            }
            else if (character == 'V' || character == 'v')
            {
                Console.Write($"{CapitalLetters3[22]}");
            }
            else if (character == 'W' || character == 'w')
            {
                Console.Write($"{CapitalLetters3[23]}");
            }
            else if (character == 'X' || character == 'x')
            {
                Console.Write($"{CapitalLetters3[24]}");
            }
            else if (character == 'Y' || character == 'y')
            {
                Console.Write($"{CapitalLetters3[25]}");
            }
            else if (character == 'Z' || character == 'z')
            {
                Console.Write($"{CapitalLetters3[26]}");
            }
            else if (character == '0')
            {
                Console.Write($"{Numbers3[0]}");
            }
            else if (character == '1')
            {
                Console.Write($"{Numbers3[1]}");
            }
            else if (character == '2')
            {
                Console.Write($"{Numbers3[2]}");
            }
            else if (character == '3')
            {
                Console.Write($"{Numbers3[3]}");
            }
            else if (character == '4')
            {
                Console.Write($"{Numbers3[4]}");
            }
            else if (character == '5')
            {
                Console.Write($"{Numbers3[5]}");
            }
            else if (character == '6')
            {
                Console.Write($"{Numbers3[6]}");
            }
            else if (character == '7')
            {
                Console.Write($"{Numbers3[7]}");
            }
            else if (character == '8')
            {
                Console.Write($"{Numbers3[8]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers3[9]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers3[9]}");
            }
            else if (character == '.')
            {
                Console.Write($"{Symbols3[1]}");
            }
            else if (character == ',')
            {
                Console.Write($"{Symbols3[2]}");
            }
            else if (character == '>')
            {
                Console.Write($"{Symbols3[3]}");
            }
            else if (character == '<')
            {
                Console.Write($"{Symbols3[4]}");
            }
            else if (character == '?')
            {
                Console.Write($"{Symbols3[5]}");
            }
            else if (character == '/')
            {
                Console.Write($"{Symbols3[6]}");
            }
            else if (character == '"')
            {
                Console.Write($"{Symbols3[7]}");
            }
            else if (character == '\'')
            {
                Console.Write($"{Symbols3[8]}");
            }
            else if (character == ':')
            {
                Console.Write($"{Symbols3[9]}");
            }
            else if (character == ';')
            {
                Console.Write($"{Symbols3[10]}");
            }
            else if (character == '[')
            {
                Console.Write($"{Symbols3[11]}");
            }
            else if (character == ']')
            {
                Console.Write($"{Symbols3[12]}");
            }
            else if (character == '{')
            {
                Console.Write($"{Symbols3[13]}");
            }
            else if (character == '}')
            {
                Console.Write($"{Symbols3[14]}");
            }
            else if (character == '(')
            {
                Console.Write($"{Symbols3[15]}");
            }
            else if (character == ')')
            {
                Console.Write($"{Symbols3[16]}");
            }
            else if (character == '|')
            {
                Console.Write($"{Symbols3[17]}");
            }
            else if (character == '!')
            {
                Console.Write($"{Symbols3[18]}");
            }
            else if (character == '@')

            {
                Console.Write($"{Symbols3[19]}");
            }
            else if (character == '#')
            {
                Console.Write($"{Symbols3[20]}");
            }
            else if (character == '$')
            {
                Console.Write($"{Symbols3[21]}");
            }
            else if (character == '%')
            {
                Console.Write($"{Symbols3[22]}");
            }
            else if (character == '^')
            {
                Console.Write($"{Symbols3[23]}");
            }
            else if (character == '&')
            {
                Console.Write($"{Symbols3[24]}");
            }
            else if (character == '*')
            {
                Console.Write($"{Symbols3[25]}");
            }
            else if (character == '_')
            {
                Console.Write($"{Symbols3[26]}");
            }
            else if (character == '-')
            {
                Console.Write($"{Symbols3[27]}");
            }
            else if (character == '+')
            {
                Console.Write($"{Symbols3[28]}");
            }
            else if (character == '=')
            {
                Console.Write($"{Symbols3[29]}");
            }
            else if (character == '`')
            {
                Console.Write($"{Symbols3[30]}");
            }
            else if (character == '~')
            {
                Console.Write($"{Symbols3[31]}");
            }
            else if (character == '\\')
            {
                Console.Write($"{Symbols3[32]}");
            }
            else
            {
                Console.Write($"Error");
            }
        }
        /*---------------------------------------------------------------------*/
        //This is row 4
        Console.WriteLine();
        for (int i = 0; i < input.Length; i++)
        {
            character = input_array[i];
            if (character == 'A' || character == 'a')
            {
                Console.Write($"{CapitalLetters4[1]}");
            }
            else if (character == 'B' || character == 'b')
            {
                Console.Write($"{CapitalLetters4[2]}");
            }
            else if (character == 'C' || character == 'c')
            {
                Console.Write($"{CapitalLetters4[3]}");
            }
            else if (character == 'D' || character == 'd')
            {
                Console.Write($"{CapitalLetters4[4]}");
            }
            else if (character == 'E' || character == 'e')
            {
                Console.Write($"{CapitalLetters4[5]}");
            }
            else if (character == 'F' || character == 'f')
            {
                Console.Write($"{CapitalLetters4[6]}");
            }
            else if (character == 'G' || character == 'g')
            {
                Console.Write($"{CapitalLetters4[7]}");
            }
            else if (character == 'H' || character == 'h')
            {
                Console.Write($"{CapitalLetters4[8]}");
            }
            else if (character == 'I' || character == 'i')
            {
                Console.Write($"{CapitalLetters4[9]}");
            }
            else if (character == 'J' || character == 'j')
            {
                Console.Write($"{CapitalLetters4[10]}");
            }
            else if (character == 'K' || character == 'k')
            {
                Console.Write($"{CapitalLetters4[11]}");
            }
            else if (character == 'L' || character == 'l')
            {
                Console.Write($"{CapitalLetters4[12]}");
            }
            else if (character == 'M' || character == 'm')
            {
                Console.Write($"{CapitalLetters4[13]}");
            }
            else if (character == 'N' || character == 'n')
            {
                Console.Write($"{CapitalLetters4[14]}");
            }
            else if (character == 'O' || character == 'o')
            {
                Console.Write($"{CapitalLetters4[15]}");
            }
            else if (character == 'P' || character == 'p')
            {
                Console.Write($"{CapitalLetters4[16]}");
            }
            else if (character == 'Q' || character == 'q')
            {
                Console.Write($"{CapitalLetters4[17]}");
            }
            else if (character == 'R' || character == 'r')
            {
                Console.Write($"{CapitalLetters4[18]}");
            }
            else if (character == 'S' || character == 's')
            {
                Console.Write($"{CapitalLetters4[19]}");
            }
            else if (character == 'T' || character == 't')
            {
                Console.Write($"{CapitalLetters4[20]}");
            }
            else if (character == 'U' || character == 'u')
            {
                Console.Write($"{CapitalLetters4[21]}");
            }
            else if (character == 'V' || character == 'v')
            {
                Console.Write($"{CapitalLetters4[22]}");
            }
            else if (character == 'W' || character == 'w')
            {
                Console.Write($"{CapitalLetters4[23]}");
            }
            else if (character == 'X' || character == 'x')
            {
                Console.Write($"{CapitalLetters4[24]}");
            }
            else if (character == 'Y' || character == 'y')
            {
                Console.Write($"{CapitalLetters4[25]}");
            }
            else if (character == 'Z' || character == 'z')
            {
                Console.Write($"{CapitalLetters4[26]}");
            }
            else if (character == '0')
            {
                Console.Write($"{Numbers4[0]}");
            }
            else if (character == '1')
            {
                Console.Write($"{Numbers4[1]}");
            }
            else if (character == '2')
            {
                Console.Write($"{Numbers4[2]}");
            }
            else if (character == '3')
            {
                Console.Write($"{Numbers4[3]}");
            }
            else if (character == '4')
            {
                Console.Write($"{Numbers4[4]}");
            }
            else if (character == '5')
            {
                Console.Write($"{Numbers4[5]}");
            }
            else if (character == '6')
            {
                Console.Write($"{Numbers4[6]}");
            }
            else if (character == '7')
            {
                Console.Write($"{Numbers4[7]}");
            }
            else if (character == '8')
            {
                Console.Write($"{Numbers4[8]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers4[9]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers4[9]}");
            }
            else if (character == '.')
            {
                Console.Write($"{Symbols4[1]}");
            }
            else if (character == ',')
            {
                Console.Write($"{Symbols4[2]}");
            }
            else if (character == '>')
            {
                Console.Write($"{Symbols4[3]}");
            }
            else if (character == '<')
            {
                Console.Write($"{Symbols4[4]}");
            }
            else if (character == '?')
            {
                Console.Write($"{Symbols4[5]}");
            }
            else if (character == '/')
            {
                Console.Write($"{Symbols4[6]}");
            }
            else if (character == '"')
            {
                Console.Write($"{Symbols4[7]}");
            }
            else if (character == '\'')
            {
                Console.Write($"{Symbols4[8]}");
            }
            else if (character == ':')
            {
                Console.Write($"{Symbols4[9]}");
            }
            else if (character == ';')
            {
                Console.Write($"{Symbols4[10]}");
            }
            else if (character == '[')
            {
                Console.Write($"{Symbols4[11]}");
            }
            else if (character == ']')
            {
                Console.Write($"{Symbols4[12]}");
            }
            else if (character == '{')
            {
                Console.Write($"{Symbols4[13]}");
            }
            else if (character == '}')
            {
                Console.Write($"{Symbols4[14]}");
            }
            else if (character == '(')
            {
                Console.Write($"{Symbols4[15]}");
            }
            else if (character == ')')
            {
                Console.Write($"{Symbols4[16]}");
            }
            else if (character == '|')
            {
                Console.Write($"{Symbols4[17]}");
            }
            else if (character == '!')
            {
                Console.Write($"{Symbols4[18]}");
            }
            else if (character == '@')

            {
                Console.Write($"{Symbols4[19]}");
            }
            else if (character == '#')
            {
                Console.Write($"{Symbols4[20]}");
            }
            else if (character == '$')
            {
                Console.Write($"{Symbols4[21]}");
            }
            else if (character == '%')
            {
                Console.Write($"{Symbols4[22]}");
            }
            else if (character == '^')
            {
                Console.Write($"{Symbols4[23]}");
            }
            else if (character == '&')
            {
                Console.Write($"{Symbols4[24]}");
            }
            else if (character == '*')
            {
                Console.Write($"{Symbols4[25]}");
            }
            else if (character == '_')
            {
                Console.Write($"{Symbols4[26]}");
            }
            else if (character == '-')
            {
                Console.Write($"{Symbols4[27]}");
            }
            else if (character == '+')
            {
                Console.Write($"{Symbols4[28]}");
            }
            else if (character == '=')
            {
                Console.Write($"{Symbols4[29]}");
            }
            else if (character == '`')
            {
                Console.Write($"{Symbols4[30]}");
            }
            else if (character == '~')
            {
                Console.Write($"{Symbols4[31]}");
            }
            else if (character == '\\')
            {
                Console.Write($"{Symbols4[32]}");
            }
            else
            {
                Console.Write($"Error");
            }
        }
        /*---------------------------------------------------------------------*/
        //This is row 5 (final)
        Console.WriteLine();
        for (int i = 0; i < input.Length; i++)
        {
            character = input_array[i];
            if (character == 'A' || character == 'a')
            {
                Console.Write($"{CapitalLetters5[1]}");
            }
            else if (character == 'B' || character == 'b')
            {
                Console.Write($"{CapitalLetters5[2]}");
            }
            else if (character == 'C' || character == 'c')
            {
                Console.Write($"{CapitalLetters5[3]}");
            }
            else if (character == 'D' || character == 'd')
            {
                Console.Write($"{CapitalLetters5[4]}");
            }
            else if (character == 'E' || character == 'e')
            {
                Console.Write($"{CapitalLetters5[5]}");
            }
            else if (character == 'F' || character == 'f')
            {
                Console.Write($"{CapitalLetters5[6]}");
            }
            else if (character == 'G' || character == 'g')
            {
                Console.Write($"{CapitalLetters5[7]}");
            }
            else if (character == 'H' || character == 'h')
            {
                Console.Write($"{CapitalLetters5[8]}");
            }
            else if (character == 'I' || character == 'i')
            {
                Console.Write($"{CapitalLetters5[9]}");
            }
            else if (character == 'J' || character == 'j')
            {
                Console.Write($"{CapitalLetters5[10]}");
            }
            else if (character == 'K' || character == 'k')
            {
                Console.Write($"{CapitalLetters5[11]}");
            }
            else if (character == 'L' || character == 'l')
            {
                Console.Write($"{CapitalLetters5[12]}");
            }
            else if (character == 'M' || character == 'm')
            {
                Console.Write($"{CapitalLetters5[13]}");
            }
            else if (character == 'N' || character == 'n')
            {
                Console.Write($"{CapitalLetters5[14]}");
            }
            else if (character == 'O' || character == 'o')
            {
                Console.Write($"{CapitalLetters5[15]}");
            }
            else if (character == 'P' || character == 'p')
            {
                Console.Write($"{CapitalLetters5[16]}");
            }
            else if (character == 'Q' || character == 'q')
            {
                Console.Write($"{CapitalLetters5[17]}");
            }
            else if (character == 'R' || character == 'r')
            {
                Console.Write($"{CapitalLetters5[18]}");
            }
            else if (character == 'S' || character == 's')
            {
                Console.Write($"{CapitalLetters5[19]}");
            }
            else if (character == 'T' || character == 't')
            {
                Console.Write($"{CapitalLetters5[20]}");
            }
            else if (character == 'U' || character == 'u')
            {
                Console.Write($"{CapitalLetters5[21]}");
            }
            else if (character == 'V' || character == 'v')
            {
                Console.Write($"{CapitalLetters5[22]}");
            }
            else if (character == 'W' || character == 'w')
            {
                Console.Write($"{CapitalLetters5[23]}");
            }
            else if (character == 'X' || character == 'x')
            {
                Console.Write($"{CapitalLetters5[24]}");
            }
            else if (character == 'Y' || character == 'y')
            {
                Console.Write($"{CapitalLetters5[25]}");
            }
            else if (character == 'Z' || character == 'z')
            {
                Console.Write($"{CapitalLetters5[26]}");
            }
            else if (character == '0')
            {
                Console.Write($"{Numbers5[0]}");
            }
            else if (character == '1')
            {
                Console.Write($"{Numbers5[1]}");
            }
            else if (character == '2')
            {
                Console.Write($"{Numbers5[2]}");
            }
            else if (character == '3')
            {
                Console.Write($"{Numbers5[3]}");
            }
            else if (character == '4')
            {
                Console.Write($"{Numbers5[4]}");
            }
            else if (character == '5')
            {
                Console.Write($"{Numbers5[5]}");
            }
            else if (character == '6')
            {
                Console.Write($"{Numbers5[6]}");
            }
            else if (character == '7')
            {
                Console.Write($"{Numbers5[7]}");
            }
            else if (character == '8')
            {
                Console.Write($"{Numbers5[8]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers5[9]}");
            }
            else if (character == '9')
            {
                Console.Write($"{Numbers5[9]}");
            }
            else if (character == '.')
            {
                Console.Write($"{Symbols5[1]}");
            }
            else if (character == ',')
            {
                Console.Write($"{Symbols5[2]}");
            }
            else if (character == '>')
            {
                Console.Write($"{Symbols5[3]}");
            }
            else if (character == '<')
            {
                Console.Write($"{Symbols5[4]}");
            }
            else if (character == '?')
            {
                Console.Write($"{Symbols5[5]}");
            }
            else if (character == '/')
            {
                Console.Write($"{Symbols5[6]}");
            }
            else if (character == '"')
            {
                Console.Write($"{Symbols5[7]}");
            }
            else if (character == '\'')
            {
                Console.Write($"{Symbols5[8]}");
            }
            else if (character == ':')
            {
                Console.Write($"{Symbols5[9]}");
            }
            else if (character == ';')
            {
                Console.Write($"{Symbols5[10]}");
            }
            else if (character == '[')
            {
                Console.Write($"{Symbols5[11]}");
            }
            else if (character == ']')
            {
                Console.Write($"{Symbols5[12]}");
            }
            else if (character == '{')
            {
                Console.Write($"{Symbols5[13]}");
            }
            else if (character == '}')
            {
                Console.Write($"{Symbols5[14]}");
            }
            else if (character == '(')
            {
                Console.Write($"{Symbols5[15]}");
            }
            else if (character == ')')
            {
                Console.Write($"{Symbols5[16]}");
            }
            else if (character == '|')
            {
                Console.Write($"{Symbols5[17]}");
            }
            else if (character == '!')
            {
                Console.Write($"{Symbols5[18]}");
            }
            else if (character == '@')

            {
                Console.Write($"{Symbols5[19]}");
            }
            else if (character == '#')
            {
                Console.Write($"{Symbols5[20]}");
            }
            else if (character == '$')
            {
                Console.Write($"{Symbols5[21]}");
            }
            else if (character == '%')
            {
                Console.Write($"{Symbols5[22]}");
            }
            else if (character == '^')
            {
                Console.Write($"{Symbols5[23]}");
            }
            else if (character == '&')
            {
                Console.Write($"{Symbols5[24]}");
            }
            else if (character == '*')
            {
                Console.Write($"{Symbols5[25]}");
            }
            else if (character == '_')
            {
                Console.Write($"{Symbols5[26]}");
            }
            else if (character == '-')
            {
                Console.Write($"{Symbols5[27]}");
            }
            else if (character == '+')
            {
                Console.Write($"{Symbols5[28]}");
            }
            else if (character == '=')
            {
                Console.Write($"{Symbols5[29]}");
            }
            else if (character == '`')
            {
                Console.Write($"{Symbols5[30]}");
            }
            else if (character == '~')
            {
                Console.Write($"{Symbols5[31]}");
            }
            else if (character == '\\')
            {
                Console.Write($"{Symbols5[32]}");
            }
            else
            {
                Console.Write($"Error");
            }
        }
        Lines = 7;
        Clear2();

    }
    //Method for clearing screen
    static void Clear2()
    {
        int defaultCalibration = Console.WindowHeight;
        int calibration = defaultCalibration - Lines;
    }

}
//Hi
