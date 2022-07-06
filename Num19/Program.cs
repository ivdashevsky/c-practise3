string PaliCheck(int num1){
    int first = num1/10000;
    int second = (num1/1000)%10;
    int fourth = (num1/10)%10;
    int fifth = num1%10;
    if (first == fifth && second == fourth) {return "Число является палиндромом";}
    else return "Число не является палиндромом";
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int lng = Convert.ToString(num).Length;

if (lng != 5) {Console.WriteLine("Вы ввели не пятизначное число");}
else Console.WriteLine(PaliCheck(num));