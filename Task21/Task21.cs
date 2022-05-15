//Write a program which finds distance between two points with 3 coordinates each.

Console.Write("Enter X-coordinate of point A: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate of point A: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Enter Z-coordinate of point A: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("Enter X-coordinate of point B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate of point B: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Enter Z-coordinate of point B: ");
int zB = int.Parse(Console.ReadLine());

float getDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    float result = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return result;
}

Console.WriteLine("{0: 0.00}" ,getDistance(xA, yA, zA, xB, yB, zB));