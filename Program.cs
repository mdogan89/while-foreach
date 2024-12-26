// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int top = 0;
while (sayac<=sayi)
{
    top += sayac;
    sayac++;
}

Console.WriteLine("ortalama: " + top/sayi);

char c = 'a';
while (c < 'z')
{
    Console.Write(c);
    c++;
}


string[] arabalar = { "BMW", "Ford", "Mercedes" };

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}



