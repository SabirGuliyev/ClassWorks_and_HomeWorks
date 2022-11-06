int num = 48;
int bolensayi = 2;
Console.WriteLine(1);
for (int i = 2; i <num; i++)
{
    if (num % i == 0)
    {
        bolensayi++;
        Console.WriteLine(i);
    }
}
Console.WriteLine(num);


Console.WriteLine(bolensayi);
