Console.Clear();

Console.WriteLine("Введити пятизначное число: ");

int num = int.Parse(Console.ReadLine()!);
if (num < 10000 ^ num > 99999)
{
    Console.WriteLine("Введенное число не является пятизначным!");
}
else
{
    int firstPartnum = num / 1000;
    int secondPartnum = num % 100;
    int threePartnum = secondPartnum % 10 * 10 + (secondPartnum / 10);
    if (firstPartnum == threePartnum)
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число НЕ палиндром");


    }

}
