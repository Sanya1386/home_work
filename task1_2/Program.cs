int n = 10;
int[] array = { 11, 15, 21, 45, 80, 32, 11, 60, 75, 88 };
int i = 0;
int SumEven = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
        SumEven++;
        i = i +1;
}
System.Console.WriteLine(SumEven);