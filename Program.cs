// Задача №41

Console.Write("Enter the elements separated by a space: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"The number of elements is greater than zero: {count}");

// Задача №43

Console.WriteLine("Enter a value B1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a value K1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a value B2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a value K2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"The point of intersection of two straight lines X: {x}; Y: {y}");