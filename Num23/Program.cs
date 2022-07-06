//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cubeTable(double N){
     double count = 1;
     Console.WriteLine("Таблица кубов:");
     while (count <= N)
     {
         double res = Math.Pow((count),3);
         count++;
         Console.WriteLine(res);
     }
}

Console.WriteLine("Введите число");
double num = Convert.ToInt32(Console.ReadLine());
cubeTable(num);

