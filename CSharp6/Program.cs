﻿
Console.WriteLine("1 ile 7 arasında sayı giriniz...");
int sayi = Convert.ToInt32(Console.ReadLine());

switch (sayi)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;

    case 2:
        Console.WriteLine("Salı");
        break;

    case 3:
        Console.WriteLine("Çarşamba");
        break;

    case 4:
        Console.WriteLine("Perşembe");
        break ;

    case 5:
        Console.WriteLine("Cuma");
        break;

    case 6:
        Console.WriteLine("Cumartesi");
        break;

    case 7:
        Console.WriteLine("Pazar");
        break;

    default:
        Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı giriniz...");
        break;

}
