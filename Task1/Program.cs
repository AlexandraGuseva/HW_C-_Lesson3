// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Input
Console.Write("Please, input a five-digit number: ");
string input_number = Console.ReadLine();

// Methods
void CheckInput(string input_number)
{
    if (input_number.Length == 5)
    {
        string correct_number = input_number;
    }
    else
    {
        System.Console.WriteLine($"Error! input number not correct !");
    }

}

void CheckingPalindrome(string input_number)
{
    if (input_number[0] == input_number[4] || input_number[1] == input_number[3])
    {
        Console.WriteLine($"Your digit {input_number} - Palindrome !.");
    }
    else Console.WriteLine($"Your digit {input_number} - Not palindrome !.");
}

// Body 
CheckInput(input_number);
CheckingPalindrome(input_number);