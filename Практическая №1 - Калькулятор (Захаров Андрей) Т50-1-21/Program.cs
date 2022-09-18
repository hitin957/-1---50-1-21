// Практическая номер 1
using System.Security.Cryptography.X509Certificates;

do
{
    Console.WriteLine("");
    Console.WriteLine("1.Сложить 2 числа");
    Console.WriteLine("2.Вычесть первое из второго");
    Console.WriteLine("3.Перемножить два числа");
    Console.WriteLine("4.Разделить первое на второе");
    Console.WriteLine("5.Возвести в степень N первое число");
    Console.WriteLine("6.Найти квадратный корень из числа");
    Console.WriteLine("7.Найти 1 процент от числа");
    Console.WriteLine("8.Найти факториал из числа");
    Console.WriteLine("9.Выйти из программы");
    Console.WriteLine("");
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    string i = Console.ReadLine();
    int j = Convert.ToInt32(i);
    if (j == 1)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 1:(Сложить 2 числа)");
        Console.WriteLine("Введите число 1:");
        string w = Console.ReadLine();
        int w2 = Convert.ToInt32(w);
        Console.WriteLine("Введите число 2:");
        string w3 = Console.ReadLine();
        int w4 = Convert.ToInt32(w3);
        int w5 = w2 + w4;
        Console.WriteLine("Ответ:" + w5);
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 2)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 2:(Вычесть первое из второго)");
        Console.WriteLine("Введите число 1:");
        string v = Console.ReadLine();
        double v2 = Convert.ToInt32(v);
        Console.WriteLine("Введите число 2:");
        string v3 = Console.ReadLine();
        double v4 = Convert.ToInt32(v3);
        double v5 = v2 - v4;
        Console.WriteLine("Ответ:" + v5);
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 3)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 3:(Перемножить два числа)");
        Console.WriteLine("Введите число 1:");
        string e = Console.ReadLine();
        int e2 = Convert.ToInt32(e);
        Console.WriteLine("Введите число 2:");
        string e3 = Console.ReadLine();
        int e4 = Convert.ToInt32(e3);
        int e5 = e2 * e4;
        Console.WriteLine("Ответ:" + e5);
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 4)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 4:(Разделить первое на второе)");
        Console.WriteLine("Введите число 1:");
        string s = Console.ReadLine();
        double s2 = Convert.ToInt32(s);
        Console.WriteLine("Введите число 2:");
        string s3 = Console.ReadLine();
        double s4 = Convert.ToInt32(s3);
        double s5 = s2 / s4;
        Console.WriteLine("Ответ:" + s5);
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 5)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 5:(Возвести в степень N первое число)");
        Console.WriteLine("Введите число:");
        string n = Console.ReadLine();
        double n2 = Convert.ToInt32(n);
        Console.WriteLine("Введите степень N:");
        string n3 = Console.ReadLine();
        double n4 = Convert.ToInt32(n3);
        Console.WriteLine("Ответ: "+Math.Pow(n2,n4));
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 6)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 6:(Найти квадратный корень из числа)");
        Console.WriteLine("Введите число из которыго вы хотите найти квадратный корень:");
        string m = Console.ReadLine();
        double m2 = Convert.ToInt32(m);
        Math.Sqrt(m2);
        Console.WriteLine("Ответ:" + Math.Sqrt(m2));
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 7)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 7:(Найти 1 процент от числа)");
        Console.WriteLine("Введите число из которого вы хотите найти один процент:");
        string r = Console.ReadLine();
        double r2 = Convert.ToInt32(r);
        r2 = r2 / 100 * 1;
        Console.WriteLine("Ответ:" + r2);
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 8)
    {
        Console.WriteLine("");
        Console.WriteLine("Вы выбрали:число 8:(Найти факториал из числа)");
        Console.WriteLine("Введите число из которого вы хотите найти факториал:");
        string f = Console.ReadLine();
        int f2 = Convert.ToInt32(f);
        int d = 1;
       for (int z=2;f2>=z;z++)
        {
            d = d * z;       
        }
        Console.WriteLine("Ответ:" + d);
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    if (j == 9)
    {
        break;
    }
    if (j < 1) 
    {
        Console.WriteLine("Ошибка. Попробуйте ещё раз.");
    }
    else if (j > 9) 
    {
        Console.WriteLine("Ошибка. Попробуйте ещё раз.");
    }
}
while (true) ;
// Захаров Андрей Т50-1-21;