int a, b;
Console.Write("Enter height of array: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter weight of array: ");
b = Convert.ToInt32(Console.ReadLine());
int [,] array1 = new int [a,b];
//Random random = new Random();
Console.WriteLine("Enter elements of array by position: ");
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        //array1[i,j] = random.Next(50);
        Console.WriteLine("H: " + i + "\tW: " + j);
        array1[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i,j] + "\t");
    }
    Console.WriteLine();
}
