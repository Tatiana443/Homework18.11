Console.WriteLine("Введите x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double Distance(int x11, int y11, int z11, int x22, int y22, int z22)
{
    return Math.Sqrt((x11 - x22) * (x11 - x22) + (y11 - y22) * (y11 - y22) + (z11 - z22) * (z11 - z22));
}
double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 3D = {distance}");
