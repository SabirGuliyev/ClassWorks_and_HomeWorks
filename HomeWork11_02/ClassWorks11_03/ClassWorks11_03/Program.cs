//Binary 1
//int[] num = { 3, 7, 11, 22, 47, 55, 79 };
//int key = 55;
//int l = 0, r = num.Length - 1, m =(l+r) / 2;
//while (l <= r)
//{
//    if (num[m]==key)
//    {
//        Console.WriteLine(m);
//        break;
//    }
//    else if (num[m] < key)
//    {
//        l = m + 1;
//    }
//    else
//    {
//        r = m - 1;
//    }
//    m = (l + r) / 2;
//}

int[] numbers = { 34, 22, 17, 5, 34, 21, 1, 2, 8, 7,80,37,13,16,11 };
int count=0;
for (int i = 0; i < numbers.Length-1;)
{
    count++;
    if (numbers[i] > numbers[i+1])
    {
        numbers[i] += numbers[i + 1];
        numbers[i+1] = numbers[i] - numbers[i+1];
        numbers[i] -= numbers[i+1];
        i = 0;
    }
    else
    {
        i++;
    }
}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

Console.WriteLine(count);




