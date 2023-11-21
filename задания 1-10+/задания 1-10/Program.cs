using System;

int nz;
do
{
    Console.WriteLine("выберите номер задачи, которую хотите проверить(если хотите закончить, введите 0): ");
    nz = Convert.ToInt32(Console.ReadLine());

    if (nz == 1)
    {
        Console.WriteLine("введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 3 == 0)
        {
            Console.WriteLine("введенное число делиться на 3");
        }
        else
        {
            Console.WriteLine("введенное число не делиться на 3");
        }
    }

    if (nz == 2)
    {
        Console.WriteLine("введите число, которое соответсвует требованиям(при делении на 5 получился остаток 2, а при делении на 7 - 1): ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 5 == 2 && n % 7 == 1)
        {
            Console.WriteLine("число соотвестует требованиям ");
        }
        else
        {
            Console.WriteLine("число не соответвует требованиям");
        }
    }

    if (nz == 3)
    {
        Console.WriteLine("введите число, которое соответсвует требованиям(делиться на 4 и не меньше 10): ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 4 == 0 && n >= 10)
        {
            Console.WriteLine("число соотвестует требованиям ");
        }
        else
        {
            Console.WriteLine("число не соответвует требованиям");
        }
    }

    if (nz == 4)
    {
        Console.WriteLine("введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n >= 5 && 10 >= n)
        {
            Console.WriteLine("число входит в диапазон от 5 до 10 включительно");
        }
        else
        {
            Console.WriteLine("число не входит в диапазон от 5 до 10 включительно");
        }
    }

    if (nz == 5)
    {
        Console.WriteLine("введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int rezn = n / 1000 % 10;
        Console.WriteLine("в введенном числе " + rezn + " тысяч/тысячи");
    }

    if (nz == 6)
    {
        Console.WriteLine("введите число в десятичной СС: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int rezn = (n & 56) >> 3;
        Console.WriteLine("вторая справа цифра в восьмиричном представлении этого числа: " + rezn);
    }

    if (nz == 7)
    {
        Console.WriteLine("введите число в десятичной СС: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int rezn = (n >> 2) % 2;
        Console.WriteLine("третий бит справа в двоичном представлении этого числа: " + rezn);
    }

    if (nz == 8)
    {
        Console.WriteLine("введите число бинарном представлении: ");
        string user = Console.ReadLine();
        int n = Convert.ToInt32(user, 2);
        int rezn = n | (1 << 2);
        Console.WriteLine("число после установки третьего бита в 1: " + Convert.ToString(rezn, 2));
    }

    if (nz == 9)
    {
        Console.WriteLine("введите число бинарном представлении: ");
        string user = Console.ReadLine();
        int n = Convert.ToInt32(user, 2);
        int rezn = n & ~(1 << 3);
        Console.WriteLine("число после установки четвертого бита в 0: " + Convert.ToString(rezn, 2));
    }

    if (nz == 10)
    {
        Console.WriteLine("введите число бинарном представлении: ");
        string user = Console.ReadLine();
        int n = Convert.ToInt32(user, 2);
        int rezn = n ^ (1 << 1);
        Console.WriteLine("число после инверсии второго бита: " + Convert.ToString(rezn, 2));
    }

} while (nz != 0);