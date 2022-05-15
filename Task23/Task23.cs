//Write a programm which will write the cubes of digits from 1 to input number.

Console.Write("Enter any number: ");
int num = int.Parse(Console.ReadLine());

void printCubes(int n)
{
    Console.WriteLine("|{0,8}|{1,8}|", "Number", "Cube");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("|{0,8}|{1,8}|", i, Math.Pow(i, 3));
    }
}

printCubes(num);