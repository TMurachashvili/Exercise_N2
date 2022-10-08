// 8.	დაწერეთ პროგრამა რომელიც მასივში დაითვლის ამ მასივში უმცირეს,უდიდეს ელემენტს და იპოვნის მედიანას(შუა წევრს)
Console.WriteLine("Enter Array Length");
int length = int.Parse(Console.ReadLine());
int[] arr8 = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Enter {i + 1}th Element of an Array");
    arr8[i] = int.Parse(Console.ReadLine());
}
int x = 0;

for (int i = 0; i < arr8.Length ; i++)
{
    for (int j = i + 1; j < arr8.Length; j++)
    {
        if (arr8[i] > arr8[j])
        {
            x = arr8[i];
            arr8[i] = arr8[j];
            arr8[j] = x;
        }
    }
}
Console.WriteLine($"{arr8[0]} is the smallest number");
Console.WriteLine($"{arr8[arr8.Length - 1]} is the greatest number");
if (arr8.Length % 2 != 0) 
{ 
    Console.WriteLine($"{arr8[arr8.Length / 2]} is Median");
}
else Console.WriteLine($"{(arr8[arr8.Length / 2 - 1] + arr8[arr8.Length / 2]) / 2} is Median");
