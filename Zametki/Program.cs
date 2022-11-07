using System;
using zametki;

Zametki pervaya = new Zametki();
pervaya.Name = "Прийти на пару";
pervaya.Opisanie = "К сожалению, не пришел";
pervaya.MyDate = new DateTime(2022,04, 15);

Zametki vtoraya = new Zametki();
vtoraya.Name = "Привет";
vtoraya.Opisanie = "Ку";
vtoraya.MyDate = new DateTime(2022, 05, 12);

List<Zametki> zametki = new List<Zametki>();
zametki.Add(pervaya);
zametki.Add(vtoraya);


DateTime selectedDate = DateTime.Now;

int x = 1;
ConsoleKeyInfo key = Console.ReadKey();

while (key.Key != ConsoleKey.Escape)
{

    if (key.Key == ConsoleKey.DownArrow)
    {
        x++;
    }
    if (key.Key == ConsoleKey.UpArrow)
    {
        x--;
    }
    if (key.Key == ConsoleKey.RightArrow)
    {

        selectedDate = selectedDate.AddDays(1);

    }
    if (key.Key == ConsoleKey.LeftArrow)
    {

        selectedDate = selectedDate.AddDays(-1);

    }

    Console.Clear();
    Console.WriteLine(selectedDate);
    foreach (Zametki zam in zametki)
    {

        Console.WriteLine("   " + zam.Name);
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("   " + zam.MyDate);
            Console.WriteLine("   " + zam.Opisanie);
        }
    }
    
    Console.SetCursorPosition(0, x);
    Console.WriteLine("-->");

    key = Console.ReadKey();
}