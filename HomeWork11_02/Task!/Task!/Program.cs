//int[] array = { };
//int min = array[0];
//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] < min)
//    {
//        min = array[i];
//    }
//    Console.WriteLine(min);


int[] arrive = { 3, 7, 15, 34 };
int counter = 0;
for (int i = 0; i < arrive.Length; i++)
    if (arrive[i] >= 0 && arrive[i] <= 9)
    {
        Console.WriteLine("reqem" + arrive[i]);
        counter++;
    }

Console.WriteLine(counter);
