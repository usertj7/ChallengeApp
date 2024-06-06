
int number = 4566;
int[] numbers = new int[10];
string numberinstring = number.ToString();
Char[] letter = numberinstring.ToArray();

foreach (var let in letter)
{
    numbers[let - '0'] += 1;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i.ToString() + " => " + numbers[i]);
}

