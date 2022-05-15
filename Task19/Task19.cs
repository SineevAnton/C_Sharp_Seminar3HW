//Write a program which checkes if the inputed five-digit number is a palindrome.

string num;
while (true)
{
    Console.Write("Enter a five-digit number: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number) && number < 100000 && number > 9999) //checking input number
    {
        num = text;
        break;
    }
    Console.WriteLine("Wrong input. Enter a five-digit number: ");
}

char[] numReverse = num.ToCharArray();
Array.Reverse(numReverse);
string result = new string(numReverse);
Console.WriteLine(num == result ? "Yes" : "No");