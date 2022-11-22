int n = -1;
while (n < 1)
{
    Console.WriteLine("Enter number: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Incorrect data");
}

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} {count * count * count}");
        count ++;
    }
}
Cube(n);
