// Mis nädalapäev täna on

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("Täna on pühapäev!");
}
else if (weekDay == 1)
{
    Console.WriteLine("Täna on esmaspäev!");
}
else if (weekDay == 2)
{
    Console.WriteLine("Täna on teisipäev!");
}
else if (weekDay == 3)
{
    Console.WriteLine("Täna on kolmapäev!");
}
else if (weekDay == 4)
{
    Console.WriteLine("Täna on neljapäev!");
}
else if (weekDay == 5)
{
    Console.WriteLine("Täna on reede!");
}
else
{
    Console.WriteLine("Täna on laupäev!");
}
Console.WriteLine("Ilusat päeva jätku!");