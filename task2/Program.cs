Console.Write("Введите координаты точки X и Y через пробел: ");
string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
    Console.WriteLine("в 1 координатной плоскости");
else if (x > 0 && y < 0)
    Console.WriteLine("во 2 координатной плоскости");
else if (x < 0 && y < 0)
    Console.WriteLine("в 3 координатной плоскости");
else if (x > 0 && y < 0)
    Console.WriteLine("в 4 координатной плоскости");
else if (x > 0 && y == 0)
    Console.WriteLine("Точка находится на оси x координат");
else if (x < 0 && y == 0)
    Console.WriteLine("Точка находится на оси -x координат");
else if (x == 0 && y > 0)
    Console.WriteLine("Точка находится на оси y координат");
else if (x == 0 && y < 0)
    Console.WriteLine("Точка находится на оси -y координат");
