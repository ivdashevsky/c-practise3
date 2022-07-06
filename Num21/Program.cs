Console.WriteLine("Введите координаты трёх точек");
Console.WriteLine("Точка 1: x");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка 1: y");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка 1: z");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка 2: x");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка 2: y");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка 2: z");
double z2 = Convert.ToDouble(Console.ReadLine());

double otrezok(double x01, 
               double y01, 
               double z01, 
               double x02,
               double y02,
               double z02){
     double d = Math.Sqrt(Math.Pow(x02 - x01, 2) + Math.Pow(y02 - y01, 2) + Math.Pow(z02 - z01, 2));
     return d;
}

Console.WriteLine($"Расстояние между двумя точками равно {otrezok(x1,y1,z1,x2,y2,z2)}");